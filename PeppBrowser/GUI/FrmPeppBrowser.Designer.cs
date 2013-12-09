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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManual = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContentBackground = new System.Windows.Forms.Panel();
            this.selection = new org.inek.PeppBrowser.GUI.Selection();
            this.lblPEPP = new System.Windows.Forms.Label();
            this.cbxPepp = new org.inek.controls.CommonControls.ComboField();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMainDiagnosis = new System.Windows.Forms.TabPage();
            this.grdMainDiagnosis = new System.Windows.Forms.DataGridView();
            this.tabSecondaryDiagnosis = new System.Windows.Forms.TabPage();
            this.grdSecondaryDiagnosis = new System.Windows.Forms.DataGridView();
            this.tabProcedures = new System.Windows.Forms.TabPage();
            this.grdProcedures = new System.Windows.Forms.DataGridView();
            this.tabDailyCosts = new System.Windows.Forms.TabPage();
            this.data = new org.inek.PeppBrowser.GUI.Data();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.titleBar = new org.inek.PeppBrowser.GUI.TitleBar();
            this.mnuMain.SuspendLayout();
            this.pnlContentBackground.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMainDiagnosis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainDiagnosis)).BeginInit();
            this.tabSecondaryDiagnosis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSecondaryDiagnosis)).BeginInit();
            this.tabProcedures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcedures)).BeginInit();
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
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 20);
            this.mnuFile.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
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
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.druckenToolStripMenuItem,
            this.designerToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem3.Text = "Report";
            // 
            // druckenToolStripMenuItem
            // 
            this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            this.druckenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.druckenToolStripMenuItem.Text = "Drucken";
            this.druckenToolStripMenuItem.Click += new System.EventHandler(this.druckenToolStripMenuItem_Click);
            // 
            // designerToolStripMenuItem
            // 
            this.designerToolStripMenuItem.Name = "designerToolStripMenuItem";
            this.designerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.designerToolStripMenuItem.Text = "Designer";
            this.designerToolStripMenuItem.Click += new System.EventHandler(this.designerToolStripMenuItem_Click);
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
            this.pnlContentBackground.Controls.Add(this.selection);
            this.pnlContentBackground.Controls.Add(this.lblPEPP);
            this.pnlContentBackground.Controls.Add(this.cbxPepp);
            this.pnlContentBackground.Controls.Add(this.tabControl);
            this.pnlContentBackground.Controls.Add(this.mnuMain);
            this.pnlContentBackground.Controls.Add(this.data);
            this.pnlContentBackground.Location = new System.Drawing.Point(3, 30);
            this.pnlContentBackground.Name = "pnlContentBackground";
            this.pnlContentBackground.Size = new System.Drawing.Size(1182, 737);
            this.pnlContentBackground.TabIndex = 8;
            this.pnlContentBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            // 
            // selection
            // 
            this.selection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selection.BackColor = System.Drawing.Color.SeaGreen;
            this.selection.Location = new System.Drawing.Point(0, 27);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(1182, 52);
            this.selection.TabIndex = 11;
            // 
            // lblPEPP
            // 
            this.lblPEPP.AutoSize = true;
            this.lblPEPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEPP.ForeColor = System.Drawing.Color.White;
            this.lblPEPP.Location = new System.Drawing.Point(7, 91);
            this.lblPEPP.Name = "lblPEPP";
            this.lblPEPP.Size = new System.Drawing.Size(52, 16);
            this.lblPEPP.TabIndex = 9;
            this.lblPEPP.Text = "PEPP:";
            // 
            // cbxPepp
            // 
            this.cbxPepp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPepp.Location = new System.Drawing.Point(105, 86);
            this.cbxPepp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPepp.MinimumSize = new System.Drawing.Size(100, 21);
            this.cbxPepp.MutltiLine = false;
            this.cbxPepp.Name = "cbxPepp";
            this.cbxPepp.ReadOnly = true;
            this.cbxPepp.Size = new System.Drawing.Size(1067, 21);
            this.cbxPepp.TabIndex = 10;
            this.cbxPepp.ButtonClicked += new System.EventHandler(this.cbxPepp_ButtonClicked);
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
            this.tabControl.Location = new System.Drawing.Point(3, 390);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1176, 344);
            this.tabControl.TabIndex = 8;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabMainDiagnosis
            // 
            this.tabMainDiagnosis.Controls.Add(this.grdMainDiagnosis);
            this.tabMainDiagnosis.Location = new System.Drawing.Point(4, 22);
            this.tabMainDiagnosis.Name = "tabMainDiagnosis";
            this.tabMainDiagnosis.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainDiagnosis.Size = new System.Drawing.Size(1168, 318);
            this.tabMainDiagnosis.TabIndex = 0;
            this.tabMainDiagnosis.Text = "Hauptdiagnosen";
            this.tabMainDiagnosis.UseVisualStyleBackColor = true;
            // 
            // grdMainDiagnosis
            // 
            this.grdMainDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMainDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMainDiagnosis.Location = new System.Drawing.Point(3, 3);
            this.grdMainDiagnosis.Name = "grdMainDiagnosis";
            this.grdMainDiagnosis.ReadOnly = true;
            this.grdMainDiagnosis.Size = new System.Drawing.Size(1162, 312);
            this.grdMainDiagnosis.TabIndex = 0;
            // 
            // tabSecondaryDiagnosis
            // 
            this.tabSecondaryDiagnosis.Controls.Add(this.grdSecondaryDiagnosis);
            this.tabSecondaryDiagnosis.Location = new System.Drawing.Point(4, 22);
            this.tabSecondaryDiagnosis.Name = "tabSecondaryDiagnosis";
            this.tabSecondaryDiagnosis.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecondaryDiagnosis.Size = new System.Drawing.Size(1168, 330);
            this.tabSecondaryDiagnosis.TabIndex = 1;
            this.tabSecondaryDiagnosis.Text = "Nebendiagnosen";
            this.tabSecondaryDiagnosis.UseVisualStyleBackColor = true;
            // 
            // grdSecondaryDiagnosis
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSecondaryDiagnosis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSecondaryDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSecondaryDiagnosis.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdSecondaryDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSecondaryDiagnosis.Location = new System.Drawing.Point(3, 3);
            this.grdSecondaryDiagnosis.Name = "grdSecondaryDiagnosis";
            this.grdSecondaryDiagnosis.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSecondaryDiagnosis.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdSecondaryDiagnosis.Size = new System.Drawing.Size(1162, 324);
            this.grdSecondaryDiagnosis.TabIndex = 1;
            // 
            // tabProcedures
            // 
            this.tabProcedures.Controls.Add(this.grdProcedures);
            this.tabProcedures.Location = new System.Drawing.Point(4, 22);
            this.tabProcedures.Name = "tabProcedures";
            this.tabProcedures.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcedures.Size = new System.Drawing.Size(1168, 330);
            this.tabProcedures.TabIndex = 2;
            this.tabProcedures.Text = "Prozeduren";
            this.tabProcedures.UseVisualStyleBackColor = true;
            // 
            // grdProcedures
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProcedures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProcedures.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProcedures.Location = new System.Drawing.Point(3, 3);
            this.grdProcedures.Name = "grdProcedures";
            this.grdProcedures.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProcedures.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdProcedures.Size = new System.Drawing.Size(1162, 324);
            this.grdProcedures.TabIndex = 2;
            // 
            // tabDailyCosts
            // 
            this.tabDailyCosts.BackColor = System.Drawing.Color.Transparent;
            this.tabDailyCosts.Location = new System.Drawing.Point(4, 22);
            this.tabDailyCosts.Name = "tabDailyCosts";
            this.tabDailyCosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabDailyCosts.Size = new System.Drawing.Size(1168, 330);
            this.tabDailyCosts.TabIndex = 3;
            this.tabDailyCosts.Text = "Tageskosten";
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.data.Location = new System.Drawing.Point(0, 114);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(1182, 270);
            this.data.TabIndex = 1;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "PeppBrowser.chm";
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.BackColor = System.Drawing.Color.SeaGreen;
            this.titleBar.Location = new System.Drawing.Point(3, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ShowIconify = true;
            this.titleBar.ShowMinMax = true;
            this.titleBar.Size = new System.Drawing.Size(1182, 30);
            this.titleBar.TabIndex = 5;
            this.titleBar.ClickedExit += new System.EventHandler(this.titleBar_ClickedExit);
            this.titleBar.ClickedMinMax += new System.EventHandler(this.titleBar_ClickedMinMax);
            this.titleBar.ClickedIconify += new System.EventHandler(this.titleBar_ClickedIconify);
            this.titleBar.MouseMoveTitleBar += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            // 
            // FrmPeppBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1188, 770);
            this.Controls.Add(this.pnlContentBackground);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.helpProvider1.SetHelpKeyword(this, "Introduction.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1188, 500);
            this.Name = "FrmPeppBrowser";
            this.helpProvider1.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEPP-Browser";
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlContentBackground.ResumeLayout(false);
            this.pnlContentBackground.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMainDiagnosis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMainDiagnosis)).EndInit();
            this.tabSecondaryDiagnosis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSecondaryDiagnosis)).EndInit();
            this.tabProcedures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProcedures)).EndInit();
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
        private System.Windows.Forms.Panel pnlContentBackground;
        private Data data;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMainDiagnosis;
        private System.Windows.Forms.TabPage tabSecondaryDiagnosis;
        private System.Windows.Forms.TabPage tabProcedures;
        private System.Windows.Forms.TabPage tabDailyCosts;
        private System.Windows.Forms.DataGridView grdSecondaryDiagnosis;
        private System.Windows.Forms.DataGridView grdProcedures;
        private System.Windows.Forms.Label lblPEPP;
        private controls.CommonControls.ComboField cbxPepp;
        private System.Windows.Forms.DataGridView grdMainDiagnosis;
        private Selection selection;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem druckenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designerToolStripMenuItem;

    }
}

