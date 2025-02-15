﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace org.inek.InekBrowser.GUI {
    public partial class FrmList : Form {

        public FrmList() {
            InitializeComponent();
            MaxColWitdh = 250;
            VisibleRows = 20;
        }

        public string SelectedItem {
            get; set;
        }

        public int DisplayCellValues {
            get; set;
        }

        /// <summary>
        /// The initial value of visible rows
        /// This value is used to calculate the inistial window size
        /// Thje user may resize the window
        /// </summary>
        public int VisibleRows { get; set; }

        /// <summary>
        /// Maximum width used whilst calculation a columns width
        /// The user may resize manually
        /// </summary>
        public int MaxColWitdh { get; set; }

        public bool MinimizeColumns {
            get { return grdData.MinimizeColumns; }
            set { grdData.MinimizeColumns = value; }
        }

        public void SetDataSource<T>(IEnumerable<T> source) {
            grdData.SetDataSource(source);
        }

        public DataTable DataSource {
            set {
                grdData.DataSource = value;
            }
        }

        public void FormatColumn(int colId, string format) {
            grdData.ColumnFormat(format, colId);
        }

        private void FormLoad(object sender, EventArgs e) {
            try {
                grdData.SizeGrid();
                if (grdData.TotalWidth + 16 > Screen.GetWorkingArea(this).Width) {
                    // if grid is to wide, limit col size to 200
                    grdData.SizeGrid(200, true);
                }
                Height = (grdData.RowHeight + 1) * Math.Min(VisibleRows, grdData.DataSource.Rows.Count) + 114;
                Width = Math.Min(Screen.GetWorkingArea(this).Width, grdData.TotalWidth + 16); // add 16 for border
                if (Left + Width > Screen.GetWorkingArea(this).Width) {
                    Left = Screen.GetWorkingArea(this).Width - Width;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
                Dispose();
        }

        public void ToolTips(string[] toolTips) {
            for (int i = 0; i < toolTips.Length; i++) {
                grdData.Columns[i].HeaderCell.ToolTipText = toolTips[i];
            }
        }

    }
}
