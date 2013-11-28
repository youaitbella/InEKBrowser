using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace org.inek.PeppBrowser.GUI {
    public partial class Selection : UserControl {
        public event EventHandler DataChanged;

        public Selection() {
            InitializeComponent();
        }

        private void ChangeData() {
                if (DataChanged != null) {
                    DataChanged(this, null);
                }
        }   
    }
}
