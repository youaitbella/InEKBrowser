using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.InekBrowser.Data.Entities {
    public class PrimaryDiagnosis {
        
        public string SystemCode { get; set; }
        public string DiagCode { get; set; }
        public string DiagCodeF { get; set; } // DRG only
        public int Count { get; set; }
        public decimal Fraction { get; set; }

        public string Hauptdiagnose { get; set; }
    }
}
