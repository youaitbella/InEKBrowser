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
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContentBackground = new System.Windows.Forms.Panel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMainDiagnosis = new System.Windows.Forms.TabPage();
            this.tabSecondaryDiagnosis = new System.Windows.Forms.TabPage();
            this.tabProcedures = new System.Windows.Forms.TabPage();
            this.tabDailyCosts = new System.Windows.Forms.TabPage();
            this.selection = new org.inek.PeppBrowser.GUI.Selection();
            this.data = new org.inek.PeppBrowser.GUI.Data();
            this.titleBar = new org.inek.PeppBrowser.GUI.TitleBar();
            this.gridMainDiagnosis = new System.Windows.Forms.DataGridView();
            this.gridSecondaryDiagnosis = new System.Windows.Forms.DataGridView();
            this.gridProcedures = new System.Windows.Forms.DataGridView();
            this.mnuMain.SuspendLayout();
            this.pnlContentBackground.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMainDiagnosis.SuspendLayout();
            this.tabSecondaryDiagnosis.SuspendLayout();
            this.tabProcedures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMainDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSecondaryDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcedures)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuData,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMain.Size = new System.Drawing.Size(1182, 24);
            this.mnuMain.TabIndex = 6;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 20);
            this.mnuFile.Text = "Datei";
            // 
            // mnuData
            // 
            this.mnuData.BackColor = System.Drawing.Color.MediumSeaGreen;
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
            this.mnuStructureCategories.Click += new System.EventHandler(this.mnuStructureCategories_Click);
            // 
            // mnuPepp
            // 
            this.mnuPepp.BackColor = System.Drawing.Color.LightGreen;
            this.mnuPepp.Name = "mnuPepp";
            this.mnuPepp.Size = new System.Drawing.Size(172, 22);
            this.mnuPepp.Text = "PEPP";
            this.mnuPepp.Click += new System.EventHandler(this.mnuPepp_Click);
            // 
            // mnuPeppInfo
            // 
            this.mnuPeppInfo.BackColor = System.Drawing.Color.LightGreen;
            this.mnuPeppInfo.Name = "mnuPeppInfo";
            this.mnuPeppInfo.Size = new System.Drawing.Size(172, 22);
            this.mnuPeppInfo.Text = "Kopfdaten";
            this.mnuPeppInfo.Click += new System.EventHandler(this.mnuPeppInfo_Click);
            // 
            // mnuPrimaryDiagnoses
            // 
            this.mnuPrimaryDiagnoses.BackColor = System.Drawing.Color.LightGreen;
            this.mnuPrimaryDiagnoses.Name = "mnuPrimaryDiagnoses";
            this.mnuPrimaryDiagnoses.Size = new System.Drawing.Size(172, 22);
            this.mnuPrimaryDiagnoses.Text = "Hauptdiagnosen";
            this.mnuPrimaryDiagnoses.Click += new System.EventHandler(this.mnuPrimaryDiagnoses_Click);
            // 
            // mnuSecondaryDiagnoses
            // 
            this.mnuSecondaryDiagnoses.BackColor = System.Drawing.Color.LightGreen;
            this.mnuSecondaryDiagnoses.Name = "mnuSecondaryDiagnoses";
            this.mnuSecondaryDiagnoses.Size = new System.Drawing.Size(172, 22);
            this.mnuSecondaryDiagnoses.Text = "Nebendiagnosen";
            this.mnuSecondaryDiagnoses.Click += new System.EventHandler(this.mnuSecondaryDiagnoses_Click);
            // 
            // mnuProcedures
            // 
            this.mnuProcedures.BackColor = System.Drawing.Color.LightGreen;
            this.mnuProcedures.Name = "mnuProcedures";
            this.mnuProcedures.Size = new System.Drawing.Size(172, 22);
            this.mnuProcedures.Text = "Prozeduren";
            this.mnuProcedures.Click += new System.EventHandler(this.mnuProcedures_Click);
            // 
            // mnuCosts
            // 
            this.mnuCosts.BackColor = System.Drawing.Color.LightGreen;
            this.mnuCosts.Name = "mnuCosts";
            this.mnuCosts.Size = new System.Drawing.Size(172, 22);
            this.mnuCosts.Text = "Kosten";
            this.mnuCosts.Click += new System.EventHandler(this.mnuCosts_Click);
            // 
            // mnuCostDomains
            // 
            this.mnuCostDomains.BackColor = System.Drawing.Color.LightGreen;
            this.mnuCostDomains.Name = "mnuCostDomains";
            this.mnuCostDomains.Size = new System.Drawing.Size(172, 22);
            this.mnuCostDomains.Text = "Kostenbereiche";
            this.mnuCostDomains.Click += new System.EventHandler(this.mnuCostDomains_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem3.Text = "Report";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManual,
            this.mnuHelp,
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
            this.mnuManual.Click += new System.EventHandler(this.mnuManual_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(130, 22);
            this.mnuHelp.Text = "Hilfe";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // mnuInfo
            // 
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(130, 22);
            this.mnuInfo.Text = "Info";
            // 
            // pnlContentBackground
            // 
            this.pnlContentBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContentBackground.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlContentBackground.Controls.Add(this.tabControl);
            this.pnlContentBackground.Controls.Add(this.mnuMain);
            this.pnlContentBackground.Controls.Add(this.selection);
            this.pnlContentBackground.Controls.Add(this.data);
            this.pnlContentBackground.Location = new System.Drawing.Point(3, 30);
            this.pnlContentBackground.Name = "pnlContentBackground";
            this.pnlContentBackground.Size = new System.Drawing.Size(1182, 711);
            this.pnlContentBackground.TabIndex = 8;
            this.pnlContentBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "PeppBrowser.chm";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabMainDiagnosis);
            this.tabControl.Controls.Add(this.tabSecondaryDiagnosis);
            this.tabControl.Controls.Add(this.tabProcedures);
            this.tabControl.Controls.Add(this.tabDailyCosts);
            this.tabControl.Location = new System.Drawing.Point(3, 378);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1176, 330);
            this.tabControl.TabIndex = 8;
            // 
            // tabMainDiagnosis
            // 
            this.tabMainDiagnosis.Controls.Add(this.gridMainDiagnosis);
            this.tabMainDiagnosis.Location = new System.Drawing.Point(4, 22);
            this.tabMainDiagnosis.Name = "tabMainDiagnosis";
            this.tabMainDiagnosis.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainDiagnosis.Size = new System.Drawing.Size(1168, 304);
            this.tabMainDiagnosis.TabIndex = 0;
            this.tabMainDiagnosis.Text = "Hauptdiagnosen";
            this.tabMainDiagnosis.UseVisualStyleBackColor = true;
            // 
            // tabSecondaryDiagnosis
            // 
            this.tabSecondaryDiagnosis.Controls.Add(this.gridSecondaryDiagnosis);
            this.tabSecondaryDiagnosis.Location = new System.Drawing.Point(4, 22);
            this.tabSecondaryDiagnosis.Name = "tabSecondaryDiagnosis";
            this.tabSecondaryDiagnosis.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecondaryDiagnosis.Size = new System.Drawing.Size(1168, 304);
            this.tabSecondaryDiagnosis.TabIndex = 1;
            this.tabSecondaryDiagnosis.Text = "Nebendiagnosen";
            this.tabSecondaryDiagnosis.UseVisualStyleBackColor = true;
            // 
            // tabProcedures
            // 
            this.tabProcedures.Controls.Add(this.gridProcedures);
            this.tabProcedures.Location = new System.Drawing.Point(4, 22);
            this.tabProcedures.Name = "tabProcedures";
            this.tabProcedures.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcedures.Size = new System.Drawing.Size(1168, 304);
            this.tabProcedures.TabIndex = 2;
            this.tabProcedures.Text = "Prozeduren";
            this.tabProcedures.UseVisualStyleBackColor = true;
            // 
            // tabDailyCosts
            // 
            this.tabDailyCosts.BackColor = System.Drawing.Color.Transparent;
            this.tabDailyCosts.Location = new System.Drawing.Point(4, 22);
            this.tabDailyCosts.Name = "tabDailyCosts";
            this.tabDailyCosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabDailyCosts.Size = new System.Drawing.Size(1168, 304);
            this.tabDailyCosts.TabIndex = 3;
            this.tabDailyCosts.Text = "Tageskosten";
            // 
            // selection
            // 
            this.selection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selection.BackColor = System.Drawing.Color.SeaGreen;
            this.selection.Location = new System.Drawing.Point(0, 27);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(1182, 87);
            this.selection.TabIndex = 7;
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.BackColor = System.Drawing.Color.SeaGreen;
            this.data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.data.Location = new System.Drawing.Point(0, 120);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(1182, 252);
            this.data.TabIndex = 1;
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.BackColor = System.Drawing.Color.LightYellow;
            this.titleBar.Location = new System.Drawing.Point(3, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1182, 30);
            this.titleBar.TabIndex = 5;
            this.titleBar.ClickedExit += new System.EventHandler(this.titleBar_ClickedExit);
            this.titleBar.ClickedMinMax += new System.EventHandler(this.titleBar_ClickedMinMax);
            this.titleBar.ClickedIconify += new System.EventHandler(this.titleBar_ClickedIconify);
            this.titleBar.MouseMoveTitleBar += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            // 
            // gridMainDiagnosis
            // 
            this.gridMainDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMainDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMainDiagnosis.Location = new System.Drawing.Point(3, 3);
            this.gridMainDiagnosis.Name = "gridMainDiagnosis";
            this.gridMainDiagnosis.Size = new System.Drawing.Size(1162, 298);
            this.gridMainDiagnosis.TabIndex = 0;
            // 
            // gridSecondaryDiagnosis
            // 
            this.gridSecondaryDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSecondaryDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSecondaryDiagnosis.Location = new System.Drawing.Point(3, 3);
            this.gridSecondaryDiagnosis.Name = "gridSecondaryDiagnosis";
            this.gridSecondaryDiagnosis.Size = new System.Drawing.Size(1162, 298);
            this.gridSecondaryDiagnosis.TabIndex = 1;
            // 
            // gridProcedures
            // 
            this.gridProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProcedures.Location = new System.Drawing.Point(3, 3);
            this.gridProcedures.Name = "gridProcedures";
            this.gridProcedures.Size = new System.Drawing.Size(1162, 298);
            this.gridProcedures.TabIndex = 2;
            // 
            // FrmPeppBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1188, 744);
            this.Controls.Add(this.pnlContentBackground);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.helpProvider1.SetHelpKeyword(this, "Introduction.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(978, 500);
            this.Name = "FrmPeppBrowser";
            this.helpProvider1.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "PEPP-Browser";
            this.TransparencyKey = System.Drawing.Color.LightYellow;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlContentBackground.ResumeLayout(false);
            this.pnlContentBackground.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMainDiagnosis.ResumeLayout(false);
            this.tabSecondaryDiagnosis.ResumeLayout(false);
            this.tabProcedures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMainDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSecondaryDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcedures)).EndInit();
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
        private Data data;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMainDiagnosis;
        private System.Windows.Forms.TabPage tabSecondaryDiagnosis;
        private System.Windows.Forms.TabPage tabProcedures;
        private System.Windows.Forms.TabPage tabDailyCosts;
        private System.Windows.Forms.DataGridView gridMainDiagnosis;
        private System.Windows.Forms.DataGridView gridSecondaryDiagnosis;
        private System.Windows.Forms.DataGridView gridProcedures;

    }
}

