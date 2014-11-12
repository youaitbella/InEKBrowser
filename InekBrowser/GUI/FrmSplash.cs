using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using org.inek.controls.util;
using org.inek.InekBrowser.Data;

namespace org.inek.InekBrowser.GUI {
    public partial class FrmSplash : Form {

        private PrintLibraryLoader _printLoader;

        /* Use for window moving */
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

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
                this.BackColor = BrowserColors.DrgSplashScreen;
                label1.Text = "DRG-Browser\nVersion " + Program.Year + ".1\n© InEK GmbH";
            } else if (Program.SystemBrowser == Program.System.Pepp) {
                titleBar.BackColor = BrowserColors.PeppSplashScreenTitleBar;
                titleBar.Title = "Code-Browser " + Program.Year;
                this.BackColor = BrowserColors.PeppSplashScreen;
                label1.Text = "Code-Browser\nVersion " + Program.Year + ".1\n© InEK GmbH";
            }
        }

        private static void SetSystem(string system) {
            if (system.ToUpper() == "DRG")
                Program.SystemBrowser = Program.System.Drg;
            else if (system.ToUpper() == "PEPP")
                Program.SystemBrowser = Program.System.Pepp;
            else
                Program.SystemBrowser = Program.System.Unknown;
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FrmSplash_Shown(object sender, EventArgs e) {
            Visible = false;
            try {
                if (Program.SystemBrowser == Program.System.Pepp) {
                    ResourceController.CheckResourceDir();
                    ResourceController.CheckForResourceFiles();
                    //ResourceController.CheckResourceFilesWithSHA256();
                    LoadPeppDataToMemory();
                } else if (Program.SystemBrowser == Program.System.Drg) {
                    
                }
                _printLoader.LoadPrintLibrarys();
                new FrmInekBrowser().Visible = true;
                Visible = false;
            } catch (Exception ex) {
                MessageBox.Show(this, ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private static void LoadPeppDataToMemory() {
            var x1 = CsvData.Context().CostDomains;
            var x2 = CsvData.Context().Costs;
            var x4 = CsvData.Context().Pepps;
            var x3 = CsvData.Context().PeppInfos;
            var x5 = CsvData.Context().PrimaryDiagnoses;
            var x8 = CsvData.Context().SecondaryDiagnoses;
            var x6 = CsvData.Context().Procedures;
            var x7 = CsvData.Context().Recherche;
            var x9 = CsvData.Context().StructureCategories;
            var x10 = CsvData.Context().Catalogs;
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
                    lblProgressState.Text = "Lade Code-Details...";
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
