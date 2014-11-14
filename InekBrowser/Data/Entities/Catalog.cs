
using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.InekBrowser.Data.Entities {
    public class Catalog {
        [Column("ka_Pepp")]
        public string Pepp { get; set; }

        [Column("ka_Verguetungsklasse")]
        public int RemunerationClass { get; set; }

        [Column("ka_Relgew")]
        public decimal RelativeWeight { get; set; }
    }
}
