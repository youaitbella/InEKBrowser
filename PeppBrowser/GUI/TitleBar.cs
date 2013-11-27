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
    public partial class TitleBar : UserControl {
        
        public Panel TitleBarPanel {
            get { return pnlTitle; }
        }

        public Panel FormStatePanel {
            get { return pnlFormStates; }
        }

        public TitleBar() {
            InitializeComponent();
        }
    }
}
