using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.inek.PeppBrowser.Data;
using org.inek.PeppBrowser.Data.Entities;

namespace org.inek.PeppBrowser.GUI {
    public partial class Selection : UserControl {
        private FrmList dlg;

        private string SK {
            get; set;
        }

        private string PEPP {
            get; set;
        }

        public Selection() {
            InitializeComponent();
            SK = "";
            PEPP = "";
        }

        private void cbxSk_ButtonClicked(object sender, EventArgs e) {
            dlg = new FrmList();
            var q = CsvData.Context().StructureCategories.OrderBy(sk => sk.Order)
                    .Select(sk => new { SK = sk.Category, sk.Text, PEPPs = sk.PeppCount, Fälle = sk.CaseCount, Tage = sk.DayCount });
            dlg.SetDataSource(q);
            dlg.Text = "Strukturkategorien";
            dlg.DisplayCellValues = 2;
            dlg.ClickedOk += DlgOnClickedOkSk;
            dlg.Show(this);
        }

        private void cbxPepp_ButtonClicked(object sender, EventArgs e) {
            dlg = new FrmList();
            var q = CsvData.Context().Pepps.Select(p => new {SK = p.StructureCategory, PEPP = p.Code, p.Text});
            if (SK != "" && PEPP != "") {
                q = q.Where(p => p.SK == SK && p.PEPP == PEPP);
            } else if (SK != "") {
                q = q.Where(p => p.SK == SK);
            } else if (PEPP != "") {
                q = q.Where(p => p.PEPP == PEPP);
            }
            dlg.SetDataSource(q);
            dlg.Text = "PEPPS";
            dlg.DisplayCellValues = 3;
            dlg.ClickedOk += DlgOnClickedOkPepp;
            dlg.Show(this);
        }

        private void cbxMainDiagnosis_ButtonClicked(object sender, EventArgs e) {
            dlg = new FrmList();
            if (SK != "") {
                List<string> pepps =
                    CsvData.Context().Pepps.Where(p => p.StructureCategory == SK).Select(p => p.Code).ToList();
                var q = CsvData.Context().PrimaryDiagnoses.Where(d => pepps.Contains(d.PeppCode)).Select(pd => new { PEPP = pd.PeppCode, Kode = pd.DiagCode, Anzahl = pd.Count, Anteil = pd.Fraction });
                dlg.SetDataSource(q);
            } else {
                var q = CsvData.Context().PrimaryDiagnoses.Select(pd => new { PEPP = pd.PeppCode, Kode = pd.DiagCode, Anzahl = pd.Count, Anteil = pd.Fraction });
                dlg.SetDataSource(q);
            }
            dlg.Text = "Hauptdiagnosen";
            dlg.DisplayCellValues = 2;
            dlg.ClickedOk += DlgOnClickedOkMainDiag;
            dlg.Show();
        }

        private void cbxSecondaryDiagnosis_ButtonClicked(object sender, EventArgs e) {
            dlg = new FrmList();
            if (SK != "") {
                List<string> pepps =
                    CsvData.Context().Pepps.Where(p => p.StructureCategory == SK).Select(p => p.Code).ToList();
                var q = CsvData.Context().SecondaryDiagnoses.Where(d => pepps.Contains(d.PeppCode)).Select(pd => new { PEPP = pd.PeppCode, Kode = pd.DiagCode, AnzahlFälle = pd.CaseCount, AnteilFälle = pd.CaseFraction, AnzahlNennungen = pd.EntryCount, AnteilNennungen = pd.EntryFraction });
                dlg.SetDataSource(q);
            } else {
                var q = CsvData.Context().SecondaryDiagnoses.Select(pd => new { PEPP = pd.PeppCode, Kode = pd.DiagCode, AnzahlFälle = pd.CaseCount, AnteilFälle = pd.CaseFraction, AnzahlNennungen = pd.EntryCount, AnteilNennungen = pd.EntryFraction });
                dlg.SetDataSource(q);
            }
            dlg.Text = "Nebendiagnosen";
            dlg.DisplayCellValues = 2;
            dlg.ClickedOk += DlgOnClickedOkSecondDiag;
            dlg.Show();
        }

        private void cbxProcedure_ButtonClicked(object sender, EventArgs e) {
            dlg = new FrmList();
            dlg.SetDataSource(CsvData.Context().Procedures);
            dlg.Text = "Prozeduren";
            dlg.DisplayCellValues = 2;
            dlg.ClickedOk += DlgOnClickedProcs;
            dlg.Show();
        }

        private void DlgOnClickedOkSk(object sender, EventArgs eventArgs) {
            cbxSk.Text = dlg.SelectedItem;
            if(cbxSk.Text.Substring(0, cbxSk.Text.IndexOf(" ")) != SK)
            {
                cbxPepp.Text = "";
                cbxMainDiagnosis.Text = "";
                cbxProcedure.Text = "";
                cbxSecondaryDiagnosis.Text = "";
                PEPP = "";
            }
            SK = cbxSk.Text.Substring(0, cbxSk.Text.IndexOf(" "));
        }

        private void DlgOnClickedOkPepp(object sender, EventArgs eventArgs) {
            cbxPepp.Text = dlg.SelectedItem;
            SK = cbxPepp.Text.Split(' ')[0];
            PEPP = cbxPepp.Text.Split(' ')[2];
            var tmp =
                CsvData.Context()
                    .StructureCategories.Select(sk => new {SK = sk.Category, Text = sk.Text})
                    .Where(sk => sk.SK == SK);
            cbxSk.Text = tmp.ElementAt(0).SK + "  ";
            cbxSk.Text += tmp.ElementAt(0).Text;
        }

        private void DlgOnClickedOkMainDiag(object sender, EventArgs eventArgs) {
            cbxMainDiagnosis.Text = dlg.SelectedItem;
            PEPP = cbxMainDiagnosis.Text.Split(' ')[0];
        }

        private void DlgOnClickedOkSecondDiag(object sender, EventArgs eventArgs) {
            cbxSecondaryDiagnosis.Text = dlg.SelectedItem;
            PEPP = cbxSecondaryDiagnosis.Text.Split(' ')[0];
        }

        private void DlgOnClickedProcs(object sender, EventArgs eventArgs) {
            cbxProcedure.Text = dlg.SelectedItem;
            PEPP = cbxProcedure.Text.Split(' ')[0];
        }
    }
}
