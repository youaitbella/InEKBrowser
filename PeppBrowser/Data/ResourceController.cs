using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace org.inek.PeppBrowser.Data {
    class ResourceController {

        public const string RESOURCE_FILES_HASH = "B364C0CBB06BB7D75F9B35D57101FADC67D6E22CA8CC8A21EFA52463EFCD";

        public enum ResourceFilesIndex {
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
        /// <summary>
        /// Throws an exception, if the resource folder doesnt exist.
        /// </summary>
        public static void CheckResourceDir() {
            if (!Directory.Exists(RESOURCE_DIR)) {
                throw new Exception("Fehler: Der Resource Ordner wurde gelöscht.");
            }
        }

        /// <summary>
        /// Throws an exception if a resource file doesnt exist.
        /// </summary>
        public static void CheckForResourceFiles() {
            string[] files = Directory.GetFiles(RESOURCE_DIR);
            for (int i = 0; i < files.Length; i++) {
                if (!File.Exists(RESOURCE_DIR + RESOURCE_FILES[i])) {
                    throw new Exception("Fehler: Die Resource-Datei " + RESOURCE_FILES[i] + " fehlt. Bitte downloaden Sie den PEPP Browser erneut.");
                }
            }
        }

        /// <summary>
        /// Throws an exception, if the resource files got manipulated.
        /// </summary>
        public static void CheckResourceFilesWithSHA256() {
            string hashes = GenerateResourceFilesHash();
            byte[] hashesBytes = Encoding.ASCII.GetBytes(hashes);
            SHA256 sha = new SHA256Managed();
            byte[] masterHashByte = sha.ComputeHash(hashesBytes);
            string masterHash = "";
            masterHash = HashBytesToHexString(masterHashByte, masterHash);
            if (masterHash != RESOURCE_FILES_HASH) {
                throw new Exception("Fehler: Die Resource-Dateien wurden verändert. Bitte laden Sie den PEPP Browser erneut herunter.");
            }
        }

        private static string GenerateResourceFilesHash() {
            string concatResourceHash = "";
            SHA256 sha = new SHA256Managed();
            for (int i = 0; i < RESOURCE_FILES.Length; i++) {
                FileStream stream = File.OpenRead(RESOURCE_DIR + RESOURCE_FILES[i]);
                byte[] fileBuffer = new byte[(int)stream.Length];
                stream.Read(fileBuffer, 0, (int)stream.Length);
                byte[] hash = sha.ComputeHash(fileBuffer);
                concatResourceHash = HashBytesToHexString(hash, concatResourceHash);
            }
            return concatResourceHash;
        }

        private static string HashBytesToHexString(byte[] hash, string concatResourceHash) {
            for (int j = 0; j < hash.Length; j++) {
                concatResourceHash += hash[j].ToString("X");
            }
            return concatResourceHash;
        }
    }
}
