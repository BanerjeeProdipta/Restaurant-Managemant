namespace Restaurant_Management.ApplicationLayer
{
    partial class ManageAdmin
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
            this.pnlGridAdmin = new System.Windows.Forms.Panel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.tileBack = new MetroFramework.Controls.MetroTile();
            this.lblEmployeeInfo = new MetroFramework.Controls.MetroLabel();
            this.dgvAdmin = new MetroFramework.Controls.MetroGrid();
            this.AppId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddDate_Of_Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddJoining_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddMarital_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBlood_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtEmployeeSearch = new MetroFramework.Controls.MetroTile();
            this.mtEmployeeDelete = new MetroFramework.Controls.MetroTile();
            this.mtEmployeeEdit = new MetroFramework.Controls.MetroTile();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.tileEditBack = new MetroFramework.Controls.MetroTile();
            this.lblSalary = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.cmbBlood_Group = new MetroFramework.Controls.MetroComboBox();
            this.dtJoining_Date = new MetroFramework.Controls.MetroDateTime();
            this.dtDate_Of_Birth = new MetroFramework.Controls.MetroDateTime();
            this.rbGenderFemale = new MetroFramework.Controls.MetroRadioButton();
            this.rbGenderMale = new MetroFramework.Controls.MetroRadioButton();
            this.txtAddPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtAddEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtAddAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtAddName = new MetroFramework.Controls.MetroTextBox();
            this.txtAddId = new MetroFramework.Controls.MetroTextBox();
            this.lblBloodGroup = new MetroFramework.Controls.MetroLabel();
            this.lblMeritalStatusel1 = new MetroFramework.Controls.MetroLabel();
            this.lblJoiningDate = new MetroFramework.Controls.MetroLabel();
            this.lblDateOfBirth = new MetroFramework.Controls.MetroLabel();
            this.lblGender = new MetroFramework.Controls.MetroLabel();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.txtSalary = new MetroFramework.Controls.MetroTextBox();
            this.cmbMaritalStatus = new MetroFramework.Controls.MetroComboBox();
            this.pnlGridAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGridAdmin
            // 
            this.pnlGridAdmin.Controls.Add(this.txtSearch);
            this.pnlGridAdmin.Controls.Add(this.tileBack);
            this.pnlGridAdmin.Controls.Add(this.lblEmployeeInfo);
            this.pnlGridAdmin.Controls.Add(this.dgvAdmin);
            this.pnlGridAdmin.Controls.Add(this.mtEmployeeSearch);
            this.pnlGridAdmin.Controls.Add(this.mtEmployeeDelete);
            this.pnlGridAdmin.Controls.Add(this.mtEmployeeEdit);
            this.pnlGridAdmin.Location = new System.Drawing.Point(0, -1);
            this.pnlGridAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGridAdmin.Name = "pnlGridAdmin";
            this.pnlGridAdmin.Size = new System.Drawing.Size(1044, 551);
            this.pnlGridAdmin.TabIndex = 1;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(665, 50);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(188, 23);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileBack
            // 
            this.tileBack.ActiveControl = null;
            this.tileBack.Location = new System.Drawing.Point(5, 6);
            this.tileBack.Margin = new System.Windows.Forms.Padding(4);
            this.tileBack.Name = "tileBack";
            this.tileBack.Size = new System.Drawing.Size(32, 42);
            this.tileBack.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileBack.TabIndex = 16;
            this.tileBack.Text = "<";
            this.tileBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tileBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileBack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileBack.UseSelectable = true;
            this.tileBack.Click += new System.EventHandler(this.TileBack_Click);
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.AutoSize = true;
            this.lblEmployeeInfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmployeeInfo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEmployeeInfo.Location = new System.Drawing.Point(17, 68);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(184, 25);
            this.lblEmployeeInfo.TabIndex = 8;
            this.lblEmployeeInfo.Text = "Admin Information";
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AllowUserToResizeRows = false;
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppId,
            this.AddName,
            this.AddAddress,
            this.AddEmail,
            this.AddPhone,
            this.AddGender,
            this.AddDate_Of_Birth,
            this.AddJoining_Date,
            this.AddMarital_Status,
            this.AddBlood_Group,
            this.AddSalary});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdmin.EnableHeadersVisualStyles = false;
            this.dgvAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAdmin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAdmin.Location = new System.Drawing.Point(19, 112);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(1000, 414);
            this.dgvAdmin.TabIndex = 6;
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
            // AddName
            // 
            this.AddName.DataPropertyName = "Name";
            this.AddName.HeaderText = "Name";
            this.AddName.MinimumWidth = 6;
            this.AddName.Name = "AddName";
            this.AddName.ReadOnly = true;
            this.AddName.Width = 125;
            // 
            // AddAddress
            // 
            this.AddAddress.DataPropertyName = "Address";
            this.AddAddress.HeaderText = "Address";
            this.AddAddress.MinimumWidth = 6;
            this.AddAddress.Name = "AddAddress";
            this.AddAddress.ReadOnly = true;
            this.AddAddress.Width = 125;
            // 
            // AddEmail
            // 
            this.AddEmail.DataPropertyName = "Email";
            this.AddEmail.HeaderText = "Email ";
            this.AddEmail.MinimumWidth = 6;
            this.AddEmail.Name = "AddEmail";
            this.AddEmail.ReadOnly = true;
            this.AddEmail.Width = 125;
            // 
            // AddPhone
            // 
            this.AddPhone.DataPropertyName = "Phone";
            this.AddPhone.HeaderText = "Phone";
            this.AddPhone.MinimumWidth = 6;
            this.AddPhone.Name = "AddPhone";
            this.AddPhone.ReadOnly = true;
            this.AddPhone.Width = 125;
            // 
            // AddGender
            // 
            this.AddGender.DataPropertyName = "Gender";
            this.AddGender.HeaderText = "Gender";
            this.AddGender.MinimumWidth = 6;
            this.AddGender.Name = "AddGender";
            this.AddGender.ReadOnly = true;
            this.AddGender.Width = 125;
            // 
            // AddDate_Of_Birth
            // 
            this.AddDate_Of_Birth.DataPropertyName = "Date_Of_Birth";
            this.AddDate_Of_Birth.HeaderText = "Date Of Birth";
            this.AddDate_Of_Birth.MinimumWidth = 6;
            this.AddDate_Of_Birth.Name = "AddDate_Of_Birth";
            this.AddDate_Of_Birth.ReadOnly = true;
            this.AddDate_Of_Birth.Width = 125;
            // 
            // AddJoining_Date
            // 
            this.AddJoining_Date.DataPropertyName = "Joining_Date";
            this.AddJoining_Date.HeaderText = "Joining Date";
            this.AddJoining_Date.MinimumWidth = 6;
            this.AddJoining_Date.Name = "AddJoining_Date";
            this.AddJoining_Date.ReadOnly = true;
            this.AddJoining_Date.Width = 125;
            // 
            // AddMarital_Status
            // 
            this.AddMarital_Status.DataPropertyName = "Marital_Status";
            this.AddMarital_Status.HeaderText = "Marital Status";
            this.AddMarital_Status.MinimumWidth = 6;
            this.AddMarital_Status.Name = "AddMarital_Status";
            this.AddMarital_Status.ReadOnly = true;
            this.AddMarital_Status.Width = 125;
            // 
            // AddBlood_Group
            // 
            this.AddBlood_Group.DataPropertyName = "Blood_Group";
            this.AddBlood_Group.HeaderText = "Blood Group";
            this.AddBlood_Group.MinimumWidth = 6;
            this.AddBlood_Group.Name = "AddBlood_Group";
            this.AddBlood_Group.ReadOnly = true;
            this.AddBlood_Group.Width = 125;
            // 
            // AddSalary
            // 
            this.AddSalary.DataPropertyName = "Salary";
            this.AddSalary.HeaderText = "Salary";
            this.AddSalary.MinimumWidth = 6;
            this.AddSalary.Name = "AddSalary";
            this.AddSalary.ReadOnly = true;
            this.AddSalary.Width = 125;
            // 
            // mtEmployeeSearch
            // 
            this.mtEmployeeSearch.ActiveControl = null;
            this.mtEmployeeSearch.Location = new System.Drawing.Point(572, 39);
            this.mtEmployeeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.mtEmployeeSearch.Name = "mtEmployeeSearch";
            this.mtEmployeeSearch.Size = new System.Drawing.Size(71, 43);
            this.mtEmployeeSearch.TabIndex = 4;
            this.mtEmployeeSearch.Text = "Search";
            this.mtEmployeeSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEmployeeSearch.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtEmployeeSearch.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtEmployeeSearch.UseSelectable = true;
            this.mtEmployeeSearch.Click += new System.EventHandler(this.MtEmployeeSearch_Click);
            // 
            // mtEmployeeDelete
            // 
            this.mtEmployeeDelete.ActiveControl = null;
            this.mtEmployeeDelete.Location = new System.Drawing.Point(483, 39);
            this.mtEmployeeDelete.Margin = new System.Windows.Forms.Padding(4);
            this.mtEmployeeDelete.Name = "mtEmployeeDelete";
            this.mtEmployeeDelete.Size = new System.Drawing.Size(71, 43);
            this.mtEmployeeDelete.TabIndex = 3;
            this.mtEmployeeDelete.Text = "Delete";
            this.mtEmployeeDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEmployeeDelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtEmployeeDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtEmployeeDelete.UseSelectable = true;
            this.mtEmployeeDelete.Click += new System.EventHandler(this.MtEmployeeDelete_Click);
            // 
            // mtEmployeeEdit
            // 
            this.mtEmployeeEdit.ActiveControl = null;
            this.mtEmployeeEdit.Location = new System.Drawing.Point(394, 39);
            this.mtEmployeeEdit.Margin = new System.Windows.Forms.Padding(4);
            this.mtEmployeeEdit.Name = "mtEmployeeEdit";
            this.mtEmployeeEdit.Size = new System.Drawing.Size(71, 43);
            this.mtEmployeeEdit.TabIndex = 2;
            this.mtEmployeeEdit.Text = "Edit";
            this.mtEmployeeEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEmployeeEdit.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtEmployeeEdit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtEmployeeEdit.UseSelectable = true;
            this.mtEmployeeEdit.Click += new System.EventHandler(this.MtEmployeeEdit_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.pnlGridAdmin);
            this.pnlEdit.Controls.Add(this.tileEditBack);
            this.pnlEdit.Controls.Add(this.lblSalary);
            this.pnlEdit.Controls.Add(this.btnSave);
            this.pnlEdit.Controls.Add(this.cmbBlood_Group);
            this.pnlEdit.Controls.Add(this.dtJoining_Date);
            this.pnlEdit.Controls.Add(this.dtDate_Of_Birth);
            this.pnlEdit.Controls.Add(this.rbGenderFemale);
            this.pnlEdit.Controls.Add(this.rbGenderMale);
            this.pnlEdit.Controls.Add(this.txtAddPhone);
            this.pnlEdit.Controls.Add(this.txtAddEmail);
            this.pnlEdit.Controls.Add(this.txtAddAddress);
            this.pnlEdit.Controls.Add(this.txtAddName);
            this.pnlEdit.Controls.Add(this.txtAddId);
            this.pnlEdit.Controls.Add(this.lblBloodGroup);
            this.pnlEdit.Controls.Add(this.lblMeritalStatusel1);
            this.pnlEdit.Controls.Add(this.lblJoiningDate);
            this.pnlEdit.Controls.Add(this.lblDateOfBirth);
            this.pnlEdit.Controls.Add(this.lblGender);
            this.pnlEdit.Controls.Add(this.lblPhone);
            this.pnlEdit.Controls.Add(this.lblEmail);
            this.pnlEdit.Controls.Add(this.lblAddress);
            this.pnlEdit.Controls.Add(this.lblName);
            this.pnlEdit.Controls.Add(this.lblId);
            this.pnlEdit.Controls.Add(this.btnCancel);
            this.pnlEdit.Controls.Add(this.txtSalary);
            this.pnlEdit.Controls.Add(this.cmbMaritalStatus);
            this.pnlEdit.Location = new System.Drawing.Point(0, 4);
            this.pnlEdit.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(1040, 546);
            this.pnlEdit.TabIndex = 6;
            // 
            // tileEditBack
            // 
            this.tileEditBack.ActiveControl = null;
            this.tileEditBack.Location = new System.Drawing.Point(4, 4);
            this.tileEditBack.Margin = new System.Windows.Forms.Padding(4);
            this.tileEditBack.Name = "tileEditBack";
            this.tileEditBack.Size = new System.Drawing.Size(32, 42);
            this.tileEditBack.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileEditBack.TabIndex = 31;
            this.tileEditBack.Text = "<";
            this.tileEditBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tileEditBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileEditBack.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileEditBack.UseSelectable = true;
            this.tileEditBack.Click += new System.EventHandler(this.TileEditBack_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(601, 339);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(46, 20);
            this.lblSalary.TabIndex = 28;
            this.lblSalary.Text = "Salary";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(752, 453);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 33);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            // 
            // cmbBlood_Group
            // 
            this.cmbBlood_Group.Enabled = false;
            this.cmbBlood_Group.FormattingEnabled = true;
            this.cmbBlood_Group.ItemHeight = 24;
            this.cmbBlood_Group.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmbBlood_Group.Location = new System.Drawing.Point(724, 281);
            this.cmbBlood_Group.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBlood_Group.Name = "cmbBlood_Group";
            this.cmbBlood_Group.Size = new System.Drawing.Size(265, 30);
            this.cmbBlood_Group.TabIndex = 23;
            this.cmbBlood_Group.UseSelectable = true;
            // 
            // dtJoining_Date
            // 
            this.dtJoining_Date.Enabled = false;
            this.dtJoining_Date.Location = new System.Drawing.Point(724, 182);
            this.dtJoining_Date.Margin = new System.Windows.Forms.Padding(4);
            this.dtJoining_Date.MinimumSize = new System.Drawing.Size(4, 30);
            this.dtJoining_Date.Name = "dtJoining_Date";
            this.dtJoining_Date.Size = new System.Drawing.Size(265, 30);
            this.dtJoining_Date.TabIndex = 20;
            // 
            // dtDate_Of_Birth
            // 
            this.dtDate_Of_Birth.Enabled = false;
            this.dtDate_Of_Birth.Location = new System.Drawing.Point(724, 124);
            this.dtDate_Of_Birth.Margin = new System.Windows.Forms.Padding(4);
            this.dtDate_Of_Birth.MinimumSize = new System.Drawing.Size(4, 30);
            this.dtDate_Of_Birth.Name = "dtDate_Of_Birth";
            this.dtDate_Of_Birth.Size = new System.Drawing.Size(265, 30);
            this.dtDate_Of_Birth.TabIndex = 19;
            // 
            // rbGenderFemale
            // 
            this.rbGenderFemale.AutoSize = true;
            this.rbGenderFemale.Enabled = false;
            this.rbGenderFemale.Location = new System.Drawing.Point(895, 79);
            this.rbGenderFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbGenderFemale.Name = "rbGenderFemale";
            this.rbGenderFemale.Size = new System.Drawing.Size(65, 17);
            this.rbGenderFemale.TabIndex = 18;
            this.rbGenderFemale.Text = "Female";
            this.rbGenderFemale.UseSelectable = true;
            // 
            // rbGenderMale
            // 
            this.rbGenderMale.AutoSize = true;
            this.rbGenderMale.Enabled = false;
            this.rbGenderMale.Location = new System.Drawing.Point(722, 79);
            this.rbGenderMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbGenderMale.Name = "rbGenderMale";
            this.rbGenderMale.Size = new System.Drawing.Size(53, 17);
            this.rbGenderMale.TabIndex = 17;
            this.rbGenderMale.Text = "Male";
            this.rbGenderMale.UseSelectable = true;
            // 
            // txtAddPhone
            // 
            // 
            // 
            // 
            this.txtAddPhone.CustomButton.Image = null;
            this.txtAddPhone.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtAddPhone.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddPhone.CustomButton.Name = "";
            this.txtAddPhone.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAddPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddPhone.CustomButton.TabIndex = 1;
            this.txtAddPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddPhone.CustomButton.UseSelectable = true;
            this.txtAddPhone.CustomButton.Visible = false;
            this.txtAddPhone.Lines = new string[0];
            this.txtAddPhone.Location = new System.Drawing.Point(220, 334);
            this.txtAddPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddPhone.MaxLength = 32767;
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.PasswordChar = '\0';
            this.txtAddPhone.ReadOnly = true;
            this.txtAddPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddPhone.SelectedText = "";
            this.txtAddPhone.SelectionLength = 0;
            this.txtAddPhone.SelectionStart = 0;
            this.txtAddPhone.ShortcutsEnabled = true;
            this.txtAddPhone.Size = new System.Drawing.Size(161, 28);
            this.txtAddPhone.TabIndex = 16;
            this.txtAddPhone.UseSelectable = true;
            this.txtAddPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddEmail
            // 
            // 
            // 
            // 
            this.txtAddEmail.CustomButton.Image = null;
            this.txtAddEmail.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtAddEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddEmail.CustomButton.Name = "";
            this.txtAddEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAddEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddEmail.CustomButton.TabIndex = 1;
            this.txtAddEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddEmail.CustomButton.UseSelectable = true;
            this.txtAddEmail.CustomButton.Visible = false;
            this.txtAddEmail.Lines = new string[0];
            this.txtAddEmail.Location = new System.Drawing.Point(220, 279);
            this.txtAddEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddEmail.MaxLength = 32767;
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.PasswordChar = '\0';
            this.txtAddEmail.ReadOnly = true;
            this.txtAddEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddEmail.SelectedText = "";
            this.txtAddEmail.SelectionLength = 0;
            this.txtAddEmail.SelectionStart = 0;
            this.txtAddEmail.ShortcutsEnabled = true;
            this.txtAddEmail.Size = new System.Drawing.Size(161, 28);
            this.txtAddEmail.TabIndex = 15;
            this.txtAddEmail.UseSelectable = true;
            this.txtAddEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddAddress
            // 
            // 
            // 
            // 
            this.txtAddAddress.CustomButton.Image = null;
            this.txtAddAddress.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtAddAddress.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddAddress.CustomButton.Name = "";
            this.txtAddAddress.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAddAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddAddress.CustomButton.TabIndex = 1;
            this.txtAddAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddAddress.CustomButton.UseSelectable = true;
            this.txtAddAddress.CustomButton.Visible = false;
            this.txtAddAddress.Lines = new string[0];
            this.txtAddAddress.Location = new System.Drawing.Point(220, 225);
            this.txtAddAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddAddress.MaxLength = 32767;
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.PasswordChar = '\0';
            this.txtAddAddress.ReadOnly = true;
            this.txtAddAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddAddress.SelectedText = "";
            this.txtAddAddress.SelectionLength = 0;
            this.txtAddAddress.SelectionStart = 0;
            this.txtAddAddress.ShortcutsEnabled = true;
            this.txtAddAddress.Size = new System.Drawing.Size(161, 28);
            this.txtAddAddress.TabIndex = 14;
            this.txtAddAddress.UseSelectable = true;
            this.txtAddAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddName
            // 
            // 
            // 
            // 
            this.txtAddName.CustomButton.Image = null;
            this.txtAddName.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtAddName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddName.CustomButton.Name = "";
            this.txtAddName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAddName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddName.CustomButton.TabIndex = 1;
            this.txtAddName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddName.CustomButton.UseSelectable = true;
            this.txtAddName.CustomButton.Visible = false;
            this.txtAddName.Lines = new string[0];
            this.txtAddName.Location = new System.Drawing.Point(220, 177);
            this.txtAddName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddName.MaxLength = 32767;
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.PasswordChar = '\0';
            this.txtAddName.ReadOnly = true;
            this.txtAddName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddName.SelectedText = "";
            this.txtAddName.SelectionLength = 0;
            this.txtAddName.SelectionStart = 0;
            this.txtAddName.ShortcutsEnabled = true;
            this.txtAddName.Size = new System.Drawing.Size(161, 28);
            this.txtAddName.TabIndex = 12;
            this.txtAddName.UseSelectable = true;
            this.txtAddName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddId
            // 
            // 
            // 
            // 
            this.txtAddId.CustomButton.Image = null;
            this.txtAddId.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.txtAddId.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddId.CustomButton.Name = "";
            this.txtAddId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAddId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddId.CustomButton.TabIndex = 1;
            this.txtAddId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddId.CustomButton.UseSelectable = true;
            this.txtAddId.CustomButton.Visible = false;
            this.txtAddId.Lines = new string[0];
            this.txtAddId.Location = new System.Drawing.Point(220, 129);
            this.txtAddId.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddId.MaxLength = 32767;
            this.txtAddId.Name = "txtAddId";
            this.txtAddId.PasswordChar = '\0';
            this.txtAddId.ReadOnly = true;
            this.txtAddId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddId.SelectedText = "";
            this.txtAddId.SelectionLength = 0;
            this.txtAddId.SelectionStart = 0;
            this.txtAddId.ShortcutsEnabled = true;
            this.txtAddId.Size = new System.Drawing.Size(161, 28);
            this.txtAddId.TabIndex = 11;
            this.txtAddId.UseSelectable = true;
            this.txtAddId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(561, 291);
            this.lblBloodGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(87, 20);
            this.lblBloodGroup.TabIndex = 10;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // lblMeritalStatusel1
            // 
            this.lblMeritalStatusel1.AutoSize = true;
            this.lblMeritalStatusel1.Location = new System.Drawing.Point(557, 241);
            this.lblMeritalStatusel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeritalStatusel1.Name = "lblMeritalStatusel1";
            this.lblMeritalStatusel1.Size = new System.Drawing.Size(90, 20);
            this.lblMeritalStatusel1.TabIndex = 9;
            this.lblMeritalStatusel1.Text = "Marital Status";
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.Location = new System.Drawing.Point(562, 187);
            this.lblJoiningDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(85, 20);
            this.lblJoiningDate.TabIndex = 8;
            this.lblJoiningDate.Text = "Joining Date";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(560, 133);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(87, 20);
            this.lblDateOfBirth.TabIndex = 7;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(591, 79);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 20);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(88, 334);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 20);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(95, 279);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(75, 225);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 20);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(88, 177);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(117, 129);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.Location = new System.Drawing.Point(893, 453);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 33);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            // 
            // txtSalary
            // 
            // 
            // 
            // 
            this.txtSalary.CustomButton.Image = null;
            this.txtSalary.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtSalary.CustomButton.Name = "";
            this.txtSalary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalary.CustomButton.TabIndex = 1;
            this.txtSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalary.CustomButton.UseSelectable = true;
            this.txtSalary.CustomButton.Visible = false;
            this.txtSalary.Lines = new string[0];
            this.txtSalary.Location = new System.Drawing.Point(724, 339);
            this.txtSalary.MaxLength = 32767;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.ReadOnly = true;
            this.txtSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalary.SelectedText = "";
            this.txtSalary.SelectionLength = 0;
            this.txtSalary.SelectionStart = 0;
            this.txtSalary.ShortcutsEnabled = true;
            this.txtSalary.Size = new System.Drawing.Size(265, 23);
            this.txtSalary.TabIndex = 29;
            this.txtSalary.UseSelectable = true;
            this.txtSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.ItemHeight = 24;
            this.cmbMaritalStatus.Items.AddRange(new object[] {
            "Married",
            "Single",
            "Divorced"});
            this.cmbMaritalStatus.Location = new System.Drawing.Point(724, 231);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(265, 30);
            this.cmbMaritalStatus.TabIndex = 30;
            this.cmbMaritalStatus.UseSelectable = true;
            // 
            // ManageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 554);
            this.Controls.Add(this.pnlEdit);
            this.Name = "ManageAdmin";
            this.Text = "ManageAdmin";
            this.Load += new System.EventHandler(this.ManageAdmin_Load);
            this.pnlGridAdmin.ResumeLayout(false);
            this.pnlGridAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGridAdmin;
        private MetroFramework.Controls.MetroTile tileBack;
        private MetroFramework.Controls.MetroLabel lblEmployeeInfo;
        private MetroFramework.Controls.MetroGrid dgvAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddDate_Of_Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddJoining_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddMarital_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddBlood_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddSalary;
        private MetroFramework.Controls.MetroTile mtEmployeeSearch;
        private MetroFramework.Controls.MetroTile mtEmployeeDelete;
        private MetroFramework.Controls.MetroTile mtEmployeeEdit;
        private System.Windows.Forms.Panel pnlEdit;
        private MetroFramework.Controls.MetroTile tileEditBack;
        private MetroFramework.Controls.MetroLabel lblSalary;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroComboBox cmbBlood_Group;
        private MetroFramework.Controls.MetroDateTime dtJoining_Date;
        private MetroFramework.Controls.MetroDateTime dtDate_Of_Birth;
        private MetroFramework.Controls.MetroRadioButton rbGenderFemale;
        private MetroFramework.Controls.MetroRadioButton rbGenderMale;
        private MetroFramework.Controls.MetroTextBox txtAddPhone;
        private MetroFramework.Controls.MetroTextBox txtAddEmail;
        private MetroFramework.Controls.MetroTextBox txtAddAddress;
        private MetroFramework.Controls.MetroTextBox txtAddName;
        private MetroFramework.Controls.MetroTextBox txtAddId;
        private MetroFramework.Controls.MetroLabel lblBloodGroup;
        private MetroFramework.Controls.MetroLabel lblMeritalStatusel1;
        private MetroFramework.Controls.MetroLabel lblJoiningDate;
        private MetroFramework.Controls.MetroLabel lblDateOfBirth;
        private MetroFramework.Controls.MetroLabel lblGender;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox txtSalary;
        private MetroFramework.Controls.MetroComboBox cmbMaritalStatus;
        private MetroFramework.Controls.MetroTextBox txtSearch;
    }
}