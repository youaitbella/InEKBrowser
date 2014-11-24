using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.InekBrowser.Data.Entities {
    public class SecondaryDiagnosis {
        public string System { get; set; }
        public string DiagCode { get; set; }
        public int CaseCount { get; set; }
        public decimal CaseFraction { get; set; }
        public int EntryCount { get; set; }
        public decimal EntryFraction { get; set; }
        public string CodeF { get; set; } // DRG only

        public string Nebendiagnose { get; set; }


    }
}
