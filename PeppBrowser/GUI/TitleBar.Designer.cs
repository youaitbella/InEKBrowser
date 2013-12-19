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
            this.lblTitle = new System.Windows.Forms.Label();
            this.picInEK = new System.Windows.Forms.PictureBox();
            this.pnlFormStates = new System.Windows.Forms.Panel();
            this.picIconify = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picMinMax = new System.Windows.Forms.PictureBox();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInEK)).BeginInit();
            this.pnlFormStates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinMax)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage")));
            this.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.picInEK);
            this.pnlTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(243, 30);
            this.pnlTitle.TabIndex = 3;
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(35, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PEPP Browser 2014";
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            // 
            // picInEK
            // 
            this.picInEK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picInEK.BackgroundImage")));
            this.picInEK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picInEK.Location = new System.Drawing.Point(3, 3);
            this.picInEK.Name = "picInEK";
            this.picInEK.Size = new System.Drawing.Size(26, 25);
            this.picInEK.TabIndex = 0;
            this.picInEK.TabStop = false;
            // 
            // pnlFormStates
            // 
            this.pnlFormStates.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormStates.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFormStates.BackgroundImage")));
            this.pnlFormStates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFormStates.Controls.Add(this.picIconify);
            this.pnlFormStates.Controls.Add(this.picExit);
            this.pnlFormStates.Controls.Add(this.picMinMax);
            this.pnlFormStates.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFormStates.Location = new System.Drawing.Point(781, 0);
            this.pnlFormStates.Name = "pnlFormStates";
            this.pnlFormStates.Size = new System.Drawing.Size(87, 30);
            this.pnlFormStates.TabIndex = 0;
            this.pnlFormStates.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFormStates_MouseMove);
            // 
            // picIconify
            // 
            this.picIconify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIconify.BackgroundImage")));
            this.picIconify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIconify.Location = new System.Drawing.Point(13, 7);
            this.picIconify.Name = "picIconify";
            this.picIconify.Size = new System.Drawing.Size(18, 18);
            this.picIconify.TabIndex = 2;
            this.picIconify.TabStop = false;
            this.picIconify.Click += new System.EventHandler(this.picIconify_Click);
            this.picIconify.MouseEnter += new System.EventHandler(this.picIconify_MouseEnter);
            this.picIconify.MouseLeave += new System.EventHandler(this.picIconify_MouseLeave);
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(62, 7);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(18, 18);
            this.picExit.TabIndex = 1;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // picMinMax
            // 
            this.picMinMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMinMax.BackgroundImage")));
            this.picMinMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMinMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinMax.Location = new System.Drawing.Point(37, 7);
            this.picMinMax.Name = "picMinMax";
            this.picMinMax.Size = new System.Drawing.Size(18, 18);
            this.picMinMax.TabIndex = 0;
            this.picMinMax.TabStop = false;
            this.picMinMax.Click += new System.EventHandler(this.picMinMax_Click);
            this.picMinMax.MouseEnter += new System.EventHandler(this.picMinMax_MouseEnter);
            this.picMinMax.MouseLeave += new System.EventHandler(this.picMinMax_MouseLeave);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.pnlFormStates);
            this.Controls.Add(this.pnlTitle);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(868, 30);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInEK)).EndInit();
            this.pnlFormStates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlFormStates;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picMinMax;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picIconify;
        private System.Windows.Forms.PictureBox picInEK;
    }
}
