using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.inek.controls.gui;
using org.inek.PeppBrowser.Data;
using org.inek.PeppBrowser.Data.Entities;

namespace org.inek.PeppBrowser.GUI {
    public partial class Selection : UserControl {
        private FrmList dlg;
        private FrmPeppBrowser parent;

        public static string SK {
            get; set;
        }

        public static string PEPP {
            get; set;
        }

        public static string PD {
            get; set;
        }

        public static string SD {
            get; set;
        }

        public static string Procedure {
            get; set;
        }

        public Selection(FrmPeppBrowser p) {
            InitializeComponent();
            SK = "";
            PEPP = "";
            PD = "";
            SD = "";
            Procedure = "";
            parent = p;
        }

        private void cbxSk_ButtonClicked(object sender, EventArgs e) {
            FrmSearch dlg = new FrmSearch(cbxSk);
            var q = CsvData.Context().StructureCategories.OrderBy(sk => sk.Order)
                    .Select(sk => new { SK = sk.Category, sk.Text, PEPPs = sk.PeppCount, Fälle = sk.CaseCount, Tage = sk.DayCount });
            dlg.SetDataSource(q);
            dlg.KeyColumns = new string[] {"SK", "Text"};
            parent.TextPEPP = "";
            dlg.Text = "Strukturkategorien";
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                cbxSk.Text =(string) dlg.Id;
            }

        }

        private void cbxMainDiagnosis_ButtonClicked(object sender, EventArgs e) {
            dlg = new FrmList {Text = "Hauptdiagnosen", DisplayCellValues = 2};
            var q = CsvData.Context()
                .Recherche.Where(md => md.PrimaryDaignosis == 1)
                .Select(md => new {Hauptdiagnose = md.Code, Text = md.Text});
            dlg.SetDataSource(q);
            dlg.ClickedOk += DlgOnClickedOkMainDiag;
            dlg.Show();
        }

        private void cbxSecondaryDiagnosis_ButtonClicked(object sender, EventArgs e) {
            
            dlg = new FrmList {Text = "Nebendiagnosen", DisplayCellValues = 2,};
            var q =
                CsvData.Context()
                    .Recherche.Where(sd => sd.SecondaryDiagnosis == 1)
                    .Select(sd => new {Sekundärdiagnose = sd.Code, Text = sd.Text});
            dlg.SetDataSource(q);
            dlg.ClickedOk += DlgOnClickedOkSecondDiag;
            dlg.Show();
        }

        private void cbxProcedure_ButtonClicked(object sender, EventArgs e) {
            dlg = new FrmList {Text = "Prozeduren", DisplayCellValues = 2};
            var q =
                CsvData.Context()
                    .Recherche.Where(proc => proc.Procedure == 1)
                    .Select(proc => new { Prozedur = proc.Code, Text = proc.Text });
            dlg.SetDataSource(q);
            dlg.ClickedOk += DlgOnClickedProcs;
            dlg.Show();
        }

        private void DlgOnClickedOkSk(object sender, EventArgs eventArgs) {
            cbxSk.Text = dlg.SelectedItem.Split('#')[1];
            SK = dlg.SelectedItem.Split('#')[0];
        }

        private void DlgOnClickedOkMainDiag(object sender, EventArgs eventArgs) {
            if (SD == "" && Procedure == "") {
                cbxSecondaryDiagnosis.Text = "";
                cbxProcedure.Text = "";
            }
            parent.TextPEPP = "";
            cbxMainDiagnosis.Text = dlg.SelectedItem.Split('#')[0];
            PEPP = cbxMainDiagnosis.Text.Split('#')[0];
            PD = cbxMainDiagnosis.Text;
        }

        private void DlgOnClickedOkSecondDiag(object sender, EventArgs eventArgs) {
            if (PD == "" && Procedure == "") {
                cbxMainDiagnosis.Text = "";
                cbxProcedure.Text = "";
            }
            parent.TextPEPP = "";
            cbxSecondaryDiagnosis.Text = dlg.SelectedItem.Split('#')[0];
            PEPP = cbxSecondaryDiagnosis.Text.Split('#')[0];
            SD = cbxSecondaryDiagnosis.Text;
        }

        private void DlgOnClickedProcs(object sender, EventArgs eventArgs) {
            if (PD == "" && SD == "") {
                cbxMainDiagnosis.Text = "";
                cbxSecondaryDiagnosis.Text = "";
                parent.TextPEPP = "";
            }
            parent.TextPEPP = "";
            cbxProcedure.Text = dlg.SelectedItem.Split('#')[0];
            PEPP = cbxProcedure.Text.Split('#')[0];
            Procedure = cbxProcedure.Text;
        }
    }
}
