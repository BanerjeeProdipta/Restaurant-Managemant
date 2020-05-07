namespace Restaurant_Management.ApplicationLayer
{
    partial class AdminFinancial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dgvFinancial = new MetroFramework.Controls.MetroGrid();
            this.AppId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFinance = new MetroFramework.Controls.MetroLabel();
            this.tileBack = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancial)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tileBack);
            this.metroPanel1.Controls.Add(this.lblFinance);
            this.metroPanel1.Controls.Add(this.dgvFinancial);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-7, 8);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1056, 540);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dgvFinancial
            // 
            this.dgvFinancial.AllowUserToAddRows = false;
            this.dgvFinancial.AllowUserToDeleteRows = false;
            this.dgvFinancial.AllowUserToResizeRows = false;
            this.dgvFinancial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFinancial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinancial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFinancial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinancial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFinancial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinancial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppId,
            this.OrderId,
            this.Table_Seat,
            this.Bill});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinancial.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFinancial.EnableHeadersVisualStyles = false;
            this.dgvFinancial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvFinancial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFinancial.Location = new System.Drawing.Point(50, 141);
            this.dgvFinancial.Name = "dgvFinancial";
            this.dgvFinancial.ReadOnly = true;
            this.dgvFinancial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinancial.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFinancial.RowHeadersWidth = 51;
            this.dgvFinancial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFinancial.RowTemplate.Height = 24;
            this.dgvFinancial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinancial.Size = new System.Drawing.Size(554, 332);
            this.dgvFinancial.TabIndex = 2;
            // 
            // AppId
            // 
            this.AppId.DataPropertyName = "AppId";
            this.AppId.HeaderText = "Id";
            this.AppId.MinimumWidth = 6;
            this.AppId.Name = "AppId";
            this.AppId.ReadOnly = true;
            this.AppId.Width = 125;
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "OrderId";
            this.OrderId.MinimumWidth = 6;
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 125;
            // 
            // Table_Seat
            // 
            this.Table_Seat.DataPropertyName = "Table";
            this.Table_Seat.HeaderText = "Table";
            this.Table_Seat.MinimumWidth = 6;
            this.Table_Seat.Name = "Table_Seat";
            this.Table_Seat.ReadOnly = true;
            this.Table_Seat.Width = 125;
            // 
            // Bill
            // 
            this.Bill.DataPropertyName = "Bill";
            this.Bill.HeaderText = "Bill";
            this.Bill.MinimumWidth = 6;
            this.Bill.Name = "Bill";
            this.Bill.ReadOnly = true;
            this.Bill.Width = 125;
            // 
            // lblFinance
            // 
            this.lblFinance.AutoSize = true;
            this.lblFinance.Location = new System.Drawing.Point(50, 88);
            this.lblFinance.Name = "lblFinance";
            this.lblFinance.Size = new System.Drawing.Size(136, 20);
            this.lblFinance.TabIndex = 3;
            this.lblFinance.Text = "Financial Information";
            // 
            // tileBack
            // 
            this.tileBack.ActiveControl = null;
            this.tileBack.Location = new System.Drawing.Point(18, 4);
            this.tileBack.Margin = new System.Windows.Forms.Padding(4);
            this.tileBack.Name = "tileBack";
            this.tileBack.Size = new System.Drawing.Size(32, 42);
            this.tileBack.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileBack.TabIndex = 19;
            this.tileBack.Text = "<";
            this.tileBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tileBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileBack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileBack.UseSelectable = true;
            this.tileBack.Click += new System.EventHandler(this.TileBack_Click);
            // 
            // AdminFinancial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 554);
            this.Controls.Add(this.metroPanel1);
            this.Name = "AdminFinancial";
            this.Text = "AdminFinancial";
            this.Load += new System.EventHandler(this.AdminFinancial_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgvFinancial;
        private MetroFramework.Controls.MetroLabel lblFinance;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill;
        private MetroFramework.Controls.MetroTile tileBack;
    }
}