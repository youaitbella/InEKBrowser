namespace org.inek.PeppBrowser.GUI {
    partial class TitleBar {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleBar));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlFormStates = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage")));
            this.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(296, 30);
            this.pnlTitle.TabIndex = 3;
            // 
            // pnlFormStates
            // 
            this.pnlFormStates.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormStates.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFormStates.BackgroundImage")));
            this.pnlFormStates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFormStates.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFormStates.Location = new System.Drawing.Point(671, 0);
            this.pnlFormStates.Name = "pnlFormStates";
            this.pnlFormStates.Size = new System.Drawing.Size(197, 30);
            this.pnlFormStates.TabIndex = 0;
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.pnlFormStates);
            this.Controls.Add(this.pnlTitle);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(868, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlFormStates;
    }
}
