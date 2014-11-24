using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.InekBrowser.Data.Entities {
    public class Recherche {
        public string Code { get; set; }
        public string Text { get; set; }
        public int PrimaryDiagnosis { get; set; }
        public int SecondaryDiagnosis { get; set; }
        public int Procedure { get; set; }

        public string CodeF { get; set; } // DRG only
    }
}
