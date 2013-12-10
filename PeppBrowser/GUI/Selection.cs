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

        public static FrmPeppBrowser Parent {
            get; set;
        }

        public Selection() {
            InitializeComponent();
            SK = "";
            PEPP = "";
            PD = "";
            SD = "";
            Procedure = "";
        }

        private void cbxSk_ButtonClicked(object sender, EventArgs e) {
            FrmSearch dlg = new FrmSearch(cbxSk);
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
                SK = cells[0].ToString();
            }

        }

        private void cbxMainDiagnosis_ButtonClicked(object sender, EventArgs e) {
            FrmSearch dlg = new FrmSearch(cbxMainDiagnosis);
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
            }
        }

        private void cbxSecondaryDiagnosis_ButtonClicked(object sender, EventArgs e) {
            FrmSearch dlg = new FrmSearch(cbxSecondaryDiagnosis);
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
            }
        }

        private void cbxProcedure_ButtonClicked(object sender, EventArgs e) {
            FrmSearch dlg = new FrmSearch(cbxProcedure);
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
            }
        }
    }
}
