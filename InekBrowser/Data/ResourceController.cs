using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace org.inek.InekBrowser.Data {
    class ResourceController {

        public const string RESOURCE_FILES_HASH = "68AEA4961FFCE5C2B6FA3246542C27D5835E75D7F1B10BFA7503E6F5D232C37";

        public enum ResourceFilesIndex {
            Hauptdiagnose,
            Kopfdaten,
            Kosten,
            Kostenbereich,
            Nebendiagnose,
            Pepp,
            Prozeduren,
            Recherche,
            Strukturkategorie,
            Katalog
        };
        
        public static string RESOURCE_DIR = @"Data\";

        public static string[] RESOURCE_FILES = {
                                                     "RepBrPepp_13_15_Hauptdiagnose.csv", 
                                                     "RepBrPepp_13_15_Kopfdaten.csv",
                                                     "RepBrPepp_13_15_Kosten.csv", 
                                                     "RepBrPepp_13_15_Kostenbereich.csv",
                                                     "RepBrPepp_13_15_Nebendiagnosen.csv", 
                                                     "RepBrPepp_13_15_Pepp.csv",
                                                     "RepBrPepp_13_15_Prozeduren.csv", 
                                                     "RepBrPepp_13_15_Recherche.csv",
                                                     "RepBrPepp_13_15_Strukturkategorie.csv",
                                                     "RepBrPepp_13_15_Katalog.csv"
                                                 };

        public static string[] RESOURCE_HEADERS = {
                                                      "hd_Pepp;hd_Code;hd_FaelleAnzahl;hd_FaelleAnteil",
                                                      
                                                      "kd_Pepp;kd_FaelleAnzahl;kd_SummePflegetage;kd_PflegetageMw;kd_PflegetageStd;kd_PflegetageHK;" +
                                                      "kd_GeschlechtM;kd_GeschlechtW;kd_AlterMw;kd_AlterStd;kd_AlterU28T;kd_AlterU01;kd_AlterU03;" +
                                                      "kd_AlterU06;kd_AlterU10;kd_AlterU16;kd_AlterU18;kd_AlterU30;kd_AlterU40;kd_AlterU50;kd_AlterU55;kd_AlterU60;kd_AlterU65;kd_AlterU75;kd_AlterU80;kd_AlterU99;" +
                                                      "kd_TageskostenMw;kd_TageskostenStd;kd_TageskostenHK;kd_Degressionsendpunkt",
                                                      
                                                      "ko_Pepp;ko_BereichNr;ko_KArt1;ko_KArt2;ko_KArt3a;ko_KArt3b;ko_KArt3c;ko_KArt3;ko_KArt4a;ko_KArt4b;ko_KArt5;ko_KArt6a;ko_KArt6b;ko_KArt7;ko_KArt8",
                                                      "kb_Nr;kb_BereichOrder;kb_Bereich",
                                                      "nd_Pepp;nd_Code;nd_FaelleAnzahl;nd_FaelleAnteil;nd_NennungenAnzahl;nd_NennungenAnteil",
                                                      "pe_SK;pe_Pepp;pe_Text",
                                                      "pr_Pepp;pr_Code;pr_FaelleAnzahl;pr_FaelleAnteil;pr_NennungenAnzahl;pr_NennungenAnteil",
                                                      "re_Code;re_Text;re_Hauptdiagnose;re_Nebendiagnose;re_Prozedur",
                                                      "st_Strukturkategorie;st_Order;st_Text;st_PeppAnzahl;st_FaelleAnzahl;st_TageAnzahl",
                                                      "ka_Pepp;ka_Verguetungsklasse;ka_Relgew"
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
                    throw new Exception("Fehler: Die Resource-Datei " + RESOURCE_FILES[i] + " fehlt. Bitte downloaden Sie den Code Browser erneut.");
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
                throw new Exception("Fehler: Die Resource-Dateien wurden verändert. Bitte laden Sie den Code Browser erneut auf unserer Website (http://g-drg.de) herunter.");
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
