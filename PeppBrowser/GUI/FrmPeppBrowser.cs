using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using combit.ListLabel18;
using Microsoft.Office.Interop.Excel;
using org.inek.PeppBrowser.Data.Entities;
using org.inek.controls.gui;
using org.inek.controls.helper;
using org.inek.PeppBrowser.Data;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;
using Point = System.Drawing.Point;

namespace org.inek.PeppBrowser.GUI {
    public partial class FrmPeppBrowser : Form {

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleBar));

        /* Use for window moving */
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        /* ################## */

        private FrmList dlg;
        private bool matrixLoaded = false;

        public static string PEPP {
            get; set;
        }

        public string TextPEPP {
            set { cbxPepp.Text = value; }
        }

        public FrmPeppBrowser() {
            InitializeComponent();
            Selection.Parent = this;
            cbxPepp.InputField.Click += cbxPepp_ButtonClicked;
        }

        private void mnuPepp_Click(object sender, System.EventArgs e) {
            FrmList dlg = new FrmList();
            var q = CsvData.Context().Pepps.Select(p => new {SK = p.StructureCategory, PEPP=p.Code, p.Text});
            dlg.SetDataSource(q);
            dlg.Text = "PEPPS";
            dlg.Show();
        }

        private void mnuStructureCategories_Click(object sender, System.EventArgs e) {
            FrmList dlg = new FrmList();
            var q =
                CsvData.Context().StructureCategories.OrderBy(sk => sk.Order)
                .Select(sk => new { SK = sk.Category, sk.Text, PEPPs = sk.PeppCount, Fälle = sk.CaseCount, Tage = sk.DayCount });
            dlg.SetDataSource(q);
            dlg.Text = "Strukturkategorien";
            dlg.Show();
        }

        private void mnuPeppInfo_Click(object sender, System.EventArgs e) {
            FrmList dlg = new FrmList();
            dlg.SetDataSource(CsvData.Context().PeppInfos);
            dlg.Text = "Kopfdaten";
            dlg.Show();

        }

        private void mnuPrimaryDiagnoses_Click(object sender, System.EventArgs e) {
            FrmList dlg = new FrmList();
            dlg.SetDataSource(CsvData.Context().PrimaryDiagnoses);
            dlg.Text = "Hauptdiagnosen";
            dlg.Show();

        }

        private void mnuSecondaryDiagnoses_Click(object sender, System.EventArgs e) {
            FrmList dlg = new FrmList();
            dlg.SetDataSource(CsvData.Context().SecondaryDiagnoses);
            dlg.Text = "Nebendiagnosen";
            dlg.Show();

        }

        private void mnuProcedures_Click(object sender, System.EventArgs e) {
            FrmList dlg = new FrmList();
            dlg.SetDataSource(CsvData.Context().Procedures);
            dlg.Text = "Prozeduren";
            dlg.Show();

        }

        private void mnuCosts_Click(object sender, System.EventArgs e) {
            FrmList dlg = new FrmList();
            dlg.SetDataSource(CsvData.Context().Costs);
            dlg.Text = "Kosten";
            dlg.Show();

        }

        private void mnuCostDomains_Click(object sender, System.EventArgs e) {
            FrmList dlg = new FrmList();
            dlg.SetDataSource(CsvData.Context().StructureCategories);
            dlg.Text = "Strukturkategorien";
            dlg.Show();
        }

        private void FrmPeppBrowser_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        //***********************************************************
        //This gives us the ability to resize the borderless from any borders instead of just the lower right corner
        protected override void WndProc(ref Message m) {
            const int wmNcHitTest = 0x84;
            const int htLeft = 10;
            const int htRight = 11;
            const int htTop = 12;
            const int htTopLeft = 13;
            const int htTopRight = 14;
            const int htBottom = 15;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;

            if (m.Msg == wmNcHitTest) {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                ///allow resize on the lower right corner
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16) {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
                ///allow resize on the lower left corner
                if (pt.X <= 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16) {
                    m.Result = (IntPtr)(IsMirrored ? htBottomRight : htBottomLeft);
                    return;
                }
                ///allow resize on the upper right corner
                if (pt.X <= 16 && pt.Y <= 16 && clientSize.Height >= 16) {
                    m.Result = (IntPtr)(IsMirrored ? htTopRight : htTopLeft);
                    return;
                }
                ///allow resize on the upper left corner
                if (pt.X >= clientSize.Width - 16 && pt.Y <= 16 && clientSize.Height >= 16) {
                    m.Result = (IntPtr)(IsMirrored ? htTopLeft : htTopRight);
                    return;
                }
                ///allow resize on the top border
                if (pt.Y <= 16 && clientSize.Height >= 16) {
                    m.Result = (IntPtr)(htTop);
                    return;
                }
                ///allow resize on the bottom border
                if (pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16) {
                    m.Result = (IntPtr)(htBottom);
                    return;
                }
                ///allow resize on the left border
                if (pt.X <= 16 && clientSize.Height >= 16) {
                    m.Result = (IntPtr)(htLeft);
                    return;
                }
                ///allow resize on the right border
                if (pt.X >= clientSize.Width - 16 && clientSize.Height >= 16) {
                    m.Result = (IntPtr)(htRight);
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void titleBar_ClickedExit(object sender, EventArgs e) {
            Application.Exit();
        }

        private void titleBar_ClickedIconify(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void titleBar_ClickedMinMax(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;
            } else {
                WindowState = FormWindowState.Normal;
            }
        }

        private void mnuManual_Click(object sender, EventArgs e) {
            try {
                Process.Start("PeppBrowser.pdf");
            } catch (Exception) {
                MessageBox.Show("Kein Handbuch verfügbar.");
            }

        }

        private void mnuHelp_Click(object sender, EventArgs e) {
            try {
                Process.Start("PeppBrowser.chm");
            } catch (Exception) {
                MessageBox.Show("Keine Hilfe verfügbar.");
            }

        }

        private void cbxPepp_ButtonClicked(object sender, EventArgs e) {
            FrmSearch dlg = new FrmSearch(cbxPepp);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.Text = "PEPP-Suche";
            var q = CsvData.Context().Pepps.Select(pepp => new {Strukturkategorie = pepp.StructureCategory, PEPP = pepp.Code, Text = pepp.Text});
            if (Selection.SK != "") {
                q = q.Where(pepp => pepp.Strukturkategorie == Selection.SK);
            }
            if (Selection.PD != "") {
                List<string> pepps =
                    CsvData.Context()
                        .PrimaryDiagnoses.Where(hd => hd.DiagCode == Selection.PD)
                        .Select(pepp => pepp.PeppCode)
                        .ToList();
                q = q.Where(pepp => pepps.Contains(pepp.PEPP));
            } else if (Selection.SD != "") {
                List<string> pepps =
                    CsvData.Context()
                        .SecondaryDiagnoses.Where(sd => sd.DiagCode == Selection.SD)
                        .Select(pepp => pepp.PeppCode)
                        .ToList();
                q = q.Where(pepp => pepps.Contains(pepp.PEPP));
            } else if (Selection.Procedure != "") {
                List<string> pepps =
                    CsvData.Context()
                        .Procedures.Where(proc => proc.ProcCode == Selection.Procedure)
                        .Select(pepp => pepp.PeppCode)
                        .ToList();
                q = q.Where(pepp => pepps.Contains(pepp.PEPP));
            }
            if (!q.Any()) {
                MessageBox.Show(this, "Es gibt keine PEPP zu Ihren Filtereinstellungen.", "Keine Pepp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dlg.SetDataSource(q);
            dlg.KeyColumns = new[] {"PEPP", "Text"};
            dlg.ButtonShowIsVisible = false;
            if (dlg.ShowDialog() == DialogResult.OK) {
                List<object> cells = (List<object>)dlg.Id;
                PEPP = cells[0].ToString();
                cbxPepp.Text = PEPP + ": ";
                cbxPepp.Text += cells[1].ToString();
                LoadPeppData();
            }
        }

        private void LoadPeppData() {
            tabControl.Enabled = true;
            FillHeadData();
            matrixLoaded = false;
            FillActiveTab(ActiveGrid());
        }

        private void FillActiveTab(DataGridView grid) {
            CsvData context = CsvData.Context();
            if (grid == grdMainDiagnosis) {
                var q =
                    context.PrimaryDiagnoses.Where(d => d.PeppCode == PEPP)
                        .Join(context.Recherche.Where(r => r.PrimaryDaignosis == 1), d => d.DiagCode, r => r.Code,
                            (d, r) => new {
                                              PEPP = d.PeppCode,
                                              HD = d.DiagCode,
                                              Hauptdiagnose = r.Text,
                                              AnzahlFälle = d.Count.ToString("##,##0"),
                                              AnteilFälle = d.Fraction.ToString("P")
                                          });
                grdMainDiagnosis.DataSource = Helper.ConvertToDataTable(q);
                grdMainDiagnosis.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                grdMainDiagnosis.Columns[2].Width = 700;
                SetHdGridColumnStyle();
            } else if (grid == grdSecondaryDiagnosis) {
                var q = context.SecondaryDiagnoses.Where(d => d.PeppCode == PEPP)
                        .Join(context.Recherche.Where(r => r.SecondaryDiagnosis == 1), d => d.DiagCode, r => r.Code,
                            (d, r) => new {
                                PEPP = d.PeppCode,
                                ND = d.DiagCode,
                                Nebendiagnose = r.Text,
                                AnzahlFälle = d.CaseCount.ToString("##,##0"),
                                AnteilFälle = d.CaseFraction.ToString("P"),
                                AnzahlNennungen = d.EntryCount.ToString("##,##0"),
                                AnteilNennungen = d.EntryFraction.ToString("P")
                            });
                grdSecondaryDiagnosis.DataSource = Helper.ConvertToDataTable(q);
                SetSdGridColumnStyle();
            } else if (grid == grdProcedures) {
                var q = context.Procedures.Where(d => d.PeppCode == PEPP)
                        .Join(context.Recherche.Where(r => r.Procedure == 1), d => d.ProcCode, r => r.Code,
                            (d, r) => new {
                                PEPP = d.PeppCode,
                                ProzedurKode = d.ProcCode,
                                Prozedur = r.Text,
                                AnzahlFälle = d.CaseCount.ToString("##,##0"),
                                AnteilFälle = d.CaseFraction.ToString("P"),
                                AnzahlNennungen = d.EntryCount.ToString("##,##0"),
                                AnteilNennungen = d.EntryFraction.ToString("P")
                            });
                grdProcedures.DataSource = Helper.ConvertToDataTable(q);
                SetProcedureGridColumnStyle();
            } else if (grid == grdCosts && !matrixLoaded) {
                BuildCostMatrix();
                matrixLoaded = true;
            }
            
        }

        private void SetHdGridColumnStyle() {
            grdMainDiagnosis.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdMainDiagnosis.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void SetSdGridColumnStyle() {
            grdSecondaryDiagnosis.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grdSecondaryDiagnosis.Columns[2].Width = 700;
            grdSecondaryDiagnosis.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdSecondaryDiagnosis.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdSecondaryDiagnosis.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdSecondaryDiagnosis.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void SetProcedureGridColumnStyle() {
            grdProcedures.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            grdProcedures.Columns[2].Width = 700;
            grdProcedures.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdProcedures.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdProcedures.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdProcedures.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void BuildCostMatrix() {
            var q =
                CsvData.Context()
                    .Costs.Where(pepp => pepp.PeppCode == PEPP)
                    .Select(c => new {
                                         KostenArt1 = c.CostType1.ToString("F"), KostenArt2 = c.CostType2.ToString("F"), KostenArt3a = c.CostType3a.ToString("F"), KostenArt3b = c.CostType3b.ToString("F"),
                                         KostenArt3c = c.CostType3c.ToString("F"), KostenArt3 = c.CostType3.ToString("F"), KostenArt4a = c.CostType4a.ToString("F"), KostenArt4b = c.CostType4b.ToString("F"), KostenArt5 = c.CostType5.ToString("F"), KostenArt6a = c.CostType6a.ToString("F"),
                                         KostenArt6b = c.CostType6b.ToString("F"), KostenArt7 = c.CostType7.ToString("F"), KostenArt8 = c.CostType8.ToString("F")
                                     });
            grdCosts.DataSource = Helper.ConvertToDataTable(q);
            List<int> rowIds = CsvData.Context()
                .Costs.Where(pepp => pepp.PeppCode == PEPP)
                .Select(ri => ri.CostDomain).ToList();
            BuildCostMatrixColHeaders(Color.LightGreen);
            BuildCostMatrixRowHeaders(rowIds, Color.LightGreen);
            BuildCostMatrixColSum(Color.MediumSeaGreen);
            decimal sum = 0;
            BuildCostMatrixRowSum(Color.MediumSeaGreen, ref sum);
            BuildCostMatrixMasterSum(Color.White, Color.SeaGreen, sum);
            CostMatrixRightToLeft();
        }

        private void CostMatrixRightToLeft() {
            int startCol = grdCosts.Columns["KostenArt1"].Index;
            int startRow = 1;
            for (int cols = startCol; cols < grdCosts.Columns.Count - 2; cols++) {
                for (int rows = startRow; rows < grdCosts.Rows.Count; rows++) {
                    DataGridViewCellStyle style = new DataGridViewCellStyle(grdCosts.Rows[rows].Cells[cols].Style);
                    style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    grdCosts.Rows[rows].Cells[cols].Style = style;
                }
            }
            startCol = grdCosts.Columns["rowSums"].Index;
            for (int i = 1; i < grdCosts.Rows.Count; i++) {
                DataGridViewCellStyle style = new DataGridViewCellStyle(grdCosts.Rows[i].Cells[startCol].Style);
                style.Alignment = DataGridViewContentAlignment.MiddleRight;
                grdCosts.Rows[i].Cells[startCol].Style = style;
            }
        }

        private void BuildCostMatrixMasterSum(Color fontColor, Color backColor, decimal sum) {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.ForeColor = fontColor;
            cellStyle.BackColor = backColor;
            int cellCol = grdCosts.Columns["rowSums"].Index;
            grdCosts.Rows[grdCosts.Rows.Count - 1].Cells[cellCol].Value = sum.ToString();
            grdCosts.Rows[grdCosts.Rows.Count - 1].Cells[cellCol].Style = cellStyle;
        }

        private void BuildCostMatrixRowSum(Color backColor, ref decimal sumsum) {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.BackColor = backColor;
            DataTable table = ((DataTable)grdCosts.DataSource);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            int sumRow = table.Rows.Count - 1;
            decimal sum = 0;
            int colStart = grdCosts.Columns["KostenArt1"].Index;
            int colEnd = grdCosts.Columns["KostenArt8"].Index;
            for (int cols = colStart; cols <= colEnd; cols++) {
                for (int rows = 1; rows < grdCosts.Rows.Count-1; rows++) {
                    sum += decimal.Parse(grdCosts.Rows[rows].Cells[cols].Value.ToString());
                }
                grdCosts.Rows[sumRow].Cells[cols].Value = sum.ToString();
                grdCosts.Rows[sumRow].Cells[cols].Style = cellStyle;
                sumsum += sum;
                sum = 0;
            }
            int sumCell = grdCosts.Columns["rowHeaders"].Index;
            grdCosts.Rows[sumRow].Cells[sumCell].Value = "Summe";
            grdCosts.Rows[sumRow].Cells[sumCell].Style = cellStyle;
        }

        private void BuildCostMatrixColSum(Color sumColor) {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.BackColor = sumColor;
            int sumCol = 1;
            if (!grdCosts.Columns.Contains("rowSums")) {
                grdCosts.Columns.Add("rowSums", "");
                sumCol = grdCosts.Columns.Count - 1;
            }
            grdCosts.Rows[0].Cells[sumCol].Value = "Summe";
            grdCosts.Rows[0].Cells[sumCol].Style = cellStyle;
            decimal sum = 0;
            int colStart = grdCosts.Columns["KostenArt1"].Index;
            int colEnd = grdCosts.Columns["KostenArt8"].Index;
            for (int rows = 1; rows < grdCosts.Rows.Count; rows++) {
                for (int cols = colStart; cols <= colEnd; cols++) {
                    sum += decimal.Parse(grdCosts.Rows[rows].Cells[cols].Value.ToString());
                }
                grdCosts.Rows[rows].Cells[sumCol].Value = sum.ToString();
                grdCosts.Rows[rows].Cells[sumCol].Style = cellStyle;
                sum = 0;
            }
        }

        private void BuildCostMatrixRowHeaders(List<int> rowIds, Color headColor) {
            int colHeaderId = 0;
            if (!grdCosts.Columns.Contains("rowHeaders")) {
                grdCosts.Columns.Add("rowHeaders", "");
                colHeaderId = grdCosts.Columns.Count - 1;
                grdCosts.Columns[colHeaderId].MinimumWidth = 280;
                grdCosts.Columns[colHeaderId].DisplayIndex = 0;
            }
            var rowMap = CreateCostCenterMap();
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = headColor;
            for (int i = 0; i < grdCosts.Rows.Count - 1; i++) {
                if (i == grdCosts.Rows.Count - 2) {
                    grdCosts.Rows[i + 1].Cells[colHeaderId].Style = headerStyle;
                }
                grdCosts.Rows[i].Cells[colHeaderId].Style = headerStyle;
                grdCosts.Rows[i + 1].Cells[colHeaderId].Value = rowMap[rowIds[i]];
            }
        }

        private static Dictionary<int, string> CreateCostCenterMap() {
            Dictionary<int, string> rowMap = new Dictionary<int, string>();
            rowMap.Add(21, "21. Station - Regelbehandlung");
            rowMap.Add(22, "22. Station - Intensivbehandlung");
            rowMap.Add(23, "23. Psychotherapie");
            rowMap.Add(24, "24. Physikalische Therapie");
            rowMap.Add(25, "25. Ergotherapie");
            rowMap.Add(26, "26. Andere Therapie");
            rowMap.Add(4, "04. OP-Bereich");
            rowMap.Add(5, "05. Anästhesie");
            rowMap.Add(7, "07. Kardiologische Diagnostik / Therapie");
            rowMap.Add(8, "08. Endoskopische Diagnostik / Therapie");
            rowMap.Add(9, "09. Radiologie");
            rowMap.Add(10, "10. Laboratorien");
            rowMap.Add(11, "11. Übrige diagnostische und therapeutische Bereiche");
            return rowMap;
        }

        private void BuildCostMatrixColHeaders(Color headColor) {
            DataTable table = ((DataTable) grdCosts.DataSource);
            DataRow row = table.NewRow();
            string[] headers = {
                      "1", "2", "3a", "3b", "3c", "3",
                      "4a", "4b", "5", "6a", "6b", "7", "8"
                  };
            for (int i = 0; i < 13; i++) {
                row[i] = headers[i];
            }
            table.Rows.InsertAt(row, 0);
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = headColor;
            for (int i = 0; i < grdCosts.Columns.Count; i++) {
                grdCosts.Rows[0].Cells[i].Style = headerStyle;
                CreateCostMatrixHeaderTooltips(i);
            }
        }

        private void CreateCostMatrixHeaderTooltips(int i) {
            switch (i) {
                case 0:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Personalkosten Ärztlicher Dienst";
                    break;
                case 1:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Personalkosten Pflege-/Erziehungsdienst";
                    break;
                case 2:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Personalkosten Psychologen";
                    break;
                case 3:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Personalkosten Sozialarbeiter/Sozial-/Heilpädagogen";
                    break;
                case 4:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Personalkosten Spezialtherapeuten";
                    break;
                case 5:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Personalkosten Med.-techn. Dienst/Funktionsdienst";
                    break;
                case 6:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Sachkosten Arzneimittel";
                    break;
                case 7:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Sachkosten Arzneimittel";
                    break;
                case 8:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Sachkosten Implantate/Transplantate";
                    break;
                case 9:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Sachkosten Übriger medizinischer Bedarf";
                    break;
                case 10:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Sachkosten Übriger medizinischer Bedarf";
                    break;
                case 11:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Personal- und Sachkosten med. Infrastruktur";
                    break;
                case 12:
                    grdCosts.Rows[0].Cells[i].ToolTipText = "Personal- und Sachkosten nicht med. Infrastruktur";
                    break;
            }
        }

        private DataGridView ActiveGrid() {
            switch (tabControl.SelectedIndex) {
                case 0:
                    return grdMainDiagnosis;
                case 1:
                    return grdSecondaryDiagnosis;
                case 2:
                    return grdProcedures;
                case 3:
                    return grdCosts;
            }
            return null;
        } 

        private void FillHeadData() {
            var q = CsvData.Context().PeppInfos.Where(pepp => pepp.Code == PEPP);
            data.CasesNumSummary = q.Select(p => p.CaseCount.ToString("##,##0")).ElementAt(0);
            data.Cases1 = q.Select(p => p.CaseCountPayLevel1.ToString("##,##0")).ElementAt(0);
            data.Cases2 = q.Select(p => p.CaseCountPayLevel2.ToString("##,##0")).ElementAt(0);
            data.Cases3 = q.Select(p => p.CaseCountPayLevel3.ToString("##,##0")).ElementAt(0);
            data.Cases4 = q.Select(p => p.CaseCountPayLevel4.ToString("##,##0")).ElementAt(0);
            data.Cases5 = q.Select(p => p.CaseCountPayLevel5.ToString("##,##0")).ElementAt(0);
            data.CasesP1 = q.Select(p => Math.Round((p.CaseFractionPayLevel1 * 100), 2).ToString()+"%").ElementAt(0); // Prozent
            data.CasesP2 = q.Select(p => Math.Round((p.CaseFractionPayLevel2 * 100), 2).ToString()+"%").ElementAt(0); // Prozent
            data.CasesP3 = q.Select(p => Math.Round((p.CaseFractionPayLevel3 * 100), 2).ToString()+"%").ElementAt(0); // Prozent
            data.CasesP4 = q.Select(p => Math.Round((p.CaseFractionPayLevel4 * 100), 2).ToString()+"%").ElementAt(0); // Prozent
            data.CasesP5 = q.Select(p => Math.Round((p.CaseFractionPayLevel5*100), 2).ToString()+"%").ElementAt(0); // Prozent
            data.DaysSummary = q.Select(p => p.LosSumDays.ToString("##,##0")).ElementAt(0);
            data.Days1 = q.Select(p => p.DayCountPayLevel1.ToString("##,##0")).ElementAt(0);
            data.Days2 = q.Select(p => p.DayCountPayLevel2.ToString("##,##0")).ElementAt(0);
            data.Days3 = q.Select(p => p.DayCountPayLevel3.ToString("##,##0")).ElementAt(0);
            data.Days4 = q.Select(p => p.DayCountPayLevel4.ToString("##,##0")).ElementAt(0);
            data.Days5 = q.Select(p => p.DayCountPayLevel5.ToString("##,##0")).ElementAt(0);
            data.LosAverage = q.Select(p => Math.Round(p.LosAverage, 1).ToString()).ElementAt(0);               // einstellig Dezimal
            data.LosStandardDeviation = q.Select(p => Math.Round(p.LosStandard, 1).ToString()).ElementAt(0);    // einstellig Dezimal
            data.LosHomogeneityCoeff = q.Select(p => Math.Round((p.LosHc*100),2).ToString()+"%").ElementAt(0);      // Prozent
            data.LosFrom1 = q.Select(p => p.LosFromPayLevel1.ToString("##,##0")).ElementAt(0);
            data.LosFrom2 = q.Select(p => p.LosFromPayLevel2.ToString("##,##0")).ElementAt(0);
            data.LosFrom3 = q.Select(p => p.LosFromPayLevel3.ToString("##,##0")).ElementAt(0);
            data.LosFrom4 = q.Select(p => p.LosFromPayLevel4.ToString("##,##0")).ElementAt(0);
            data.LosFrom5 = q.Select(p => p.LosFromPayLevel5.ToString("##,##0")).ElementAt(0);
            data.LosTo1 = q.Select(p => p.LosToPayLevel1.ToString("##,##0")).ElementAt(0);
            data.LosTo2 = q.Select(p => p.LosToPayLevel2.ToString("##,##0")).ElementAt(0);
            data.LosTo3 = q.Select(p => p.LosToPayLevel3.ToString("##,##0")).ElementAt(0);
            data.LosTo4 = q.Select(p => p.LosToPayLevel4.ToString("##,##0")).ElementAt(0);
            data.LosTo5 = q.Select(p => p.LosToPayLevel5.ToString("##,##0")).ElementAt(0);
            data.ValuationRatio1 = q.Select(p => Math.Round(p.ValuationRatLevel1, 4).ToString()).ElementAt(0);  // vierstellig Dezimal
            data.ValuationRatio2 = q.Select(p => Math.Round(p.ValuationRatLevel2, 4).ToString()).ElementAt(0);  // vierstellig Dezimal
            data.ValuationRatio3 = q.Select(p => Math.Round(p.ValuationRatLevel3, 4).ToString()).ElementAt(0);  // vierstellig Dezimal
            data.ValuationRatio4 = q.Select(p => Math.Round(p.ValuationRatLevel4, 4).ToString()).ElementAt(0);  // vierstellig Dezimal
            data.ValuationRatio5 = q.Select(p => Math.Round(p.ValuationRatLevel5, 4).ToString()).ElementAt(0);  // vierstellig Dezimal
            data.GenderMale = q.Select(p => Math.Round((p.GenderMale * 100), 2).ToString()+"%").ElementAt(0);         // Prozent
            data.GenderFemale = q.Select(p => Math.Round((p.GenderFemale * 100), 2).ToString()+"%").ElementAt(0);     // Prozent
            data.AgeAverage = q.Select(p => Math.Round(p.AgeAverage, 1).ToString()).ElementAt(0);               // einstellig Dezimal
            data.AgeStandardDeviation = q.Select(p => Math.Round(p.AgeStandard,1).ToString()).ElementAt(0);     // einstellig Dezimal
            data.LT28Days = q.Select(p => Math.Round((p.AgeBelow28Days * 100), 2).ToString()+"%").ElementAt(0);        // Prozent
            data.Bt28Days1Year = q.Select(p => Math.Round((p.AgeBelow1Year * 100), 2).ToString()+"%").ElementAt(0);    // Prozent
            data.Bt1Year2 = q.Select(p => Math.Round((p.AgeBelow3Years * 100), 2).ToString()+"%").ElementAt(0);        // Prozent
            data.Bt3Year5 = q.Select(p => Math.Round((p.AgeBelow6Years * 100), 2).ToString()+"%").ElementAt(0);        // Prozent
            data.Bt6Year9 = q.Select(p => Math.Round((p.AgeBelow10Years * 100), 2).ToString()+"%").ElementAt(0);       // Prozent
            data.Bt10Year15 = q.Select(p => Math.Round((p.AgeBelow16Years * 100), 2).ToString()+"%").ElementAt(0);     // Prozent
            data.Bt16Year17 = q.Select(p => Math.Round((p.AgeBelow18Years * 100), 2).ToString()+"%").ElementAt(0);     // Prozent
            data.Bt18Year29 = q.Select(p => Math.Round((p.AgeBelow30Years * 100), 2).ToString()+"%").ElementAt(0);     // Prozent
            data.Bt30Year39 = q.Select(p => Math.Round((p.AgeBelow40Years * 100), 2).ToString()+"%").ElementAt(0);     // Prozent
            data.Bt40Year49 = q.Select(p => Math.Round((p.AgeBelow50Years * 100), 2).ToString()+"%").ElementAt(0);     // Prozent
            data.Bt50Year54 = q.Select(p => Math.Round((p.AgeBelow55Years * 100), 2).ToString()+"%").ElementAt(0);     // Prozent
            data.Bt55Year59 = q.Select(p => Math.Round((p.AgeBelow60Years * 100), 2).ToString()+"%").ElementAt(0);     // Prozent
            data.Bt60Year64 = q.Select(p => Math.Round((p.AgeBelow65Years * 100), 2).ToString()+"%").ElementAt(0);     // Prozent
            data.Bt65Year74 = q.Select(p => Math.Round((p.AgeBelow75Years * 100), 2).ToString()+"%").ElementAt(0);     // Prozent
            data.Bt75Year79 = q.Select(p => Math.Round((p.AgeBelow80Years * 100), 2).ToString()+"%").ElementAt(0);     // Prozent
            data.Gt79Year = q.Select(p => Math.Round((p.AgeBelow99Years * 100), 2).ToString()+"%").ElementAt(0);       // Prozent
            data.DailyCostsAverage = q.Select(p => Math.Round(p.DayCostsAverage, 2).ToString()).ElementAt(0);   // zweistellig Dezimal (money)
            data.DailyCostsStandardDeviation = q.Select(p => Math.Round(p.DayCostsStandard, 2).ToString()).ElementAt(0);    // zweistellig Dezimal (money)
            data.DailyCostsHomogeneityCoeff = q.Select(p => Math.Round((p.DayCostsHc * 100), 2).ToString()+"%").ElementAt(0);  // Prozent
            data.TitlePEPP = "Kennzahlen - " + PEPP;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            FillActiveTab(ActiveGrid());
        }


        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void druckenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            Reporter reporter = new Reporter();
            reporter.Perform(LlProject.List, LlAutoMasterMode.AsVariables, OutputType.Print, "peppDruck", setReportData(PEPP), "data");
             */
        }


        private void designerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(PEPP == "" || PEPP == null){
                MessageBox.Show("Keine PEPP gewählt. Druck nicht möglich!");
            }
            else{
                Reporter reporter = new Reporter();
                reporter.Perform(LlProject.List, LlAutoMasterMode.AsVariables, OutputType.Design, "peppDruck", setReportData(PEPP), "data");    
            }
            
        }

        private void grdMainDiagnosis_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (grdMainDiagnosis.SelectedRows.Count > 0) {
                string hd = grdMainDiagnosis.SelectedRows[0].Cells[1].Value.ToString();
                List<string> pepps =
                    CsvData.Context()
                        .PrimaryDiagnoses
                        .Where(pepp => pepp.DiagCode == hd)
                        .Select(pepp => pepp.PeppCode)
                        .ToList();
                var q = CsvData.Context().PrimaryDiagnoses.Where(pd => pepps.Contains(pd.PeppCode) && pd.DiagCode == hd)
                    .Select(pd => new {PEPP = pd.PeppCode, HD = pd.DiagCode, AnzahlFälle = pd.Count.ToString("##,##0"), AnteilFälle = pd.Fraction.ToString("P")});
                FrmSearch search = new FrmSearch(this);
                search.StartPosition = FormStartPosition.CenterParent;
                search.Text = "PEPPs zu Hauptdiagnosen";
                search.ButtonShowIsVisible = false;
                search.SetDataSource(q);
                search.ColumnTextAlign(2, DataGridViewContentAlignment.MiddleRight);
                search.ColumnTextAlign(3, DataGridViewContentAlignment.MiddleRight);
                if (search.ShowDialog() == DialogResult.OK) {
                    LoadPeppByTabControl(search);
                }
            }
        }

        private void grdSecondaryDiagnosis_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (grdSecondaryDiagnosis.SelectedRows.Count > 0) {
                string sd = grdSecondaryDiagnosis.SelectedRows[0].Cells[1].Value.ToString();
                List<string> pepps =
                    CsvData.Context()
                        .SecondaryDiagnoses
                        .Where(pepp => pepp.DiagCode == sd)
                        .Select(pepp => pepp.PeppCode)
                        .ToList();
                var q = CsvData.Context().SecondaryDiagnoses.Where(pd => pepps.Contains(pd.PeppCode) && pd.DiagCode == sd)
                    .Select(nd => new {
                        PEPP = nd.PeppCode,
                        ND = nd.DiagCode,
                        AnzahlFälle = nd.CaseCount.ToString("##,##0"),
                        AnteilFälle = nd.CaseFraction.ToString("P"),
                        AnzahlNennungen = nd.EntryCount.ToString("##,##0"),
                        AnteilNennungen = nd.EntryFraction.ToString("P")
                                      });
                FrmSearch search = new FrmSearch(this);
                search.StartPosition = FormStartPosition.CenterParent;
                search.Text = "PEPPs zu Nebendiagnosen";
                search.ButtonShowIsVisible = false;
                search.SetDataSource(q);
                search.ColumnTextAlign(2, DataGridViewContentAlignment.MiddleRight);
                search.ColumnTextAlign(3, DataGridViewContentAlignment.MiddleRight);
                search.ColumnTextAlign(4, DataGridViewContentAlignment.MiddleRight);
                search.ColumnTextAlign(5, DataGridViewContentAlignment.MiddleRight);
                if (search.ShowDialog() == DialogResult.OK) {
                    LoadPeppByTabControl(search);
                }
            }
        }

        private void grdProcedures_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (grdProcedures.SelectedRows.Count > 0) {
                string proc = grdProcedures.SelectedRows[0].Cells[1].Value.ToString();
                List<string> pepps =
                    CsvData.Context()
                        .Procedures
                        .Where(pepp => pepp.ProcCode == proc)
                        .Select(pepp => pepp.PeppCode)
                        .ToList();
                var q = CsvData.Context().Procedures.Where(pd => pepps.Contains(pd.PeppCode) && pd.ProcCode == proc)
                    .Select(p => new {
                        PEPP = p.PeppCode,
                        Prozedur = p.ProcCode,
                        AnzahlFälle = p.CaseCount.ToString("##,##0"),
                        AnteilFälle = p.CaseFraction.ToString("P"),
                        AnzahlNennungen = p.EntryCount.ToString("##,##0"),
                        AnteilNennungen = p.EntryFraction.ToString("P")
                                     });
                FrmSearch search = new FrmSearch(this);
                search.StartPosition = FormStartPosition.CenterParent;
                search.Text = "PEPPs zu Prozeduren";
                search.ButtonShowIsVisible = false;
                search.SetDataSource(q);
                search.ColumnTextAlign(2, DataGridViewContentAlignment.MiddleRight);
                search.ColumnTextAlign(3, DataGridViewContentAlignment.MiddleRight);
                search.ColumnTextAlign(4, DataGridViewContentAlignment.MiddleRight);
                search.ColumnTextAlign(5, DataGridViewContentAlignment.MiddleRight);
                if (search.ShowDialog() == DialogResult.OK) {
                    LoadPeppByTabControl(search);
                }
            }
        }

        private List<PeppData> setReportData(string pepp)
        {
            PeppInfo info = CsvData.Context().PeppInfos.Single(p => p.Code == pepp);
            info.StruCat = Selection.SKTxt;
            info.PeppTxt = cbxPepp.Text;
            PeppData data = new PeppData(info);
            data.PDX = CsvData.Context().PrimaryDiagnoses.Where(p => p.PeppCode == pepp).ToList();
            data.DDX = CsvData.Context().SecondaryDiagnoses.Where(p => p.PeppCode == pepp).ToList();
            data.Proc = CsvData.Context().Procedures.Where(p => p.PeppCode == pepp).ToList();
            List<PeppData> dataSet = new List<PeppData>();
            dataSet.Add(data);

            return dataSet;
        }


        private void LoadPeppByTabControl(FrmSearch search) {
            selection.ClearSelection();
            PEPP = search.Id.ToString();
            cbxPepp.Text = PEPP + ": ";
            cbxPepp.Text += CsvData.Context().Pepps.Where(p => p.Code == PEPP).Select(p => p.Text).Single();
            LoadPeppData();
        }

        private void mnuInfo_Click(object sender, EventArgs e) {
            FrmAbout about = new FrmAbout();
            about.ShowDialog(this);
        }

        private void FrmPeppBrowser_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Maximized) {
                titleBar.MinMaxImage = (Image) resources.GetObject("picMinMax.BackgroundImage2");
            } else {
                titleBar.MinMaxImage = (Image) resources.GetObject("picMinMax.BackgroundImage");
            }
        }
    }
}
