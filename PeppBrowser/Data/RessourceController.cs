using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace org.inek.PeppBrowser.Data {
    class RessourceController {

        public enum RessourceFilesIndex {
            Hauptdiagnose,
            Kopfdaten,
            Kosten,
            Kostenbereich,
            Nebendiagnose,
            Pepp,
            Prozeduren,
            Recherche,
            Strukturkategorie
        };

        public static string RESOURCE_DIR = @"Data\Resources\";

        public static string[] RESOURCE_FILES = {
                                                     "PeppBr_12_14_Hauptdiagnose.csv", "PeppBr_12_14_Kopfdaten.csv",
                                                     "PeppBr_12_14_Kosten.csv", "PeppBr_12_14_Kostenbereich.csv",
                                                     "PeppBr_12_14_Nebendiagnose.csv", "PeppBr_12_14_Pepp.csv",
                                                     "PeppBr_12_14_Prozeduren.csv", "PeppBr_12_14_Recherche.csv",
                                                     "PeppBr_12_14_Strukturkategorie.csv"
                                                 };

        public static bool CheckRessourceDir() {
            return Directory.Exists(RESOURCE_DIR);
        }

        public static bool CheckForResourceFiles() {
            string[] files = Directory.GetFiles(RESOURCE_DIR);
            for (int i = 0; i < files.Length; i++) {
                
            }
        }
    }
}
