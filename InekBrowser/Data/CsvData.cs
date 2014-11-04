using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Globalization;
using System.IO;
using System.Reflection;
using org.inek.InekBrowser.Data.Entities;
using org.inek.controls.helper;

namespace org.inek.InekBrowser.Data {
    /// <summary>
    /// This class encapsulates all persistent datta objects
    /// It#s instnce is available by Context, similar to DbContext
    /// All data will be lazy loaded on demand only
    /// All entities to be loaded need to be annotated with "Column" at each property.
    /// Theses names equal to the names of the headline
    /// </summary>
    public class CsvData {
        private static CsvData _instance;
        private static ResourceController _controller;

        private readonly List<Cost> _costs = new List<Cost>();
        private readonly List<CostDomain> _costDomains = new List<CostDomain>();
        private readonly List<Pepp> _pepps = new List<Pepp>();
        private readonly List<PeppInfo> _peppInfos = new List<PeppInfo>();
        private readonly List<PrimaryDiagnosis> _primaryDiagnoses = new List<PrimaryDiagnosis>();
        private readonly List<Procedure> _procedures = new List<Procedure>();
        private readonly List<SecondaryDiagnosis> _secondaryDiagnoses = new List<SecondaryDiagnosis>();
        private readonly List<StructureCategory> _structureCategories = new List<StructureCategory>();
        private readonly List<Recherche> _recherche = new List<Recherche>(); 

        private CsvData() {
        }

        public static CsvData Context() {
            if (_instance == null) {
                _instance = new CsvData();
                _controller = new ResourceController();
            }
            return _instance;
        }

        public IEnumerable<Cost> Costs {
            get {
                EnsureData(_costs, ResourceController.RESOURCE_FILES[(int)ResourceController.ResourceFilesIndex.Kosten], ResourceController.RESOURCE_HEADERS[(int)ResourceController.ResourceFilesIndex.Kosten]);
                return _costs;
            }
        }

        public IEnumerable<CostDomain> CostDomains {
            get {
                EnsureData(_costDomains, ResourceController.RESOURCE_FILES[(int)ResourceController.ResourceFilesIndex.Kostenbereich], ResourceController.RESOURCE_HEADERS[(int)ResourceController.ResourceFilesIndex.Kostenbereich]);
                return _costDomains;
            }
        }

        public IEnumerable<StructureCategory> StructureCategories {
            get {
                EnsureData(_structureCategories, ResourceController.RESOURCE_FILES[(int)ResourceController.ResourceFilesIndex.Strukturkategorie], ResourceController.RESOURCE_HEADERS[(int)ResourceController.ResourceFilesIndex.Strukturkategorie]);
                return _structureCategories;
            }
        }

        public IEnumerable<Pepp> Pepps {
            get {
                EnsureData(_pepps, ResourceController.RESOURCE_FILES[(int)ResourceController.ResourceFilesIndex.Pepp], ResourceController.RESOURCE_HEADERS[(int)ResourceController.ResourceFilesIndex.Pepp]);
                return _pepps;
            }
        }

        public IEnumerable<PeppInfo> PeppInfos {
            get {
                EnsureData(_peppInfos, ResourceController.RESOURCE_FILES[(int)ResourceController.ResourceFilesIndex.Kopfdaten], ResourceController.RESOURCE_HEADERS[(int)ResourceController.ResourceFilesIndex.Kopfdaten]);
                return _peppInfos;
            }
        }

        public IEnumerable<Procedure> Procedures {
            get {
                EnsureData(_procedures, ResourceController.RESOURCE_FILES[(int)ResourceController.ResourceFilesIndex.Prozeduren], ResourceController.RESOURCE_HEADERS[(int)ResourceController.ResourceFilesIndex.Prozeduren]);
                return _procedures;
            }
        }

        public IEnumerable<PrimaryDiagnosis> PrimaryDiagnoses {
            get {
                EnsureData(_primaryDiagnoses, ResourceController.RESOURCE_FILES[(int)ResourceController.ResourceFilesIndex.Hauptdiagnose], ResourceController.RESOURCE_HEADERS[(int)ResourceController.ResourceFilesIndex.Hauptdiagnose]);
                return _primaryDiagnoses;
            }
        }

        public IEnumerable<SecondaryDiagnosis> SecondaryDiagnoses {
            get {
                EnsureData(_secondaryDiagnoses, ResourceController.RESOURCE_FILES[(int)ResourceController.ResourceFilesIndex.Nebendiagnose], ResourceController.RESOURCE_HEADERS[(int)ResourceController.ResourceFilesIndex.Nebendiagnose]);
                return _secondaryDiagnoses;
            }
        }

        public IEnumerable<Recherche> Recherche {
            get {
                EnsureData(_recherche, ResourceController.RESOURCE_FILES[(int)ResourceController.ResourceFilesIndex.Recherche], ResourceController.RESOURCE_HEADERS[(int)ResourceController.ResourceFilesIndex.Recherche]);
                return _recherche;
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
                string relativeName = ResourceController.RESOURCE_DIR + filename;


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
                            if (tokens[names[name]] == null)
                                continue;
                            switch (info.PropertyType.Name) {
                                case "Decimal":
                                    decimal decimalNumber = 0;
                                    if (tokens[names[name]] == "")
                                        continue;
                                    try {
                                        decimalNumber = decimal.Parse(tokens[names[name]], new CultureInfo("de"));
                                    } catch {
                                        
                                    }
                                    info.SetValue(obj, decimalNumber, null);
                                    break;
                                case "Int32":
                                    int number = 0;
                                    if (tokens[names[name]] == "")
                                        continue;
                                    try {
                                        
                                        number = int.Parse(tokens[names[name]]);
                                    } catch {
                                        
                                    }
                                    info.SetValue(obj, number, null);
                                    break;
                                case "String":
                                    info.SetValue(obj, tokens[names[name]], null);
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
