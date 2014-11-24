using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.InekBrowser.Data.Entities {
    public class Procedure {
        public string System { get; set; }
        public string ProcCode { get; set; }
        public int CaseCount { get; set; }
        public decimal CaseFraction { get; set; }
        public int EntryCount { get; set; }
        public decimal EntryFraction { get; set; }
        public string CodeF { get; set; } // DRG only

        public string Prozedur { get; set; }

    }
}
