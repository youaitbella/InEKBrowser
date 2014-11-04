using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.inek.InekBrowser.Data.Entities {
    public class CostDomain {
        //kb_Nr;kb_Bereich;kb_BereichOrder

        [Column("kb_Nr")]
        public int DomainId { get; set; }

        [Column("kb_BereichOrder")]
        public int Order { get; set; }

        [Column("kb_Bereich")]
        public string DomainText { get; set; }

    }
}
