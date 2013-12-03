namespace org.inek.PeppBrowser.GUI {
    partial class FrmList {
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
            this.grdData = new org.inek.controls.FilteredDataGridView.FilteredDataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grdData.DataSource = null;
            this.grdData.EnableInfo = false;
            this.grdData.ExtendColumns = false;
            this.grdData.FormatDecimal = "#,##0.00";
            this.grdData.FormatInteger = "#";
            this.grdData.FrozenCols = 0;
            this.grdData.KeepFilter = false;
            this.grdData.KeyColumns = null;
            this.grdData.Location = new System.Drawing.Point(12, 12);
            this.grdData.MaxColSize = 0;
            this.grdData.MinimizeColumns = false;
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersVisible = true;
            this.grdData.RowHeight = 18;
            this.grdData.Size = new System.Drawing.Size(458, 237);
            this.grdData.TabIndex = 0;
            this.grdData.ToolTipColumn = null;
            this.grdData.TranslationDictionarys = null;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(395, 255);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 290);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grdData);
            this.Name = "FrmList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmList";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private controls.FilteredDataGridView.FilteredDataGridView grdData;
        private System.Windows.Forms.Button btnOk;
    }
}