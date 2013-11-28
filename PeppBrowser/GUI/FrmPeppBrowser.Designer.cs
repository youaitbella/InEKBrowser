namespace org.inek.PeppBrowser.GUI {
    partial class FrmPeppBrowser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStructureCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPepp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPeppInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrimaryDiagnoses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSecondaryDiagnoses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcedures = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCosts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCostDomains = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManual = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContentBackground = new System.Windows.Forms.Panel();
            this.resizerE = new System.Windows.Forms.PictureBox();
            this.resizerW = new System.Windows.Forms.PictureBox();
            this.resizerSW = new System.Windows.Forms.PictureBox();
            this.resizerS = new System.Windows.Forms.PictureBox();
            this.resizerSE = new System.Windows.Forms.PictureBox();
            this.resizerNW = new System.Windows.Forms.PictureBox();
            this.resizerNE = new System.Windows.Forms.PictureBox();
            this.selection = new org.inek.PeppBrowser.GUI.Selection();
            this.data1 = new org.inek.PeppBrowser.GUI.Data();
            this.titleBar = new org.inek.PeppBrowser.GUI.TitleBar();
            this.mnuMain.SuspendLayout();
            this.pnlContentBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizerE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizerW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizerSW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizerS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizerSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizerNW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizerNE)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mnuMain.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuData,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1});
            this.mnuMain.Location = new System.Drawing.Point(3, 0);
            this.mnuMain.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMain.Size = new System.Drawing.Size(182, 24);
            this.mnuMain.TabIndex = 6;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.LightGreen;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 20);
            this.mnuFile.Text = "Datei";
            // 
            // mnuData
            // 
            this.mnuData.BackColor = System.Drawing.Color.LightGreen;
            this.mnuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStructureCategories,
            this.mnuPepp,
            this.mnuPeppInfo,
            this.mnuPrimaryDiagnoses,
            this.mnuSecondaryDiagnoses,
            this.mnuProcedures,
            this.mnuCosts,
            this.mnuCostDomains});
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(50, 20);
            this.mnuData.Text = "Daten";
            // 
            // mnuStructureCategories
            // 
            this.mnuStructureCategories.BackColor = System.Drawing.Color.LightGreen;
            this.mnuStructureCategories.Name = "mnuStructureCategories";
            this.mnuStructureCategories.Size = new System.Drawing.Size(172, 22);
            this.mnuStructureCategories.Text = "Strukturkategorien";
            // 
            // mnuPepp
            // 
            this.mnuPepp.BackColor = System.Drawing.Color.LightGreen;
            this.mnuPepp.Name = "mnuPepp";
            this.mnuPepp.Size = new System.Drawing.Size(172, 22);
            this.mnuPepp.Text = "PEPP";
            // 
            // mnuPeppInfo
            // 
            this.mnuPeppInfo.BackColor = System.Drawing.Color.LightGreen;
            this.mnuPeppInfo.Name = "mnuPeppInfo";
            this.mnuPeppInfo.Size = new System.Drawing.Size(172, 22);
            this.mnuPeppInfo.Text = "Kopfdaten";
            // 
            // mnuPrimaryDiagnoses
            // 
            this.mnuPrimaryDiagnoses.BackColor = System.Drawing.Color.LightGreen;
            this.mnuPrimaryDiagnoses.Name = "mnuPrimaryDiagnoses";
            this.mnuPrimaryDiagnoses.Size = new System.Drawing.Size(172, 22);
            this.mnuPrimaryDiagnoses.Text = "Hauptdiagnosen";
            // 
            // mnuSecondaryDiagnoses
            // 
            this.mnuSecondaryDiagnoses.BackColor = System.Drawing.Color.LightGreen;
            this.mnuSecondaryDiagnoses.Name = "mnuSecondaryDiagnoses";
            this.mnuSecondaryDiagnoses.Size = new System.Drawing.Size(172, 22);
            this.mnuSecondaryDiagnoses.Text = "Nebendiagnosen";
            // 
            // mnuProcedures
            // 
            this.mnuProcedures.BackColor = System.Drawing.Color.LightGreen;
            this.mnuProcedures.Name = "mnuProcedures";
            this.mnuProcedures.Size = new System.Drawing.Size(172, 22);
            this.mnuProcedures.Text = "Prozeduren";
            // 
            // mnuCosts
            // 
            this.mnuCosts.BackColor = System.Drawing.Color.LightGreen;
            this.mnuCosts.Name = "mnuCosts";
            this.mnuCosts.Size = new System.Drawing.Size(172, 22);
            this.mnuCosts.Text = "Kosten";
            // 
            // mnuCostDomains
            // 
            this.mnuCostDomains.BackColor = System.Drawing.Color.LightGreen;
            this.mnuCostDomains.Name = "mnuCostDomains";
            this.mnuCostDomains.Size = new System.Drawing.Size(172, 22);
            this.mnuCostDomains.Text = "Kostenbereiche";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.LightGreen;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem3.Text = "Report";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.LightGreen;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManual,
            this.mnuInfo});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // mnuManual
            // 
            this.mnuManual.Name = "mnuManual";
            this.mnuManual.Size = new System.Drawing.Size(130, 22);
            this.mnuManual.Text = "Handbuch";
            // 
            // mnuInfo
            // 
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(130, 22);
            this.mnuInfo.Text = "Info";
            // 
            // pnlContentBackground
            // 
            this.pnlContentBackground.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlContentBackground.Controls.Add(this.selection);
            this.pnlContentBackground.Controls.Add(this.data1);
            this.pnlContentBackground.Controls.Add(this.resizerE);
            this.pnlContentBackground.Controls.Add(this.resizerSW);
            this.pnlContentBackground.Controls.Add(this.resizerS);
            this.pnlContentBackground.Controls.Add(this.resizerSE);
            this.pnlContentBackground.Controls.Add(this.mnuMain);
            this.pnlContentBackground.Controls.Add(this.resizerW);
            this.pnlContentBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentBackground.Location = new System.Drawing.Point(0, 30);
            this.pnlContentBackground.Name = "pnlContentBackground";
            this.pnlContentBackground.Size = new System.Drawing.Size(1017, 636);
            this.pnlContentBackground.TabIndex = 8;
            this.pnlContentBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            // 
            // resizerE
            // 
            this.resizerE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resizerE.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.resizerE.Location = new System.Drawing.Point(1007, -18);
            this.resizerE.Name = "resizerE";
            this.resizerE.Size = new System.Drawing.Size(11, 644);
            this.resizerE.TabIndex = 12;
            this.resizerE.TabStop = false;
            // 
            // resizerW
            // 
            this.resizerW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.resizerW.BackColor = System.Drawing.Color.Transparent;
            this.resizerW.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.resizerW.Location = new System.Drawing.Point(0, -18);
            this.resizerW.Name = "resizerW";
            this.resizerW.Size = new System.Drawing.Size(10, 644);
            this.resizerW.TabIndex = 11;
            this.resizerW.TabStop = false;
            // 
            // resizerSW
            // 
            this.resizerSW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resizerSW.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.resizerSW.Location = new System.Drawing.Point(0, 626);
            this.resizerSW.Name = "resizerSW";
            this.resizerSW.Size = new System.Drawing.Size(10, 10);
            this.resizerSW.TabIndex = 10;
            this.resizerSW.TabStop = false;
            // 
            // resizerS
            // 
            this.resizerS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resizerS.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.resizerS.Location = new System.Drawing.Point(9, 626);
            this.resizerS.Name = "resizerS";
            this.resizerS.Size = new System.Drawing.Size(998, 10);
            this.resizerS.TabIndex = 9;
            this.resizerS.TabStop = false;
            // 
            // resizerSE
            // 
            this.resizerSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizerSE.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.resizerSE.Location = new System.Drawing.Point(1007, 626);
            this.resizerSE.Name = "resizerSE";
            this.resizerSE.Size = new System.Drawing.Size(10, 10);
            this.resizerSE.TabIndex = 8;
            this.resizerSE.TabStop = false;
            // 
            // resizerNW
            // 
            this.resizerNW.BackColor = System.Drawing.Color.SeaGreen;
            this.resizerNW.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.resizerNW.Location = new System.Drawing.Point(0, 0);
            this.resizerNW.Name = "resizerNW";
            this.resizerNW.Size = new System.Drawing.Size(10, 10);
            this.resizerNW.TabIndex = 12;
            this.resizerNW.TabStop = false;
            // 
            // resizerNE
            // 
            this.resizerNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resizerNE.BackColor = System.Drawing.Color.SeaGreen;
            this.resizerNE.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.resizerNE.Location = new System.Drawing.Point(1007, 0);
            this.resizerNE.Name = "resizerNE";
            this.resizerNE.Size = new System.Drawing.Size(10, 10);
            this.resizerNE.TabIndex = 13;
            this.resizerNE.TabStop = false;
            // 
            // selection
            // 
            this.selection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selection.BackColor = System.Drawing.Color.SeaGreen;
            this.selection.Location = new System.Drawing.Point(3, 27);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(1011, 87);
            this.selection.TabIndex = 7;
            // 
            // data1
            // 
            this.data1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data1.BackColor = System.Drawing.Color.SeaGreen;
            this.data1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.data1.Location = new System.Drawing.Point(3, 120);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(1011, 225);
            this.data1.TabIndex = 1;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Ivory;
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1017, 30);
            this.titleBar.TabIndex = 5;
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            // 
            // FrmPeppBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1017, 666);
            this.Controls.Add(this.resizerNW);
            this.Controls.Add(this.resizerNE);
            this.Controls.Add(this.pnlContentBackground);
            this.Controls.Add(this.titleBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FrmPeppBrowser";
            this.Text = "PEPP-Browser";
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlContentBackground.ResumeLayout(false);
            this.pnlContentBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizerE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizerW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizerSW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizerS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizerSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizerNW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizerNE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar titleBar;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripMenuItem mnuStructureCategories;
        private System.Windows.Forms.ToolStripMenuItem mnuPepp;
        private System.Windows.Forms.ToolStripMenuItem mnuPeppInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuPrimaryDiagnoses;
        private System.Windows.Forms.ToolStripMenuItem mnuSecondaryDiagnoses;
        private System.Windows.Forms.ToolStripMenuItem mnuProcedures;
        private System.Windows.Forms.ToolStripMenuItem mnuCosts;
        private System.Windows.Forms.ToolStripMenuItem mnuCostDomains;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuManual;
        private System.Windows.Forms.ToolStripMenuItem mnuInfo;
        private Selection selection;
        private System.Windows.Forms.Panel pnlContentBackground;
        private Data data1;
        private System.Windows.Forms.PictureBox resizerSE;
        private System.Windows.Forms.PictureBox resizerSW;
        private System.Windows.Forms.PictureBox resizerS;
        private System.Windows.Forms.PictureBox resizerW;
        private System.Windows.Forms.PictureBox resizerNW;
        private System.Windows.Forms.PictureBox resizerNE;
        private System.Windows.Forms.PictureBox resizerE;

    }
}

