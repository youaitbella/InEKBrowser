using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using org.inek.InekBrowser.GUI;

namespace P21Browser {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CultureInfo culture;

            culture = CultureInfo.CreateSpecificCulture("de-DE");

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            Application.Run(new FrmSplash("P21"));
        }
    }
}
