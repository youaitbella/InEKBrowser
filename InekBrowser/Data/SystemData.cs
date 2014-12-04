using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using org.inek.InekBrowser.Data.Entities;

namespace org.inek.InekBrowser.Data {
    class SystemData :SystemInfo{
        public SystemData(SystemInfo systemInfo)
        {
            foreach (PropertyInfo info in typeof(SystemInfo).GetProperties())
            {
                PropertyInfo targetInfo = typeof (SystemData).GetProperty(info.Name);
                targetInfo.SetValue(this, info.GetValue(systemInfo, null), null);
            }
        }

        public List<PrimaryDiagnosis> PrimDiag { get; set; }
        public List<SecondaryDiagnosis> SecDiag { get; set; }
        public List<Procedure> Proc { get; set; }
        public List<Cost> Cost { get; set; }
        public int casesDrgMDC { get; set; }
        public int casesMDC { get; set; }
        public string fromMDC { get; set; }

    }


}
