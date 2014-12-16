using System;
using System.Drawing;
using System.Windows.Forms;

namespace org.inek.InekBrowser.GUI {
    public partial class DrgData : UserControl {

        public event EventHandler ClickedCatalogue;

        public string GenderMale {
            set { txtGenderMale.Text = value; }
        }

        public string GenderFemale {
            set { txtGenderFemale.Text = value; }
        }

        public string GenderUnknown {
            set { txtGenderUnknown.Text = value; }
        }

        public string CaseCostAvg {
            set { txtArithMw.Text = value; }
        }

        public string CaseCostStd {
            set { txtStdAbw.Text = value; }
        }

        public string PCCL0 {
            set { txtPCCL0.Text = value; }
        }

        public string PCCL1 {
            set { txtPCCL1.Text = value; }
        }

        public string PCCL2 {
            set { txtPCCL2.Text = value; }
        }

        public string PCCL3 {
            set { txtPCCL3.Text = value; }
        }

        public string PCCL4 {
            set { txtPCCL4.Text = value; }
        }

        public string LosShort {
            set { txtLosShort.Text = value; }
        }

        public string LosNormal {
            set { txtLosNormal.Text = value; }
        }

        public string LosLong {
            set { txtLosLong.Text = value; }
        }

        public string LosDay1Reduction {
            set { txtDay1Reduction.Text = value; }
        }

        public string LosDay1Remuneration {
            set { txtDay1Remuneration.Text = value; }
        }

        public string LosAvg {
            set { txtLosAvg.Text = value; }
        }

        public string LosStd {
            set { txtLosStd.Text = value; }
        }

        public string ValutationRatio {
            set { txtValutationRatio.Text = value; }
        }

        public string CasesNormal {
            set { txtCasesNormal.Text = value; }
        }

        public string FromMdc {
            set { txtFromMdc.Text = value; }
        }

        public string FromAll {
            set { txtFromAll.Text = value; }
        }

        public string LT28Days { // Lt = less than
            set { txtLT28Days.Text = value; }
        }

        public string Bt28Days1Year { // Bt = between
            set { txtBt28Days1Year.Text = value; }
        }

        public string Bt1Year2 {
            set { txtBt1Year2.Text = value; }
        }

        public string Bt3Year5 {
            set { txtBt3Year5.Text = value; }
        }

        public string Bt6Year9 {
            set { txtBt6Year9.Text = value; }
        }

        public string Bt10Year15 {
            set { txtBt10Year15.Text = value; }
        }

        public string Bt16Year17 {
            set { txtBt16Year17.Text = value; }
        }

        public string Bt18Year29 {
            set { txtBt18Year29.Text = value; }
        }

        public string Bt30Year39 {
            set { txtBt30Year39.Text = value; }
        }

        public string Bt40Year49 {
            set { txtBt40Year49.Text = value; }
        }

        public string Bt50Year54 {
            set { txtBt50Year54.Text = value; }
        }

        public string Bt55Year59 {
            set { txtBt55Year59.Text = value; }
        }

        public string Bt60Year64 {
            set { txtBt60Year64.Text = value; }
        }

        public string Bt65Year74 {
             set { txtBt65Year74.Text = value; }
        }

        public string Bt75Year79 {
            set { txtBt75Year79.Text = value; }
        }

        public string Gt79Year { // Greater than
            set { txtGt79Year.Text = value; }
        }

        public string TitleDrg {
            set { pnlData.Text = value; }
        }

        public string Mdc {
            set { txtMdcNum.Text = value; }
        }

        public string MdcText {
            set { txtMdcText.Text = value; }
        }

        public string NumDrgs {
            set { txtNumDrgs.Text = value; }
        }

        public string MdcCases {
            set { txtN.Text = value; }
        }

        public DrgData() {
            InitializeComponent();
        }

        public void ColorTextFields(Color color) {
            foreach (Control tb in Controls) {
                ColorTextFields(color, tb);
            }
        }

        private void ColorTextFields(Color color, Control control) {
            foreach (Control tb in control.Controls) {
                var grp = typeof(GroupBox);
                var p = typeof(Panel);
                if (tb.GetType() == grp || tb.GetType() == p)
                    ColorTextFields(color, tb);
                var t = typeof(TextBox);
                if (tb.GetType() != t) continue;
                var box = (TextBox)tb;
                box.BackColor = color;
            }
        }

        private void btnCatalog_Click(object sender, System.EventArgs e) {
            if (ClickedCatalogue != null)
                ClickedCatalogue(sender, e);
        }
    }
}
