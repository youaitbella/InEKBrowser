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

        public Label Title {
            get { return lblTitle; }
        }

        public TitleBar() {
            InitializeComponent();
        }

        private void picMinMax_MouseEnter(object sender, EventArgs e) {
            picMinMax.BackColor = Color.MediumSeaGreen;
        }

        private void picMinMax_MouseLeave(object sender, EventArgs e) {
            picMinMax.BackColor = Color.SeaGreen;
        }

        private void picExit_MouseEnter(object sender, EventArgs e) {
            picExit.BackColor = Color.MediumSeaGreen;
        }

        private void picExit_MouseLeave(object sender, EventArgs e) {
            picExit.BackColor = Color.SeaGreen;
        }

        private void picIconify_MouseEnter(object sender, EventArgs e) {
            picIconify.BackColor = Color.MediumSeaGreen;
        }

        private void picIconify_MouseLeave(object sender, EventArgs e) {
            picIconify.BackColor = Color.SeaGreen;
        }
    }
}
