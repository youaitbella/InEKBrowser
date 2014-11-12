namespace org.inek.InekBrowser.GUI {
    partial class FrmSplash {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.grpPanel = new System.Windows.Forms.GroupBox();
            this.lblProgressState = new System.Windows.Forms.Label();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.titleBar = new org.inek.InekBrowser.GUI.TitleBar();
            this.grpPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPanel
            // 
            this.grpPanel.Controls.Add(this.lblProgressState);
            this.grpPanel.Controls.Add(this.prgBar);
            this.grpPanel.Controls.Add(this.groupBox2);
            this.grpPanel.Controls.Add(this.pictureBox1);
            this.grpPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpPanel.Location = new System.Drawing.Point(0, 30);
            this.grpPanel.Name = "grpPanel";
            this.grpPanel.Size = new System.Drawing.Size(325, 468);
            this.grpPanel.TabIndex = 3;
            this.grpPanel.TabStop = false;
            // 
            // lblProgressState
            // 
            this.lblProgressState.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressState.ForeColor = System.Drawing.Color.White;
            this.lblProgressState.Location = new System.Drawing.Point(12, 408);
            this.lblProgressState.Name = "lblProgressState";
            this.lblProgressState.Size = new System.Drawing.Size(299, 23);
            this.lblProgressState.TabIndex = 5;
            this.lblProgressState.Text = "Lade Kostenbereich...";
            this.lblProgressState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgBar
            // 
            this.prgBar.BackColor = System.Drawing.SystemColors.Control;
            this.prgBar.ForeColor = System.Drawing.SystemColors.Control;
            this.prgBar.Location = new System.Drawing.Point(13, 434);
            this.prgBar.Maximum = 90;
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(298, 23);
            this.prgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 72);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code-Browser\r\nVersion 2014.1\r\n© InEK GmbH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 308);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.SteelBlue;
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.MinMaxImage = ((System.Drawing.Image)(resources.GetObject("titleBar.MinMaxImage")));
            this.titleBar.Name = "titleBar";
            this.titleBar.ShowIconify = false;
            this.titleBar.ShowMinMax = false;
            this.titleBar.Size = new System.Drawing.Size(325, 30);
            this.titleBar.TabIndex = 4;
            this.titleBar.ClickedExit += new System.EventHandler(this.titleBar_ClickedExit);
            this.titleBar.MouseMoveTitleBar += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(325, 498);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.grpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplash";
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            this.Shown += new System.EventHandler(this.FrmSplash_Shown);
            this.grpPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Label lblProgressState;
        private TitleBar titleBar;

    }
}