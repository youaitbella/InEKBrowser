using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.PeppBrowser.Data.Entities {
    public class PrimaryDiagnosis {

        [Column("hd_Pepp")]
        public string PeppCode { get; set; }

        [Column("hd_CodeF")]
        public string DiagCode { get; set; }

        [Column("hd_Code")]
        public string DiagCodeShort { get; set; }

        [Column("hd_Anzahl")]
        public int Count { get; set; }

        [Column("kd_Anteil")]
        public int Fraction { get; set; }
    }
}
