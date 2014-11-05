using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace org.inek.InekBrowser.GUI {
    public partial class PeppData : UserControl {

        public string CasesNumSummary {
            set { txtCasesSummary.Text = value; }
        }

        public string DaysSummary {
            set { txtDaysSummary.Text = value; }
        }

        public string LosAverage {
            set { txtLosAverage.Text = value; }
        }

        public string LosStandardDeviation {
            set { txtLosStandardDeviation.Text = value; }
        }

        public string LosHomogeneityCoeff {
            set { txtLosHomogeneityCoeff.Text = value; }
        }

        public string DailyCostsAverage {
            set { txtDailyCostsAverage.Text = value; }
        }

        public string DailyCostsStandardDeviation {
            set { txtDailyCostsStandardDeviation.Text = value; }
        }

        public string DailyCostsHomogeneityCoeff {
            set { txtDailyCostsHomogeneityCoeff.Text = value; }
        }

        public string AgeAverage {
            set { txtAgeAverage.Text = value; }
        }

        public string AgeStandardDeviation {
            set { txtAgeStandardDeviation.Text = value; }
        }

        public string GenderMale {
            set { txtGenderMale.Text = value; }
        }

        public string GenderFemale {
            set { txtGenderFemale.Text = value; }
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

        public string TitlePEPP {
            set { pnlData.Text = value; }
        }

        public PeppData() {
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
    }
}
