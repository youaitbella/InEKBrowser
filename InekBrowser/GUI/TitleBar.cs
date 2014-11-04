using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace org.inek.InekBrowser.GUI {
    public partial class TitleBar : UserControl {

        public event EventHandler ClickedExit;
        public event EventHandler ClickedMinMax;
        public event EventHandler ClickedIconify;
        public event MouseEventHandler MouseMoveTitleBar;

        public bool ShowIconify {
            get { return picIconify.Visible; }
            set { picIconify.Visible = value; }
        }

        public bool ShowMinMax {
            get { return picMinMax.Visible; }
            set { picMinMax.Visible = value; }
        }

        public Image MinMaxImage {
            get { return picMinMax.BackgroundImage; }
            set { picMinMax.BackgroundImage = value; }
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

        private void picExit_Click(object sender, EventArgs e) {
            if (ClickedExit != null) {
                ClickedExit(picExit, e);
            }
        }

        private bool normalWindow = false;
        private void picMinMax_Click(object sender, EventArgs e) {
            if (ClickedMinMax != null) {
                normalWindow = !normalWindow;
                ClickedMinMax(picMinMax, e);
            }
        }

        private void picIconify_Click(object sender, EventArgs e) {
            if (ClickedIconify != null) {
                ClickedIconify(picIconify, e);
            }
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e) {
            if (MouseMoveTitleBar != null) {
                MouseMoveTitleBar(lblTitle, e);
            }
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e) {
            if (MouseMoveTitleBar != null) {
                MouseMoveTitleBar(pnlTitle, e);
            }
        }

        private void pnlFormStates_MouseMove(object sender, MouseEventArgs e) {
            if (MouseMoveTitleBar != null) {
                MouseMoveTitleBar(pnlFormStates, e);
            }
        }

        public string Title { set { lblTitle.Text = value; } }
    }
}
