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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPepp = new org.inek.controls.CommonControls.ComboField();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEPP:";
            // 
            // cbxPepp
            // 
            this.cbxPepp.Location = new System.Drawing.Point(92, 124);
            this.cbxPepp.MinimumSize = new System.Drawing.Size(100, 21);
            this.cbxPepp.MutltiLine = false;
            this.cbxPepp.Name = "cbxPepp";
            this.cbxPepp.ReadOnly = false;
            this.cbxPepp.Size = new System.Drawing.Size(412, 21);
            this.cbxPepp.TabIndex = 1;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxPepp);
            this.Controls.Add(this.label1);
            this.Name = "Selection";
            this.Size = new System.Drawing.Size(577, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private controls.CommonControls.ComboField cbxPepp;
    }
}
