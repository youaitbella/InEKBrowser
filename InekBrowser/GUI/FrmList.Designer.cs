namespace org.inek.InekBrowser.GUI {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewRow dataGridViewRow1 = new System.Windows.Forms.DataGridViewRow();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmList));
            this.btnOk = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.grdData = new org.inek.controls.FilteredDataGridView.FilteredDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(395, 255);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Abbrechen";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.grdData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.Autosizing = false;
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grdData.ColumnCount = 0;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdData.DataSource = null;
            this.grdData.EnableInfo = false;
            this.grdData.ExtendColumns = false;
            this.grdData.FirstDisplayedCell = null;
            this.grdData.FormatDecimal = "#,##0.00";
            this.grdData.FormatDouble = "#,##0";
            this.grdData.FormatInteger = "#";
            this.grdData.FrozenCols = 0;
            this.grdData.GridColor = System.Drawing.SystemColors.Control;
            this.grdData.HighlightCellBackColor = System.Drawing.Color.Yellow;
            this.grdData.Highlightmode = org.inek.controls.CommonControls.InekDataGridView.HighlightMode.Row;
            this.grdData.InfoAutomaticMode = org.inek.controls.FilteredDataGridView.FilteredDataGridView.InfoAutoMode.None;
            this.grdData.KeepFilter = false;
            this.grdData.KeyColumns = null;
            this.grdData.Location = new System.Drawing.Point(12, 12);
            this.grdData.MaxColSize = 0;
            this.grdData.MinimizeColumns = false;
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersVisible = true;
            this.grdData.RowHeight = 18;
            dataGridViewRow1.Height = 18;
            this.grdData.RowTemplate = dataGridViewRow1;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(458, 237);
            this.grdData.SuspendFormat = false;
            this.grdData.TabIndex = 0;
            this.grdData.ToolTipColumn = null;
            this.grdData.TranslationDictionarys = null;
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 290);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grdData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmList";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private controls.FilteredDataGridView.FilteredDataGridView grdData;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.HelpProvider helpProvider1;
    }
}