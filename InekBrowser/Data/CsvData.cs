using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net.Mail;
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
        private readonly List<SystemInfo> _systemInfo = new List<SystemInfo>();
        private readonly List<PrimaryDiagnosis> _primaryDiagnoses = new List<PrimaryDiagnosis>();
        private readonly List<Procedure> _procedures = new List<Procedure>();
        private readonly List<SecondaryDiagnosis> _secondaryDiagnoses = new List<SecondaryDiagnosis>();
        private readonly List<StructureCategory> _structureCategories = new List<StructureCategory>();
        private readonly List<Recherche> _recherche = new List<Recherche>();
        private readonly List<Catalog> _catalogs = new List<Catalog>();
        private readonly List<Mdc> _mdcs = new List<Mdc>();

        public enum DrgType {
            BA,
            HA
        }

        public static DrgType DrgSystemType { get; set; }

        private CsvData() {
        }

        public static CsvData Context() {
            if (_instance == null) {
                _instance = new CsvData();
                DrgSystemType = DrgType.BA;
            }
            return _instance;
        }

        public IEnumerable<Cost> Costs {
            get {
                if (_costs.Count == 0) {
                    if(Program.SystemBrowser == Program.System.Pepp)
                        LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Kosten], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Kosten]);
                    else if (Program.SystemBrowser == Program.System.Drg) {
                        if(DrgSystemType == DrgType.BA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.KostenBa], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.KostenBa]);
                        else if(DrgSystemType == DrgType.HA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.KostenHa], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.KostenHa]);
                    }
                }
                return _costs;
            }
        }

        public IEnumerable<CostDomain> CostDomains {
            get {
                if (_costDomains.Count == 0) {
                    if (Program.SystemBrowser == Program.System.Pepp)
                        LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Kostenbereich], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Kostenbereich]);
                    else if (Program.SystemBrowser == Program.System.Drg)
                        LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.Kostenbereich], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.Kostenbereich]);
                }
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
                if (_system.Count == 0) {
                    if(Program.SystemBrowser == Program.System.Pepp)
                        LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Pepp], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Pepp]);
                    else if (Program.SystemBrowser == Program.System.Drg)
                        LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.Drg], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.Drg]);
                }
                return _system;
            }
        }

        public IEnumerable<SystemInfo> SystemInfo {
            get {
                if (_systemInfo.Count == 0) {
                    if(Program.SystemBrowser == Program.System.Pepp)
                        LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Kopfdaten], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Kopfdaten]);
                    else if (Program.SystemBrowser == Program.System.Drg) {
                        if(DrgSystemType == DrgType.BA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.KopfdatenBa], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.KopfdatenBa]);
                        else if(DrgSystemType == DrgType.HA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.KopfdatenHa], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.KopfdatenHa]);
                    }
                }
                return _systemInfo;
            }
        }

        public IEnumerable<Procedure> Procedures {
            get {
                if (_procedures.Count == 0) {
                    if(Program.SystemBrowser == Program.System.Pepp)
                        LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Prozeduren], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Prozeduren]);
                    else if (Program.SystemBrowser == Program.System.Drg) {
                        if(DrgSystemType == DrgType.BA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.ProzedurenBa], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.ProzedurenBa]);
                        else if(DrgSystemType == DrgType.HA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.ProzedurenHa], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.ProzedurenHa]);
                    }
                }
                return _procedures;
            }
        }

        public IEnumerable<PrimaryDiagnosis> PrimaryDiagnoses {
            get {
                if(_primaryDiagnoses.Count == 0) {
                    if(Program.SystemBrowser == Program.System.Pepp)
                        LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Hauptdiagnose], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Hauptdiagnose]);
                    else if (Program.SystemBrowser == Program.System.Drg) {
                        if(DrgSystemType == DrgType.BA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.HauptdiagnosenBa], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.HauptdiagnosenBa]);
                        else if(DrgSystemType == DrgType.HA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.HauptdiagnosenHa], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.HauptdiagnosenHa]);
                    }
                }
                return _primaryDiagnoses;
            }
        }

        public IEnumerable<SecondaryDiagnosis> SecondaryDiagnoses {
            get {
                if (_secondaryDiagnoses.Count == 0) {
                    if (Program.SystemBrowser == Program.System.Pepp) 
                        LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Nebendiagnose], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Nebendiagnose]);
                    else if(Program.SystemBrowser == Program.System.Drg) {
                        if (DrgSystemType == DrgType.BA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.NebendiagnosenBa], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.NebendiagnosenBa]);
                        else if(DrgSystemType == DrgType.HA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.NebendiagnosenHa], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.NebendiagnosenHa]);
                    }
                }
                return _secondaryDiagnoses;
            }
        }

        public IEnumerable<Recherche> Recherche {
            get {
                if (_recherche.Count == 0) {
                    if(Program.SystemBrowser == Program.System.Pepp)
                        LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Recherche], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Recherche]);
                    else if (Program.SystemBrowser == Program.System.Drg) {
                        if(DrgSystemType == DrgType.BA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.RechercheBa], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.RechercheBa]);
                        else if(DrgSystemType == DrgType.HA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.RechercheHa], ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.RechercheHa]);
                    }
                }
                return _recherche;
            }
        }

        public IEnumerable<Catalog> Catalogs {
            get {
                if(_catalogs.Count == 0)
                    if(Program.SystemBrowser == Program.System.Pepp)
                        LoadData(ResourceController.PEPP_RESOURCE_FILES[(int)ResourceController.PeppResourceFilesIndex.Katalog], ResourceController.PEPP_RESOURCE_HEADERS[(int)ResourceController.PeppResourceFilesIndex.Katalog]);
                return _catalogs;
            }
        }

        public IEnumerable<Mdc> Mdcs {
            get {
                if (_mdcs.Count == 0) {
                    if (Program.SystemBrowser == Program.System.Drg) {
                        if (DrgSystemType == DrgType.BA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.MdcBa],
                                ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.MdcBa]);
                        else if (DrgSystemType == DrgType.HA)
                            LoadData(ResourceController.DRG_RESOURCE_FILES[(int)ResourceController.DrgResourceFilesIndex.MdcHa],
                                ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.MdcHa]);
                    }
                }
                return _mdcs;
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
                    else if (Program.SystemBrowser == Program.System.Drg && filename.StartsWith("RepBrDrg_BA"))
                        MapDrgBaCsv2Entity(headline, tokens);
                    else if (Program.SystemBrowser == Program.System.Drg && filename.StartsWith("RepBrDrg_HA"))
                        MapDrgHaCsv2Entity(headline, tokens);
                }
            }
        }

        private void MapDrgHaCsv2Entity(string headline, string[] tokens) {
            if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.Drg]) {
                MapDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.Kostenbereich]) {
                MapCostDomainDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.HauptdiagnosenHa]) {
                MapPrimaryDiagnosisDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.KopfdatenHa]) {
                MapSystemInfoDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.KostenHa]) {
                MapCostDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.MdcHa]) {
                MapMdc(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.NebendiagnosenHa]) {
                MapSecondaryDiagnosisDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.ProzedurenHa]) {
                MapProcedureDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int)ResourceController.DrgResourceFilesIndex.RechercheHa]) {
                MapRechercheDrg(tokens);
            }
        }

        public void ClearDataCaches() {
            _costDomains.Clear();
            _mdcs.Clear();
            _costs.Clear();
            _primaryDiagnoses.Clear();
            _procedures.Clear();
            _recherche.Clear();
            _secondaryDiagnoses.Clear();
            _system.Clear();
            _systemInfo.Clear();
        }

        private void MapDrgBaCsv2Entity(string headline, string[] tokens) {
            if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int) ResourceController.DrgResourceFilesIndex.Drg]) {
                MapDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int) ResourceController.DrgResourceFilesIndex.Kostenbereich]) {
                MapCostDomainDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int) ResourceController.DrgResourceFilesIndex.HauptdiagnosenBa]) {
                MapPrimaryDiagnosisDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int) ResourceController.DrgResourceFilesIndex.KopfdatenBa]) {
                MapSystemInfoDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int) ResourceController.DrgResourceFilesIndex.KostenBa]) {
                MapCostDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int) ResourceController.DrgResourceFilesIndex.MdcBa]) {
                MapMdc(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int) ResourceController.DrgResourceFilesIndex.NebendiagnosenBa]) {
                MapSecondaryDiagnosisDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int) ResourceController.DrgResourceFilesIndex.ProzedurenBa]) {
                MapProcedureDrg(tokens);
            } else if (headline == ResourceController.DRG_RESOURCE_HEADERS[(int) ResourceController.DrgResourceFilesIndex.RechercheBa]) {
                MapRechercheDrg(tokens);
            }
        }

        private void MapRechercheDrg(string[] tokens) {
            var r = new Recherche {
                                      Code = tokens[0],
                                      Text = tokens[1],
                                      CodeF = tokens[2],
                                      PrimaryDiagnosis = int.Parse(tokens[3]),
                                      SecondaryDiagnosis = int.Parse(tokens[4]),
                                      Procedure = int.Parse(tokens[5])
                                  };
            _recherche.Add(r);
        }

        private void MapProcedureDrg(string[] tokens) {
            var p = new Procedure {
                                      System = tokens[0],
                                      ProcCode = tokens[1],
                                      CaseFraction = decimal.Parse(tokens[2]),
                                      CodeF = tokens[3],
                                      CaseCount = int.Parse(tokens[4]),
                                      EntryFraction = decimal.Parse(tokens[5]),
                                      EntryCount = int.Parse(tokens[6])
                                  };
            _procedures.Add(p);
        }

        private void MapSecondaryDiagnosisDrg(string[] tokens) {
            var sd = new SecondaryDiagnosis {
                                                System = tokens[0],
                                                DiagCode = tokens[1],
                                                CaseFraction = decimal.Parse(tokens[2]),
                                                CodeF = tokens[3],
                                                CaseCount = int.Parse(tokens[3]),
                                                EntryFraction = decimal.Parse(tokens[4]),
                                                EntryCount = int.Parse(tokens[5])
                                            };
            _secondaryDiagnoses.Add(sd);
        }

        private void MapMdc(string[] tokens) {
            var mdc = new Mdc {
                                  MDC = tokens[0],
                                  Text = tokens[1],
                                  DrgCount = int.Parse(tokens[2]),
                                  CaseCount = int.Parse(tokens[3])
                              };
            _mdcs.Add(mdc);
        }

        private void MapCostDrg(string[] tokens) {
            var c = new Cost {
                                 Code = tokens[0],
                                 CostDomain = int.Parse(tokens[1]),
                                 CostType1 = decimal.Parse(tokens[2]),
                                 CostType2 = decimal.Parse(tokens[3]),
                                 CostType3 = decimal.Parse(tokens[4]),
                                 CostType4a = decimal.Parse(tokens[5]),
                                 CostType4b = decimal.Parse(tokens[6]),
                                 CostType5 = decimal.Parse(tokens[7]),
                                 CostType6a = decimal.Parse(tokens[8]),
                                 CostType6b = decimal.Parse(tokens[9]),
                                 CostType7 = decimal.Parse(tokens[10]),
                                 CostType8 = decimal.Parse(tokens[11]),
                                 CostSum = decimal.Parse(tokens[12])
                             };
            _costs.Add(c);
        }

        private void MapSystemInfoDrg(string[] tokens) {
            var si = new SystemInfo {
                                        MDC = tokens[0],
                                        Code = tokens[1],
                                        CaseCount = int.Parse(tokens[2]),
                                        PCCL0 = decimal.Parse(tokens[3]),
                                        PCCL1 = decimal.Parse(tokens[4]),
                                        PCCL2 = decimal.Parse(tokens[5]),
                                        PCCL3 = decimal.Parse(tokens[6]),
                                        GenderMale = decimal.Parse(tokens[7]),
                                        GenderFemale = decimal.Parse(tokens[8]),
                                        GenderUnknown = decimal.Parse(tokens[9]),
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
                                        LosShort = decimal.Parse(tokens[26]),
                                        LosNormal = decimal.Parse(tokens[27]),
                                        LosLong = decimal.Parse(tokens[28]),
                                        Day1Reduction = int.Parse(tokens[29]),
                                        Day1Remuneration = int.Parse(tokens[30]),
                                        LosAverage = decimal.Parse(tokens[31]),
                                        ValuationRatio = decimal.Parse(tokens[32]),
                                        FractionAllCases = decimal.Parse(tokens[33]),
                                        LosStandard = decimal.Parse(tokens[34]),
                                        CostAverage = decimal.Parse(tokens[35]),
                                        CostStandard = decimal.Parse(tokens[36])
                                    };
            _systemInfo.Add(si);
        }

        private void MapPrimaryDiagnosisDrg(string[] tokens) {
            var pd = new PrimaryDiagnosis {
                                              SystemCode = tokens[0],
                                              DiagCode = tokens[1],
                                              Fraction = decimal.Parse(tokens[2]),
                                              DiagCodeF = tokens[3],
                                              Count = int.Parse(tokens[4])
                                          };
            _primaryDiagnoses.Add(pd);
        }

        private void MapCostDomainDrg(string[] tokens) {
            var cd = new CostDomain {DomainId = int.Parse(tokens[0]), DomainText = tokens[1]};
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
                MapPeppInfo(_systemInfo, tokens);
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

        private static void MapPeppInfo(List<SystemInfo> list, string[] tokens) {
            for (int i = 0; i < tokens.Length; i++) {
                if (tokens[i] == "")
                    tokens[i] = 0 + "";
            }
            var pi = new SystemInfo {
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
                                      System = tokens[0],
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
                                 Code = tokens[0],
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
                                                    System = tokens[0],
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
