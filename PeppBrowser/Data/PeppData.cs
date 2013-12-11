using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using org.inek.PeppBrowser.Data.Entities;

namespace org.inek.PeppBrowser.Data {
    class PeppData :PeppInfo{
        public PeppData(PeppInfo peppInfo)
        {
            foreach (PropertyInfo info in typeof(PeppInfo).GetProperties())
            {
                PropertyInfo targetInfo = typeof (PeppData).GetProperty(info.Name);
                targetInfo.SetValue(this, info.GetValue(peppInfo));
            }
        }

        public List<PrimaryDiagnosis> PDX { get; set; }
        public List<SecondaryDiagnosis> DDX { get; set; }
        public List<Procedure> Proc { get; set; }
        public StructureCategory StructCat { get; set; }
    }


}
