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
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cbxMk = new org.inek.controls.CommonControls.ComboField();
            this.lblMk = new System.Windows.Forms.Label();
            this.cbxPepp = new org.inek.controls.CommonControls.ComboField();
            this.lblPEPP = new System.Windows.Forms.Label();
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.cbxProfile = new System.Windows.Forms.ComboBox();
            this.lblPreDecision = new System.Windows.Forms.Label();
            this.cbxPreDecision = new org.inek.controls.CommonControls.ComboField();
            this.lblCode = new System.Windows.Forms.Label();
            this.cbxCode = new org.inek.controls.CommonControls.ComboField();
            this.grpFilter.SuspendLayout();
            this.grpProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.Controls.Add(this.cbxDepartment);
            this.grpFilter.Controls.Add(this.lblDepartment);
            this.grpFilter.Controls.Add(this.cbxMk);
            this.grpFilter.Controls.Add(this.lblMk);
            this.grpFilter.Controls.Add(this.cbxPepp);
            this.grpFilter.Controls.Add(this.lblPEPP);
            this.grpFilter.Location = new System.Drawing.Point(3, 3);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(465, 102);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(6, 73);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(54, 13);
            this.lblDepartment.TabIndex = 10;
            this.lblDepartment.Text = "Abteilung:";
            // 
            // cbxMk
            // 
            this.cbxMk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMk.Location = new System.Drawing.Point(66, 16);
            this.cbxMk.MinimumSize = new System.Drawing.Size(100, 21);
            this.cbxMk.MutltiLine = false;
            this.cbxMk.Name = "cbxMk";
            this.cbxMk.ReadOnly = false;
            this.cbxMk.Size = new System.Drawing.Size(393, 21);
            this.cbxMk.TabIndex = 9;
            // 
            // lblMk
            // 
            this.lblMk.AutoSize = true;
            this.lblMk.Location = new System.Drawing.Point(6, 20);
            this.lblMk.Name = "lblMk";
            this.lblMk.Size = new System.Drawing.Size(26, 13);
            this.lblMk.TabIndex = 8;
            this.lblMk.Text = "MK:";
            // 
            // cbxPepp
            // 
            this.cbxPepp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPepp.Location = new System.Drawing.Point(66, 43);
            this.cbxPepp.MinimumSize = new System.Drawing.Size(100, 21);
            this.cbxPepp.MutltiLine = false;
            this.cbxPepp.Name = "cbxPepp";
            this.cbxPepp.ReadOnly = false;
            this.cbxPepp.Size = new System.Drawing.Size(393, 21);
            this.cbxPepp.TabIndex = 7;
            // 
            // lblPEPP
            // 
            this.lblPEPP.AutoSize = true;
            this.lblPEPP.Location = new System.Drawing.Point(6, 47);
            this.lblPEPP.Name = "lblPEPP";
            this.lblPEPP.Size = new System.Drawing.Size(38, 13);
            this.lblPEPP.TabIndex = 6;
            this.lblPEPP.Text = "PEPP:";
            // 
            // grpProfile
            // 
            this.grpProfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grpProfile.Controls.Add(this.cbxCode);
            this.grpProfile.Controls.Add(this.lblCode);
            this.grpProfile.Controls.Add(this.cbxPreDecision);
            this.grpProfile.Controls.Add(this.lblPreDecision);
            this.grpProfile.Controls.Add(this.cbxProfile);
            this.grpProfile.Controls.Add(this.lblProfile);
            this.grpProfile.Location = new System.Drawing.Point(474, 3);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Size = new System.Drawing.Size(418, 102);
            this.grpProfile.TabIndex = 1;
            this.grpProfile.TabStop = false;
            this.grpProfile.Text = "Profil";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Items.AddRange(new object[] {
            "Hauptabteilung",
            "Belegabteilung",
            "Teilstationär"});
            this.cbxDepartment.Location = new System.Drawing.Point(66, 70);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(393, 21);
            this.cbxDepartment.TabIndex = 11;
            this.cbxDepartment.Text = "Hauptdiagnosen";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(6, 20);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(33, 13);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "Profil:";
            // 
            // cbxProfile
            // 
            this.cbxProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Items.AddRange(new object[] {
            "Hauptdiagnosen (HD)",
            "Nebendiagnosen (ND)",
            "Prozeduren (PR)"});
            this.cbxProfile.Location = new System.Drawing.Point(77, 17);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(335, 21);
            this.cbxProfile.TabIndex = 1;
            this.cbxProfile.Text = "Hauptdiagnosen (HD)";
            // 
            // lblPreDecision
            // 
            this.lblPreDecision.AutoSize = true;
            this.lblPreDecision.Location = new System.Drawing.Point(6, 47);
            this.lblPreDecision.Name = "lblPreDecision";
            this.lblPreDecision.Size = new System.Drawing.Size(65, 13);
            this.lblPreDecision.TabIndex = 2;
            this.lblPreDecision.Text = "Vorauswahl:";
            // 
            // cbxPreDecision
            // 
            this.cbxPreDecision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPreDecision.Location = new System.Drawing.Point(77, 43);
            this.cbxPreDecision.MinimumSize = new System.Drawing.Size(100, 21);
            this.cbxPreDecision.MutltiLine = false;
            this.cbxPreDecision.Name = "cbxPreDecision";
            this.cbxPreDecision.ReadOnly = false;
            this.cbxPreDecision.Size = new System.Drawing.Size(335, 21);
            this.cbxPreDecision.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 73);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Kode:";
            // 
            // cbxCode
            // 
            this.cbxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCode.Location = new System.Drawing.Point(77, 70);
            this.cbxCode.MinimumSize = new System.Drawing.Size(100, 21);
            this.cbxCode.MutltiLine = false;
            this.cbxCode.Name = "cbxCode";
            this.cbxCode.ReadOnly = false;
            this.cbxCode.Size = new System.Drawing.Size(335, 21);
            this.cbxCode.TabIndex = 5;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpProfile);
            this.Controls.Add(this.grpFilter);
            this.Name = "Selection";
            this.Size = new System.Drawing.Size(895, 111);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private controls.CommonControls.ComboField cbxMk;
        private System.Windows.Forms.Label lblMk;
        private controls.CommonControls.ComboField cbxPepp;
        private System.Windows.Forms.Label lblPEPP;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.ComboBox cbxProfile;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblCode;
        private controls.CommonControls.ComboField cbxPreDecision;
        private System.Windows.Forms.Label lblPreDecision;
        private controls.CommonControls.ComboField cbxCode;

    }
}
