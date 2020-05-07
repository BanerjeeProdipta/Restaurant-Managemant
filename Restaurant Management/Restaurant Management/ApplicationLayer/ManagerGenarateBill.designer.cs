namespace Restaurant_Management.ApplicationLayer
{
    partial class ManagerGenarateBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dgvOrder = new MetroFramework.Controls.MetroGrid();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.tileBack = new MetroFramework.Controls.MetroTile();
            this.txtBill = new MetroFramework.Controls.MetroTextBox();
            this.lblBill = new MetroFramework.Controls.MetroLabel();
            this.txtOrderId = new MetroFramework.Controls.MetroTextBox();
            this.txtTable = new MetroFramework.Controls.MetroTextBox();
            this.lblOrderId = new MetroFramework.Controls.MetroLabel();
            this.lblTable = new MetroFramework.Controls.MetroLabel();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChoose = new MetroFramework.Controls.MetroButton();
            this.btnPay = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnChoose);
            this.metroPanel1.Controls.Add(this.dgvOrder);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(0, 6);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1071, 550);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.FoodName,
            this.Table_Seat,
            this.Quantity,
            this.Price});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOrder.Location = new System.Drawing.Point(312, 8);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(724, 467);
            this.dgvOrder.Style = MetroFramework.MetroColorStyle.Brown;
            this.dgvOrder.TabIndex = 3;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnPay);
            this.metroPanel2.Controls.Add(this.tileBack);
            this.metroPanel2.Controls.Add(this.txtBill);
            this.metroPanel2.Controls.Add(this.lblBill);
            this.metroPanel2.Controls.Add(this.txtOrderId);
            this.metroPanel2.Controls.Add(this.txtTable);
            this.metroPanel2.Controls.Add(this.lblOrderId);
            this.metroPanel2.Controls.Add(this.lblTable);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 12;
            this.metroPanel2.Location = new System.Drawing.Point(1, 4);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(303, 546);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 13;
            // 
            // tileBack
            // 
            this.tileBack.ActiveControl = null;
            this.tileBack.Location = new System.Drawing.Point(4, 4);
            this.tileBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tileBack.Name = "tileBack";
            this.tileBack.Size = new System.Drawing.Size(32, 42);
            this.tileBack.Style = MetroFramework.MetroColorStyle.Brown;
            this.tileBack.TabIndex = 16;
            this.tileBack.Text = "<";
            this.tileBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tileBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileBack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileBack.UseSelectable = true;
            this.tileBack.Click += new System.EventHandler(this.TileBack_Click);
            // 
            // txtBill
            // 
            // 
            // 
            // 
            this.txtBill.CustomButton.Image = null;
            this.txtBill.CustomButton.Location = new System.Drawing.Point(297, 2);
            this.txtBill.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBill.CustomButton.Name = "";
            this.txtBill.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtBill.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBill.CustomButton.TabIndex = 1;
            this.txtBill.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBill.CustomButton.UseSelectable = true;
            this.txtBill.CustomButton.Visible = false;
            this.txtBill.Lines = new string[0];
            this.txtBill.Location = new System.Drawing.Point(29, 390);
            this.txtBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBill.MaxLength = 32767;
            this.txtBill.Name = "txtBill";
            this.txtBill.PasswordChar = '\0';
            this.txtBill.ReadOnly = true;
            this.txtBill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBill.SelectedText = "";
            this.txtBill.SelectionLength = 0;
            this.txtBill.SelectionStart = 0;
            this.txtBill.ShortcutsEnabled = true;
            this.txtBill.Size = new System.Drawing.Size(249, 28);
            this.txtBill.TabIndex = 7;
            this.txtBill.UseSelectable = true;
            this.txtBill.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBill.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(31, 336);
            this.lblBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(26, 20);
            this.lblBill.TabIndex = 6;
            this.lblBill.Text = "Bill";
            // 
            // txtOrderId
            // 
            // 
            // 
            // 
            this.txtOrderId.CustomButton.Image = null;
            this.txtOrderId.CustomButton.Location = new System.Drawing.Point(297, 2);
            this.txtOrderId.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrderId.CustomButton.Name = "";
            this.txtOrderId.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtOrderId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrderId.CustomButton.TabIndex = 1;
            this.txtOrderId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrderId.CustomButton.UseSelectable = true;
            this.txtOrderId.CustomButton.Visible = false;
            this.txtOrderId.Lines = new string[0];
            this.txtOrderId.Location = new System.Drawing.Point(29, 277);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrderId.MaxLength = 32767;
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.PasswordChar = '\0';
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderId.SelectedText = "";
            this.txtOrderId.SelectionLength = 0;
            this.txtOrderId.SelectionStart = 0;
            this.txtOrderId.ShortcutsEnabled = true;
            this.txtOrderId.Size = new System.Drawing.Size(249, 28);
            this.txtOrderId.TabIndex = 5;
            this.txtOrderId.UseSelectable = true;
            this.txtOrderId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTable
            // 
            // 
            // 
            // 
            this.txtTable.CustomButton.Image = null;
            this.txtTable.CustomButton.Location = new System.Drawing.Point(297, 2);
            this.txtTable.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTable.CustomButton.Name = "";
            this.txtTable.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtTable.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTable.CustomButton.TabIndex = 1;
            this.txtTable.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTable.CustomButton.UseSelectable = true;
            this.txtTable.CustomButton.Visible = false;
            this.txtTable.Lines = new string[0];
            this.txtTable.Location = new System.Drawing.Point(29, 164);
            this.txtTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTable.MaxLength = 32767;
            this.txtTable.Name = "txtTable";
            this.txtTable.PasswordChar = '\0';
            this.txtTable.ReadOnly = true;
            this.txtTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTable.SelectedText = "";
            this.txtTable.SelectionLength = 0;
            this.txtTable.SelectionStart = 0;
            this.txtTable.ShortcutsEnabled = true;
            this.txtTable.Size = new System.Drawing.Size(249, 28);
            this.txtTable.TabIndex = 4;
            this.txtTable.UseSelectable = true;
            this.txtTable.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTable.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(31, 223);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(61, 20);
            this.lblOrderId.TabIndex = 3;
            this.lblOrderId.Text = "Order Id";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(31, 110);
            this.lblTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(41, 20);
            this.lblTable.TabIndex = 2;
            this.lblTable.Text = "Table";
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "AppId";
            this.OrderId.HeaderText = "Id";
            this.OrderId.MinimumWidth = 6;
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 125;
            // 
            // FoodName
            // 
            this.FoodName.DataPropertyName = "Item";
            this.FoodName.HeaderText = "Item";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            this.FoodName.Width = 125;
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
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(922, 497);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(82, 31);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseSelectable = true;
            this.btnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(101, 470);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(82, 31);
            this.btnPay.TabIndex = 17;
            this.btnPay.Text = "Pay";
            this.btnPay.UseSelectable = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // ManagerGenarateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerGenarateBill";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "ManagerGenarateBill";
            this.Load += new System.EventHandler(this.ManagerGenarateBill_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtBill;
        private MetroFramework.Controls.MetroLabel lblBill;
        private MetroFramework.Controls.MetroTextBox txtOrderId;
        private MetroFramework.Controls.MetroTextBox txtTable;
        private MetroFramework.Controls.MetroLabel lblOrderId;
        private MetroFramework.Controls.MetroLabel lblTable;
        private MetroFramework.Controls.MetroTile tileBack;
        private MetroFramework.Controls.MetroGrid dgvOrder;
        private MetroFramework.Controls.MetroButton btnChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private MetroFramework.Controls.MetroButton btnPay;
    }
}