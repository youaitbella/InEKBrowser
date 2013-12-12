namespace org.inek.PeppBrowser.GUI {
    partial class Selection {
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
            this.picClearProc = new System.Windows.Forms.PictureBox();
            this.picClearSd = new System.Windows.Forms.PictureBox();
            this.picClearHd = new System.Windows.Forms.PictureBox();
            this.picClearSk = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSecondaryDiagnosis = new System.Windows.Forms.Label();
            this.lblMainDiagnosis = new System.Windows.Forms.Label();
            this.lblSk = new System.Windows.Forms.Label();
            this.cbxProcedure = new org.inek.controls.CommonControls.ComboField();
            this.cbxSecondaryDiagnosis = new org.inek.controls.CommonControls.ComboField();
            this.cbxMainDiagnosis = new org.inek.controls.CommonControls.ComboField();
            this.cbxSk = new org.inek.controls.CommonControls.ComboField();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClearProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearSd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearHd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearSk)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFilter
            // 
            this.grpFilter.BackColor = System.Drawing.Color.SeaGreen;
            this.grpFilter.Controls.Add(this.picClearProc);
            this.grpFilter.Controls.Add(this.picClearSd);
            this.grpFilter.Controls.Add(this.picClearHd);
            this.grpFilter.Controls.Add(this.picClearSk);
            this.grpFilter.Controls.Add(this.cbxProcedure);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Controls.Add(this.cbxSecondaryDiagnosis);
            this.grpFilter.Controls.Add(this.lblSecondaryDiagnosis);
            this.grpFilter.Controls.Add(this.lblMainDiagnosis);
            this.grpFilter.Controls.Add(this.cbxMainDiagnosis);
            this.grpFilter.Controls.Add(this.cbxSk);
            this.grpFilter.Controls.Add(this.lblSk);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilter.ForeColor = System.Drawing.Color.White;
            this.grpFilter.Location = new System.Drawing.Point(0, 0);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(996, 52);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "PEPP-Filter";
            // 
            // picClearProc
            // 
            this.picClearProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClearProc.BackgroundImage = global::org.inek.PeppBrowser.Properties.Resources.peppo_exit;
            this.picClearProc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClearProc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClearProc.Location = new System.Drawing.Point(970, 24);
            this.picClearProc.Name = "picClearProc";
            this.picClearProc.Size = new System.Drawing.Size(15, 15);
            this.picClearProc.TabIndex = 19;
            this.picClearProc.TabStop = false;
            this.picClearProc.Visible = false;
            this.picClearProc.Click += new System.EventHandler(this.picClearProc_Click);
            // 
            // picClearSd
            // 
            this.picClearSd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClearSd.BackgroundImage = global::org.inek.PeppBrowser.Properties.Resources.peppo_exit;
            this.picClearSd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClearSd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClearSd.Location = new System.Drawing.Point(783, 24);
            this.picClearSd.Name = "picClearSd";
            this.picClearSd.Size = new System.Drawing.Size(15, 15);
            this.picClearSd.TabIndex = 18;
            this.picClearSd.TabStop = false;
            this.picClearSd.Visible = false;
            this.picClearSd.Click += new System.EventHandler(this.picClearSd_Click);
            // 
            // picClearHd
            // 
            this.picClearHd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClearHd.BackgroundImage = global::org.inek.PeppBrowser.Properties.Resources.peppo_exit;
            this.picClearHd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClearHd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClearHd.Location = new System.Drawing.Point(585, 24);
            this.picClearHd.Name = "picClearHd";
            this.picClearHd.Size = new System.Drawing.Size(15, 15);
            this.picClearHd.TabIndex = 17;
            this.picClearHd.TabStop = false;
            this.picClearHd.Visible = false;
            this.picClearHd.Click += new System.EventHandler(this.picClearHd_Click);
            // 
            // picClearSk
            // 
            this.picClearSk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClearSk.BackgroundImage = global::org.inek.PeppBrowser.Properties.Resources.peppo_exit;
            this.picClearSk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClearSk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClearSk.Location = new System.Drawing.Point(374, 25);
            this.picClearSk.Name = "picClearSk";
            this.picClearSk.Size = new System.Drawing.Size(15, 15);
            this.picClearSk.TabIndex = 16;
            this.picClearSk.TabStop = false;
            this.picClearSk.Visible = false;
            this.picClearSk.Click += new System.EventHandler(this.picClearSk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(804, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Prozedur:";
            // 
            // lblSecondaryDiagnosis
            // 
            this.lblSecondaryDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecondaryDiagnosis.AutoSize = true;
            this.lblSecondaryDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaryDiagnosis.Location = new System.Drawing.Point(606, 24);
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
            this.lblMainDiagnosis.Location = new System.Drawing.Point(411, 24);
            this.lblMainDiagnosis.Name = "lblMainDiagnosis";
            this.lblMainDiagnosis.Size = new System.Drawing.Size(82, 13);
            this.lblMainDiagnosis.TabIndex = 1;
            this.lblMainDiagnosis.Text = "Hauptdiagnose:";
            // 
            // lblSk
            // 
            this.lblSk.AutoSize = true;
            this.lblSk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSk.Location = new System.Drawing.Point(9, 25);
            this.lblSk.Name = "lblSk";
            this.lblSk.Size = new System.Drawing.Size(91, 13);
            this.lblSk.TabIndex = 8;
            this.lblSk.Text = "Strukturkategorie:";
            // 
            // cbxProcedure
            // 
            this.cbxProcedure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProcedure.Location = new System.Drawing.Point(863, 19);
            this.cbxProcedure.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbxProcedure.MinimumSize = new System.Drawing.Size(40, 21);
            this.cbxProcedure.MutltiLine = false;
            this.cbxProcedure.Name = "cbxProcedure";
            this.cbxProcedure.ReadOnly = true;
            this.cbxProcedure.Size = new System.Drawing.Size(100, 21);
            this.cbxProcedure.TabIndex = 15;
            this.cbxProcedure.ButtonClicked += new System.EventHandler(this.cbxProcedure_ButtonClicked);
            // 
            // cbxSecondaryDiagnosis
            // 
            this.cbxSecondaryDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSecondaryDiagnosis.Location = new System.Drawing.Point(697, 19);
            this.cbxSecondaryDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSecondaryDiagnosis.MinimumSize = new System.Drawing.Size(40, 21);
            this.cbxSecondaryDiagnosis.MutltiLine = false;
            this.cbxSecondaryDiagnosis.Name = "cbxSecondaryDiagnosis";
            this.cbxSecondaryDiagnosis.ReadOnly = true;
            this.cbxSecondaryDiagnosis.Size = new System.Drawing.Size(80, 21);
            this.cbxSecondaryDiagnosis.TabIndex = 3;
            this.cbxSecondaryDiagnosis.ButtonClicked += new System.EventHandler(this.cbxSecondaryDiagnosis_ButtonClicked);
            // 
            // cbxMainDiagnosis
            // 
            this.cbxMainDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMainDiagnosis.Location = new System.Drawing.Point(499, 19);
            this.cbxMainDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMainDiagnosis.MinimumSize = new System.Drawing.Size(30, 21);
            this.cbxMainDiagnosis.MutltiLine = false;
            this.cbxMainDiagnosis.Name = "cbxMainDiagnosis";
            this.cbxMainDiagnosis.ReadOnly = true;
            this.cbxMainDiagnosis.Size = new System.Drawing.Size(80, 21);
            this.cbxMainDiagnosis.TabIndex = 0;
            this.cbxMainDiagnosis.ButtonClicked += new System.EventHandler(this.cbxMainDiagnosis_ButtonClicked);
            // 
            // cbxSk
            // 
            this.cbxSk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSk.Location = new System.Drawing.Point(106, 20);
            this.cbxSk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSk.MinimumSize = new System.Drawing.Size(100, 21);
            this.cbxSk.MutltiLine = false;
            this.cbxSk.Name = "cbxSk";
            this.cbxSk.ReadOnly = true;
            this.cbxSk.Size = new System.Drawing.Size(262, 21);
            this.cbxSk.TabIndex = 9;
            this.cbxSk.ButtonClicked += new System.EventHandler(this.cbxSk_ButtonClicked);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.grpFilter);
            this.Name = "Selection";
            this.Size = new System.Drawing.Size(996, 52);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClearProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearSd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearHd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClearSk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblSk;
        private controls.CommonControls.ComboField cbxSk;
        private controls.CommonControls.ComboField cbxMainDiagnosis;
        private controls.CommonControls.ComboField cbxSecondaryDiagnosis;
        private System.Windows.Forms.Label lblSecondaryDiagnosis;
        private System.Windows.Forms.Label lblMainDiagnosis;
        private controls.CommonControls.ComboField cbxProcedure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picClearSk;
        private System.Windows.Forms.PictureBox picClearHd;
        private System.Windows.Forms.PictureBox picClearSd;
        private System.Windows.Forms.PictureBox picClearProc;


    }
}
