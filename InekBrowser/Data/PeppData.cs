using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using org.inek.InekBrowser.Data.Entities;
using org.inek.InekBrowser.Data.Entities.PEPP;

namespace org.inek.InekBrowser.Data {
    class PeppData :PeppInfo{
        public PeppData(PeppInfo peppInfo)
        {
            foreach (PropertyInfo info in typeof(PeppInfo).GetProperties())
            {
                PropertyInfo targetInfo = typeof (PeppData).GetProperty(info.Name);
                targetInfo.SetValue(this, info.GetValue(peppInfo, null), null);
            }
        }

        public List<PrimaryDiagnosis> PrimDiag { get; set; }
        public List<SecondaryDiagnosis> SecDiag { get; set; }
        public List<Procedure> Proc { get; set; }
        public List<Cost> Cost { get; set; }

    }


}
