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
            this.cbxProcedure = new org.inek.controls.CommonControls.ComboField();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSecondaryDiagnosis = new org.inek.controls.CommonControls.ComboField();
            this.lblSecondaryDiagnosis = new System.Windows.Forms.Label();
            this.lblMainDiagnosis = new System.Windows.Forms.Label();
            this.cbxMainDiagnosis = new org.inek.controls.CommonControls.ComboField();
            this.cbxSk = new org.inek.controls.CommonControls.ComboField();
            this.lblSk = new System.Windows.Forms.Label();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFilter
            // 
            this.grpFilter.BackColor = System.Drawing.Color.SeaGreen;
            this.grpFilter.Controls.Add(this.cbxProcedure);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Controls.Add(this.cbxSecondaryDiagnosis);
            this.grpFilter.Controls.Add(this.lblSecondaryDiagnosis);
            this.grpFilter.Controls.Add(this.lblMainDiagnosis);
            this.grpFilter.Controls.Add(this.cbxMainDiagnosis);
            this.grpFilter.Controls.Add(this.cbxSk);
            this.grpFilter.Controls.Add(this.lblSk);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpFilter.ForeColor = System.Drawing.Color.White;
            this.grpFilter.Location = new System.Drawing.Point(0, 0);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(974, 52);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "PEPP-Filter";
            // 
            // cbxProcedure
            // 
            this.cbxProcedure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProcedure.Location = new System.Drawing.Point(864, 20);
            this.cbxProcedure.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbxProcedure.MinimumSize = new System.Drawing.Size(40, 21);
            this.cbxProcedure.MutltiLine = false;
            this.cbxProcedure.Name = "cbxProcedure";
            this.cbxProcedure.ReadOnly = false;
            this.cbxProcedure.Size = new System.Drawing.Size(100, 21);
            this.cbxProcedure.TabIndex = 15;
            this.cbxProcedure.ButtonClicked += new System.EventHandler(this.cbxProcedure_ButtonClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(805, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Prozedur:";
            // 
            // cbxSecondaryDiagnosis
            // 
            this.cbxSecondaryDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSecondaryDiagnosis.Location = new System.Drawing.Point(699, 20);
            this.cbxSecondaryDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSecondaryDiagnosis.MinimumSize = new System.Drawing.Size(40, 21);
            this.cbxSecondaryDiagnosis.MutltiLine = false;
            this.cbxSecondaryDiagnosis.Name = "cbxSecondaryDiagnosis";
            this.cbxSecondaryDiagnosis.ReadOnly = false;
            this.cbxSecondaryDiagnosis.Size = new System.Drawing.Size(100, 21);
            this.cbxSecondaryDiagnosis.TabIndex = 3;
            this.cbxSecondaryDiagnosis.ButtonClicked += new System.EventHandler(this.cbxSecondaryDiagnosis_ButtonClicked);
            // 
            // lblSecondaryDiagnosis
            // 
            this.lblSecondaryDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecondaryDiagnosis.AutoSize = true;
            this.lblSecondaryDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaryDiagnosis.Location = new System.Drawing.Point(608, 23);
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
            this.lblMainDiagnosis.Location = new System.Drawing.Point(414, 23);
            this.lblMainDiagnosis.Name = "lblMainDiagnosis";
            this.lblMainDiagnosis.Size = new System.Drawing.Size(82, 13);
            this.lblMainDiagnosis.TabIndex = 1;
            this.lblMainDiagnosis.Text = "Hauptdiagnose:";
            // 
            // cbxMainDiagnosis
            // 
            this.cbxMainDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMainDiagnosis.Location = new System.Drawing.Point(502, 20);
            this.cbxMainDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMainDiagnosis.MinimumSize = new System.Drawing.Size(40, 21);
            this.cbxMainDiagnosis.MutltiLine = false;
            this.cbxMainDiagnosis.Name = "cbxMainDiagnosis";
            this.cbxMainDiagnosis.ReadOnly = false;
            this.cbxMainDiagnosis.Size = new System.Drawing.Size(100, 21);
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
            this.cbxSk.ReadOnly = false;
            this.cbxSk.Size = new System.Drawing.Size(297, 21);
            this.cbxSk.TabIndex = 9;
            this.cbxSk.ButtonClicked += new System.EventHandler(this.cbxSk_ButtonClicked);
            // 
            // lblSk
            // 
            this.lblSk.AutoSize = true;
            this.lblSk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSk.Location = new System.Drawing.Point(9, 23);
            this.lblSk.Name = "lblSk";
            this.lblSk.Size = new System.Drawing.Size(91, 13);
            this.lblSk.TabIndex = 8;
            this.lblSk.Text = "Strukturkategorie:";
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.grpFilter);
            this.Name = "Selection";
            this.Size = new System.Drawing.Size(974, 52);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
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


    }
}
