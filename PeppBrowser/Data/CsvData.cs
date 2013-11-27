using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using org.inek.PeppBrowser.Data.Entities;
using org.inek.controls.helper;

namespace org.inek.PeppBrowser.Data {
    /// <summary>
    /// This class encapsulates all persistent datta objects
    /// It#s instnce is available by Context, similar to DbContext
    /// All data will be lazy loaded on demand only
    /// All entities to be loaded need to be annotated with "Column" at each property.
    /// Theses names equal to the names of the headline
    /// </summary>
    public class CsvData {
        private static CsvData _instance;

        private readonly List<Cost> _costs = new List<Cost>();
        private readonly List<CostDomain> _costDomains = new List<CostDomain>();
        private readonly List<Pepp> _pepps = new List<Pepp>();
        private readonly List<PeppInfo> _peppInfos = new List<PeppInfo>();
        private readonly List<PrimaryDiagnosis> _primaryDiagnoses = new List<PrimaryDiagnosis>();
        private readonly List<Procedure> _procedures = new List<Procedure>();
        private readonly List<SecondaryDiagnosis> _secondaryDiagnoses = new List<SecondaryDiagnosis>();
        private readonly List<StructureCategory> _structureCategories = new List<StructureCategory>();

        private CsvData() {
        }

        public static CsvData Context() {
            if (_instance == null) {
                _instance = new CsvData();
            }
            return _instance;
        }

        public IEnumerable<Cost> Costs {
            get {
                EnsureData(_costs, "PeppBr_12_14_Kosten.csv", "ko_Pepp;ko_BereichNr;ko_KArt1;ko_KArt2;ko_KArt3a;ko_KArt3b;ko_KArt3c;ko_KArt3;ko_KArt4a;ko_KArt4b;ko_KArt6a;ko_KArt6b;ko_KArt7;ko_KArt8;ko_Summe");
                return _costs;
            }
        }

        public IEnumerable<CostDomain> CostDomains {
            get {
                EnsureData(_costDomains, "PeppBr_12_14_Kostenbereich.csv", "kb_Nr;kb_Bereich;kb_BereichOrder");
                return _costDomains;
            }
        }

        public IEnumerable<StructureCategory> StructureCategories {
            get {
                EnsureData(_structureCategories, "PeppBr_12_14_Strukturkategorie.csv", "st_Strukturkategorie;st_Order;st_Text;st_PeppAnzahl;st_FaelleAnzahl;st_TageAnzahl");
                return _structureCategories;
            }
        }

        public IEnumerable<Pepp> Pepps {
            get {
                EnsureData(_pepps, "PeppBr_12_14_Pepp.csv", "pe_SK;pe_Pepp;pe_Text");
                return _pepps;
            }
        }

        public IEnumerable<PeppInfo> PeppInfos {
            get {
                EnsureData(_peppInfos, "PeppBr_12_14_Kopfdaten.csv", "kd_Pepp;kd_FaelleAnzahl;kd_FaelleAnzahlVgst1;kd_FaelleAnzahlVgst2;kd_FaelleAnzahlVgst3;kd_FaelleAnzahlVgst4;" +
                                                                     "kd_FaelleAnzahlVgst5;kd_FaelleAnteilVstufe1;kd_FaelleAnteilVstufe2;kd_FaelleAnteilVstufe3;kd_FaelleAnteilVstufe4;" +
                                                                     "kd_FaelleAnteilVstufe5;kd_TageAnzahlVgst1;kd_TageAnzahlVgst2;kd_TageAnzahlVgst3;kd_TageAnzahlVgst4;kd_TageAnzahlVgst5;" +
                                                                     "kd_VwdSummeTage;kd_VwdMw;kd_VwdStd;kd_VwdHK;kd_VwdVonVgst1;kd_VwdBisVgst1;kd_BewertungsrelationTagVgst1;kd_VwdVonVgst2;" +
                                                                     "kd_VwdBisVgst2;kd_BewertungsrelationTagVgst2;kd_VwdVonVgst3;kd_VwdBisVgst3;kd_BewertungsrelationTagVgst3;kd_VwdVonVgst4;" +
                                                                     "kd_VwdBisVgst4;kd_BewertungsrelationTagVgst4;kd_VwdVonVgst5;kd_VwdBisVgst5;kd_BewertungsrelationTagVgst5;kd_GeschlechtM;" +
                                                                     "kd_GeschlechtW;kd_AlterMw;kd_AlterStd;kd_AlterU28T;kd_AlterU01;kd_AlterU03;kd_AlterU06;kd_AlterU10;kd_AlterU16;" +
                                                                     "kd_AlterU18;kd_AlterU30;kd_AlterU40;kd_AlterU50;kd_AlterU55;kd_AlterU60;kd_AlterU65;kd_AlterU75;kd_AlterU80;kd_AlterU99;" +
                                                                     "kd_TageskostenMw;kd_TageskostenStd;kd_TageskostenHK");
                return _peppInfos;
            }
        }

