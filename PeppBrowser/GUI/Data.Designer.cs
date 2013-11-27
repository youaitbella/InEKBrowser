namespace org.inek.PeppBrowser.GUI {
    partial class Data {
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
            this.pnlData = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlData.ForeColor = System.Drawing.Color.White;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(976, 248);
            this.pnlData.TabIndex = 0;
            this.pnlData.TabStop = false;
            this.pnlData.Text = "Daten";
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.pnlData);
            this.Name = "Data";
            this.Size = new System.Drawing.Size(976, 248);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlData;
    }
}
