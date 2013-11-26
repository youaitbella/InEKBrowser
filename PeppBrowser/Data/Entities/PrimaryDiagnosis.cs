using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.PeppBrowser.Data.Entities {
    public class PrimaryDiagnosis {

        [Column("hd_Pepp")]
        public string PeppCode { get; set; }

        [Column("hd_Code")]
        public string DiagCode { get; set; }

        [Column("hd_Anzahl")]
        public int Count { get; set; }

        [Column("hd_Anteil")]
        public decimal Fraction { get; set; }
    }
}
