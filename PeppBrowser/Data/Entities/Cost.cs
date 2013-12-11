using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.PeppBrowser.Data.Entities {
    public class Cost {
        [Column("ko_Pepp")]
        public string PeppCode { get; set; }

        [Column("ko_BereichNr")]
        public int CostDomain { get; set; }

        [Column("ko_KArt1")]
        public decimal CostType1 { get; set; }

        [Column("ko_KArt2")]
        public decimal CostType2 { get; set; }

        [Column("ko_KArt3a")]
        public decimal CostType3a { get; set; }

        [Column("ko_KArt3b")]
        public decimal CostType3b { get; set; }

        [Column("ko_KArt3c")]
        public decimal CostType3c { get; set; }

        [Column("ko_KArt3")]
        public decimal CostType3 { get; set; }

        [Column("ko_KArt4a")]
        public decimal CostType4a { get; set; }

        [Column("ko_KArt4b")]
        public decimal CostType4b { get; set; }

        [Column("ko_KArt5")]
        public decimal CostType5 { get; set; }

        [Column("ko_KArt6a")]
        public decimal CostType6a { get; set; }

        [Column("ko_KArt6b")]
        public decimal CostType6b { get; set; }

        [Column("ko_KArt7")]
        public decimal CostType7 { get; set; }

        [Column("ko_KArt8")]
        public decimal CostType8 { get; set; }
    }
}
