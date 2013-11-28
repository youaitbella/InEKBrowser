using System;
using System.Collections.Generic;
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


        // Handles resize event 
        protected override void WndProc(ref Message m) {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;

            const UInt32 HTLEFT = 10;
            const UInt32 HTRIGHT = 11;
            const UInt32 HTBOTTOMRIGHT = 17;
            const UInt32 HTBOTTOM = 15;
            const UInt32 HTBOTTOMLEFT = 16;
            const UInt32 HTTOP = 12;
            const UInt32 HTTOPLEFT = 13;
            const UInt32 HTTOPRIGHT = 14;

            const int RESIZE_HANDLE_SIZE = 10;
            bool handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE) {
                Size formSize = this.Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);

            Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {
            {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
            {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
        };

                foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes) {
                    if (hitBox.Value.Contains(clientPoint)) {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }
    }
}
