using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.InekBrowser.Data.Entities {
    public class Recherche {
        [Column("re_Code")]
        public string Code { get; set; }

        [Column("re_Text")]
        public string Text { get; set; }

        [Column("re_Hauptdiagnose")]
        public int PrimaryDiagnosis { get; set; }

        [Column("re_Nebendiagnose")]
        public int SecondaryDiagnosis { get; set; }

        [Column("re_Prozedur")]
        public int Procedure { get; set; } 
    }
}
