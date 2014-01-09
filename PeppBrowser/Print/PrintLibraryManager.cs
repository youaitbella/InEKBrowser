using System;
using System.Runtime.InteropServices;

namespace org.inek.PeppBrowser.Print {
    public class PrintLibraryManager {
        
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        static extern bool SetCurrentDirectory(string lpPathName);

        public string PrintDirectory {
            get; set;
        }

        private string[] _listLabelLibrarys;

        public PrintLibraryManager(string printDirectory)
            : this(printDirectory, new[] { "cmut18.dll", "cmbr18.dll", "cmct18.dll", "cmdw18.dll", "cmmx18.dll", "cmll18pr.dll", "cmll18.dll", "cmll18xl.dll" }) {
        }

        public PrintLibraryManager(string printDirectory, string[] printLibs) {
            PrintDirectory = printDirectory;
            _listLabelLibrarys = printLibs;
        }

        public void LoadPrintLibrarys() {
            SetCurrentDirectory(PrintDirectory);
            foreach (string library in _listLabelLibrarys) {
                IntPtr moduleHandle = IntPtr.Zero;
                moduleHandle = LoadLibrary(library);
                if (moduleHandle == IntPtr.Zero) {
                    throw new Exception("Failed to load a List & Label library. Path: \""+ library + "\"");  
                }
            }
            SetCurrentDirectory("..");
        }
    }
}
