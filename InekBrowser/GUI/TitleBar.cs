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

        private Color HoverColor;
        private Color Default;

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
            if (Program.SystemBrowser == Program.System.Drg) {
                HoverColor = BrowserColors.DrgTitleBarIconHover;
                Default = BrowserColors.DrgTitleBar;
            } else if (Program.SystemBrowser == Program.System.Pepp) {
                HoverColor = BrowserColors.PeppTitleBarIconHover;
                Default = BrowserColors.PeppTitleBar;
            }
        }

        private void picMinMax_MouseEnter(object sender, EventArgs e) {
            picMinMax.BackColor = HoverColor;
        }

        private void picMinMax_MouseLeave(object sender, EventArgs e) {
            picMinMax.BackColor = Default;
        }

        private void picExit_MouseEnter(object sender, EventArgs e) {
            picExit.BackColor = HoverColor;
        }

        private void picExit_MouseLeave(object sender, EventArgs e) {
            picExit.BackColor = Default;
        }

        private void picIconify_MouseEnter(object sender, EventArgs e) {
            picIconify.BackColor = HoverColor;
        }

        private void picIconify_MouseLeave(object sender, EventArgs e) {
            picIconify.BackColor = Default;
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
