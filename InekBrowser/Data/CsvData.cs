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

        private readonly List<Cost> _costs = new List<Cost>();
        private readonly List<CostDomain> _costDomains = new List<CostDomain>();
        private readonly List<Entities.System> _system = new List<Entities.System>();
        private readonly List<PeppInfo> _peppInfos = new List<PeppInfo>();
        private readonly List<PrimaryDiagnosis> _primaryDiagnoses = new List<PrimaryDiagnosis>();
        private readonly List<Procedure> _procedures = new List<Procedure>();
        private readonly List<SecondaryDiagnosis> _secondaryDiagnoses = new List<SecondaryDiagnosis>();
        private readonly List<StructureCategory> _structureCategories = new List<StructureCategory>();
        private readonly List<Recherche> _recherche = new List<Recherche>();
        private readonly List<Catalog> _catalogs = new List<Catalog>(); 

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
                if(_costs.Count == 0)
                    LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Kosten], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Kosten]);
                return _costs;
            }
        }

        public IEnumerable<CostDomain> CostDomains {
            get {
                if(_costDomains.Count == 0)
                    LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Kostenbereich], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Kostenbereich]);
                return _costDomains;
            }
        }

        public IEnumerable<StructureCategory> StructureCategories {
            get {
                if(_structureCategories.Count == 0)
                    LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Strukturkategorie], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Strukturkategorie]);
                return _structureCategories;
            }
        }

        public IEnumerable<Entities.System> System {
            get {
                if(_system.Count == 0)
                    LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Pepp], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Pepp]);
                return _system;
            }
        }

        public IEnumerable<PeppInfo> PeppInfos {
            get {
                if(_peppInfos.Count == 0)
                    LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Kopfdaten], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Kopfdaten]);
                return _peppInfos;
            }
        }

        public IEnumerable<Procedure> Procedures {
            get {
                if(_procedures.Count == 0)
                    LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Prozeduren], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Prozeduren]);
                return _procedures;
            }
        }

        public IEnumerable<PrimaryDiagnosis> PrimaryDiagnoses {
            get {
                if(_primaryDiagnoses.Count == 0)
                    LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Hauptdiagnose], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Hauptdiagnose]);
                return _primaryDiagnoses;
            }
        }

        public IEnumerable<SecondaryDiagnosis> SecondaryDiagnoses {
            get {
                if(_secondaryDiagnoses.Count == 0)
                    LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Nebendiagnose], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Nebendiagnose]);
                return _secondaryDiagnoses;
            }
        }

        public IEnumerable<Recherche> Recherche {
            get {
                if(_recherche.Count == 0)
                    LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Recherche], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Recherche]);
                return _recherche;
            }
        }

        public IEnumerable<Catalog> Catalogs {
            get {
                if(_catalogs.Count == 0)
                    LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Katalog], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Katalog]);
                return _catalogs;
            }
        } 


        //private void EnsureData<T>(List<T> list, string filename, string headline) {
        //    if (list.Count > 0) { return; }
        //    using (new WaitCursor()) {

        //        Dictionary<string, int> names = new Dictionary<string, int>();
        //        string[] header = headline.Split(new[] { ";" }, StringSplitOptions.None);
        //        for (int i = 0; i < header.Length; i++) {
        //            names.Add(header[i], i);
        //        }
        //        bool isFirstLine = true;
        //        string relativeName = ResourceController.RESOURCE_DIR + filename;


        //        foreach (string line in File.ReadLines(relativeName)) {
        //            if (isFirstLine) {
        //                isFirstLine = false;
        //                if (line != headline) {
        //                    throw new DataException("Wrong headline");
        //                }
        //            } else {
        //                string[] tokens = line.Split(new[] { ";" }, StringSplitOptions.None);
        //                if (tokens.Length != names.Count) {
        //                    throw new DataException("Wrong field count");
        //                }
        //                T obj = Activator.CreateInstance<T>();
        //                foreach (PropertyInfo info in typeof(T).GetProperties()) {
        //                    if (!Attribute.IsDefined(info, typeof(ColumnAttribute))) { continue; }
        //                    ColumnAttribute columnAttribute = (ColumnAttribute)Attribute.GetCustomAttribute(info, typeof(ColumnAttribute));
        //                    string name = columnAttribute.Name;
        //                    if (tokens[names[name]] == null)
        //                        continue;
        //                    switch (info.PropertyType.Name) {
        //                        case "Decimal":
        //                            decimal decimalNumber = 0;
        //                            if (tokens[names[name]] == "")
        //                                continue;
        //                            try {
        //                                decimalNumber = decimal.Parse(tokens[names[name]], new CultureInfo("de"));
        //                            } catch {
                                        
        //                            }
        //                            info.SetValue(obj, decimalNumber, null);
        //                            break;
        //                        case "Int32":
        //                            int number = 0;
        //                            if (tokens[names[name]] == "")
        //                                continue;
        //                            try {
                                        
        //                                number = int.Parse(tokens[names[name]]);
        //                            } catch {
                                        
        //                            }
        //                            info.SetValue(obj, number, null);
        //                            break;
        //                        case "String":
        //                            info.SetValue(obj, tokens[names[name]], null);
        //                            break;
        //                        default:
        //                            throw new NotImplementedException("Type " + info.PropertyType.Name + " not implemented yet");
        //                    }

        //                }
        //                list.Add(obj);
        //            }
        //        }
        //    }
        //}

        private void LoadData(string filename, string headline) {
            Dictionary<string, int> names = new Dictionary<string, int>();
            string[] header = headline.Split(new[] { ";" }, StringSplitOptions.None);
            for (int i = 0; i < header.Length; i++) {
                names.Add(header[i], i);
            }
            bool isFirstLine = true;
            string relativeName = "Data\\" + Program.Year + "\\" + filename;


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
                    if(Program.SystemBrowser == Program.System.Pepp)
                        MapPeppCsv2Entity(headline, tokens);
                    else if (Program.SystemBrowser == Program.System.Drg)
                        MapDrgCsv2Entity(headline, tokens);
                }
            }
        }

        private void MapDrgCsv2Entity(string headline, string[] tokens) {
            if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int) ResourceController.DrgResourceFilesIndex.Drg]) {
                MapDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int) ResourceController.DrgResourceFilesIndex.Kostenbereich]) {
                MapCostDomainDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int) ResourceController.DrgResourceFilesIndex.HauptdiagnosenBa]) {
                var pd = new PrimaryDiagnosis();
                pd.SystemCode = tokens[0];
                pd.DiagCode = tokens[1];
                pd.Fraction = decimal.Parse(tokens[2]);
                pd.DiagCodeF = tokens[3];
                pd.Count = int.Parse(tokens[4]);
                _primaryDiagnoses.Add(pd);
            }
        }

        private void MapCostDomainDrg(string[] tokens) {
            var cd = new CostDomain();
            cd.DomainId = int.Parse(tokens[0]);
            cd.DomainText = tokens[1];
            _costDomains.Add(cd);
        }

        private void MapDrg(string[] tokens) {
            var drg = new Entities.System {
                                              Category = tokens[0],
                                              Partition = int.Parse(tokens[1]),
                                              Code = tokens[2],
                                              Text = tokens[3],
                                              Calculated = int.Parse(tokens[4])
                                          };
            _system.Add(drg);
        }

        private void MapPeppCsv2Entity(string headline, string[] tokens) {
            if (headline == ResourceController.PEPP_RESOURCE_HEADERS[(int) ResourceController.PeppResourceFilesIndex.Nebendiagnose]) {
                MapSecondaryDiagnosis(_secondaryDiagnoses, tokens);
            } else if (headline == ResourceController.PEPP_RESOURCE_HEADERS[(int) ResourceController.PeppResourceFilesIndex.Hauptdiagnose]) {
                MapPrimaryDiagnosis(_primaryDiagnoses, tokens);
            } else if (headline == ResourceController.PEPP_RESOURCE_HEADERS[(int) ResourceController.PeppResourceFilesIndex.Kosten]) {
                MapCost(_costs, tokens);
            } else if (headline ==
                       ResourceController.PEPP_RESOURCE_HEADERS[(int) ResourceController.PeppResourceFilesIndex.Kostenbereich]) {
                MapCostDomain(_costDomains, tokens);
            } else if (headline ==
                       ResourceController.PEPP_RESOURCE_HEADERS[(int) ResourceController.PeppResourceFilesIndex.Pepp]) {
                MapPepp(_system, tokens);
            } else if (headline ==
                       ResourceController.PEPP_RESOURCE_HEADERS[(int) ResourceController.PeppResourceFilesIndex.Prozeduren]) {
                MapProcedure(_procedures, tokens);
            } else if (headline ==
                       ResourceController.PEPP_RESOURCE_HEADERS[
                           (int) ResourceController.PeppResourceFilesIndex.Recherche]) {
                MapRecherche(_recherche, tokens);
            } else if (headline ==
                       ResourceController.PEPP_RESOURCE_HEADERS[
                           (int) ResourceController.PeppResourceFilesIndex.Strukturkategorie]) {
                MapStructureCategory(_structureCategories, tokens);
            } else if (headline ==
                       ResourceController.PEPP_RESOURCE_HEADERS[
                           (int) ResourceController.PeppResourceFilesIndex.Kopfdaten]) {
                MapPeppInfo(_peppInfos, tokens);
            } else if (headline == ResourceController.PEPP_RESOURCE_HEADERS[(int) ResourceController.PeppResourceFilesIndex.Katalog]) {
                MapCatalogs(tokens);
            }
        }

        private void MapCatalogs(string[] tokens) {
            var c = new Catalog {
                                    Pepp = tokens[0],
                                    RemunerationClass = int.Parse(tokens[1]),
                                    RelativeWeight = decimal.Parse(tokens[2])
                                };
            _catalogs.Add(c);
        }

        private static void MapPeppInfo(List<PeppInfo> list, string[] tokens) {
            for (int i = 0; i < tokens.Length; i++) {
                if (tokens[i] == "")
                    tokens[i] = 0 + "";
            }
            var pi = new PeppInfo {
                                      Code = tokens[0],
                                      CaseCount = int.Parse(tokens[1]),
                                      LosSumDays = int.Parse(tokens[2]),
                                      LosAverage = decimal.Parse(tokens[3]),
                                      LosStandard = decimal.Parse(tokens[4]),
                                      LosHc = decimal.Parse(tokens[5]),
                                      GenderMale = decimal.Parse(tokens[6]),
                                      GenderFemale = decimal.Parse(tokens[7]),
                                      AgeAverage = decimal.Parse(tokens[8]),
                                      AgeStandard = decimal.Parse(tokens[9]),
                                      AgeBelow28Days = decimal.Parse(tokens[10]),
                                      AgeBelow1Year = decimal.Parse(tokens[11]),
                                      AgeBelow3Years = decimal.Parse(tokens[12]),
                                      AgeBelow6Years = decimal.Parse(tokens[13]),
                                      AgeBelow10Years = decimal.Parse(tokens[14]),
                                      AgeBelow16Years = decimal.Parse(tokens[15]),
                                      AgeBelow18Years = decimal.Parse(tokens[16]),
                                      AgeBelow30Years = decimal.Parse(tokens[17]),
                                      AgeBelow40Years = decimal.Parse(tokens[18]),
                                      AgeBelow50Years = decimal.Parse(tokens[19]),
                                      AgeBelow55Years = decimal.Parse(tokens[20]),
                                      AgeBelow60Years = decimal.Parse(tokens[21]),
                                      AgeBelow65Years = decimal.Parse(tokens[22]),
                                      AgeBelow75Years = decimal.Parse(tokens[23]),
                                      AgeBelow80Years = decimal.Parse(tokens[24]),
                                      AgeBelow99Years = decimal.Parse(tokens[25]),
                                      DayCostsAverage = decimal.Parse(tokens[26]),
                                      DayCostsStandard = decimal.Parse(tokens[27]),
                                      DayCostsHc = decimal.Parse(tokens[28]),
                                      Degression = int.Parse(tokens[29])
                                  };
            list.Add(pi);
        }

        private static void MapStructureCategory(List<StructureCategory> list, string[] tokens) {
            var sc = new StructureCategory();
            sc.Category = tokens[0];
            sc.Order = int.Parse(tokens[1]);
            sc.Text = tokens[2];
            sc.PeppCount = int.Parse(tokens[3]);
            sc.CaseCount = int.Parse(tokens[4]);
            sc.DayCount = int.Parse(tokens[5]);
            list.Add(sc);
        }

        private static void MapRecherche(List<Recherche> list, string[] tokens) {
            var r = new Recherche {
                                      Code = tokens[0],
                                      Text = tokens[1],
                                      PrimaryDiagnosis = int.Parse(tokens[2]),
                                      SecondaryDiagnosis = int.Parse(tokens[3]),
                                      Procedure = int.Parse(tokens[4])
                                  };
            list.Add(r);
        }

        private static void MapProcedure(List<Procedure> list, string[] tokens) {
            var p = new Procedure {
                                      PeppCode = tokens[0],
                                      ProcCode = tokens[1],
                                      CaseCount = int.Parse(tokens[2]),
                                      CaseFraction = decimal.Parse(tokens[3]),
                                      EntryCount = int.Parse(tokens[4]),
                                      EntryFraction = decimal.Parse(tokens[5])
                                  };
            list.Add(p);
        }

        private static void MapPepp(List<Entities.System> list, string[] tokens) {
            var p = new Entities.System {Category = tokens[0], Code = tokens[1], Text = tokens[2]};
            list.Add(p);
        }

        private static void MapCostDomain(List<CostDomain> list, string[] tokens) {
            var cd = new CostDomain {
                                        DomainId = int.Parse(tokens[0]),
                                        Order = int.Parse(tokens[1]),
                                        DomainText = tokens[2]
                                    };
            list.Add(cd);
        }

        private static void MapCost(List<Cost> list, string[] tokens) {
            var c = new Cost {
                                 PeppCode = tokens[0],
                                 CostDomain = int.Parse(tokens[1]),
                                 CostType1 = decimal.Parse(tokens[2]),
                                 CostType2 = decimal.Parse(tokens[3]),
                                 CostType3a = decimal.Parse(tokens[4]),
                                 CostType3b = decimal.Parse(tokens[5]),
                                 CostType3c = decimal.Parse(tokens[6]),
                                 CostType3 = decimal.Parse(tokens[7]),
                                 CostType4a = decimal.Parse(tokens[8]),
                                 CostType4b = decimal.Parse(tokens[9]),
                                 CostType5 = decimal.Parse(tokens[10]),
                                 CostType6a = decimal.Parse(tokens[11]),
                                 CostType6b = decimal.Parse(tokens[12]),
                                 CostType7 = decimal.Parse(tokens[13]),
                                 CostType8 = decimal.Parse(tokens[14])
                             };
            list.Add(c);
        }

        private static void MapPrimaryDiagnosis(List<PrimaryDiagnosis> list, string[] tokens) {
            var pd = new PrimaryDiagnosis {
                                              SystemCode = tokens[0],
                                              DiagCode = tokens[1],
                                              Count = int.Parse(tokens[2]),
                                              Fraction = decimal.Parse(tokens[3])
                                          };
            list.Add(pd);
        }

        private static void MapSecondaryDiagnosis(List<SecondaryDiagnosis> list, string[] tokens) {
            var diagnosis = new SecondaryDiagnosis {
                                                    PeppCode = tokens[0],
                                                    DiagCode = tokens[1],
                                                    CaseCount = int.Parse(tokens[2]),
                                                    CaseFraction = decimal.Parse(tokens[3]),
                                                    EntryCount = int.Parse(tokens[4]),
                                                    EntryFraction = decimal.Parse(tokens[5])
                                                    };
            list.Add(diagnosis);
        }
    }
}
