using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.InekBrowser.Data.Entities {
    public class Cost {
        public string Code { get; set; }
        public int CostDomain { get; set; }
        public decimal CostType1 { get; set; }
        public decimal CostType2 { get; set; }
        public decimal CostType3a { get; set; } // PEPP only
        public decimal CostType3b { get; set; } // PEPP only
        public decimal CostType3c { get; set; } // PEPP only
        public decimal CostType3 { get; set; }
        public decimal CostType4a { get; set; }
        public decimal CostType4b { get; set; }
        public decimal CostType5 { get; set; }
        public decimal CostType6a { get; set; }
        public decimal CostType6b { get; set; }
        public decimal CostType6c { get; set; }
        public decimal CostType7 { get; set; }
        public decimal CostType8 { get; set; }
        public decimal CostSum { get; set; } // DRG only

        public string TxtBez { get; set; }
    }
}
