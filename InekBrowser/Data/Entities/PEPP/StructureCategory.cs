using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.InekBrowser.Data.Entities.PEPP {
    public class StructureCategory {
        //;;;st_PeppAnzahl;st_FaelleAnzahl;st_TageAnzahl

        [Column("st_Strukturkategorie")]
        public string Category { get; set; }

        [Column("st_Order")]
        public int Order { get; set; }

        [Column("st_Text")]
        public string Text { get; set; }

        [Column("st_PeppAnzahl")]
        public int PeppCount { get; set; }

        [Column("st_FaelleAnzahl")]
        public int CaseCount { get; set; }

        [Column("st_TageAnzahl")]
        public int DayCount { get; set; }

    }
}
