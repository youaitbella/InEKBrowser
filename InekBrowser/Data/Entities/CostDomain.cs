using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.InekBrowser.Data.Entities {
    public class CostDomain {
        //kb_Nr;kb_Bereich;kb_BereichOrder
        public int DomainId { get; set; }
        public int Order { get; set; }
        public string DomainText { get; set; }

    }
}
