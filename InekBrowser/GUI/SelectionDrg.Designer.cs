namespace org.inek.InekBrowser.GUI {
    partial class SelectionDrg {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.picClearProc = new System.Windows.Forms.PictureBox();
            this.picClearSecondaryDiag = new System.Windows.Forms.PictureBox();
            this.picClearPrimaryDiag = new System.Windows.Forms.PictureBox();
            this.picClearCategory = new System.Windows.Forms.PictureBox();
            this.cbxProcedure = new org.inek.controls.CommonControls.ComboField();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSecondaryDiagnosis = new org.inek.controls.CommonControls.ComboField();
            this.lblSecondaryDiagnosis = new System.Windows.Forms.Label();
            this.lblMainDiagnosis = new System.Windows.Forms.Label();
            this.cbxMainDiagnosis = new org.inek.controls.CommonControls.ComboField();
            this.cbxCategory = new org.inek.controls.CommonControls.ComboField();
            this.lblSk = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClearProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearSecondaryDiag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearPrimaryDiag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFilter
            // 
            this.grpFilter.BackColor = System.Drawing.Color.Transparent;
            this.grpFilter.Controls.Add(this.cbxDepartment);
            this.grpFilter.Controls.Add(this.lblDepartment);
            this.grpFilter.Controls.Add(this.picClearProc);
            this.grpFilter.Controls.Add(this.picClearSecondaryDiag);
            this.grpFilter.Controls.Add(this.picClearPrimaryDiag);
            this.grpFilter.Controls.Add(this.picClearCategory);
            this.grpFilter.Controls.Add(this.cbxProcedure);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Controls.Add(this.cbxSecondaryDiagnosis);
            this.grpFilter.Controls.Add(this.lblSecondaryDiagnosis);
            this.grpFilter.Controls.Add(this.lblMainDiagnosis);
            this.grpFilter.Controls.Add(this.cbxMainDiagnosis);
            this.grpFilter.Controls.Add(this.cbxCategory);
            this.grpFilter.Controls.Add(this.lblSk);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilter.ForeColor = System.Drawing.Color.White;
            this.grpFilter.Location = new System.Drawing.Point(0, 0);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(996, 52);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "DRG-Filter";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(825, 25);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(54, 13);
            this.lblDepartment.TabIndex = 20;
            this.lblDepartment.Text = "Abteilung:";
            // 
            // picClearProc
            // 
            this.picClearProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClearProc.BackgroundImage = global::org.inek.InekBrowser.Properties.Resources.peppo_exit;
            this.picClearProc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClearProc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClearProc.Location = new System.Drawing.Point(806, 24);
            this.picClearProc.Name = "picClearProc";
            this.picClearProc.Size = new System.Drawing.Size(15, 15);
            this.picClearProc.TabIndex = 19;
            this.picClearProc.TabStop = false;
            this.picClearProc.Visible = false;
            this.picClearProc.Click += new System.EventHandler(this.picClearProc_Click);
            // 
            // picClearSecondaryDiag
            // 
            this.picClearSecondaryDiag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClearSecondaryDiag.BackgroundImage = global::org.inek.InekBrowser.Properties.Resources.peppo_exit;
            this.picClearSecondaryDiag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClearSecondaryDiag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClearSecondaryDiag.Location = new System.Drawing.Point(639, 23);
            this.picClearSecondaryDiag.Name = "picClearSecondaryDiag";
            this.picClearSecondaryDiag.Size = new System.Drawing.Size(15, 15);
            this.picClearSecondaryDiag.TabIndex = 18;
            this.picClearSecondaryDiag.TabStop = false;
            this.picClearSecondaryDiag.Visible = false;
            this.picClearSecondaryDiag.Click += new System.EventHandler(this.picClearSd_Click);
            // 
            // picClearPrimaryDiag
            // 
            this.picClearPrimaryDiag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClearPrimaryDiag.BackgroundImage = global::org.inek.InekBrowser.Properties.Resources.peppo_exit;
            this.picClearPrimaryDiag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClearPrimaryDiag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClearPrimaryDiag.Location = new System.Drawing.Point(471, 23);
            this.picClearPrimaryDiag.Name = "picClearPrimaryDiag";
            this.picClearPrimaryDiag.Size = new System.Drawing.Size(15, 15);
            this.picClearPrimaryDiag.TabIndex = 17;
            this.picClearPrimaryDiag.TabStop = false;
            this.picClearPrimaryDiag.Visible = false;
            this.picClearPrimaryDiag.Click += new System.EventHandler(this.picClearHd_Click);
            // 
            // picClearCategory
            // 
            this.picClearCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClearCategory.BackgroundImage = global::org.inek.InekBrowser.Properties.Resources.peppo_exit;
            this.picClearCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClearCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClearCategory.Location = new System.Drawing.Point(310, 23);
            this.picClearCategory.Name = "picClearCategory";
            this.picClearCategory.Size = new System.Drawing.Size(15, 15);
            this.picClearCategory.TabIndex = 16;
            this.picClearCategory.TabStop = false;
            this.picClearCategory.Visible = false;
            this.picClearCategory.Click += new System.EventHandler(this.picClearSk_Click);
            // 
            // cbxProcedure
            // 
            this.cbxProcedure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProcedure.Location = new System.Drawing.Point(713, 19);
            this.cbxProcedure.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbxProcedure.MinimumSize = new System.Drawing.Size(40, 21);
            this.cbxProcedure.MutltiLine = false;
            this.cbxProcedure.Name = "cbxProcedure";
            this.cbxProcedure.ReadOnly = true;
            this.cbxProcedure.Size = new System.Drawing.Size(86, 22);
            this.cbxProcedure.TabIndex = 15;
            this.cbxProcedure.ButtonClicked += new System.EventHandler(this.cbxProcedure_ButtonClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Prozedur:";
            // 
            // cbxSecondaryDiagnosis
            // 
            this.cbxSecondaryDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSecondaryDiagnosis.Location = new System.Drawing.Point(577, 19);
            this.cbxSecondaryDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSecondaryDiagnosis.MinimumSize = new System.Drawing.Size(40, 21);
            this.cbxSecondaryDiagnosis.MutltiLine = false;
            this.cbxSecondaryDiagnosis.Name = "cbxSecondaryDiagnosis";
            this.cbxSecondaryDiagnosis.ReadOnly = true;
            this.cbxSecondaryDiagnosis.Size = new System.Drawing.Size(56, 21);
            this.cbxSecondaryDiagnosis.TabIndex = 3;
            this.cbxSecondaryDiagnosis.ButtonClicked += new System.EventHandler(this.cbxSecondaryDiagnosis_ButtonClicked);
            // 
            // lblSecondaryDiagnosis
            // 
            this.lblSecondaryDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecondaryDiagnosis.AutoSize = true;
            this.lblSecondaryDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaryDiagnosis.Location = new System.Drawing.Point(491, 24);
            this.lblSecondaryDiagnosis.Name = "lblSecondaryDiagnosis";
            this.lblSecondaryDiagnosis.Size = new System.Drawing.Size(85, 13);
            this.lblSecondaryDiagnosis.TabIndex = 2;
            this.lblSecondaryDiagnosis.Text = "Nebendiagnose:";
            // 
            // lblMainDiagnosis
            // 
            this.lblMainDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainDiagnosis.AutoSize = true;
            this.lblMainDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainDiagnosis.Location = new System.Drawing.Point(326, 24);
            this.lblMainDiagnosis.Name = "lblMainDiagnosis";
            this.lblMainDiagnosis.Size = new System.Drawing.Size(82, 13);
            this.lblMainDiagnosis.TabIndex = 1;
            this.lblMainDiagnosis.Text = "Hauptdiagnose:";
            // 
            // cbxMainDiagnosis
            // 
            this.cbxMainDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMainDiagnosis.Location = new System.Drawing.Point(409, 19);
            this.cbxMainDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMainDiagnosis.MinimumSize = new System.Drawing.Size(30, 21);
            this.cbxMainDiagnosis.MutltiLine = false;
            this.cbxMainDiagnosis.Name = "cbxMainDiagnosis";
            this.cbxMainDiagnosis.ReadOnly = true;
            this.cbxMainDiagnosis.Size = new System.Drawing.Size(56, 21);
            this.cbxMainDiagnosis.TabIndex = 0;
            this.cbxMainDiagnosis.ButtonClicked += new System.EventHandler(this.cbxMainDiagnosis_ButtonClicked);
            // 
            // cbxCategory
            // 
            this.cbxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCategory.Location = new System.Drawing.Point(42, 20);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCategory.MinimumSize = new System.Drawing.Size(100, 21);
            this.cbxCategory.MutltiLine = false;
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.ReadOnly = true;
            this.cbxCategory.Size = new System.Drawing.Size(262, 21);
            this.cbxCategory.TabIndex = 9;
            this.cbxCategory.ButtonClicked += new System.EventHandler(this.cbxCategory_ButtonClicked);
            // 
            // lblSk
            // 
            this.lblSk.AutoSize = true;
            this.lblSk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSk.Location = new System.Drawing.Point(9, 25);
            this.lblSk.Name = "lblSk";
            this.lblSk.Size = new System.Drawing.Size(34, 13);
            this.lblSk.TabIndex = 8;
            this.lblSk.Text = "MDC:";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "PeppBrowser.chm";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Items.AddRange(new object[] {
            "Hauptabteilung",
            "Belegabteilung"});
            this.cbxDepartment.Location = new System.Drawing.Point(879, 19);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(108, 23);
            this.cbxDepartment.TabIndex = 21;
            this.cbxDepartment.Text = "Hauptabteilung";
            this.cbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxDepartment_SelectedIndexChanged);
            // 
            // SelectionDrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.grpFilter);
            this.Name = "SelectionDrg";
            this.Size = new System.Drawing.Size(996, 52);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClearProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearSecondaryDiag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearPrimaryDiag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblSk;
        private controls.CommonControls.ComboField cbxCategory;
        private controls.CommonControls.ComboField cbxMainDiagnosis;
        private controls.CommonControls.ComboField cbxSecondaryDiagnosis;
        private System.Windows.Forms.Label lblSecondaryDiagnosis;
        private System.Windows.Forms.Label lblMainDiagnosis;
        private controls.CommonControls.ComboField cbxProcedure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picClearCategory;
        private System.Windows.Forms.PictureBox picClearPrimaryDiag;
        private System.Windows.Forms.PictureBox picClearSecondaryDiag;
        private System.Windows.Forms.PictureBox picClearProc;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cbxDepartment;


    }
}
