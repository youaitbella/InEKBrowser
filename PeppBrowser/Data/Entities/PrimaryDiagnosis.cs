using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.PeppBrowser.Data.Entities {
    public class PrimaryDiagnosis {

        [Column("hd_Pepp")]
        public string PeppCode { get; set; }

        [Column("hd_Code")]
        public string DiagCode { get; set; }

        [Column("hd_FaelleAnzahl")]
        public int Count { get; set; }

        [Column("hd_FaelleAnteil")]
        public decimal Fraction { get; set; }
    }
}
