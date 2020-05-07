namespace Restaurant_Management.ApplicationLayer
{
    partial class Menu
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
            this.pnlAddMenu = new MetroFramework.Controls.MetroPanel();
            this.txtMenuPrice = new MetroFramework.Controls.MetroTextBox();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.cmbMenuCategory = new MetroFramework.Controls.MetroComboBox();
            this.lblCatagory = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tileSave = new MetroFramework.Controls.MetroTile();
            this.txtMenuName = new MetroFramework.Controls.MetroTextBox();
            this.txtMenuId = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.dgvMenu = new MetroFramework.Controls.MetroGrid();
            this.tileSearch = new MetroFramework.Controls.MetroTile();
            this.tileDelete = new MetroFramework.Controls.MetroTile();
            this.tileAdd = new MetroFramework.Controls.MetroTile();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddMenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenuManage.SuspendLayout();
            this.pnlAddMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuManage
            // 
            this.pnlMenuManage.Controls.Add(this.txtSearch);
            this.pnlMenuManage.Controls.Add(this.tileBack);
            this.pnlMenuManage.Controls.Add(this.pnlAddMenu);
            this.pnlMenuManage.Controls.Add(this.dgvMenu);
            this.pnlMenuManage.Controls.Add(this.tileSearch);
            this.pnlMenuManage.Controls.Add(this.tileDelete);
            this.pnlMenuManage.Controls.Add(this.tileAdd);
            this.pnlMenuManage.HorizontalScrollbarBarColor = true;
            this.pnlMenuManage.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenuManage.HorizontalScrollbarSize = 12;
            this.pnlMenuManage.Location = new System.Drawing.Point(2, 6);
            this.pnlMenuManage.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuManage.Name = "pnlMenuManage";
            this.pnlMenuManage.Size = new System.Drawing.Size(1067, 549);
            this.pnlMenuManage.TabIndex = 0;
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
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(865, 82);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(144, 23);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Click += new System.EventHandler(this.TxtSearch_Click);
            // 
            // tileBack
            // 
            this.tileBack.ActiveControl = null;
            this.tileBack.Location = new System.Drawing.Point(4, 4);
            this.tileBack.Margin = new System.Windows.Forms.Padding(4);
            this.tileBack.Name = "tileBack";
            this.tileBack.Size = new System.Drawing.Size(32, 42);
            this.tileBack.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileBack.TabIndex = 15;
            this.tileBack.Text = "<";
            this.tileBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tileBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileBack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileBack.UseSelectable = true;
            this.tileBack.Click += new System.EventHandler(this.TileBack_Click);
            // 
            // pnlAddMenu
            // 
            this.pnlAddMenu.Controls.Add(this.txtMenuPrice);
            this.pnlAddMenu.Controls.Add(this.lblPrice);
            this.pnlAddMenu.Controls.Add(this.cmbMenuCategory);
            this.pnlAddMenu.Controls.Add(this.lblCatagory);
            this.pnlAddMenu.Controls.Add(this.metroLabel1);
            this.pnlAddMenu.Controls.Add(this.tileSave);
            this.pnlAddMenu.Controls.Add(this.txtMenuName);
            this.pnlAddMenu.Controls.Add(this.txtMenuId);
            this.pnlAddMenu.Controls.Add(this.lblName);
            this.pnlAddMenu.Controls.Add(this.lblId);
            this.pnlAddMenu.HorizontalScrollbarBarColor = true;
            this.pnlAddMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAddMenu.HorizontalScrollbarSize = 12;
            this.pnlAddMenu.Location = new System.Drawing.Point(4, 85);
            this.pnlAddMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddMenu.Name = "pnlAddMenu";
            this.pnlAddMenu.Size = new System.Drawing.Size(423, 460);
            this.pnlAddMenu.TabIndex = 14;
            this.pnlAddMenu.VerticalScrollbarBarColor = true;
            this.pnlAddMenu.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAddMenu.VerticalScrollbarSize = 13;
            // 
            // txtMenuPrice
            // 
            // 
            // 
            // 
            this.txtMenuPrice.CustomButton.Image = null;
            this.txtMenuPrice.CustomButton.Location = new System.Drawing.Point(207, 2);
            this.txtMenuPrice.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMenuPrice.CustomButton.Name = "";
            this.txtMenuPrice.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMenuPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMenuPrice.CustomButton.TabIndex = 1;
            this.txtMenuPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMenuPrice.CustomButton.UseSelectable = true;
            this.txtMenuPrice.CustomButton.Visible = false;
            this.txtMenuPrice.Lines = new string[0];
            this.txtMenuPrice.Location = new System.Drawing.Point(145, 277);
            this.txtMenuPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtMenuPrice.MaxLength = 32767;
            this.txtMenuPrice.Name = "txtMenuPrice";
            this.txtMenuPrice.PasswordChar = '\0';
            this.txtMenuPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMenuPrice.SelectedText = "";
            this.txtMenuPrice.SelectionLength = 0;
            this.txtMenuPrice.SelectionStart = 0;
            this.txtMenuPrice.ShortcutsEnabled = true;
            this.txtMenuPrice.Size = new System.Drawing.Size(233, 28);
            this.txtMenuPrice.TabIndex = 14;
            this.txtMenuPrice.UseSelectable = true;
            this.txtMenuPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMenuPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(60, 279);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 20);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price";
            // 
            // cmbMenuCategory
            // 
            this.cmbMenuCategory.FormattingEnabled = true;
            this.cmbMenuCategory.ItemHeight = 24;
            this.cmbMenuCategory.Items.AddRange(new object[] {
            "Appetizer",
            "Main Course",
            "Dessert",
            "Beverages"});
            this.cmbMenuCategory.Location = new System.Drawing.Point(145, 166);
            this.cmbMenuCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMenuCategory.Name = "cmbMenuCategory";
            this.cmbMenuCategory.Size = new System.Drawing.Size(232, 30);
            this.cmbMenuCategory.TabIndex = 12;
            this.cmbMenuCategory.UseSelectable = true;
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(25, 169);
            this.lblCatagory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(65, 20);
            this.lblCatagory.TabIndex = 11;
            this.lblCatagory.Text = "Catagory";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AllowDrop = true;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel1.Location = new System.Drawing.Point(164, 30);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 20);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Enter Information ";
            // 
            // tileSave
            // 
            this.tileSave.ActiveControl = null;
            this.tileSave.Location = new System.Drawing.Point(307, 359);
            this.tileSave.Margin = new System.Windows.Forms.Padding(4);
            this.tileSave.Name = "tileSave";
            this.tileSave.Size = new System.Drawing.Size(71, 43);
            this.tileSave.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileSave.TabIndex = 8;
            this.tileSave.Text = "Save";
            this.tileSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSave.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSave.UseSelectable = true;
            this.tileSave.Click += new System.EventHandler(this.TileSave_Click);
            // 
            // txtMenuName
            // 
            // 
            // 
            // 
            this.txtMenuName.CustomButton.Image = null;
            this.txtMenuName.CustomButton.Location = new System.Drawing.Point(207, 2);
            this.txtMenuName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMenuName.CustomButton.Name = "";
            this.txtMenuName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMenuName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMenuName.CustomButton.TabIndex = 1;
            this.txtMenuName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMenuName.CustomButton.UseSelectable = true;
            this.txtMenuName.CustomButton.Visible = false;
            this.txtMenuName.Lines = new string[0];
            this.txtMenuName.Location = new System.Drawing.Point(145, 220);
            this.txtMenuName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMenuName.MaxLength = 32767;
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.PasswordChar = '\0';
            this.txtMenuName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMenuName.SelectedText = "";
            this.txtMenuName.SelectionLength = 0;
            this.txtMenuName.SelectionStart = 0;
            this.txtMenuName.ShortcutsEnabled = true;
            this.txtMenuName.Size = new System.Drawing.Size(233, 28);
            this.txtMenuName.TabIndex = 6;
            this.txtMenuName.UseSelectable = true;
            this.txtMenuName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMenuName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMenuId
            // 
            // 
            // 
            // 
            this.txtMenuId.CustomButton.Image = null;
            this.txtMenuId.CustomButton.Location = new System.Drawing.Point(207, 2);
            this.txtMenuId.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMenuId.CustomButton.Name = "";
            this.txtMenuId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMenuId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMenuId.CustomButton.TabIndex = 1;
            this.txtMenuId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMenuId.CustomButton.UseSelectable = true;
            this.txtMenuId.CustomButton.Visible = false;
            this.txtMenuId.Enabled = false;
            this.txtMenuId.Lines = new string[0];
            this.txtMenuId.Location = new System.Drawing.Point(145, 114);
            this.txtMenuId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMenuId.MaxLength = 32767;
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.PasswordChar = '\0';
            this.txtMenuId.ReadOnly = true;
            this.txtMenuId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMenuId.SelectedText = "";
            this.txtMenuId.SelectionLength = 0;
            this.txtMenuId.SelectionStart = 0;
            this.txtMenuId.ShortcutsEnabled = true;
            this.txtMenuId.Size = new System.Drawing.Size(233, 28);
            this.txtMenuId.TabIndex = 5;
            this.txtMenuId.UseSelectable = true;
            this.txtMenuId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMenuId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 223);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(84, 114);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 20);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AllowUserToResizeRows = false;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AddMenuName,
            this.Catagory,
            this.Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenu.EnableHeadersVisualStyles = false;
            this.dgvMenu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMenu.Location = new System.Drawing.Point(459, 135);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(577, 396);
            this.dgvMenu.Style = MetroFramework.MetroColorStyle.Orange;
            this.dgvMenu.TabIndex = 13;
            // 
            // tileSearch
            // 
            this.tileSearch.ActiveControl = null;
            this.tileSearch.Location = new System.Drawing.Point(755, 72);
            this.tileSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tileSearch.Name = "tileSearch";
            this.tileSearch.Size = new System.Drawing.Size(71, 43);
            this.tileSearch.Style = MetroFramework.MetroColorStyle.Orange;
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
            this.tileDelete.Location = new System.Drawing.Point(650, 71);
            this.tileDelete.Margin = new System.Windows.Forms.Padding(4);
            this.tileDelete.Name = "tileDelete";
            this.tileDelete.Size = new System.Drawing.Size(71, 43);
            this.tileDelete.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileDelete.TabIndex = 11;
            this.tileDelete.Text = "Delete";
            this.tileDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileDelete.UseSelectable = true;
            this.tileDelete.Click += new System.EventHandler(this.TileDelete_Click);
            // 
            // tileAdd
            // 
            this.tileAdd.ActiveControl = null;
            this.tileAdd.Location = new System.Drawing.Point(544, 71);
            this.tileAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tileAdd.Name = "tileAdd";
            this.tileAdd.Size = new System.Drawing.Size(71, 43);
            this.tileAdd.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileAdd.TabIndex = 9;
            this.tileAdd.Text = "Add";
            this.tileAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAdd.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileAdd.UseSelectable = true;
            this.tileAdd.Click += new System.EventHandler(this.TileAdd_Click);
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
            this.AddMenuName.DataPropertyName = "Name";
            this.AddMenuName.HeaderText = "Name";
            this.AddMenuName.MinimumWidth = 6;
            this.AddMenuName.Name = "AddMenuName";
            this.AddMenuName.ReadOnly = true;
            this.AddMenuName.Width = 125;
            // 
            // Catagory
            // 
            this.Catagory.DataPropertyName = "Category";
            this.Catagory.HeaderText = "Catagory";
            this.Catagory.MinimumWidth = 6;
            this.Catagory.Name = "Catagory";
            this.Catagory.ReadOnly = true;
            this.Catagory.Width = 125;
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlMenuManage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Menu";
            this.pnlMenuManage.ResumeLayout(false);
            this.pnlAddMenu.ResumeLayout(false);
            this.pnlAddMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMenuManage;
        private MetroFramework.Controls.MetroTile tileSearch;
        private MetroFramework.Controls.MetroTile tileDelete;
        private MetroFramework.Controls.MetroGrid dgvMenu;
        private MetroFramework.Controls.MetroPanel pnlAddMenu;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile tileSave;
        private MetroFramework.Controls.MetroTextBox txtMenuName;
        private MetroFramework.Controls.MetroTextBox txtMenuId;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroTextBox txtMenuPrice;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroComboBox cmbMenuCategory;
        private MetroFramework.Controls.MetroLabel lblCatagory;
        private MetroFramework.Controls.MetroTile tileBack;
        private MetroFramework.Controls.MetroTile tileAdd;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddMenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}