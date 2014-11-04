using System;
using System.Windows.Forms;
using org.inek.InekBrowser.GUI;

namespace org.inek.InekBrowser {
    static class Program {

        public enum System {
            Drg,
            Pepp,
            Unknown
        }

        public static System SystemBrowser { get; set; }
        public const string Year = "2015";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSplash("InekBrowser"));
        }
    }
}
