using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using org.inek.PeppBrowser.Data;

namespace org.inek.PeppBrowser.GUI {
    public partial class FrmPeppBrowser : Form {

        /* Use for window moving */
        private const int WM_NCLBUTTONDOWN  = 0xA1;
        private const int HT_CAPTION        = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        /* ################## */


        public FrmPeppBrowser() {
            InitializeComponent();
            titleBar.TitleBarPanel.MouseMove += FrmPeppBrowser_MouseMove;
            titleBar.FormStatePanel.MouseMove += FrmPeppBrowser_MouseMove;
            titleBar.Title.MouseMove += FrmPeppBrowser_MouseMove;
        }

        private void mnuPepp_Click(object sender, System.EventArgs e) {
            FrmList dlg = new FrmList();
            dlg.SetDataSource(CsvData.Context().Pepps);
            dlg.Text = "PEPPS";
            dlg.Show();
        }

        private void mnuStructureCategories_Click(object sender, System.EventArgs e) {
            FrmList dlg = new FrmList();
            dlg.SetDataSource(CsvData.Context().StructureCategories);
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
            Cursor = DefaultCursor;
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
