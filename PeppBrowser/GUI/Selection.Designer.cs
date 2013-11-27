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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pnlSplitter1 = new System.Windows.Forms.Panel();
            this.lblPEPP = new System.Windows.Forms.Label();
            this.cbxPepp = new org.inek.controls.CommonControls.ComboField();
            this.lblSk = new System.Windows.Forms.Label();
            this.cbxMk = new org.inek.controls.CommonControls.ComboField();
            this.lblMainDiagnosis = new System.Windows.Forms.Label();
            this.cbxMainDiagnosis = new org.inek.controls.CommonControls.ComboField();
            this.cbxSecondaryDiagnosis = new org.inek.controls.CommonControls.ComboField();
            this.lblSecondaryDiagnosis = new System.Windows.Forms.Label();
            this.cbxProcedure = new org.inek.controls.CommonControls.ComboField();
            this.lblProcedure = new System.Windows.Forms.Label();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.BackColor = System.Drawing.Color.Transparent;
            this.grpFilter.Controls.Add(this.splitContainer1);
            this.grpFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilter.Location = new System.Drawing.Point(3, 4);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(856, 78);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cbxProcedure);
            this.splitContainer1.Panel2.Controls.Add(this.lblProcedure);
            this.splitContainer1.Size = new System.Drawing.Size(856, 63);
            this.splitContainer1.SplitterDistance = 609;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel1.Controls.Add(this.pnlSplitter1);
            this.splitContainer2.Panel1.Controls.Add(this.lblPEPP);
            this.splitContainer2.Panel1.Controls.Add(this.cbxPepp);
            this.splitContainer2.Panel1.Controls.Add(this.lblSk);
            this.splitContainer2.Panel1.Controls.Add(this.cbxMk);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel2.Controls.Add(this.lblMainDiagnosis);
            this.splitContainer2.Panel2.Controls.Add(this.cbxMainDiagnosis);
            this.splitContainer2.Panel2.Controls.Add(this.cbxSecondaryDiagnosis);
            this.splitContainer2.Panel2.Controls.Add(this.lblSecondaryDiagnosis);
            this.splitContainer2.Size = new System.Drawing.Size(606, 58);
            this.splitContainer2.SplitterDistance = 295;
            this.splitContainer2.TabIndex = 13;
            // 
            // pnlSplitter1
            // 
            this.pnlSplitter1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlSplitter1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlSplitter1.Enabled = false;
            this.pnlSplitter1.Location = new System.Drawing.Point(-27, 9);
            this.pnlSplitter1.Name = "pnlSplitter1";
            this.pnlSplitter1.Size = new System.Drawing.Size(6, 46);
            this.pnlSplitter1.TabIndex = 16;
            // 
            // lblPEPP
            // 
            this.lblPEPP.AutoSize = true;
            this.lblPEPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPEPP.Location = new System.Drawing.Point(3, 36);
            this.lblPEPP.Name = "lblPEPP";
            this.lblPEPP.Size = new System.Drawing.Size(38, 13);
            this.lblPEPP.TabIndex = 6;
            this.lblPEPP.Text = "PEPP:";
            // 
            // cbxPepp
            // 
            this.cbxPepp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPepp.Location = new System.Drawing.Point(63, 32);
            this.cbxPepp.MinimumSize = new System.Drawing.Size(100, 21);
            this.cbxPepp.MutltiLine = false;
            this.cbxPepp.Name = "cbxPepp";
            this.cbxPepp.ReadOnly = false;
            this.cbxPepp.Size = new System.Drawing.Size(229, 22);
            this.cbxPepp.TabIndex = 7;
            // 
            // lblSk
            // 
            this.lblSk.AutoSize = true;
            this.lblSk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSk.Location = new System.Drawing.Point(3, 9);
            this.lblSk.Name = "lblSk";
            this.lblSk.Size = new System.Drawing.Size(24, 13);
            this.lblSk.TabIndex = 8;
            this.lblSk.Text = "SK:";
            // 
            // cbxMk
            // 
            this.cbxMk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMk.Location = new System.Drawing.Point(63, 6);
            this.cbxMk.MinimumSize = new System.Drawing.Size(100, 21);
            this.cbxMk.MutltiLine = false;
            this.cbxMk.Name = "cbxMk";
            this.cbxMk.ReadOnly = false;
            this.cbxMk.Size = new System.Drawing.Size(229, 22);
            this.cbxMk.TabIndex = 9;
            // 
            // lblMainDiagnosis
            // 
            this.lblMainDiagnosis.AutoSize = true;
            this.lblMainDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainDiagnosis.Location = new System.Drawing.Point(2, 9);
            this.lblMainDiagnosis.Name = "lblMainDiagnosis";
            this.lblMainDiagnosis.Size = new System.Drawing.Size(82, 13);
            this.lblMainDiagnosis.TabIndex = 1;
            this.lblMainDiagnosis.Text = "Hauptdiagnose:";
            // 
            // cbxMainDiagnosis
            // 
            this.cbxMainDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMainDiagnosis.Location = new System.Drawing.Point(90, 6);
            this.cbxMainDiagnosis.MinimumSize = new System.Drawing.Size(100, 21);
            this.cbxMainDiagnosis.MutltiLine = false;
            this.cbxMainDiagnosis.Name = "cbxMainDiagnosis";
            this.cbxMainDiagnosis.ReadOnly = false;
            this.cbxMainDiagnosis.Size = new System.Drawing.Size(214, 22);
            this.cbxMainDiagnosis.TabIndex = 0;
            // 
            // cbxSecondaryDiagnosis
            // 
            this.cbxSecondaryDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSecondaryDiagnosis.Location = new System.Drawing.Point(90, 32);
            this.cbxSecondaryDiagnosis.MinimumSize = new System.Drawing.Size(100, 21);
            this.cbxSecondaryDiagnosis.MutltiLine = false;
            this.cbxSecondaryDiagnosis.Name = "cbxSecondaryDiagnosis";
            this.cbxSecondaryDiagnosis.ReadOnly = false;
            this.cbxSecondaryDiagnosis.Size = new System.Drawing.Size(214, 22);
            this.cbxSecondaryDiagnosis.TabIndex = 3;
            // 
            // lblSecondaryDiagnosis
            // 
            this.lblSecondaryDiagnosis.AutoSize = true;
            this.lblSecondaryDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaryDiagnosis.Location = new System.Drawing.Point(2, 36);
            this.lblSecondaryDiagnosis.Name = "lblSecondaryDiagnosis";
            this.lblSecondaryDiagnosis.Size = new System.Drawing.Size(85, 13);
            this.lblSecondaryDiagnosis.TabIndex = 2;
            this.lblSecondaryDiagnosis.Text = "Nebendiagnose:";
            // 
            // cbxProcedure
            // 
            this.cbxProcedure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProcedure.Location = new System.Drawing.Point(62, 9);
            this.cbxProcedure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxProcedure.MinimumSize = new System.Drawing.Size(133, 0);
            this.cbxProcedure.MutltiLine = false;
            this.cbxProcedure.Name = "cbxProcedure";
            this.cbxProcedure.ReadOnly = false;
            this.cbxProcedure.Size = new System.Drawing.Size(174, 22);
            this.cbxProcedure.TabIndex = 15;
            // 
            // lblProcedure
            // 
            this.lblProcedure.AutoSize = true;
            this.lblProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedure.Location = new System.Drawing.Point(3, 11);
            this.lblProcedure.Name = "lblProcedure";
            this.lblProcedure.Size = new System.Drawing.Size(52, 13);
            this.lblProcedure.TabIndex = 14;
            this.lblProcedure.Text = "Prozedur:";
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.grpFilter);
            this.Name = "Selection";
            this.Size = new System.Drawing.Size(862, 86);
            this.grpFilter.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblPEPP;
        private controls.CommonControls.ComboField cbxPepp;
        private System.Windows.Forms.Label lblSk;
        private controls.CommonControls.ComboField cbxMk;
        private controls.CommonControls.ComboField cbxMainDiagnosis;
        private controls.CommonControls.ComboField cbxSecondaryDiagnosis;
        private System.Windows.Forms.Label lblSecondaryDiagnosis;
        private System.Windows.Forms.Label lblMainDiagnosis;
        private controls.CommonControls.ComboField cbxProcedure;
        private System.Windows.Forms.Label lblProcedure;
        private System.Windows.Forms.Panel pnlSplitter1;


    }
}
