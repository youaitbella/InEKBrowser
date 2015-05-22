using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using org.inek.controls.helper;
using org.inek.controls.util;
using org.inek.InekBrowser.Data;
using Application = System.Windows.Forms.Application;

namespace org.inek.InekBrowser.GUI {
    public partial class FrmSplash : Form {

        private PrintLibraryLoader _printLoader;

        /* Use for window moving */
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        /* ################## */

        public FrmSplash(string system) {
            InitializeComponent();
            Visible = false;
            SetSystem(system);
            UpdateGuiForSystem();
            _printLoader = new PrintLibraryLoader(@"Print\");
        }

        private void UpdateGuiForSystem() {
            if (Program.SystemBrowser == Program.System.Drg) {
                titleBar.BackColor = BrowserColors.DrgSplashScreenTitleBar;
                titleBar.Title = "DRG-Browser " + Program.Year;
                BackColor = BrowserColors.DrgSplashScreen;
                label1.Text = "DRG-Browser\nVersion " + Program.Year + ".1\n© InEK GmbH";
            } else if (Program.SystemBrowser == Program.System.Pepp) {
                titleBar.BackColor = BrowserColors.PeppSplashScreenTitleBar;
                titleBar.Title = "PEPP-Browser " + Program.Year;
                BackColor = BrowserColors.PeppSplashScreen;
                label1.Text = "PEPP-Browser\nVersion " + Program.Year + ".1\n© InEK GmbH";
            } else if (Program.SystemBrowser == Program.System.P21) {
                titleBar.BackColor = BrowserColors.DrgSplashScreenTitleBar;
                titleBar.Title = "P21-Browser " + Program.Year;
                BackColor = BrowserColors.DrgSplashScreen;
                label1.Text = "P21-Browser\nVersion " + Program.Year + ".1\n© InEK GmbH";
            } 
            else if (Program.SystemBrowser == Program.System.Unknown)
                Application.Exit();
        }

        private static void SetSystem(string system) {
            if (system.ToUpper() == "DRG")
                Program.SystemBrowser = Program.System.Drg;
            else if (system.ToUpper() == "PEPP")
                Program.SystemBrowser = Program.System.Pepp;
            else if(system.ToUpper() == "P21")
                Program.SystemBrowser = Program.System.P21;
            else
                Program.SystemBrowser = Program.System.Unknown;
        }

        private void TitleBarMouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FrmSplash_Shown(object sender, EventArgs e) {
            Visible = false;
            Cursor = Cursors.WaitCursor;
            try {
                ResourceController.CheckResourceDir();
                ResourceController.CheckForResourceFiles();
                ResourceController.CheckResourceFilesWithSHA256();
                if (Program.SystemBrowser == Program.System.Pepp) {
                    CsvData.Context().LoadPeppDataToMemory();
                } else if (Program.SystemBrowser == Program.System.Drg || Program.SystemBrowser == Program.System.P21) {
                    CsvData.Context().LoadDrgDataToMemory(CsvData.DrgType.HA);
                }
                bool success = _printLoader.LoadPrintLibrarys(PrintLibraryLoader.FailureOption.ReturnFalse);
                if (!success) {
                    MessageBox.Show("Fehler beim Laden der Druck-Bibliothek. Es sind keine Reports möglich.");
                }
                new FrmInekBrowser().Visible = true;
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
            }
            Cursor = DefaultCursor;
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e) {
            
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            prgBar.PerformStep();
            switch (e.ProgressPercentage) {
                case 10:
                    lblProgressState.Text = "Lade Kosten...";
                    break;
                case 20:
                    lblProgressState.Text = "Lade PEPPs...";
                    break;
                case 30:
                    lblProgressState.Text = "Lade PEPP-Details...";
                    break;
                case 40:
                    lblProgressState.Text = "Lade Hauptdiagnosen...";
                    break;
                case 50:
                    lblProgressState.Text = "Lade Nebendiagnosen...";
                    break;
                case 60:
                    lblProgressState.Text = "Lade Prozeduren...";
                    break;
                case 70:
                    lblProgressState.Text = "Lade Recherche-Daten...";
                    break;
                case 80:
                    lblProgressState.Text = "Lade Strukturkategorien...";
                    break;
            }
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (!e.Cancelled) {
            }
        }

        private void titleBar_ClickedExit(object sender, EventArgs e) {
            Application.Exit();
        }

        private void FrmSplash_Load(object sender, EventArgs e) {
            
        }
    }
}
