using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using org.inek.controls.gui;
using org.inek.InekBrowser.Data;

namespace org.inek.InekBrowser.GUI {
    public partial class SelectionPepp : UserControl {

        public static string Category {
            get; set;
        }

        public static string CategoryText {
            get; set;
        }

        public static string Code {
            get; set;
        }

        public static string PrimaryDiagnosis {
            get; set;
        }

        public static string SecondaryDiagnosis {
            get; set;
        }

        public static string Procedure {
            get; set;
        }

        public new static FrmInekBrowser Parent { 
            private get; set;
        }

        public SelectionPepp() {
            InitializeComponent();
            Category = "";
            CategoryText = "";
            Code = "";
            PrimaryDiagnosis = "";
            SecondaryDiagnosis = "";
            Procedure = "";
            cbxCategory.InputField.Click += cbxSk_ButtonClicked;
            cbxMainDiagnosis.InputField.Click += cbxMainDiagnosis_ButtonClicked;
            cbxSecondaryDiagnosis.InputField.Click += cbxSecondaryDiagnosis_ButtonClicked;
            cbxProcedure.InputField.Click += cbxProcedure_ButtonClicked;
        }

        public void ClearSelection() {
            Category = "";
            Code = "";
            PrimaryDiagnosis = "";
            SecondaryDiagnosis = "";
            Procedure = "";
            cbxCategory.Text = "";
            cbxMainDiagnosis.Text = "";
            cbxSecondaryDiagnosis.Text = "";
            cbxProcedure.Text = "";
            picClearPrimaryDiag.Visible = false;
            picClearSecondaryDiag.Visible = false;
            picClearCategory.Visible = false;
        }

        private void SetHelpProvider(FrmSearch dlg) {
            dlg.helpProvider1.HelpNamespace = helpProvider1.HelpNamespace;
            dlg.helpProvider1.SetHelpNavigator(dlg, HelpNavigator.Topic);
            dlg.helpProvider1.SetShowHelp(dlg, true);
            dlg.helpProvider1.SetHelpKeyword(dlg, "Filter.htm");
        }

        private void cbxSk_ButtonClicked(object sender, EventArgs e) {
            FrmSearch dlg = new FrmSearch(cbxCategory);
            SetHelpProvider(dlg);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ButtonShowIsVisible = false;
            var q = CsvData.Context().StructureCategories.OrderBy(sk => sk.Order)
                    .Select(sk => new { SK = sk.Category, sk.Text, PEPPs = sk.PeppCount, Fälle = sk.CaseCount, Tage = sk.DayCount });
            dlg.SetDataSource(q);
            dlg.KeyColumns = new string[] {"SK", "Text"};
            dlg.Text = "Strukturkategorien";
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                Parent.TextCode = "";
                List<object> cells = (List<object>) dlg.Id;
                cbxCategory.Text = cells[1].ToString();
                CategoryText = cbxCategory.Text;
                Category = cells[0].ToString();
                picClearCategory.Visible = true;
            }

        }

        private void cbxMainDiagnosis_ButtonClicked(object sender, EventArgs e) {
            FrmSearch dlg = new FrmSearch(cbxMainDiagnosis);
            SetHelpProvider(dlg);
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ButtonShowIsVisible = false;
            var q = CsvData.Context()
                .Recherche.Where(md => md.PrimaryDiagnosis == 1).Select(pd => new { Hauptdiagnose = pd.Code, Text = pd.Text });
            dlg.SetDataSource(q);
            dlg.Text = "Hauptdiagnosen";
            dlg.KeyColumns = new[] {"Hauptdiagnose"};
            if (dlg.ShowDialog() == DialogResult.OK) {
                Parent.TextCode = "";
                cbxProcedure.Text = "";
                Procedure = "";
                cbxSecondaryDiagnosis.Text = "";
                SecondaryDiagnosis = "";
                cbxMainDiagnosis.Text = dlg.Id.ToString();
                PrimaryDiagnosis = dlg.Id.ToString();
                picClearPrimaryDiag.Visible = true;
                picClearSecondaryDiag.Visible = false;
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
                Parent.TextCode = "";
                cbxMainDiagnosis.Text = "";
                PrimaryDiagnosis = "";
                cbxProcedure.Text = "";
                Procedure = "";
                cbxSecondaryDiagnosis.Text = dlg.Id.ToString();
                SecondaryDiagnosis = dlg.Id.ToString();
                picClearSecondaryDiag.Visible = true;
                picClearPrimaryDiag.Visible = false;
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
                Parent.TextCode = "";
                cbxMainDiagnosis.Text = "";
                PrimaryDiagnosis = "";
                cbxSecondaryDiagnosis.Text = "";
                SecondaryDiagnosis = "";
                cbxProcedure.Text = dlg.Id.ToString();
                Procedure = dlg.Id.ToString();
                picClearProc.Visible = true;
                picClearPrimaryDiag.Visible = false;
                picClearSecondaryDiag.Visible = false;
            }
        }

        private void picClearSk_Click(object sender, EventArgs e) {
            Category = "";
            cbxCategory.Text = "";
            picClearCategory.Visible = false;
        }

        private void picClearHd_Click(object sender, EventArgs e) {
            cbxMainDiagnosis.Text = "";
            PrimaryDiagnosis = "";
            picClearPrimaryDiag.Visible = false;
        }

        private void picClearSd_Click(object sender, EventArgs e) {
            cbxSecondaryDiagnosis.Text = "";
            SecondaryDiagnosis = "";
            picClearSecondaryDiag.Visible = false;
        }

        private void picClearProc_Click(object sender, EventArgs e) {
            cbxProcedure.Text = "";
            Procedure = "";
            picClearProc.Visible = false;
        }
    }
}
