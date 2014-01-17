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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeppBrowser));
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
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionTag = new System.Windows.Forms.ToolStripMenuItem();
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
            this.grdCosts = new System.Windows.Forms.DataGridView();
            this.data = new org.inek.PeppBrowser.GUI.Data();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerPeppBlink = new System.Windows.Forms.Timer(this.components);
            this.titleBar = new org.inek.PeppBrowser.GUI.TitleBar();
            this.timerPrintWindow = new System.Windows.Forms.Timer(this.components);
            this.mnuMain.SuspendLayout();
            this.pnlContentBackground.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMainDiagnosis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainDiagnosis)).BeginInit();
            this.tabSecondaryDiagnosis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSecondaryDiagnosis)).BeginInit();
            this.tabProcedures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcedures)).BeginInit();
            this.tabDailyCosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCosts)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuData,
            this.mnuReport,
            this.mnuQuestionTag});
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
            this.beendenToolStripMenuItem.Image = global::org.inek.PeppBrowser.Properties.Resources.peppo_quit;
            this.beendenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
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
            this.mnuStructureCategories.BackColor = System.Drawing.SystemColors.Control;
            this.mnuStructureCategories.Name = "mnuStructureCategories";
            this.mnuStructureCategories.Size = new System.Drawing.Size(172, 22);
            this.mnuStructureCategories.Text = "Strukturkategorien";
            this.mnuStructureCategories.Click += new System.EventHandler(this.mnuStructureCategories_Click);
            // 
            // mnuPepp
            // 
            this.mnuPepp.BackColor = System.Drawing.SystemColors.Control;
            this.mnuPepp.Name = "mnuPepp";
            this.mnuPepp.Size = new System.Drawing.Size(172, 22);
            this.mnuPepp.Text = "PEPP";
            this.mnuPepp.Click += new System.EventHandler(this.mnuPepp_Click);
            // 
            // mnuPeppInfo
            // 
            this.mnuPeppInfo.BackColor = System.Drawing.SystemColors.Control;
            this.mnuPeppInfo.Name = "mnuPeppInfo";
            this.mnuPeppInfo.Size = new System.Drawing.Size(172, 22);
            this.mnuPeppInfo.Text = "Kopfdaten";
            this.mnuPeppInfo.Click += new System.EventHandler(this.mnuPeppInfo_Click);
            // 
            // mnuPrimaryDiagnoses
            // 
            this.mnuPrimaryDiagnoses.BackColor = System.Drawing.SystemColors.Control;
            this.mnuPrimaryDiagnoses.Name = "mnuPrimaryDiagnoses";
            this.mnuPrimaryDiagnoses.Size = new System.Drawing.Size(172, 22);
            this.mnuPrimaryDiagnoses.Text = "Hauptdiagnosen";
            this.mnuPrimaryDiagnoses.Click += new System.EventHandler(this.mnuPrimaryDiagnoses_Click);
            // 
            // mnuSecondaryDiagnoses
            // 
            this.mnuSecondaryDiagnoses.BackColor = System.Drawing.SystemColors.Control;
            this.mnuSecondaryDiagnoses.Name = "mnuSecondaryDiagnoses";
            this.mnuSecondaryDiagnoses.Size = new System.Drawing.Size(172, 22);
            this.mnuSecondaryDiagnoses.Text = "Nebendiagnosen";
            this.mnuSecondaryDiagnoses.Click += new System.EventHandler(this.mnuSecondaryDiagnoses_Click);
            // 
            // mnuProcedures
            // 
            this.mnuProcedures.BackColor = System.Drawing.SystemColors.Control;
            this.mnuProcedures.Name = "mnuProcedures";
            this.mnuProcedures.Size = new System.Drawing.Size(172, 22);
            this.mnuProcedures.Text = "Prozeduren";
            this.mnuProcedures.Click += new System.EventHandler(this.mnuProcedures_Click);
            // 
            // mnuCosts
            // 
            this.mnuCosts.BackColor = System.Drawing.SystemColors.Control;
            this.mnuCosts.Name = "mnuCosts";
            this.mnuCosts.Size = new System.Drawing.Size(172, 22);
            this.mnuCosts.Text = "Kosten";
            this.mnuCosts.Click += new System.EventHandler(this.mnuCosts_Click);
            // 
            // mnuCostDomains
            // 
            this.mnuCostDomains.BackColor = System.Drawing.SystemColors.Control;
            this.mnuCostDomains.Name = "mnuCostDomains";
            this.mnuCostDomains.Size = new System.Drawing.Size(172, 22);
            this.mnuCostDomains.Text = "Kostenbereiche";
            this.mnuCostDomains.Click += new System.EventHandler(this.mnuCostDomains_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.druckenToolStripMenuItem,
            this.designerToolStripMenuItem});
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(54, 20);
            this.mnuReport.Text = "Report";
            // 
            // druckenToolStripMenuItem
            // 
            this.druckenToolStripMenuItem.Image = global::org.inek.PeppBrowser.Properties.Resources.peppo_print;
            this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            this.druckenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.druckenToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.druckenToolStripMenuItem.Text = "Drucken";
            this.druckenToolStripMenuItem.Click += new System.EventHandler(this.druckenToolStripMenuItem_Click);
            // 
            // designerToolStripMenuItem
            // 
            this.designerToolStripMenuItem.Name = "designerToolStripMenuItem";
            this.designerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.designerToolStripMenuItem.Text = "Designer";
            this.designerToolStripMenuItem.Visible = false;
            this.designerToolStripMenuItem.Click += new System.EventHandler(this.designerToolStripMenuItem_Click);
            // 
            // mnuQuestionTag
            // 
            this.mnuQuestionTag.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mnuQuestionTag.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManual,
            this.mnuHelp,
            this.mnuInfo});
            this.mnuQuestionTag.Name = "mnuQuestionTag";
            this.mnuQuestionTag.Size = new System.Drawing.Size(24, 20);
            this.mnuQuestionTag.Text = "?";
            // 
            // mnuManual
            // 
            this.mnuManual.Image = global::org.inek.PeppBrowser.Properties.Resources.peppo_manual;
            this.mnuManual.Name = "mnuManual";
            this.mnuManual.Size = new System.Drawing.Size(130, 22);
            this.mnuManual.Text = "Handbuch";
            this.mnuManual.Click += new System.EventHandler(this.mnuManual_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Image = global::org.inek.PeppBrowser.Properties.Resources.peppo_help;
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(130, 22);
            this.mnuHelp.Text = "Hilfe";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // mnuInfo
            // 
            this.mnuInfo.Image = global::org.inek.PeppBrowser.Properties.Resources.peppo_info;
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(130, 22);
            this.mnuInfo.Text = "Info";
            this.mnuInfo.Click += new System.EventHandler(this.mnuInfo_Click);
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
            this.helpProvider1.SetHelpKeyword(this.selection, "Filter.htm");
            this.helpProvider1.SetHelpNavigator(this.selection, System.Windows.Forms.HelpNavigator.Topic);
            this.selection.Location = new System.Drawing.Point(0, 27);
            this.selection.Name = "selection";
            this.helpProvider1.SetShowHelp(this.selection, true);
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
            this.helpProvider1.SetHelpKeyword(this.cbxPepp, "Filter.htm");
            this.helpProvider1.SetHelpNavigator(this.cbxPepp, System.Windows.Forms.HelpNavigator.Topic);
            this.cbxPepp.Location = new System.Drawing.Point(107, 88);
            this.cbxPepp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPepp.MinimumSize = new System.Drawing.Size(40, 21);
            this.cbxPepp.MutltiLine = false;
            this.cbxPepp.Name = "cbxPepp";
            this.cbxPepp.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.cbxPepp, true);
            this.cbxPepp.Size = new System.Drawing.Size(1067, 21);
            this.cbxPepp.TabIndex = 10;
            this.toolTip.SetToolTip(this.cbxPepp, "Wählen Sie eine PEPP aus.");
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
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
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
            this.grdMainDiagnosis.AllowUserToAddRows = false;
            this.grdMainDiagnosis.AllowUserToDeleteRows = false;
            this.grdMainDiagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMainDiagnosis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdMainDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMainDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpKeyword(this.grdMainDiagnosis, "Datenreiter_Hauptdiagnose.htm");
            this.helpProvider1.SetHelpNavigator(this.grdMainDiagnosis, System.Windows.Forms.HelpNavigator.Topic);
            this.grdMainDiagnosis.Location = new System.Drawing.Point(3, 3);
            this.grdMainDiagnosis.MultiSelect = false;
            this.grdMainDiagnosis.Name = "grdMainDiagnosis";
            this.grdMainDiagnosis.ReadOnly = true;
            this.grdMainDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdMainDiagnosis.RowHeadersVisible = false;
            this.grdMainDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider1.SetShowHelp(this.grdMainDiagnosis, true);
            this.grdMainDiagnosis.Size = new System.Drawing.Size(1162, 312);
            this.grdMainDiagnosis.TabIndex = 0;
            this.grdMainDiagnosis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMainDiagnosis_CellDoubleClick);
            // 
            // tabSecondaryDiagnosis
            // 
            this.tabSecondaryDiagnosis.Controls.Add(this.grdSecondaryDiagnosis);
            this.tabSecondaryDiagnosis.Location = new System.Drawing.Point(4, 22);
            this.tabSecondaryDiagnosis.Name = "tabSecondaryDiagnosis";
            this.tabSecondaryDiagnosis.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecondaryDiagnosis.Size = new System.Drawing.Size(1168, 318);
            this.tabSecondaryDiagnosis.TabIndex = 1;
            this.tabSecondaryDiagnosis.Text = "Nebendiagnosen";
            this.tabSecondaryDiagnosis.UseVisualStyleBackColor = true;
            // 
            // grdSecondaryDiagnosis
            // 
            this.grdSecondaryDiagnosis.AllowUserToAddRows = false;
            this.grdSecondaryDiagnosis.AllowUserToDeleteRows = false;
            this.grdSecondaryDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSecondaryDiagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSecondaryDiagnosis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSecondaryDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.helpProvider1.SetHelpKeyword(this.grdSecondaryDiagnosis, "Datenreiter_Nebendiagnosen.htm");
            this.helpProvider1.SetHelpNavigator(this.grdSecondaryDiagnosis, System.Windows.Forms.HelpNavigator.Topic);
            this.grdSecondaryDiagnosis.Location = new System.Drawing.Point(3, 3);
            this.grdSecondaryDiagnosis.MultiSelect = false;
            this.grdSecondaryDiagnosis.Name = "grdSecondaryDiagnosis";
            this.grdSecondaryDiagnosis.ReadOnly = true;
            this.grdSecondaryDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdSecondaryDiagnosis.RowHeadersVisible = false;
            this.grdSecondaryDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider1.SetShowHelp(this.grdSecondaryDiagnosis, true);
            this.grdSecondaryDiagnosis.Size = new System.Drawing.Size(1162, 312);
            this.grdSecondaryDiagnosis.TabIndex = 1;
            this.grdSecondaryDiagnosis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSecondaryDiagnosis_CellDoubleClick);
            // 
            // tabProcedures
            // 
            this.tabProcedures.Controls.Add(this.grdProcedures);
            this.tabProcedures.Location = new System.Drawing.Point(4, 22);
            this.tabProcedures.Name = "tabProcedures";
            this.tabProcedures.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcedures.Size = new System.Drawing.Size(1168, 318);
            this.tabProcedures.TabIndex = 2;
            this.tabProcedures.Text = "Prozeduren";
            this.tabProcedures.UseVisualStyleBackColor = true;
            // 
            // grdProcedures
            // 
            this.grdProcedures.AllowUserToAddRows = false;
            this.grdProcedures.AllowUserToDeleteRows = false;
            this.grdProcedures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProcedures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpKeyword(this.grdProcedures, "Datenreiter_Nebendiagnosen.htm");
            this.helpProvider1.SetHelpNavigator(this.grdProcedures, System.Windows.Forms.HelpNavigator.Topic);
            this.grdProcedures.Location = new System.Drawing.Point(3, 3);
            this.grdProcedures.MultiSelect = false;
            this.grdProcedures.Name = "grdProcedures";
            this.grdProcedures.ReadOnly = true;
            this.grdProcedures.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdProcedures.RowHeadersVisible = false;
            this.grdProcedures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider1.SetShowHelp(this.grdProcedures, true);
            this.grdProcedures.Size = new System.Drawing.Size(1162, 312);
            this.grdProcedures.TabIndex = 2;
            this.grdProcedures.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProcedures_CellDoubleClick);
            // 
            // tabDailyCosts
            // 
            this.tabDailyCosts.BackColor = System.Drawing.Color.Transparent;
            this.tabDailyCosts.Controls.Add(this.grdCosts);
            this.tabDailyCosts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabDailyCosts.Location = new System.Drawing.Point(4, 22);
            this.tabDailyCosts.Name = "tabDailyCosts";
            this.tabDailyCosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabDailyCosts.Size = new System.Drawing.Size(1168, 318);
            this.tabDailyCosts.TabIndex = 3;
            this.tabDailyCosts.Text = "Tageskosten";
            // 
            // grdCosts
            // 
            this.grdCosts.AllowUserToAddRows = false;
            this.grdCosts.AllowUserToDeleteRows = false;
            this.grdCosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCosts.ColumnHeadersVisible = false;
            this.grdCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpKeyword(this.grdCosts, "Datenreiter_Tageskosten.htm");
            this.helpProvider1.SetHelpNavigator(this.grdCosts, System.Windows.Forms.HelpNavigator.Topic);
            this.grdCosts.Location = new System.Drawing.Point(3, 3);
            this.grdCosts.MultiSelect = false;
            this.grdCosts.Name = "grdCosts";
            this.grdCosts.ReadOnly = true;
            this.grdCosts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdCosts.RowHeadersVisible = false;
            this.grdCosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.helpProvider1.SetShowHelp(this.grdCosts, true);
            this.grdCosts.Size = new System.Drawing.Size(1162, 312);
            this.grdCosts.TabIndex = 3;
            this.grdCosts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCosts_CellClick);
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
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 200;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 200;
            this.toolTip.ReshowDelay = 40;
            // 
            // timerPeppBlink
            // 
            this.timerPeppBlink.Interval = 250;
            this.timerPeppBlink.Tick += new System.EventHandler(this.timerPeppBlink_Tick);
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.BackColor = System.Drawing.Color.SeaGreen;
            this.titleBar.Location = new System.Drawing.Point(3, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.titleBar.MinMaxImage = ((System.Drawing.Image)(resources.GetObject("titleBar.MinMaxImage")));
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
            // timerPrintWindow
            // 
            this.timerPrintWindow.Interval = 1000;
            this.timerPrintWindow.Tick += new System.EventHandler(this.timerPrintWindow_Tick);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1188, 500);
            this.Name = "FrmPeppBrowser";
            this.helpProvider1.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PEPP-Browser";
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            this.Resize += new System.EventHandler(this.FrmPeppBrowser_Resize);
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
            this.tabDailyCosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCosts)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionTag;
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
        private System.Windows.Forms.Label lblPEPP;
        private controls.CommonControls.ComboField cbxPepp;
        private System.Windows.Forms.DataGridView grdMainDiagnosis;
        private Selection selection;
        private System.Windows.Forms.DataGridView grdSecondaryDiagnosis;
        private System.Windows.Forms.DataGridView grdProcedures;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem druckenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designerToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdCosts;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timerPeppBlink;
        private System.Windows.Forms.Timer timerPrintWindow;

    }
}

