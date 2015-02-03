using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace org.inek.InekBrowser.GUI {
    public partial class FrmAbout : Form {

        /* Use for window moving */
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        /* ################## */

        public FrmAbout() {
            InitializeComponent();
            titleBar.ShowIconify = false;
            titleBar.ShowMinMax = false;
            UpdateGuiForSystem();
        }

        private void UpdateGuiForSystem() {
            if (Program.SystemBrowser == Program.System.Pepp) {
                titleBar.BackColor = BrowserColors.PeppSplashScreenTitleBar;
                titleBar.Title = "PEPP-Browser " + Program.Year;
                BackColor = BrowserColors.PeppSplashScreen;
                label1.Text = "PEPP-Browser\nVersion " + Program.Year + ".1\n© InEK GmbH";
            } else if (Program.SystemBrowser == Program.System.Drg) {
                titleBar.BackColor = BrowserColors.DrgSplashScreenTitleBar;
                titleBar.Title = "G-DRG-Report-Browser " + Program.Year;
                BackColor = BrowserColors.DrgSplashScreen;
                label1.Text = "G-DRG-Report-Browser\nVersion " + Program.Year + ".1\n© InEK GmbH";
            } else if (Program.SystemBrowser == Program.System.P21) {
                titleBar.BackColor = BrowserColors.P21SplashScreenTitleBar;
                titleBar.Title = "G-DRG-Browser " + (int.Parse(Program.Year) - 2) + "_" + (int.Parse(Program.Year) - 1);
                BackColor = BrowserColors.P21SplashScreen;
                label1.Text = "G-DRG-Browser " + (int.Parse(Program.Year) - 2) + "_" + (int.Parse(Program.Year) - 1) + "\nVersion " + Program.Year + ".1\n© InEK GmbH";
            }
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Dispose();
        }
    }
}
