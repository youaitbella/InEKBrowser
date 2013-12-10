using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.PeppBrowser.Data.Entities {
    public class Procedure {
        [Column("pr_Pepp")]
        public string PeppCode { get; set; }

        [Column("pr_Code")]
        public string ProcCode { get; set; }

        [Column("pr_FaelleAnzahl")]
        public int CaseCount { get; set; }

        [Column("pr_FaelleAnteil")]
        public decimal CaseFraction { get; set; }

        [Column("pr_NennungenAnzahl")]
        public int EntryCount { get; set; }

        [Column("pr_NennungenAnteil")]
        public decimal EntryFraction { get; set; }

    }
}
