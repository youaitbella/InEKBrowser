using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using org.inek.controls.gui;
using org.inek.InekBrowser.Data;

namespace org.inek.InekBrowser.GUI {
    public partial class Selection : UserControl {

        public static string SK {
            get; set;
        }

        public static string SKTxt {
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

        public new static FrmInekBrowser Parent { 
            private get; set;
        }

        public Selection() {
            InitializeComponent();
            SK = "";
            SKTxt = "";
            PEPP = "";
            PD = "";
            SD = "";
            Procedure = "";
            cbxSk.InputField.Click += cbxSk_ButtonClicked;
            cbxMainDiagnosis.InputField.Click += cbxMainDiagnosis_ButtonClicked;
            cbxSecondaryDiagnosis.InputField.Click += cbxSecondaryDiagnosis_ButtonClicked;
            cbxProcedure.InputField.Click += cbxProcedure_ButtonClicked;
        }

        public void ClearSelection() {
            SK = "";
            PEPP = "";
            PD = "";
            SD = "";
            Procedure = "";
            cbxSk.Text = "";
            cbxMainDiagnosis.Text = "";
            cbxSecondaryDiagnosis.Text = "";
            cbxProcedure.Text = "";
            picClearHd.Visible = false;
            picClearSd.Visible = false;
            picClearSk.Visible = false;
        }

        private void SetHelpProvider(FrmSearch dlg) {
            dlg.helpProvider1.HelpNamespace = helpProvider1.HelpNamespace;
            dlg.helpProvider1.SetHelpNavigator(dlg, HelpNavigator.Topic);
            dlg.helpProvider1.SetShowHelp(dlg, true);
            dlg.helpProvider1.SetHelpKeyword(dlg, "Filter.htm");
        }

        private void cbxSk_ButtonClicked(object sender, EventArgs e) {
            FrmSearch dlg = new FrmSearch(cbxSk);
            SetHelpProvider(dlg);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ButtonShowIsVisible = false;
            var q = CsvData.Context().StructureCategories.OrderBy(sk => sk.Order)
                    .Select(sk => new { SK = sk.Category, sk.Text, PEPPs = sk.PeppCount, Fälle = sk.CaseCount, Tage = sk.DayCount });
            dlg.SetDataSource(q);
            dlg.KeyColumns = new string[] {"SK", "Text"};
            dlg.Text = "Strukturkategorien";
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                Parent.TextPEPP = "";
                List<object> cells = (List<object>) dlg.Id;
                cbxSk.Text = cells[1].ToString();
                SKTxt = cbxSk.Text;
                SK = cells[0].ToString();
                picClearSk.Visible = true;
            }

        }

        private void cbxMainDiagnosis_ButtonClicked(object sender, EventArgs e) {
            FrmSearch dlg = new FrmSearch(cbxMainDiagnosis);
            SetHelpProvider(dlg);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ButtonShowIsVisible = false;
            var q = CsvData.Context()
                .Recherche.Where(md => md.PrimaryDaignosis == 1)
                .Select(md => new {Hauptdiagnose = md.Code, Text = md.Text});
            dlg.SetDataSource(q);
            dlg.Text = "Hauptdiagnosen";
            dlg.KeyColumns = new[] {"Hauptdiagnose"};
            if (dlg.ShowDialog() == DialogResult.OK) {
                Parent.TextPEPP = "";
                cbxProcedure.Text = "";
                Procedure = "";
                cbxSecondaryDiagnosis.Text = "";
                SD = "";
                cbxMainDiagnosis.Text = dlg.Id.ToString();
                PD = dlg.Id.ToString();
                picClearHd.Visible = true;
                picClearSd.Visible = false;
                picClearProc.Visible = false;
            }
        }

        private void cbxSecondaryDiagnosis_ButtonClicked(object sender, EventArgs e) {
            FrmSearch dlg = new FrmSearch(cbxSecondaryDiagnosis);
            SetHelpProvider(dlg);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ButtonShowIsVisible = false;
            var q =
                CsvData.Context()
                    .Recherche.Where(sd => sd.SecondaryDiagnosis == 1)
                    .Select(sd => new {Sekundärdiagnose = sd.Code, Text = sd.Text});
            dlg.SetDataSource(q);
            dlg.Text = "Sekundärdiagnosen";
            dlg.KeyColumns = new[] {"Sekundärdiagnose"};
            if (dlg.ShowDialog() == DialogResult.OK) {
                Parent.TextPEPP = "";
                cbxMainDiagnosis.Text = "";
                PD = "";
                cbxProcedure.Text = "";
                Procedure = "";
                cbxSecondaryDiagnosis.Text = dlg.Id.ToString();
                SD = dlg.Id.ToString();
                picClearSd.Visible = true;
                picClearHd.Visible = false;
                picClearProc.Visible = false;
            }
        }

        private void cbxProcedure_ButtonClicked(object sender, EventArgs e) {
            FrmSearch dlg = new FrmSearch(cbxProcedure);
            SetHelpProvider(dlg);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ButtonShowIsVisible = false;
            var q =
                CsvData.Context()
                    .Recherche.Where(proc => proc.Procedure == 1)
                    .Select(proc => new { Prozedur = proc.Code, Text = proc.Text });
            dlg.SetDataSource(q);
            dlg.Text = "Prozeduren";
            dlg.KeyColumns = new[] {"Prozedur"};
            if (dlg.ShowDialog() == DialogResult.OK) {
                Parent.TextPEPP = "";
                cbxMainDiagnosis.Text = "";
                PD = "";
                cbxSecondaryDiagnosis.Text = "";
                SD = "";
                cbxProcedure.Text = dlg.Id.ToString();
                Procedure = dlg.Id.ToString();
                picClearProc.Visible = true;
                picClearHd.Visible = false;
                picClearSd.Visible = false;
            }
        }

        private void picClearSk_Click(object sender, EventArgs e) {
            SK = "";
            cbxSk.Text = "";
            picClearSk.Visible = false;
        }

        private void picClearHd_Click(object sender, EventArgs e) {
            cbxMainDiagnosis.Text = "";
            PD = "";
            picClearHd.Visible = false;
        }

        private void picClearSd_Click(object sender, EventArgs e) {
            cbxSecondaryDiagnosis.Text = "";
            SD = "";
            picClearSd.Visible = false;
        }

        private void picClearProc_Click(object sender, EventArgs e) {
            cbxProcedure.Text = "";
            Procedure = "";
            picClearProc.Visible = false;
        }
    }
}
