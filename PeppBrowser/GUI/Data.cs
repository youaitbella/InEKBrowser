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

namespace org.inek.PeppBrowser.GUI {
    public partial class Data : UserControl {

        public string CasesNumSummary {
            set { txtCasesSummary.Text = value; }
        }

        public string Cases1 {
            set { txtCases1.Text = value; }
        }

        public string Cases2 {
            set { txtCases2.Text = value; }
        }

        public string Cases3 {
            set { txtCases3.Text = value; }
        }

        public string Cases4 {
            set { txtCases4.Text = value; }
        }

        public string Cases5 {
            set { txtCases5.Text = value; }
        }

        public string CasesP1 {
            set { txtCasesP1.Text = value; }
        }

        public string CasesP2 {
            set { txtCasesP2.Text = value; }
        }

        public string CasesP3 {
            set { txtCasesP3.Text = value; }
        }

        public string CasesP4 {
            set { txtCasesP4.Text = value; }
        }

        public string CasesP5 {
            set { txtCasesP5.Text = value; }
        }

        public string DaysSummary {
            set { txtDaysSummary.Text = value; }
        }

        public string Days1 {
            set { txtDays1.Text = value; }
        }

        public string Days2 {
            set { txtDays2.Text = value; }
        }

        public string Days3 {
            set { txtDays3.Text = value; }
        }

        public string Days4 {
            set { txtDays4.Text = value; }
        }

        public string Days5 {
            set { txtDays5.Text = value; }
        }

        public string LosFrom1 {
            set { txtLosFrom1.Text = value; }
        }

        public string LosFrom2 {
            set { txtLosFrom2.Text = value; }
        }

        public string LosFrom3 {
            set { txtLosFrom3.Text = value; }
        }

        public string LosFrom4 {
            set { txtLosFrom4.Text = value; }
        }

        public string LosFrom5 {
            set { txtLosFrom5.Text = value; }
        }

        public string LosTo1 {
            set { txtLosTo1.Text = value; }
        }

        public string LosTo2 {
            set { txtLosTo2.Text = value; }
        }

        public string LosTo3 {
            set { txtLosTo3.Text = value; }
        }

        public string LosTo4 {
            set { txtLosTo4.Text = value; }
        }

        public string LosTo5 {
            set { txtLosTo5.Text = value; }
        }

        public string ValuationRatio1 {
            set { txtValuationRatio1.Text = value; }
        }

        public string ValuationRatio2 {
            set { txtValuationRatio2.Text = value; }
        }

        public string ValuationRatio3 {
            set { txtValuationRatio3.Text = value; }
        }

        public string ValuationRatio4 {
            set { txtValuationRatio4.Text = value; }
        }

        public string ValuationRatio5 {
            set { txtValuationRatio5.Text = value; }
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

        public Data() {
            InitializeComponent();
        }
    }
}
