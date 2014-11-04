using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.InekBrowser.Data.Entities {
    public class PrimaryDiagnosis {

        [Column("hd_Pepp")]
        public string PeppCode { get; set; }

        [Column("hd_Code")]
        public string DiagCode { get; set; }

        [Column("hd_FaelleAnzahl")]
        public int Count { get; set; }

        [Column("hd_FaelleAnteil")]
        public decimal Fraction { get; set; }

        public string Hauptdiagnose { get; set; }
    }
}