        public IEnumerable<Procedure> Procedures {
            get {
                EnsureData(_procedures, "PeppBr_12_14_Prozeduren.csv", "pr_Pepp;pr_Code;pr_AnzahlFaelle;pr_AnteilFaelle;pr_AnzahlNennungen;pr_AnteilNennungen");
                return _procedures;
            }
        }

        public IEnumerable<PrimaryDiagnosis> PrimaryDiagnoses {
            get {
                EnsureData(_primaryDiagnoses, "PeppBr_12_14_Hauptdiagnose.csv", "hd_Pepp;hd_Code;hd_Anzahl;hd_Anteil");
                return _primaryDiagnoses;
            }
        }

        public IEnumerable<SecondaryDiagnosis> SecondaryDiagnoses {
            get {
                EnsureData(_secondaryDiagnoses, "PeppBr_12_14_Nebendiagnose.csv", "nd_Pepp;nd_Code;nd_AnzahlFaelle;nd_AnteilFaelle;nd_AnzahlNennungen;nd_AnteilNennungen");
                return _secondaryDiagnoses;
            }
        }


        private void EnsureData<T>(List<T> list, string filename, string headline) {
            if (list.Count > 0) { return; }
            using (new WaitCursor()) {

                Dictionary<string, int> names = new Dictionary<string, int>();
                string[] header = headline.Split(new[] { ";" }, StringSplitOptions.None);
                for (int i = 0; i < header.Length; i++) {
                    names.Add(header[i], i);
                }
                bool isFirstLine = true;
                string relativeName = @"Data\Resources\" + filename;


                foreach (string line in File.ReadLines(relativeName)) {
                    if (isFirstLine) {
                        isFirstLine = false;
                        if (line != headline) {
                            throw new DataException("Wrong headline");
                        }
                    } else {
                        string[] tokens = line.Split(new[] { ";" }, StringSplitOptions.None);
                        if (tokens.Length != names.Count) {
                            throw new DataException("Wrong field count");
                        }
                        T obj = Activator.CreateInstance<T>();
                        foreach (PropertyInfo info in typeof(T).GetProperties()) {
                            if (!Attribute.IsDefined(info, typeof(ColumnAttribute))) { continue; }
                            ColumnAttribute columnAttribute = (ColumnAttribute)Attribute.GetCustomAttribute(info, typeof(ColumnAttribute));
                            string name = columnAttribute.Name;
                            switch (info.PropertyType.Name) {
                                case "Decimal":
                                    decimal decimalNumber = 0;
                                    try {
                                        decimalNumber = decimal.Parse(tokens[names[name]], new CultureInfo("de"));
                                    } catch { }
                                    info.SetValue(obj, decimalNumber);
                                    break;
                                case "Int32":
                                    int number = 0;
                                    try {
                                        number = int.Parse(tokens[names[name]]);
                                    } catch { }
                                    info.SetValue(obj, number);
                                    break;
                                case "String":
                                    info.SetValue(obj, tokens[names[name]]);
                                    break;
                                default:
                                    throw new NotImplementedException("Type " + info.PropertyType.Name + " not implemented yet");
                            }

                        }
                        list.Add(obj);
                    }
                }
            }
        }

    }
}
