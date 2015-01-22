using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace org.inek.InekBrowser.Data {
    class ResourceController {

        private const string PEPP_RESOURCE_FILES_HASH = "5FE57F631EC793D69BD98C47270A028EA31B14A777AD5608ED67CDB52411F5";
        private const string DRG_RESOURCE_FILES_HASH = "F4E25812AA32650D6572339DABCE3EE9D44C62A709C328EACBC2F6451E014";
        private const string P21_RESOURCE_FILES_HASH = "98FD31F336BCF7133DA703880D470FF7BB3B047E0DCB15971B740E619623DD";

        public enum DrgResourceFilesIndex {
            Drg,
            Kostenbereich,
            HauptdiagnosenBa,
            KopfdatenBa,
            KostenBa,
            MdcBa,
            NebendiagnosenBa,
            ProzedurenBa,
            RechercheBa,
            HauptdiagnosenHa,
            KopfdatenHa,
            KostenHa,
            MdcHa,
            NebendiagnosenHa,
            ProzedurenHa,
            RechercheHa
        };

        public enum PeppResourceFilesIndex {
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

        public enum P21TsResourceFilesIndex {
            Hauptdiagnose,
            Kopfdaten,
            Mdc,
            Nebendiagnose,
            Prozeduren,
            Recherche,
            
            HauptdiagnoseDrgHa,
            ProzedurenDrgHa,
            KopfdatenDrgHa,
            MdcDrgHa,
            NebendiagnosenDrgHa,
            RechercheDrgHa,

            HauptdiagnoseDrgBa,
            KopfdatenDrgBa,
            MdcDrgBa,
            NebendiagnosenDrgBa,
            ProzedurenDrgBa,
            RechercheDrgBa,

            Drg
        }
        
        public static string RESOURCE_DIR = @"Data\";

        public static string[] DRG_RESOURCE_FILES = {
                                                        "RepBrDrg_13_15_Drg.csv",
                                                        "RepBrDrg_13_15_Kostenbereich.csv",
                                                        "RepBrDrg_BA_13_15_Hauptdiagnose.csv",
                                                        "RepBrDrg_BA_13_15_Kopfdaten.csv",
                                                        "RepBrDrg_BA_13_15_Kosten.csv",
                                                        "RepBrDrg_BA_13_15_Mdc.csv",
                                                        "RepBrDrg_BA_13_15_Nebendiagnosen.csv",
                                                        "RepBrDrg_BA_13_15_Prozeduren.csv",
                                                        "RepBrDrg_BA_13_15_Recherche.csv",
                                                        "RepBrDrg_HA_13_15_Hauptdiagnose.csv",
                                                        "RepBrDrg_HA_13_15_Kopfdaten.csv",
                                                        "RepBrDrg_HA_13_15_Kosten.csv",
                                                        "RepBrDrg_HA_13_15_Mdc.csv",
                                                        "RepBrDrg_HA_13_15_Nebendiagnosen.csv",
                                                        "RepBrDrg_HA_13_15_Prozeduren.csv",
                                                        "RepBrDrg_HA_13_15_Recherche.csv"
                                                    };

        public static string[] PEPP_RESOURCE_FILES = {
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

        public static string[] P21_RESOURCE_FILES = {
                                                        "P21BrDrg_TS_13_14_Hauptdiagnose.csv",
                                                        "P21BrDrg_TS_13_14_Kopfdaten.csv",
                                                        "P21BrDrg_TS_13_14_Mdc.csv",
                                                        "P21BrDrg_TS_13_14_Nebendiagnosen.csv",
                                                        "P21BrDrg_TS_13_14_Prozeduren.csv",
                                                        "P21BrDrg_TS_13_14_Recherche.csv",
                                                        
                                                        "P21BrDrg_HA_13_14_Hauptdiagnose.csv",
                                                        "P21BrDrg_HA_13_14_Prozeduren.csv",
                                                        "P21BrDrg_HA_13_14_Kopfdaten.csv",
                                                        "P21BrDrg_HA_13_14_Mdc.csv",
                                                        "P21BrDrg_HA_13_14_Nebendiagnosen.csv",
                                                        "P21BrDrg_HA_13_14_Recherche.csv",
                                                        
                                                        "P21BrDrg_BA_13_14_Hauptdiagnose.csv",
                                                        "P21BrDrg_BA_13_14_Kopfdaten.csv",
                                                        "P21BrDrg_BA_13_14_Mdc.csv",
                                                        "P21BrDrg_BA_13_14_Nebendiagnosen.csv",
                                                        "P21BrDrg_BA_13_14_Prozeduren.csv",
                                                        "P21BrDrg_BA_13_14_Recherche.csv",

                                                        "P21BrDrg_13_14_Drg.csv"
                                                    };

        public static string[] DRG_RESOURCE_HEADERS = {
                                                          "ID_MDC;ID_Partition;ID_DRG;ID_Text;ID_BA_Kalkuliert",
                                                          "IB_Nr;IB_Bereich",
                                                          "IH_DRG;IH_Code;IH_Prozent;IH_CodeF;IH_Anzahl",

                                                          "IK_MDC;IK_DRG;IK_Faelle_Anzahl;IK_PCCL0;IK_PCCL1;IK_PCCL2;IK_PCCL3;" +
                                                          "IK_PCCL4;IK_GeschlechtM;IK_GeschlechtW;IK_GeschlechtU;IK_AlterU28T;" +
                                                          "IK_AlterU01;IK_AlterU03;IK_AlterU06;IK_AlterU10;IK_AlterU16;IK_AlterU18;" +
                                                          "IK_AlterU30;IK_AlterU40;IK_AlterU50;IK_AlterU55;IK_AlterU60;IK_AlterU65;" +
                                                          "IK_AlterU75;IK_AlterU80;IK_AlterU99;IK_VWD_Kurz;IK_VWD_Norm;IK_VWD_Lang;" +
                                                          "IK_uGVD;IK_oGVD;IK_VWD_MW;IK_Bewertungsrelation;IK_Gesamt;IK_VWD_STD;IK_KOST_MW;IK_KOST_STD",

                                                          "IO_DRG;IO_BereichNr;IO_KArt1;IO_KArt2;IO_KArt3;IO_KArt4a;" +
                                                          "IO_KArt4b;IO_KArt5;IO_KArt6a;IO_KArt6b;IO_KArt7;IO_KArt8;IO_Summe",

                                                          "IM_MDC;IM_Text;IM_DRG_Anzahl;IM_Faelle_Anzahl",
                                                          "IN_DRG;IN_Code;IN_Prozent;IN_CodeF;IN_Anzahl;IN_ProzentN;IN_AnzahlN",
                                                          "IP_DRG;IP_Code;IP_Prozent;IP_CodeF;IP_Anzahl;IP_ProzentN;IP_AnzahlN",
                                                          "IC_Code;IC_Text;IC_CodeF;IC_ANZHDI;IC_ANZNDI;IC_AnzProzI",

                                                          "IH_DRG;IH_Code;IH_Prozent;IH_CodeF;IH_Anzahl",

                                                          "IK_MDC;IK_DRG;IK_Faelle_Anzahl;IK_PCCL0;IK_PCCL1;IK_PCCL2;" +
                                                          "IK_PCCL3;IK_PCCL4;IK_GeschlechtM;IK_GeschlechtW;IK_GeschlechtU;" +
                                                          "IK_AlterU28T;IK_AlterU01;IK_AlterU03;IK_AlterU06;IK_AlterU10;" +
                                                          "IK_AlterU16;IK_AlterU18;IK_AlterU30;IK_AlterU40;IK_AlterU50;" +
                                                          "IK_AlterU55;IK_AlterU60;IK_AlterU65;IK_AlterU75;IK_AlterU80;" +
                                                          "IK_AlterU99;IK_VWD_Kurz;IK_VWD_Norm;IK_VWD_Lang;IK_uGVD;IK_oGVD;" +
                                                          "IK_VWD_MW;IK_Bewertungsrelation;IK_Gesamt;IK_VWD_STD;IK_KOST_MW;IK_KOST_STD",

                                                          "IO_DRG;IO_BereichNr;IO_KArt1;IO_KArt2;IO_KArt3;IO_KArt4a;IO_KArt4b;IO_KArt5;" +
                                                          "IO_KArt6a;IO_KArt6b;IO_KArt7;IO_KArt8;IO_Summe",

                                                          "IM_MDC;IM_Text;IM_DRG_Anzahl;IM_Faelle_Anzahl",
                                                          "IN_DRG;IN_Code;IN_Prozent;IN_CodeF;IN_Anzahl;IN_ProzentN;IN_AnzahlN",
                                                          "IP_DRG;IP_Code;IP_Prozent;IP_CodeF;IP_Anzahl;IP_ProzentN;IP_AnzahlN",
                                                          "IC_Code;IC_Text;IC_CodeF;IC_ANZHDI;IC_ANZNDI;IC_AnzProzI"
                                                      };

        public static string[] PEPP_RESOURCE_HEADERS = {
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

        public static string[] P21_RESOURCE_HEADERS = {
                                                          "IH_DRG;IH_CodeF;IH_Anzahl;IH_Prozent",
                                                          "IK_MDC;IK_DRG;IK_Faelle_Anzahl;IK_PCCL0;IK_PCCL1;IK_PCCL2;IK_PCCL3;IK_PCCL4;IK_GeschlechtM;IK_GeschlechtW;IK_GeschlechtU;IK_AlterU28T;IK_AlterU01;IK_AlterU03;IK_AlterU06;IK_AlterU10;IK_AlterU16;IK_AlterU18;IK_AlterU30;IK_AlterU40;IK_AlterU50;IK_AlterU55;IK_AlterU60;IK_AlterU65;IK_AlterU75;IK_AlterU80;IK_AlterU99;IK_VWD_Kurz;IK_VWD_Norm;IK_VWD_Lang;IK_uGVD;IK_oGVD;IK_VWD_MW;IK_Bewertungsrelation;IK_Gesamt;IK_VWD_STD",
                                                          "IM_MDC;IM_Text;IM_DRG_Anzahl;IM_Faelle_Anzahl",
                                                          "IN_DRG;IN_CodeF;IN_Anzahl;IN_Prozent;IN_AnzahlN;IN_ProzentN",
                                                          "IP_DRG;IP_CodeF;IP_Anzahl;IP_Prozent;IP_AnzahlN;IP_ProzentN",
                                                          "IC_CodeF;IC_Text;IC_ANZHDI;IC_ANZNDI;IC_AnzProzI",

                                                          "IH_DRG;IH_CodeF;IH_Anzahl;IH_Prozent",
                                                          "IP_DRG;IP_CodeF;IP_Anzahl;IP_Prozent;IP_AnzahlN;IP_ProzentN",
                                                          "IK_MDC;IK_DRG;IK_Faelle_Anzahl;IK_PCCL0;IK_PCCL1;IK_PCCL2;IK_PCCL3;IK_PCCL4;IK_GeschlechtM;IK_GeschlechtW;IK_GeschlechtU;IK_AlterU28T;IK_AlterU01;IK_AlterU03;IK_AlterU06;IK_AlterU10;IK_AlterU16;IK_AlterU18;IK_AlterU30;IK_AlterU40;IK_AlterU50;IK_AlterU55;IK_AlterU60;IK_AlterU65;IK_AlterU75;IK_AlterU80;IK_AlterU99;IK_VWD_Kurz;IK_VWD_Norm;IK_VWD_Lang;IK_uGVD;IK_oGVD;IK_VWD_MW;IK_Bewertungsrelation;IK_Gesamt;IK_VWD_STD",
                                                          "IM_MDC;IM_Text;IM_DRG_Anzahl;IM_Faelle_Anzahl",
                                                          "IN_DRG;IN_CodeF;IN_Anzahl;IN_Prozent;IN_AnzahlN;IN_ProzentN",
                                                          "IC_CodeF;IC_Text;IC_ANZHDI;IC_ANZNDI;IC_AnzProzI",

                                                          "IH_DRG;IH_CodeF;IH_Anzahl;IH_Prozent",
                                                          "IK_MDC;IK_DRG;IK_Faelle_Anzahl;IK_PCCL0;IK_PCCL1;IK_PCCL2;IK_PCCL3;IK_PCCL4;IK_GeschlechtM;IK_GeschlechtW;IK_GeschlechtU;IK_AlterU28T;IK_AlterU01;IK_AlterU03;IK_AlterU06;IK_AlterU10;IK_AlterU16;IK_AlterU18;IK_AlterU30;IK_AlterU40;IK_AlterU50;IK_AlterU55;IK_AlterU60;IK_AlterU65;IK_AlterU75;IK_AlterU80;IK_AlterU99;IK_VWD_Kurz;IK_VWD_Norm;IK_VWD_Lang;IK_uGVD;IK_oGVD;IK_VWD_MW;IK_Bewertungsrelation;IK_Gesamt;IK_VWD_STD",
                                                          "IM_MDC;IM_Text;IM_DRG_Anzahl;IM_Faelle_Anzahl",
                                                          "IN_DRG;IN_CodeF;IN_Anzahl;IN_Prozent;IN_AnzahlN;IN_ProzentN",
                                                          "IP_DRG;IP_CodeF;IP_Anzahl;IP_Prozent;IP_AnzahlN;IP_ProzentN",
                                                          "IC_CodeF;IC_Text;IC_ANZHDI;IC_ANZNDI;IC_AnzProzI",

                                                          "ID_MDC;ID_Partition;ID_DRG;ID_Text"
                                                      };

        /// <summary>
        /// Throws an exception, if the resource folder doesnt exist.
        /// </summary>
        public static void CheckResourceDir() {
            if (!Directory.Exists(RESOURCE_DIR + Program.Year)) {
                throw new Exception("Fehler: Der Resource Ordner wurde gelöscht.");
            }
        }

        /// <summary>
        /// Throws an exception if a resource file doesnt exist.
        /// </summary>
        public static void CheckForResourceFiles() {
            string[] files = Directory.GetFiles(RESOURCE_DIR + Program.Year);
            for (int i = 0; i < files.Length; i++) {
                if (Program.SystemBrowser == Program.System.Pepp && !File.Exists(RESOURCE_DIR + Program.Year + "\\" + PEPP_RESOURCE_FILES[i])) {
                    throw new Exception("Fehler: Die Resource-Datei " + PEPP_RESOURCE_FILES[i] + " fehlt. Bitte downloaden Sie den PEPP-Browser erneut.");
                }
                if (Program.SystemBrowser == Program.System.Drg && !File.Exists(RESOURCE_DIR + Program.Year + "\\" + DRG_RESOURCE_FILES[i])) {
                    throw new Exception("Fehler: Die Resource-Datei " + DRG_RESOURCE_FILES[i] + " fehlt. Bitte downloaden Sie den DRG-Browser erneut.");
                }
                if (Program.SystemBrowser == Program.System.P21 && !File.Exists(RESOURCE_DIR + Program.Year + "\\" + P21_RESOURCE_FILES[i])) {
                    throw new Exception("Fehler: Die Resource-Datei " + P21_RESOURCE_FILES[i] + " fehlt. Bitte downloaden Sie den DRG-Browser erneut.");
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
            bool hashDifferent = masterHash != PEPP_RESOURCE_FILES_HASH && Program.SystemBrowser == Program.System.Pepp 
                || masterHash != DRG_RESOURCE_FILES_HASH && Program.SystemBrowser == Program.System.Drg 
                || masterHash != P21_RESOURCE_FILES_HASH && Program.SystemBrowser == Program.System.P21;
            if (hashDifferent) {
                throw new Exception("Fehler: Die Resource-Dateien wurden verändert. Bitte laden Sie den DRG-Browser erneut auf unserer Website (http://g-drg.de) herunter.");
            }
        }

        private static string GenerateResourceFilesHash() {
            string concatResourceHash = "";
            SHA256 sha = new SHA256Managed();
            if (Program.SystemBrowser == Program.System.Pepp) {
                for (int i = 0; i < PEPP_RESOURCE_FILES.Length; i++) {
                    FileStream stream = File.OpenRead(RESOURCE_DIR + Program.Year + "\\" + PEPP_RESOURCE_FILES[i]);
                    byte[] fileBuffer = new byte[(int)stream.Length];
                    stream.Read(fileBuffer, 0, (int)stream.Length);
                    byte[] hash = sha.ComputeHash(fileBuffer);
                    concatResourceHash = HashBytesToHexString(hash, concatResourceHash);
                }
            } else if (Program.SystemBrowser == Program.System.Drg) {
                for (int i = 0; i < DRG_RESOURCE_FILES.Length; i++) {
                    FileStream stream = File.OpenRead(RESOURCE_DIR + Program.Year + "\\" + DRG_RESOURCE_FILES[i]);
                    byte[] fileBuffer = new byte[(int)stream.Length];
                    stream.Read(fileBuffer, 0, (int)stream.Length);
                    byte[] hash = sha.ComputeHash(fileBuffer);
                    concatResourceHash = HashBytesToHexString(hash, concatResourceHash);
                }
            } else if (Program.SystemBrowser == Program.System.P21) {
                for (int i = 0; i < P21_RESOURCE_FILES.Length; i++) {
                    FileStream stream = File.OpenRead(RESOURCE_DIR + Program.Year + "\\" + P21_RESOURCE_FILES[i]);
                    byte[] fileBuffer = new byte[(int)stream.Length];
                    stream.Read(fileBuffer, 0, (int)stream.Length);
                    byte[] hash = sha.ComputeHash(fileBuffer);
                    concatResourceHash = HashBytesToHexString(hash, concatResourceHash);
                }
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
