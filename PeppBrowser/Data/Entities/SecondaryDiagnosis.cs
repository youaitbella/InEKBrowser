using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.inek.PeppBrowser.Data.Entities {
    public class SecondaryDiagnosis {
        [Column("nd_Pepp")]
        public string PeppCode { get; set; }

        [Column("nd_CodeF")]
        public string DiagCode { get; set; }

        [Column("nd_Code")]
        public string DiagCodeShort { get; set; }

        [Column("nd_AnzahlFaelle")]
        public int CaseCount { get; set; }

        [Column("nd_AnteilFaelle")]
        public int CaseFraction { get; set; }

        [Column("nd_AnzahlNennungen")]
        public int EntryCount { get; set; }

        [Column("nd_AnteilNennungen")]
        public int EntryFraction { get; set; }


    }
}
