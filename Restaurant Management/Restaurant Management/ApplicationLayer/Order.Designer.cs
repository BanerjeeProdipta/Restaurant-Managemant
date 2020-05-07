namespace Restaurant_Management.ApplicationLayer
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenuManage = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.tileBack = new MetroFramework.Controls.MetroTile();
            this.dgvOrder = new MetroFramework.Controls.MetroGrid();
            this.tileSearch = new MetroFramework.Controls.MetroTile();
            this.tileDelete = new MetroFramework.Controls.MetroTile();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddMenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenuManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuManage
            // 
            this.pnlMenuManage.Controls.Add(this.txtSearch);
            this.pnlMenuManage.Controls.Add(this.tileBack);
            this.pnlMenuManage.Controls.Add(this.dgvOrder);
            this.pnlMenuManage.Controls.Add(this.tileSearch);
            this.pnlMenuManage.Controls.Add(this.tileDelete);
            this.pnlMenuManage.HorizontalScrollbarBarColor = true;
            this.pnlMenuManage.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenuManage.HorizontalScrollbarSize = 12;
            this.pnlMenuManage.Location = new System.Drawing.Point(0, 5);
            this.pnlMenuManage.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuManage.Name = "pnlMenuManage";
            this.pnlMenuManage.Size = new System.Drawing.Size(1067, 549);
            this.pnlMenuManage.TabIndex = 1;
            this.pnlMenuManage.VerticalScrollbarBarColor = true;
            this.pnlMenuManage.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMenuManage.VerticalScrollbarSize = 13;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(455, 80);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(114, 23);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileBack
            // 
            this.tileBack.ActiveControl = null;
            this.tileBack.Location = new System.Drawing.Point(4, 4);
            this.tileBack.Margin = new System.Windows.Forms.Padding(4);
            this.tileBack.Name = "tileBack";
            this.tileBack.Size = new System.Drawing.Size(32, 42);
            this.tileBack.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileBack.TabIndex = 15;
            this.tileBack.Text = "<";
            this.tileBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tileBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileBack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileBack.UseSelectable = true;
            this.tileBack.Click += new System.EventHandler(this.TileBack_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AddMenuName,
            this.Table_Seat,
            this.Quantity,
            this.Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOrder.Location = new System.Drawing.Point(18, 135);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(688, 396);
            this.dgvOrder.Style = MetroFramework.MetroColorStyle.Purple;
            this.dgvOrder.TabIndex = 13;
            // 
            // tileSearch
            // 
            this.tileSearch.ActiveControl = null;
            this.tileSearch.Location = new System.Drawing.Point(343, 71);
            this.tileSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tileSearch.Name = "tileSearch";
            this.tileSearch.Size = new System.Drawing.Size(71, 43);
            this.tileSearch.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileSearch.TabIndex = 12;
            this.tileSearch.Text = "Search";
            this.tileSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSearch.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileSearch.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSearch.UseSelectable = true;
            this.tileSearch.Click += new System.EventHandler(this.TileSearch_Click);
            // 
            // tileDelete
            // 
            this.tileDelete.ActiveControl = null;
            this.tileDelete.Location = new System.Drawing.Point(219, 71);
            this.tileDelete.Margin = new System.Windows.Forms.Padding(4);
            this.tileDelete.Name = "tileDelete";
            this.tileDelete.Size = new System.Drawing.Size(71, 43);
            this.tileDelete.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileDelete.TabIndex = 11;
            this.tileDelete.Text = "Delete";
            this.tileDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDelete.UseSelectable = true;
            this.tileDelete.Click += new System.EventHandler(this.TileDelete_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "AppId";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // AddMenuName
            // 
            this.AddMenuName.DataPropertyName = "Item";
            this.AddMenuName.HeaderText = "Name";
            this.AddMenuName.MinimumWidth = 6;
            this.AddMenuName.Name = "AddMenuName";
            this.AddMenuName.ReadOnly = true;
            this.AddMenuName.Width = 125;
            // 
            // Table_Seat
            // 
            this.Table_Seat.DataPropertyName = "Table_Seat";
            this.Table_Seat.HeaderText = "Table";
            this.Table_Seat.MinimumWidth = 6;
            this.Table_Seat.Name = "Table_Seat";
            this.Table_Seat.ReadOnly = true;
            this.Table_Seat.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlMenuManage);
            this.Name = "Order";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.pnlMenuManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMenuManage;
        private MetroFramework.Controls.MetroTile tileBack;
        private MetroFramework.Controls.MetroGrid dgvOrder;
        private MetroFramework.Controls.MetroTile tileSearch;
        private MetroFramework.Controls.MetroTile tileDelete;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddMenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}