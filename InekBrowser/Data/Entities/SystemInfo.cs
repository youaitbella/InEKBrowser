using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.InekBrowser.Data.Entities {
    public class SystemInfo {
       
        #region DRG
        public string MDC { get; set; } // DRG only
        public decimal PCCL0 { get; set; } // DRG only
        public decimal PCCL1 { get; set; } // DRG only
        public decimal PCCL2 { get; set; } // DRG only
        public decimal PCCL3 { get; set; } // DRG only
        public decimal PCCL4 { get; set; } // DRG only
        public decimal PCCL5 { get; set; } // DRG only
        public decimal PCCL6 { get; set; } // DRG only
        public decimal PCCL7 { get; set; } // DRG only
        public decimal LosShort { get; set; } // DRG only
        public decimal LosNormal { get; set; } // DRG only
        public decimal LosLong { get; set; } // DRG only
        public decimal CostAverage { get; set; } // DRG only
        public decimal CostStandard { get; set; } // DRG only
        public decimal FractionAllCases { get; set; } // DRG only
        public decimal ValuationRatio { get; set; } // DRG only
        public int Day1Reduction { get; set; } // DRG only
        public int Day1Remuneration { get; set; } // DRG only
        public decimal GenderUnknown { get; set; } // DRG only
        #endregion

        #region PEPP
        public int LosSumDays { get; set; } // PEPP only
        public decimal LosHc { get; set; }  // hc = homogeneity coefficient; PEPP only
        public decimal AgeAverage { get; set; } // PEPP only
        public decimal AgeStandard { get; set; } // PEPP only
        public decimal DayCostsAverage { get; set; } // PEPP only
        public decimal DayCostsStandard { get; set; } // PEPP only
        public decimal DayCostsHc { get; set; } // hc = homogeneity coefficient; PEPP only
        public int Degression { get; set; } // PEPP only
        #endregion

        public string Code { get; set; }
        public int CaseCount { get; set; }
        public decimal LosAverage{ get; set; }
        public decimal LosStandard { get; set; }
        public decimal GenderMale { get; set; }
        public decimal GenderFemale { get; set; }
        public decimal AgeBelow28Days { get; set; }
        public decimal AgeBelow1Year { get; set; }
        public decimal AgeBelow3Years { get; set; }
        public decimal AgeBelow6Years { get; set; }
        public decimal AgeBelow10Years { get; set; }
        public decimal AgeBelow16Years { get; set; }
        public decimal AgeBelow18Years { get; set; }
        public decimal AgeBelow30Years { get; set; }
        public decimal AgeBelow40Years { get; set; }
        public decimal AgeBelow50Years { get; set; }
        public decimal AgeBelow55Years { get; set; }
        public decimal AgeBelow60Years { get; set; }
        public decimal AgeBelow65Years { get; set; }
        public decimal AgeBelow75Years { get; set; }
        public decimal AgeBelow80Years { get; set; }
        public decimal AgeBelow99Years { get; set; }

        #region Print
        public string StruCat { get; set; }
        public string PeppTxt { get; set; }
        public string DrgTxt { get; set; }
        public string MdcCat { get; set; }
        public string Devision { get; set; }
        #endregion
    }
}
