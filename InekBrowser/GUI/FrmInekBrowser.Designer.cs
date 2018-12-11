using org.inek.controls.CommonControls;

namespace org.inek.InekBrowser.GUI {
    partial class FrmInekBrowser {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInekBrowser));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPeppInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrimaryDiagnoses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSecondaryDiagnoses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcedures = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCosts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCostDomain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalogue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecherche = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataDir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionTag = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManual = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContentBackground = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMainDiagnosis = new System.Windows.Forms.TabPage();
            this.grdMainDiagnosis = new System.Windows.Forms.DataGridView();
            this.tabSecondaryDiagnosis = new System.Windows.Forms.TabPage();
            this.grdSecondaryDiagnosis = new System.Windows.Forms.DataGridView();
            this.tabProcedures = new System.Windows.Forms.TabPage();
            this.grdProcedures = new System.Windows.Forms.DataGridView();
            this.tabCosts = new System.Windows.Forms.TabPage();
            this.grdCosts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSystem = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerPeppBlink = new System.Windows.Forms.Timer(this.components);
            this.timerPrintWindow = new System.Windows.Forms.Timer(this.components);
            this.selectionPepp = new org.inek.InekBrowser.GUI.SelectionPepp();
            this.peppData = new org.inek.InekBrowser.GUI.PeppData();
            this.cbxSystem = new org.inek.controls.CommonControls.ComboField();
            this.titleBar = new org.inek.InekBrowser.GUI.TitleBar();
            this.mnuMain.SuspendLayout();
            this.pnlContentBackground.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMainDiagnosis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainDiagnosis)).BeginInit();
            this.tabSecondaryDiagnosis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSecondaryDiagnosis)).BeginInit();
            this.tabProcedures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcedures)).BeginInit();
            this.tabCosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCosts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.DodgerBlue;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuData,
            this.mnuReport,
            this.mnuQuestionTag});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMain.Size = new System.Drawing.Size(1196, 24);
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
            this.beendenToolStripMenuItem.Image = global::org.inek.InekBrowser.Properties.Resources.peppo_quit;
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
            this.mnuCategories,
            this.mnuSystem,
            this.mnuPeppInfo,
            this.mnuPrimaryDiagnoses,
            this.mnuSecondaryDiagnoses,
            this.mnuProcedures,
            this.mnuCosts,
            this.mnuCostDomain,
            this.mnuCatalogue,
            this.mnuRecherche,
            this.mnuDataDir});
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(50, 20);
            this.mnuData.Text = "Daten";
            // 
            // mnuCategories
            // 
            this.mnuCategories.BackColor = System.Drawing.SystemColors.Control;
            this.mnuCategories.Name = "mnuCategories";
            this.mnuCategories.Size = new System.Drawing.Size(185, 22);
            this.mnuCategories.Text = "Strukturkategorien";
            this.mnuCategories.Click += new System.EventHandler(this.MnuCategoriesClick);
            // 
            // mnuSystem
            // 
            this.mnuSystem.BackColor = System.Drawing.SystemColors.Control;
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(185, 22);
            this.mnuSystem.Text = "Code";
            this.mnuSystem.Click += new System.EventHandler(this.MnuSystemClick);
            // 
            // mnuPeppInfo
            // 
            this.mnuPeppInfo.BackColor = System.Drawing.SystemColors.Control;
            this.mnuPeppInfo.Name = "mnuPeppInfo";
            this.mnuPeppInfo.Size = new System.Drawing.Size(185, 22);
            this.mnuPeppInfo.Text = "Kopfdaten";
            this.mnuPeppInfo.Click += new System.EventHandler(this.MnuSystemInfoClick);
            // 
            // mnuPrimaryDiagnoses
            // 
            this.mnuPrimaryDiagnoses.BackColor = System.Drawing.SystemColors.Control;
            this.mnuPrimaryDiagnoses.Name = "mnuPrimaryDiagnoses";
            this.mnuPrimaryDiagnoses.Size = new System.Drawing.Size(185, 22);
            this.mnuPrimaryDiagnoses.Text = "Hauptdiagnosen";
            this.mnuPrimaryDiagnoses.Click += new System.EventHandler(this.mnuPrimaryDiagnoses_Click);
            // 
            // mnuSecondaryDiagnoses
            // 
            this.mnuSecondaryDiagnoses.BackColor = System.Drawing.SystemColors.Control;
            this.mnuSecondaryDiagnoses.Name = "mnuSecondaryDiagnoses";
            this.mnuSecondaryDiagnoses.Size = new System.Drawing.Size(185, 22);
            this.mnuSecondaryDiagnoses.Text = "Nebendiagnosen";
            this.mnuSecondaryDiagnoses.Click += new System.EventHandler(this.mnuSecondaryDiagnoses_Click);
            // 
            // mnuProcedures
            // 
            this.mnuProcedures.BackColor = System.Drawing.SystemColors.Control;
            this.mnuProcedures.Name = "mnuProcedures";
            this.mnuProcedures.Size = new System.Drawing.Size(185, 22);
            this.mnuProcedures.Text = "Prozeduren";
            this.mnuProcedures.Click += new System.EventHandler(this.mnuProcedures_Click);
            // 
            // mnuCosts
            // 
            this.mnuCosts.BackColor = System.Drawing.SystemColors.Control;
            this.mnuCosts.Name = "mnuCosts";
            this.mnuCosts.Size = new System.Drawing.Size(185, 22);
            this.mnuCosts.Text = "Kosten";
            this.mnuCosts.Click += new System.EventHandler(this.mnuCosts_Click);
            // 
            // mnuCostDomain
            // 
            this.mnuCostDomain.Name = "mnuCostDomain";
            this.mnuCostDomain.Size = new System.Drawing.Size(185, 22);
            this.mnuCostDomain.Text = "Kostenbereich";
            this.mnuCostDomain.Click += new System.EventHandler(this.kostenbereichToolStripMenuItem_Click);
            // 
            // mnuCatalogue
            // 
            this.mnuCatalogue.Name = "mnuCatalogue";
            this.mnuCatalogue.Size = new System.Drawing.Size(185, 22);
            this.mnuCatalogue.Text = "Katalog";
            this.mnuCatalogue.Click += new System.EventHandler(this.mnuCatalogue_Click);
            // 
            // mnuRecherche
            // 
            this.mnuRecherche.BackColor = System.Drawing.SystemColors.Control;
            this.mnuRecherche.Name = "mnuRecherche";
            this.mnuRecherche.Size = new System.Drawing.Size(185, 22);
            this.mnuRecherche.Text = "Recherche";
            this.mnuRecherche.Click += new System.EventHandler(this.mnuRecherche_Click);
            // 
            // mnuDataDir
            // 
            this.mnuDataDir.Image = global::org.inek.InekBrowser.Properties.Resources.folder_document_icon;
            this.mnuDataDir.Name = "mnuDataDir";
            this.mnuDataDir.Size = new System.Drawing.Size(185, 22);
            this.mnuDataDir.Text = "Daten-Ordner öffnen";
            this.mnuDataDir.Click += new System.EventHandler(this.mnuDataDir_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.mnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.druckenToolStripMenuItem,
            this.pDFExportToolStripMenuItem,
            this.designerToolStripMenuItem});
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(54, 20);
            this.mnuReport.Text = "Report";
            // 
            // druckenToolStripMenuItem
            // 
            this.druckenToolStripMenuItem.Image = global::org.inek.InekBrowser.Properties.Resources.peppo_print;
            this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            this.druckenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.druckenToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.druckenToolStripMenuItem.Text = "Drucken";
            this.druckenToolStripMenuItem.Click += new System.EventHandler(this.druckenToolStripMenuItem_Click);
            // 
            // pDFExportToolStripMenuItem
            // 
            this.pDFExportToolStripMenuItem.Image = global::org.inek.InekBrowser.Properties.Resources.doc_pdf_icon;
            this.pDFExportToolStripMenuItem.Name = "pDFExportToolStripMenuItem";
            this.pDFExportToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pDFExportToolStripMenuItem.Text = "PDF-Export";
            this.pDFExportToolStripMenuItem.Click += new System.EventHandler(this.pDFExportToolStripMenuItem_Click);
            // 
            // designerToolStripMenuItem
            // 
            this.designerToolStripMenuItem.Enabled = false;
            this.designerToolStripMenuItem.Name = "designerToolStripMenuItem";
            this.designerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
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
            this.mnuManual.Image = global::org.inek.InekBrowser.Properties.Resources.peppo_manual;
            this.mnuManual.Name = "mnuManual";
            this.mnuManual.Size = new System.Drawing.Size(130, 22);
            this.mnuManual.Text = "Handbuch";
            this.mnuManual.Click += new System.EventHandler(this.mnuManual_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Image = global::org.inek.InekBrowser.Properties.Resources.peppo_help;
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(130, 22);
            this.mnuHelp.Text = "Hilfe";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // mnuInfo
            // 
            this.mnuInfo.Image = global::org.inek.InekBrowser.Properties.Resources.peppo_info;
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
            this.pnlContentBackground.Controls.Add(this.tableLayoutPanel1);
            this.pnlContentBackground.Controls.Add(this.mnuMain);
            this.pnlContentBackground.Location = new System.Drawing.Point(3, 30);
            this.pnlContentBackground.Name = "pnlContentBackground";
            this.pnlContentBackground.Size = new System.Drawing.Size(1196, 661);
            this.pnlContentBackground.TabIndex = 8;
            this.pnlContentBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.selectionPepp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.peppData, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1196, 637);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabMainDiagnosis);
            this.tabControl.Controls.Add(this.tabSecondaryDiagnosis);
            this.tabControl.Controls.Add(this.tabProcedures);
            this.tabControl.Controls.Add(this.tabCosts);
            this.tabControl.Location = new System.Drawing.Point(3, 267);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1190, 367);
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
            this.tabMainDiagnosis.Size = new System.Drawing.Size(1182, 341);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMainDiagnosis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMainDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMainDiagnosis.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdMainDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpKeyword(this.grdMainDiagnosis, "Datenreiter_Hauptdiagnose.htm");
            this.helpProvider1.SetHelpNavigator(this.grdMainDiagnosis, System.Windows.Forms.HelpNavigator.Topic);
            this.grdMainDiagnosis.Location = new System.Drawing.Point(3, 3);
            this.grdMainDiagnosis.MultiSelect = false;
            this.grdMainDiagnosis.Name = "grdMainDiagnosis";
            this.grdMainDiagnosis.ReadOnly = true;
            this.grdMainDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMainDiagnosis.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdMainDiagnosis.RowHeadersVisible = false;
            this.grdMainDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider1.SetShowHelp(this.grdMainDiagnosis, true);
            this.grdMainDiagnosis.Size = new System.Drawing.Size(1176, 335);
            this.grdMainDiagnosis.TabIndex = 0;
            this.grdMainDiagnosis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMainDiagnosis_CellDoubleClick);
            // 
            // tabSecondaryDiagnosis
            // 
            this.tabSecondaryDiagnosis.Controls.Add(this.grdSecondaryDiagnosis);
            this.tabSecondaryDiagnosis.Location = new System.Drawing.Point(4, 22);
            this.tabSecondaryDiagnosis.Name = "tabSecondaryDiagnosis";
            this.tabSecondaryDiagnosis.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecondaryDiagnosis.Size = new System.Drawing.Size(1182, 341);
            this.tabSecondaryDiagnosis.TabIndex = 1;
            this.tabSecondaryDiagnosis.Text = "Nebendiagnosen";
            this.tabSecondaryDiagnosis.UseVisualStyleBackColor = true;
            // 
            // grdSecondaryDiagnosis
            // 
            this.grdSecondaryDiagnosis.AllowUserToAddRows = false;
            this.grdSecondaryDiagnosis.AllowUserToDeleteRows = false;
            this.grdSecondaryDiagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSecondaryDiagnosis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdSecondaryDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSecondaryDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.grdSecondaryDiagnosis.Size = new System.Drawing.Size(1176, 335);
            this.grdSecondaryDiagnosis.TabIndex = 1;
            this.grdSecondaryDiagnosis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSecondaryDiagnosis_CellDoubleClick);
            // 
            // tabProcedures
            // 
            this.tabProcedures.Controls.Add(this.grdProcedures);
            this.tabProcedures.Location = new System.Drawing.Point(4, 22);
            this.tabProcedures.Name = "tabProcedures";
            this.tabProcedures.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcedures.Size = new System.Drawing.Size(1182, 341);
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
            this.grdProcedures.Size = new System.Drawing.Size(1176, 335);
            this.grdProcedures.TabIndex = 2;
            this.grdProcedures.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProcedures_CellDoubleClick);
            // 
            // tabCosts
            // 
            this.tabCosts.BackColor = System.Drawing.Color.Transparent;
            this.tabCosts.Controls.Add(this.grdCosts);
            this.tabCosts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabCosts.Location = new System.Drawing.Point(4, 22);
            this.tabCosts.Name = "tabCosts";
            this.tabCosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabCosts.Size = new System.Drawing.Size(1182, 341);
            this.tabCosts.TabIndex = 3;
            this.tabCosts.Text = "Tageskosten";
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
            this.grdCosts.Size = new System.Drawing.Size(1176, 335);
            this.grdCosts.TabIndex = 3;
            this.grdCosts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCosts_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbxSystem);
            this.panel1.Controls.Add(this.lblSystem);
            this.panel1.Location = new System.Drawing.Point(3, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 24);
            this.panel1.TabIndex = 13;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.White;
            this.lblSystem.Location = new System.Drawing.Point(0, 5);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(49, 16);
            this.lblSystem.TabIndex = 9;
            this.lblSystem.Text = "Code:";
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
            // timerPrintWindow
            // 
            this.timerPrintWindow.Interval = 1000;
            this.timerPrintWindow.Tick += new System.EventHandler(this.timerPrintWindow_Tick);
            // 
            // selectionPepp
            // 
            this.selectionPepp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionPepp.BackColor = System.Drawing.Color.SteelBlue;
            this.helpProvider1.SetHelpKeyword(this.selectionPepp, "Filter.htm");
            this.helpProvider1.SetHelpNavigator(this.selectionPepp, System.Windows.Forms.HelpNavigator.Topic);
            this.selectionPepp.Location = new System.Drawing.Point(3, 3);
            this.selectionPepp.Name = "selectionPepp";
            this.helpProvider1.SetShowHelp(this.selectionPepp, true);
            this.selectionPepp.Size = new System.Drawing.Size(1190, 52);
            this.selectionPepp.TabIndex = 11;
            // 
            // peppData
            // 
            this.peppData.BackColor = System.Drawing.Color.SeaGreen;
            this.peppData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.peppData.CatalogueActive = true;
            this.peppData.Degression = "0";
            this.peppData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peppData.Location = new System.Drawing.Point(3, 91);
            this.peppData.MinimumSize = new System.Drawing.Size(0, 170);
            this.peppData.Name = "peppData";
            this.peppData.Size = new System.Drawing.Size(1190, 170);
            this.peppData.TabIndex = 12;
            this.peppData.ClickedCatalogue += new System.EventHandler(this.peppData_ClickedCatalogue);
            // 
            // cbxSystem
            // 
            this.cbxSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpKeyword(this.cbxSystem, "Filter.htm");
            this.helpProvider1.SetHelpNavigator(this.cbxSystem, System.Windows.Forms.HelpNavigator.Topic);
            this.cbxSystem.Location = new System.Drawing.Point(106, 0);
            this.cbxSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSystem.MinimumSize = new System.Drawing.Size(40, 21);
            this.cbxSystem.MutltiLine = false;
            this.cbxSystem.Name = "cbxSystem";
            this.cbxSystem.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.cbxSystem, true);
            this.cbxSystem.Size = new System.Drawing.Size(1084, 21);
            this.cbxSystem.TabIndex = 10;
            this.toolTip.SetToolTip(this.cbxSystem, "Wählen Sie eine Code aus.");
            this.cbxSystem.ButtonClicked += new System.EventHandler(this.cbxSystem_ButtonClicked);
            this.cbxSystem.Load += new System.EventHandler(this.cbxPepp_Load);
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.BackColor = System.Drawing.Color.SteelBlue;
            this.titleBar.Location = new System.Drawing.Point(3, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.titleBar.MinMaxImage = ((System.Drawing.Image)(resources.GetObject("titleBar.MinMaxImage")));
            this.titleBar.Name = "titleBar";
            this.titleBar.ShowIconify = true;
            this.titleBar.ShowMinMax = true;
            this.titleBar.Size = new System.Drawing.Size(1196, 30);
            this.titleBar.TabIndex = 5;
            this.titleBar.ClickedExit += new System.EventHandler(this.titleBar_ClickedExit);
            this.titleBar.ClickedMinMax += new System.EventHandler(this.titleBar_ClickedMinMax);
            this.titleBar.ClickedIconify += new System.EventHandler(this.titleBar_ClickedIconify);
            this.titleBar.MouseMoveTitleBar += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            // 
            // FrmInekBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1202, 694);
            this.Controls.Add(this.pnlContentBackground);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.helpProvider1.SetHelpKeyword(this, "Introduction.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1188, 500);
            this.Name = "FrmInekBrowser";
            this.helpProvider1.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Browser";
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPeppBrowser_MouseMove);
            this.Resize += new System.EventHandler(this.FrmPeppBrowser_Resize);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlContentBackground.ResumeLayout(false);
            this.pnlContentBackground.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabMainDiagnosis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMainDiagnosis)).EndInit();
            this.tabSecondaryDiagnosis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSecondaryDiagnosis)).EndInit();
            this.tabProcedures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProcedures)).EndInit();
            this.tabCosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCosts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar titleBar;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripMenuItem mnuCategories;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuPeppInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuPrimaryDiagnoses;
        private System.Windows.Forms.ToolStripMenuItem mnuSecondaryDiagnoses;
        private System.Windows.Forms.ToolStripMenuItem mnuProcedures;
        private System.Windows.Forms.ToolStripMenuItem mnuCosts;
        private System.Windows.Forms.ToolStripMenuItem mnuRecherche;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionTag;
        private System.Windows.Forms.ToolStripMenuItem mnuManual;
        private System.Windows.Forms.ToolStripMenuItem mnuInfo;
        private System.Windows.Forms.Panel pnlContentBackground;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMainDiagnosis;
        private System.Windows.Forms.TabPage tabSecondaryDiagnosis;
        private System.Windows.Forms.TabPage tabProcedures;
        private System.Windows.Forms.TabPage tabCosts;
        private System.Windows.Forms.Label lblSystem;
        private controls.CommonControls.ComboField cbxSystem;
        private System.Windows.Forms.DataGridView grdMainDiagnosis;
        private SelectionPepp selectionPepp;
        private System.Windows.Forms.DataGridView grdSecondaryDiagnosis;
        private System.Windows.Forms.DataGridView grdProcedures;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem druckenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designerToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdCosts;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timerPeppBlink;
        private System.Windows.Forms.Timer timerPrintWindow;
        private System.Windows.Forms.ToolStripMenuItem pDFExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDataDir;
        private PeppData peppData;
        private System.Windows.Forms.ToolStripMenuItem mnuCostDomain;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

