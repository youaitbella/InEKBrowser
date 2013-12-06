using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using org.inek.controls.FilteredDataGridView;
using org.inek.controls.helper;
using org.inek.PeppBrowser.Data;
using org.inek.PeppBrowser.Data.Entities;

namespace org.inek.PeppBrowser.GUI {
    public partial class FrmPeppBrowser : Form {

        /* Use for window moving */
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        /* ################## */

        private FrmList dlg;

        public static string PEPP {
            get; set;
        }

        public string TextPEPP {
            set { cbxPepp.Text = value; }
        }

        public FrmPeppBrowser() {
            InitializeComponent();
            Selection.Parent = this;
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
            dlg = new FrmList();
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
                MessageBox.Show(pnlContentBackground, "Es gibt keine PEPP zu Ihren Filtereinstellungen.", "Keine Pepp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dlg.SetDataSource(q);
            dlg.DisplayCellValues = 3;
            dlg.ClickedOk += dlg_ClickedOkPepp;
            dlg.Show(this);
        }

        void dlg_ClickedOkPepp(object sender, EventArgs e) {
            PEPP = dlg.SelectedItem.Split('#')[1];
            cbxPepp.Text = dlg.SelectedItem.Split('#')[2];
            FillHeadData();
            FillActiveTab(ActiveGrid());
        }

        private void FillActiveTab(DataGridView grid) {
            if (grid == grdMainDiagnosis) {
                grid.DataSource = Helper.ConvertToDataTable(CsvData.Context().PrimaryDiagnoses.Where(pepp => pepp.PeppCode == PEPP)
                    .Select(pepp => new { PEPP = pepp.PeppCode, Hauptdiagnose = pepp.DiagCode, Anzahl = pepp.Count, Anteil = pepp.Fraction }));
            } else if (grid == grdSecondaryDiagnosis) {
                grid.DataSource = Helper.ConvertToDataTable(CsvData.Context().SecondaryDiagnoses.Where(pepp => pepp.PeppCode == PEPP)
                    .Select(pepp => new { PEPP = pepp.PeppCode, Nebendiagnose = pepp.DiagCode, AnzahlFälle = pepp.CaseCount, AnteilFälle = pepp.CaseFraction, AnzahlNennungen = pepp.EntryCount, AnteilNennungen = pepp.EntryFraction }));   
            } else if (grid == grdProcedures) {
                grid.DataSource = Helper.ConvertToDataTable(CsvData.Context().Procedures.Where(pepp => pepp.PeppCode == PEPP)
                    .Select(pepp => new { PEPP = pepp.PeppCode, Prozedur = pepp.ProcCode, AnzahlFälle = pepp.CaseCount, AnteilFälle = pepp.CaseFraction, AnzahlNennungen = pepp.EntryCount, AnteilNennungen = pepp.EntryFraction }));   
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
            }
            return null;
        } 

        private void FillHeadData() {
            var q = CsvData.Context().PeppInfos.Where(pepp => pepp.Code == PEPP);
            data.CasesNumSummary = q.Select(p => p.CaseCount.ToString()).ElementAt(0);
            data.Cases1 = q.Select(p => p.CaseCountPayLevel1.ToString()).ElementAt(0);
            data.Cases2 = q.Select(p => p.CaseCountPayLevel2.ToString()).ElementAt(0);
            data.Cases3 = q.Select(p => p.CaseCountPayLevel3.ToString()).ElementAt(0);
            data.Cases4 = q.Select(p => p.CaseCountPayLevel4.ToString()).ElementAt(0);
            data.Cases5 = q.Select(p => p.CaseCountPayLevel5.ToString()).ElementAt(0);
            data.CasesP1 = q.Select(p => Math.Round((p.CaseFractionPayLevel1*100), 2).ToString()).ElementAt(0); // Prozent
            data.CasesP2 = q.Select(p => Math.Round((p.CaseFractionPayLevel2*100), 2).ToString()).ElementAt(0); // Prozent
            data.CasesP3 = q.Select(p => Math.Round((p.CaseFractionPayLevel3*100), 2).ToString()).ElementAt(0); // Prozent
            data.CasesP4 = q.Select(p => Math.Round((p.CaseFractionPayLevel4*100), 2).ToString()).ElementAt(0); // Prozent
            data.CasesP5 = q.Select(p => Math.Round((p.CaseFractionPayLevel5*100), 2).ToString()).ElementAt(0); // Prozent
            data.DaysSummary = q.Select(p => p.LosSumDays.ToString()).ElementAt(0);
            data.Days1 = q.Select(p => p.DayCountPayLevel1.ToString()).ElementAt(0);
            data.Days2 = q.Select(p => p.DayCountPayLevel2.ToString()).ElementAt(0);
            data.Days3 = q.Select(p => p.DayCountPayLevel3.ToString()).ElementAt(0);
            data.Days4 = q.Select(p => p.DayCountPayLevel4.ToString()).ElementAt(0);
            data.Days5 = q.Select(p => p.DayCountPayLevel5.ToString()).ElementAt(0);
            data.LosAverage = q.Select(p => Math.Round(p.LosAverage, 1).ToString()).ElementAt(0);               // einstellig Dezimal
            data.LosStandardDeviation = q.Select(p => Math.Round(p.LosStandard, 1).ToString()).ElementAt(0);    // einstellig Dezimal
            data.LosHomogeneityCoeff = q.Select(p => Math.Round((p.LosHc*100),2).ToString()).ElementAt(0);      // Prozent
            data.LosFrom1 = q.Select(p => p.LosFromPayLevel1.ToString()).ElementAt(0);
            data.LosFrom2 = q.Select(p => p.LosFromPayLevel2.ToString()).ElementAt(0);
            data.LosFrom3 = q.Select(p => p.LosFromPayLevel3.ToString()).ElementAt(0);
            data.LosFrom4 = q.Select(p => p.LosFromPayLevel4.ToString()).ElementAt(0);
            data.LosFrom5 = q.Select(p => p.LosFromPayLevel5.ToString()).ElementAt(0);
            data.LosTo1 = q.Select(p => p.LosToPayLevel1.ToString()).ElementAt(0);
            data.LosTo2 = q.Select(p => p.LosToPayLevel2.ToString()).ElementAt(0);
            data.LosTo3 = q.Select(p => p.LosToPayLevel3.ToString()).ElementAt(0);
            data.LosTo4 = q.Select(p => p.LosToPayLevel4.ToString()).ElementAt(0);
            data.LosTo5 = q.Select(p => p.LosToPayLevel5.ToString()).ElementAt(0);
            data.ValuationRatio1 = q.Select(p => Math.Round(p.ValuationRatLevel1, 4).ToString()).ElementAt(0);  // vierstellig Dezimal
            data.ValuationRatio2 = q.Select(p => Math.Round(p.ValuationRatLevel2, 4).ToString()).ElementAt(0);  // vierstellig Dezimal
            data.ValuationRatio3 = q.Select(p => Math.Round(p.ValuationRatLevel3, 4).ToString()).ElementAt(0);  // vierstellig Dezimal
            data.ValuationRatio4 = q.Select(p => Math.Round(p.ValuationRatLevel4, 4).ToString()).ElementAt(0);  // vierstellig Dezimal
            data.ValuationRatio5 = q.Select(p => Math.Round(p.ValuationRatLevel5, 4).ToString()).ElementAt(0);  // vierstellig Dezimal
            data.GenderMale = q.Select(p => Math.Round((p.GenderMale*100), 2).ToString()).ElementAt(0);         // Prozent
            data.GenderFemale = q.Select(p => Math.Round((p.GenderFemale*100), 2).ToString()).ElementAt(0);     // Prozent
            data.AgeAverage = q.Select(p => Math.Round(p.AgeAverage, 1).ToString()).ElementAt(0);               // einstellig Dezimal
            data.AgeStandardDeviation = q.Select(p => Math.Round(p.AgeStandard,1).ToString()).ElementAt(0);     // einstellig Dezimal
            data.LT28Days = q.Select(p => Math.Round((p.AgeBelow28Days*100),2).ToString()).ElementAt(0);        // Prozent
            data.Bt28Days1Year = q.Select(p => Math.Round((p.AgeBelow1Year*100),2).ToString()).ElementAt(0);    // Prozent
            data.Bt1Year2 = q.Select(p => Math.Round((p.AgeBelow3Years*100),2).ToString()).ElementAt(0);        // Prozent
            data.Bt3Year5 = q.Select(p => Math.Round((p.AgeBelow6Years*100),2).ToString()).ElementAt(0);        // Prozent
            data.Bt6Year9 = q.Select(p => Math.Round((p.AgeBelow10Years*100),2).ToString()).ElementAt(0);       // Prozent
            data.Bt10Year15 = q.Select(p => Math.Round((p.AgeBelow16Years*100),2).ToString()).ElementAt(0);     // Prozent
            data.Bt16Year17 = q.Select(p => Math.Round((p.AgeBelow18Years*100),2).ToString()).ElementAt(0);     // Prozent
            data.Bt18Year29 = q.Select(p => Math.Round((p.AgeBelow30Years*100),2).ToString()).ElementAt(0);     // Prozent
            data.Bt30Year39 = q.Select(p => Math.Round((p.AgeBelow40Years*100),2).ToString()).ElementAt(0);     // Prozent
            data.Bt40Year49 = q.Select(p => Math.Round((p.AgeBelow50Years*100),2).ToString()).ElementAt(0);     // Prozent
            data.Bt50Year54 = q.Select(p => Math.Round((p.AgeBelow55Years*100),2).ToString()).ElementAt(0);     // Prozent
            data.Bt55Year59 = q.Select(p => Math.Round((p.AgeBelow60Years*100),2).ToString()).ElementAt(0);     // Prozent
            data.Bt60Year64 = q.Select(p => Math.Round((p.AgeBelow65Years*100),2).ToString()).ElementAt(0);     // Prozent
            data.Bt65Year74 = q.Select(p => Math.Round((p.AgeBelow75Years*100),2).ToString()).ElementAt(0);     // Prozent
            data.Bt75Year79 = q.Select(p => Math.Round((p.AgeBelow80Years*100),2).ToString()).ElementAt(0);     // Prozent
            data.Gt79Year = q.Select(p => Math.Round((p.AgeBelow99Years*100),2).ToString()).ElementAt(0);       // Prozent
            data.DailyCostsAverage = q.Select(p => Math.Round(p.DayCostsAverage, 2).ToString()).ElementAt(0);   // zweistellig Dezimal (money)
            data.DailyCostsStandardDeviation = q.Select(p => Math.Round(p.DayCostsStandard, 2).ToString()).ElementAt(0);    // zweistellig Dezimal (money)
            data.DailyCostsHomogeneityCoeff = q.Select(p => Math.Round((p.DayCostsHc*100),2).ToString()).ElementAt(0);  // Prozent
            data.TitlePEPP = "PEPP - " + PEPP;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            FillActiveTab(ActiveGrid());
        }
    }
}
