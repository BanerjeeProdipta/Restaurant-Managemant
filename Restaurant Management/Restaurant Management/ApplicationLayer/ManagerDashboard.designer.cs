namespace Restaurant_Management.ApplicationLayer
{
    partial class Manager_Dashboard
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
            this.pnlMyProfile = new MetroFramework.Controls.MetroPanel();
            this.mtMyProfile = new MetroFramework.Controls.MetroTile();
            this.ptbAdmin = new System.Windows.Forms.PictureBox();
            this.pnlAdminProfile = new MetroFramework.Controls.MetroPanel();
            this.pnlAdminDashboard = new MetroFramework.Controls.MetroPanel();
            this.mtMenu = new MetroFramework.Controls.MetroTile();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.lblWelcome = new MetroFramework.Controls.MetroLabel();
            this.mtViewWaiter = new MetroFramework.Controls.MetroTile();
            this.mtOrder = new MetroFramework.Controls.MetroTile();
            this.mtBillGenerate = new MetroFramework.Controls.MetroTile();
            this.mtFinancials = new MetroFramework.Controls.MetroTile();
            this.mtTable = new MetroFramework.Controls.MetroTile();
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.lblAdminBlood_Group = new MetroFramework.Controls.MetroLabel();
            this.txtManagerBlood_Group = new System.Windows.Forms.TextBox();
            this.lblAdminMarital_Status = new MetroFramework.Controls.MetroLabel();
            this.txtManagerMaritalStatus = new System.Windows.Forms.TextBox();
            this.lblAdminJoining_Date = new MetroFramework.Controls.MetroLabel();
            this.txtManagerJoining_Date = new System.Windows.Forms.TextBox();
            this.lblAdminDate_Of_Birth = new MetroFramework.Controls.MetroLabel();
            this.txtManagerDate_Of_Birth = new System.Windows.Forms.TextBox();
            this.lblAdminGender = new MetroFramework.Controls.MetroLabel();
            this.txtManagerGender = new System.Windows.Forms.TextBox();
            this.lblAdminEmail = new MetroFramework.Controls.MetroLabel();
            this.txtManagerEmail = new System.Windows.Forms.TextBox();
            this.lblAdminPhone = new MetroFramework.Controls.MetroLabel();
            this.txtManagerPhone = new System.Windows.Forms.TextBox();
            this.lblAdminAddress = new MetroFramework.Controls.MetroLabel();
            this.txtManagerAddress = new System.Windows.Forms.TextBox();
            this.lblAdminName = new MetroFramework.Controls.MetroLabel();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.lblAdminId = new MetroFramework.Controls.MetroLabel();
            this.txtMangerId = new System.Windows.Forms.TextBox();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.lblSalary = new MetroFramework.Controls.MetroLabel();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.pnlMyProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdmin)).BeginInit();
            this.pnlAdminProfile.SuspendLayout();
            this.pnlAdminDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMyProfile
            // 
            this.pnlMyProfile.Controls.Add(this.mtMyProfile);
            this.pnlMyProfile.Controls.Add(this.ptbAdmin);
            this.pnlMyProfile.HorizontalScrollbarBarColor = true;
            this.pnlMyProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMyProfile.HorizontalScrollbarSize = 12;
            this.pnlMyProfile.Location = new System.Drawing.Point(-1, 75);
            this.pnlMyProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMyProfile.Name = "pnlMyProfile";
            this.pnlMyProfile.Size = new System.Drawing.Size(309, 484);
            this.pnlMyProfile.Style = MetroFramework.MetroColorStyle.Teal;
            this.pnlMyProfile.TabIndex = 9;
            this.pnlMyProfile.VerticalScrollbarBarColor = true;
            this.pnlMyProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMyProfile.VerticalScrollbarSize = 13;
            // 
            // mtMyProfile
            // 
            this.mtMyProfile.ActiveControl = null;
            this.mtMyProfile.Location = new System.Drawing.Point(0, 351);
            this.mtMyProfile.Margin = new System.Windows.Forms.Padding(4);
            this.mtMyProfile.Name = "mtMyProfile";
            this.mtMyProfile.Size = new System.Drawing.Size(308, 79);
            this.mtMyProfile.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtMyProfile.TabIndex = 3;
            this.mtMyProfile.Text = "My Profile";
            this.mtMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtMyProfile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtMyProfile.UseSelectable = true;
            this.mtMyProfile.Click += new System.EventHandler(this.MtMyProfile_Click);
            // 
            // ptbAdmin
            // 
            this.ptbAdmin.Image = global::Restaurant_Management.Properties.Resources.sales_manager_icon_2;
            this.ptbAdmin.Location = new System.Drawing.Point(41, 95);
            this.ptbAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.ptbAdmin.Name = "ptbAdmin";
            this.ptbAdmin.Size = new System.Drawing.Size(224, 215);
            this.ptbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAdmin.TabIndex = 2;
            this.ptbAdmin.TabStop = false;
            // 
            // pnlAdminProfile
            // 
            this.pnlAdminProfile.Controls.Add(this.pnlAdminDashboard);
            this.pnlAdminProfile.Controls.Add(this.lblAdminBlood_Group);
            this.pnlAdminProfile.Controls.Add(this.txtManagerBlood_Group);
            this.pnlAdminProfile.Controls.Add(this.lblAdminMarital_Status);
            this.pnlAdminProfile.Controls.Add(this.txtManagerMaritalStatus);
            this.pnlAdminProfile.Controls.Add(this.lblAdminJoining_Date);
            this.pnlAdminProfile.Controls.Add(this.txtManagerJoining_Date);
            this.pnlAdminProfile.Controls.Add(this.lblAdminDate_Of_Birth);
            this.pnlAdminProfile.Controls.Add(this.txtManagerDate_Of_Birth);
            this.pnlAdminProfile.Controls.Add(this.lblAdminGender);
            this.pnlAdminProfile.Controls.Add(this.txtManagerGender);
            this.pnlAdminProfile.Controls.Add(this.lblAdminEmail);
            this.pnlAdminProfile.Controls.Add(this.txtManagerEmail);
            this.pnlAdminProfile.Controls.Add(this.lblAdminPhone);
            this.pnlAdminProfile.Controls.Add(this.txtManagerPhone);
            this.pnlAdminProfile.Controls.Add(this.lblAdminAddress);
            this.pnlAdminProfile.Controls.Add(this.txtManagerAddress);
            this.pnlAdminProfile.Controls.Add(this.lblAdminName);
            this.pnlAdminProfile.Controls.Add(this.txtManagerName);
            this.pnlAdminProfile.Controls.Add(this.lblAdminId);
            this.pnlAdminProfile.Controls.Add(this.txtMangerId);
            this.pnlAdminProfile.Controls.Add(this.btnEdit);
            this.pnlAdminProfile.Controls.Add(this.lblSalary);
            this.pnlAdminProfile.Controls.Add(this.txtSalary);
            this.pnlAdminProfile.HorizontalScrollbarBarColor = true;
            this.pnlAdminProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAdminProfile.HorizontalScrollbarSize = 12;
            this.pnlAdminProfile.Location = new System.Drawing.Point(324, 0);
            this.pnlAdminProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAdminProfile.Name = "pnlAdminProfile";
            this.pnlAdminProfile.Size = new System.Drawing.Size(739, 559);
            this.pnlAdminProfile.Style = MetroFramework.MetroColorStyle.Lime;
            this.pnlAdminProfile.TabIndex = 10;
            this.pnlAdminProfile.VerticalScrollbarBarColor = true;
            this.pnlAdminProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAdminProfile.VerticalScrollbarSize = 13;
            // 
            // pnlAdminDashboard
            // 
            this.pnlAdminDashboard.Controls.Add(this.mtMenu);
            this.pnlAdminDashboard.Controls.Add(this.lblUserName);
            this.pnlAdminDashboard.Controls.Add(this.lblWelcome);
            this.pnlAdminDashboard.Controls.Add(this.mtViewWaiter);
            this.pnlAdminDashboard.Controls.Add(this.mtOrder);
            this.pnlAdminDashboard.Controls.Add(this.mtBillGenerate);
            this.pnlAdminDashboard.Controls.Add(this.mtFinancials);
            this.pnlAdminDashboard.Controls.Add(this.mtTable);
            this.pnlAdminDashboard.Controls.Add(this.btnLogOut);
            this.pnlAdminDashboard.HorizontalScrollbarBarColor = true;
            this.pnlAdminDashboard.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAdminDashboard.HorizontalScrollbarSize = 12;
            this.pnlAdminDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAdminDashboard.Name = "pnlAdminDashboard";
            this.pnlAdminDashboard.Size = new System.Drawing.Size(735, 560);
            this.pnlAdminDashboard.TabIndex = 11;
            this.pnlAdminDashboard.VerticalScrollbarBarColor = true;
            this.pnlAdminDashboard.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAdminDashboard.VerticalScrollbarSize = 13;
            // 
            // mtMenu
            // 
            this.mtMenu.ActiveControl = null;
            this.mtMenu.BackColor = System.Drawing.Color.White;
            this.mtMenu.Location = new System.Drawing.Point(264, 111);
            this.mtMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtMenu.Name = "mtMenu";
            this.mtMenu.Size = new System.Drawing.Size(212, 122);
            this.mtMenu.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtMenu.TabIndex = 10;
            this.mtMenu.Text = "Menu";
            this.mtMenu.UseSelectable = true;
            this.mtMenu.Click += new System.EventHandler(this.MtMenu_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(577, 39);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(38, 20);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(499, 39);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(70, 20);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome,";
            // 
            // mtViewWaiter
            // 
            this.mtViewWaiter.ActiveControl = null;
            this.mtViewWaiter.BackColor = System.Drawing.Color.White;
            this.mtViewWaiter.Location = new System.Drawing.Point(33, 111);
            this.mtViewWaiter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtViewWaiter.Name = "mtViewWaiter";
            this.mtViewWaiter.Size = new System.Drawing.Size(212, 122);
            this.mtViewWaiter.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtViewWaiter.TabIndex = 7;
            this.mtViewWaiter.Text = "View Waiters";
            this.mtViewWaiter.UseSelectable = true;
            this.mtViewWaiter.Click += new System.EventHandler(this.MtViewWaiter_Click);
            // 
            // mtOrder
            // 
            this.mtOrder.ActiveControl = null;
            this.mtOrder.Location = new System.Drawing.Point(499, 111);
            this.mtOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtOrder.Name = "mtOrder";
            this.mtOrder.Size = new System.Drawing.Size(212, 122);
            this.mtOrder.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtOrder.TabIndex = 6;
            this.mtOrder.Text = "Order";
            this.mtOrder.UseSelectable = true;
            this.mtOrder.Click += new System.EventHandler(this.MtOrder_Click);
            // 
            // mtBillGenerate
            // 
            this.mtBillGenerate.ActiveControl = null;
            this.mtBillGenerate.Location = new System.Drawing.Point(499, 277);
            this.mtBillGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtBillGenerate.Name = "mtBillGenerate";
            this.mtBillGenerate.Size = new System.Drawing.Size(212, 122);
            this.mtBillGenerate.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtBillGenerate.TabIndex = 5;
            this.mtBillGenerate.Text = "Bill Generate";
            this.mtBillGenerate.UseSelectable = true;
            this.mtBillGenerate.Click += new System.EventHandler(this.MtBillGenerate_Click);
            // 
            // mtFinancials
            // 
            this.mtFinancials.ActiveControl = null;
            this.mtFinancials.Location = new System.Drawing.Point(264, 277);
            this.mtFinancials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtFinancials.Name = "mtFinancials";
            this.mtFinancials.Size = new System.Drawing.Size(212, 122);
            this.mtFinancials.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtFinancials.TabIndex = 4;
            this.mtFinancials.Text = "Financials";
            this.mtFinancials.UseSelectable = true;
            this.mtFinancials.Click += new System.EventHandler(this.MtFinancials_Click);
            // 
            // mtTable
            // 
            this.mtTable.ActiveControl = null;
            this.mtTable.Location = new System.Drawing.Point(32, 277);
            this.mtTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtTable.Name = "mtTable";
            this.mtTable.Size = new System.Drawing.Size(212, 122);
            this.mtTable.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtTable.TabIndex = 2;
            this.mtTable.Text = "Table";
            this.mtTable.UseSelectable = true;
            this.mtTable.Click += new System.EventHandler(this.MtTable_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(577, 468);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(116, 33);
            this.btnLogOut.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseCustomBackColor = true;
            this.btnLogOut.UseCustomForeColor = true;
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // lblAdminBlood_Group
            // 
            this.lblAdminBlood_Group.AutoSize = true;
            this.lblAdminBlood_Group.Location = new System.Drawing.Point(381, 412);
            this.lblAdminBlood_Group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminBlood_Group.Name = "lblAdminBlood_Group";
            this.lblAdminBlood_Group.Size = new System.Drawing.Size(87, 20);
            this.lblAdminBlood_Group.TabIndex = 21;
            this.lblAdminBlood_Group.Text = "Blood Group";
            // 
            // txtManagerBlood_Group
            // 
            this.txtManagerBlood_Group.Location = new System.Drawing.Point(519, 415);
            this.txtManagerBlood_Group.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerBlood_Group.Name = "txtManagerBlood_Group";
            this.txtManagerBlood_Group.ReadOnly = true;
            this.txtManagerBlood_Group.Size = new System.Drawing.Size(132, 22);
            this.txtManagerBlood_Group.TabIndex = 20;
            // 
            // lblAdminMarital_Status
            // 
            this.lblAdminMarital_Status.AutoSize = true;
            this.lblAdminMarital_Status.Location = new System.Drawing.Point(377, 332);
            this.lblAdminMarital_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminMarital_Status.Name = "lblAdminMarital_Status";
            this.lblAdminMarital_Status.Size = new System.Drawing.Size(90, 20);
            this.lblAdminMarital_Status.TabIndex = 19;
            this.lblAdminMarital_Status.Text = "Marital Status";
            // 
            // txtManagerMaritalStatus
            // 
            this.txtManagerMaritalStatus.Location = new System.Drawing.Point(519, 335);
            this.txtManagerMaritalStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerMaritalStatus.Name = "txtManagerMaritalStatus";
            this.txtManagerMaritalStatus.ReadOnly = true;
            this.txtManagerMaritalStatus.Size = new System.Drawing.Size(132, 22);
            this.txtManagerMaritalStatus.TabIndex = 18;
            // 
            // lblAdminJoining_Date
            // 
            this.lblAdminJoining_Date.AutoSize = true;
            this.lblAdminJoining_Date.Location = new System.Drawing.Point(377, 255);
            this.lblAdminJoining_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminJoining_Date.Name = "lblAdminJoining_Date";
            this.lblAdminJoining_Date.Size = new System.Drawing.Size(85, 20);
            this.lblAdminJoining_Date.TabIndex = 17;
            this.lblAdminJoining_Date.Text = "Joining Date";
            // 
            // txtManagerJoining_Date
            // 
            this.txtManagerJoining_Date.Location = new System.Drawing.Point(519, 255);
            this.txtManagerJoining_Date.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerJoining_Date.Name = "txtManagerJoining_Date";
            this.txtManagerJoining_Date.ReadOnly = true;
            this.txtManagerJoining_Date.Size = new System.Drawing.Size(132, 22);
            this.txtManagerJoining_Date.TabIndex = 16;
            // 
            // lblAdminDate_Of_Birth
            // 
            this.lblAdminDate_Of_Birth.AutoSize = true;
            this.lblAdminDate_Of_Birth.Location = new System.Drawing.Point(375, 172);
            this.lblAdminDate_Of_Birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminDate_Of_Birth.Name = "lblAdminDate_Of_Birth";
            this.lblAdminDate_Of_Birth.Size = new System.Drawing.Size(87, 20);
            this.lblAdminDate_Of_Birth.TabIndex = 15;
            this.lblAdminDate_Of_Birth.Text = "Date of Birth";
            // 
            // txtManagerDate_Of_Birth
            // 
            this.txtManagerDate_Of_Birth.Location = new System.Drawing.Point(519, 175);
            this.txtManagerDate_Of_Birth.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerDate_Of_Birth.Name = "txtManagerDate_Of_Birth";
            this.txtManagerDate_Of_Birth.ReadOnly = true;
            this.txtManagerDate_Of_Birth.Size = new System.Drawing.Size(132, 22);
            this.txtManagerDate_Of_Birth.TabIndex = 14;
            // 
            // lblAdminGender
            // 
            this.lblAdminGender.AutoSize = true;
            this.lblAdminGender.Location = new System.Drawing.Point(392, 103);
            this.lblAdminGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminGender.Name = "lblAdminGender";
            this.lblAdminGender.Size = new System.Drawing.Size(56, 20);
            this.lblAdminGender.TabIndex = 13;
            this.lblAdminGender.Text = "Gender";
            // 
            // txtManagerGender
            // 
            this.txtManagerGender.Location = new System.Drawing.Point(519, 103);
            this.txtManagerGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerGender.Name = "txtManagerGender";
            this.txtManagerGender.ReadOnly = true;
            this.txtManagerGender.Size = new System.Drawing.Size(132, 22);
            this.txtManagerGender.TabIndex = 12;
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.Location = new System.Drawing.Point(56, 332);
            this.lblAdminEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(42, 20);
            this.lblAdminEmail.TabIndex = 11;
            this.lblAdminEmail.Text = "Email";
            // 
            // txtManagerEmail
            // 
            this.txtManagerEmail.Location = new System.Drawing.Point(153, 336);
            this.txtManagerEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerEmail.Name = "txtManagerEmail";
            this.txtManagerEmail.ReadOnly = true;
            this.txtManagerEmail.Size = new System.Drawing.Size(132, 22);
            this.txtManagerEmail.TabIndex = 10;
            // 
            // lblAdminPhone
            // 
            this.lblAdminPhone.AutoSize = true;
            this.lblAdminPhone.Location = new System.Drawing.Point(49, 412);
            this.lblAdminPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminPhone.Name = "lblAdminPhone";
            this.lblAdminPhone.Size = new System.Drawing.Size(49, 20);
            this.lblAdminPhone.TabIndex = 9;
            this.lblAdminPhone.Text = "Phone";
            // 
            // txtManagerPhone
            // 
            this.txtManagerPhone.Location = new System.Drawing.Point(153, 414);
            this.txtManagerPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerPhone.Name = "txtManagerPhone";
            this.txtManagerPhone.ReadOnly = true;
            this.txtManagerPhone.Size = new System.Drawing.Size(132, 22);
            this.txtManagerPhone.TabIndex = 8;
            // 
            // lblAdminAddress
            // 
            this.lblAdminAddress.AutoSize = true;
            this.lblAdminAddress.Location = new System.Drawing.Point(36, 252);
            this.lblAdminAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminAddress.Name = "lblAdminAddress";
            this.lblAdminAddress.Size = new System.Drawing.Size(59, 20);
            this.lblAdminAddress.TabIndex = 7;
            this.lblAdminAddress.Text = "Address";
            // 
            // txtManagerAddress
            // 
            this.txtManagerAddress.Location = new System.Drawing.Point(153, 258);
            this.txtManagerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerAddress.Name = "txtManagerAddress";
            this.txtManagerAddress.ReadOnly = true;
            this.txtManagerAddress.Size = new System.Drawing.Size(132, 22);
            this.txtManagerAddress.TabIndex = 6;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(51, 172);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(47, 20);
            this.lblAdminName.TabIndex = 5;
            this.lblAdminName.Text = "Name";
            // 
            // txtManagerName
            // 
            this.txtManagerName.Location = new System.Drawing.Point(153, 181);
            this.txtManagerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.ReadOnly = true;
            this.txtManagerName.Size = new System.Drawing.Size(132, 22);
            this.txtManagerName.TabIndex = 4;
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminId.Location = new System.Drawing.Point(84, 105);
            this.lblAdminId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(20, 20);
            this.lblAdminId.TabIndex = 3;
            this.lblAdminId.Text = "Id";
            // 
            // txtMangerId
            // 
            this.txtMangerId.Location = new System.Drawing.Point(153, 103);
            this.txtMangerId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMangerId.Name = "txtMangerId";
            this.txtMangerId.ReadOnly = true;
            this.txtMangerId.Size = new System.Drawing.Size(132, 22);
            this.txtMangerId.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(559, 481);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 45);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AccessibleName = "lblSalary";
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(51, 471);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(46, 20);
            this.lblSalary.TabIndex = 24;
            this.lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.AcceptsReturn = true;
            this.txtSalary.AccessibleName = "";
            this.txtSalary.Location = new System.Drawing.Point(155, 473);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(132, 22);
            this.txtSalary.TabIndex = 23;
            // 
            // Manager_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlMyProfile);
            this.Controls.Add(this.pnlAdminProfile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manager_Dashboard";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Manager Dashboard";
            this.Load += new System.EventHandler(this.Manager_Dashboard_Load);
            this.pnlMyProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdmin)).EndInit();
            this.pnlAdminProfile.ResumeLayout(false);
            this.pnlAdminProfile.PerformLayout();
            this.pnlAdminDashboard.ResumeLayout(false);
            this.pnlAdminDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMyProfile;
        private MetroFramework.Controls.MetroTile mtMyProfile;
        private MetroFramework.Controls.MetroPanel pnlAdminProfile;
        private MetroFramework.Controls.MetroLabel lblAdminBlood_Group;
        private System.Windows.Forms.TextBox txtManagerBlood_Group;
        private MetroFramework.Controls.MetroLabel lblAdminMarital_Status;
        private System.Windows.Forms.TextBox txtManagerMaritalStatus;
        private MetroFramework.Controls.MetroLabel lblAdminJoining_Date;
        private System.Windows.Forms.TextBox txtManagerJoining_Date;
        private MetroFramework.Controls.MetroLabel lblAdminDate_Of_Birth;
        private System.Windows.Forms.TextBox txtManagerDate_Of_Birth;
        private MetroFramework.Controls.MetroLabel lblAdminGender;
        private System.Windows.Forms.TextBox txtManagerGender;
        private MetroFramework.Controls.MetroLabel lblAdminEmail;
        private System.Windows.Forms.TextBox txtManagerEmail;
        private MetroFramework.Controls.MetroLabel lblAdminPhone;
        private System.Windows.Forms.TextBox txtManagerPhone;
        private MetroFramework.Controls.MetroLabel lblAdminAddress;
        private System.Windows.Forms.TextBox txtManagerAddress;
        private MetroFramework.Controls.MetroLabel lblAdminName;
        private System.Windows.Forms.TextBox txtManagerName;
        private MetroFramework.Controls.MetroLabel lblAdminId;
        private System.Windows.Forms.TextBox txtMangerId;
        private MetroFramework.Controls.MetroPanel pnlAdminDashboard;
        private MetroFramework.Controls.MetroLabel lblUserName;
        private MetroFramework.Controls.MetroLabel lblWelcome;
        private MetroFramework.Controls.MetroTile mtViewWaiter;
        private MetroFramework.Controls.MetroTile mtOrder;
        private MetroFramework.Controls.MetroTile mtBillGenerate;
        private MetroFramework.Controls.MetroTile mtFinancials;
        private MetroFramework.Controls.MetroTile mtTable;
        private MetroFramework.Controls.MetroButton btnLogOut;
        private System.Windows.Forms.PictureBox ptbAdmin;
        private MetroFramework.Controls.MetroTile mtMenu;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroLabel lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
    }
}