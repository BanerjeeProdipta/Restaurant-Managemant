namespace Restaurant_Management.ApplicationLayer
{
    partial class ViewWaiters
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.tileBack = new MetroFramework.Controls.MetroTile();
            this.lblEmployeeInfo = new MetroFramework.Controls.MetroLabel();
            this.dgvWaiter = new MetroFramework.Controls.MetroGrid();
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
            this.pnlAddEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaiter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.Controls.Add(this.txtSearch);
            this.pnlAddEmployee.Controls.Add(this.tileBack);
            this.pnlAddEmployee.Controls.Add(this.lblEmployeeInfo);
            this.pnlAddEmployee.Controls.Add(this.dgvWaiter);
            this.pnlAddEmployee.Controls.Add(this.mtEmployeeSearch);
            this.pnlAddEmployee.Location = new System.Drawing.Point(0, 4);
            this.pnlAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(1067, 544);
            this.pnlAddEmployee.TabIndex = 1;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(751, 65);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(169, 28);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileBack
            // 
            this.tileBack.ActiveControl = null;
            this.tileBack.Location = new System.Drawing.Point(4, 4);
            this.tileBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lblEmployeeInfo.Location = new System.Drawing.Point(15, 76);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(145, 20);
            this.lblEmployeeInfo.TabIndex = 8;
            this.lblEmployeeInfo.Text = "Employee Information";
            // 
            // dgvWaiter
            // 
            this.dgvWaiter.AllowUserToAddRows = false;
            this.dgvWaiter.AllowUserToDeleteRows = false;
            this.dgvWaiter.AllowUserToResizeRows = false;
            this.dgvWaiter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWaiter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWaiter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvWaiter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWaiter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvWaiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWaiter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWaiter.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvWaiter.EnableHeadersVisualStyles = false;
            this.dgvWaiter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvWaiter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWaiter.Location = new System.Drawing.Point(15, 116);
            this.dgvWaiter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvWaiter.Name = "dgvWaiter";
            this.dgvWaiter.ReadOnly = true;
            this.dgvWaiter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWaiter.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvWaiter.RowHeadersWidth = 51;
            this.dgvWaiter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvWaiter.RowTemplate.Height = 24;
            this.dgvWaiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWaiter.Size = new System.Drawing.Size(1000, 414);
            this.dgvWaiter.TabIndex = 6;
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
            this.mtEmployeeSearch.Location = new System.Drawing.Point(944, 57);
            this.mtEmployeeSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // ViewWaiters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlAddEmployee);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewWaiters";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "View Waiters";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaiter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddEmployee;
        private MetroFramework.Controls.MetroLabel lblEmployeeInfo;
        private MetroFramework.Controls.MetroGrid dgvWaiter;
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
        private MetroFramework.Controls.MetroTile tileBack;
        private MetroFramework.Controls.MetroTextBox txtSearch;
    }
}