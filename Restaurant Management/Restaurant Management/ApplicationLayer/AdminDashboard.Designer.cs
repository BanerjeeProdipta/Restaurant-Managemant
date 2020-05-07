namespace Restaurant_Management.ApplicationLayer
{
    partial class AdminDashboard
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
            this.mtMenu = new MetroFramework.Controls.MetroTile();
            this.mtTable = new MetroFramework.Controls.MetroTile();
            this.mtFinancials = new MetroFramework.Controls.MetroTile();
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.mtManageAdmin = new MetroFramework.Controls.MetroTile();
            this.mtOrder = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAdminProfile = new MetroFramework.Controls.MetroPanel();
            this.lblAdminBlood_Group = new MetroFramework.Controls.MetroLabel();
            this.txtAdminBlood_Group = new System.Windows.Forms.TextBox();
            this.lblAdminMarital_Status = new MetroFramework.Controls.MetroLabel();
            this.txtAdminMaritalStatus = new System.Windows.Forms.TextBox();
            this.lblAdminJoining_Date = new MetroFramework.Controls.MetroLabel();
            this.txtAdminJoining_Date = new System.Windows.Forms.TextBox();
            this.lblAdminDate_Of_Birth = new MetroFramework.Controls.MetroLabel();
            this.txtAdminDate_Of_Birth = new System.Windows.Forms.TextBox();
            this.lblAdminGender = new MetroFramework.Controls.MetroLabel();
            this.txtAdminGender = new System.Windows.Forms.TextBox();
            this.lblAdminEmail = new MetroFramework.Controls.MetroLabel();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.lblAdminPhone = new MetroFramework.Controls.MetroLabel();
            this.txtAdminPhone = new System.Windows.Forms.TextBox();
            this.lblAdminAddress = new MetroFramework.Controls.MetroLabel();
            this.txtAdminAddress = new System.Windows.Forms.TextBox();
            this.lblAdminName = new MetroFramework.Controls.MetroLabel();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.lblAdminId = new MetroFramework.Controls.MetroLabel();
            this.txtAdminId = new System.Windows.Forms.TextBox();
            this.btnAdminUpdate = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.pnlAdminDashboard = new MetroFramework.Controls.MetroPanel();
            this.mtManageWaiter = new MetroFramework.Controls.MetroTile();
            this.mtManageManager = new MetroFramework.Controls.MetroTile();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.lblWelcome = new MetroFramework.Controls.MetroLabel();
            this.mtAddEmployee = new MetroFramework.Controls.MetroTile();
            this.pnlMyProfile = new MetroFramework.Controls.MetroPanel();
            this.mtMyProfile = new MetroFramework.Controls.MetroTile();
            this.ptbAdmin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlAdminProfile.SuspendLayout();
            this.pnlAdminDashboard.SuspendLayout();
            this.pnlMyProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // mtMenu
            // 
            this.mtMenu.ActiveControl = null;
            this.mtMenu.BackColor = System.Drawing.Color.White;
            this.mtMenu.Location = new System.Drawing.Point(376, 277);
            this.mtMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtMenu.Name = "mtMenu";
            this.mtMenu.Size = new System.Drawing.Size(170, 122);
            this.mtMenu.Style = MetroFramework.MetroColorStyle.Green;
            this.mtMenu.TabIndex = 1;
            this.mtMenu.Text = "Menu";
            this.mtMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtMenu.UseSelectable = true;
            this.mtMenu.Click += new System.EventHandler(this.MtMenu_Click);
            // 
            // mtTable
            // 
            this.mtTable.ActiveControl = null;
            this.mtTable.Location = new System.Drawing.Point(6, 277);
            this.mtTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtTable.Name = "mtTable";
            this.mtTable.Size = new System.Drawing.Size(155, 122);
            this.mtTable.Style = MetroFramework.MetroColorStyle.Green;
            this.mtTable.TabIndex = 2;
            this.mtTable.Text = "Table";
            this.mtTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtTable.UseSelectable = true;
            this.mtTable.Click += new System.EventHandler(this.MtTable_Click);
            // 
            // mtFinancials
            // 
            this.mtFinancials.ActiveControl = null;
            this.mtFinancials.Location = new System.Drawing.Point(575, 277);
            this.mtFinancials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtFinancials.Name = "mtFinancials";
            this.mtFinancials.Size = new System.Drawing.Size(164, 122);
            this.mtFinancials.Style = MetroFramework.MetroColorStyle.Green;
            this.mtFinancials.TabIndex = 4;
            this.mtFinancials.Text = "Financials";
            this.mtFinancials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtFinancials.UseSelectable = true;
            this.mtFinancials.Click += new System.EventHandler(this.MtFinancials_Click_1);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(623, 486);
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
            // mtManageAdmin
            // 
            this.mtManageAdmin.ActiveControl = null;
            this.mtManageAdmin.Location = new System.Drawing.Point(189, 120);
            this.mtManageAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtManageAdmin.Name = "mtManageAdmin";
            this.mtManageAdmin.Size = new System.Drawing.Size(159, 122);
            this.mtManageAdmin.Style = MetroFramework.MetroColorStyle.Green;
            this.mtManageAdmin.TabIndex = 5;
            this.mtManageAdmin.Text = "Manage Admin";
            this.mtManageAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtManageAdmin.UseSelectable = true;
            this.mtManageAdmin.Click += new System.EventHandler(this.MtManageAdmin_Click);
            // 
            // mtOrder
            // 
            this.mtOrder.ActiveControl = null;
            this.mtOrder.Location = new System.Drawing.Point(189, 277);
            this.mtOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtOrder.Name = "mtOrder";
            this.mtOrder.Size = new System.Drawing.Size(159, 122);
            this.mtOrder.Style = MetroFramework.MetroColorStyle.Green;
            this.mtOrder.TabIndex = 6;
            this.mtOrder.Text = "Order";
            this.mtOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtOrder.UseSelectable = true;
            this.mtOrder.Click += new System.EventHandler(this.MtOrder_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlAdminProfile);
            this.panel1.Location = new System.Drawing.Point(304, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 564);
            this.panel1.TabIndex = 7;
            // 
            // pnlAdminProfile
            // 
            this.pnlAdminProfile.Controls.Add(this.lblAdminBlood_Group);
            this.pnlAdminProfile.Controls.Add(this.txtAdminBlood_Group);
            this.pnlAdminProfile.Controls.Add(this.lblAdminMarital_Status);
            this.pnlAdminProfile.Controls.Add(this.txtAdminMaritalStatus);
            this.pnlAdminProfile.Controls.Add(this.lblAdminJoining_Date);
            this.pnlAdminProfile.Controls.Add(this.txtAdminJoining_Date);
            this.pnlAdminProfile.Controls.Add(this.lblAdminDate_Of_Birth);
            this.pnlAdminProfile.Controls.Add(this.txtAdminDate_Of_Birth);
            this.pnlAdminProfile.Controls.Add(this.lblAdminGender);
            this.pnlAdminProfile.Controls.Add(this.txtAdminGender);
            this.pnlAdminProfile.Controls.Add(this.lblAdminEmail);
            this.pnlAdminProfile.Controls.Add(this.txtAdminEmail);
            this.pnlAdminProfile.Controls.Add(this.lblAdminPhone);
            this.pnlAdminProfile.Controls.Add(this.txtAdminPhone);
            this.pnlAdminProfile.Controls.Add(this.lblAdminAddress);
            this.pnlAdminProfile.Controls.Add(this.txtAdminAddress);
            this.pnlAdminProfile.Controls.Add(this.lblAdminName);
            this.pnlAdminProfile.Controls.Add(this.txtAdminName);
            this.pnlAdminProfile.Controls.Add(this.lblAdminId);
            this.pnlAdminProfile.Controls.Add(this.txtAdminId);
            this.pnlAdminProfile.Controls.Add(this.btnAdminUpdate);
            this.pnlAdminProfile.Controls.Add(this.metroLabel1);
            this.pnlAdminProfile.Controls.Add(this.txtSalary);
            this.pnlAdminProfile.HorizontalScrollbarBarColor = true;
            this.pnlAdminProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAdminProfile.HorizontalScrollbarSize = 12;
            this.pnlAdminProfile.Location = new System.Drawing.Point(-39, 0);
            this.pnlAdminProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAdminProfile.Name = "pnlAdminProfile";
            this.pnlAdminProfile.Size = new System.Drawing.Size(779, 559);
            this.pnlAdminProfile.Style = MetroFramework.MetroColorStyle.Lime;
            this.pnlAdminProfile.TabIndex = 8;
            this.pnlAdminProfile.VerticalScrollbarBarColor = true;
            this.pnlAdminProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAdminProfile.VerticalScrollbarSize = 13;
            // 
            // lblAdminBlood_Group
            // 
            this.lblAdminBlood_Group.AutoSize = true;
            this.lblAdminBlood_Group.Location = new System.Drawing.Point(381, 429);
            this.lblAdminBlood_Group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminBlood_Group.Name = "lblAdminBlood_Group";
            this.lblAdminBlood_Group.Size = new System.Drawing.Size(87, 20);
            this.lblAdminBlood_Group.TabIndex = 21;
            this.lblAdminBlood_Group.Text = "Blood Group";
            // 
            // txtAdminBlood_Group
            // 
            this.txtAdminBlood_Group.Location = new System.Drawing.Point(519, 432);
            this.txtAdminBlood_Group.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminBlood_Group.Name = "txtAdminBlood_Group";
            this.txtAdminBlood_Group.ReadOnly = true;
            this.txtAdminBlood_Group.Size = new System.Drawing.Size(132, 22);
            this.txtAdminBlood_Group.TabIndex = 20;
            // 
            // lblAdminMarital_Status
            // 
            this.lblAdminMarital_Status.AutoSize = true;
            this.lblAdminMarital_Status.Location = new System.Drawing.Point(377, 349);
            this.lblAdminMarital_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminMarital_Status.Name = "lblAdminMarital_Status";
            this.lblAdminMarital_Status.Size = new System.Drawing.Size(90, 20);
            this.lblAdminMarital_Status.TabIndex = 19;
            this.lblAdminMarital_Status.Text = "Marital Status";
            // 
            // txtAdminMaritalStatus
            // 
            this.txtAdminMaritalStatus.Location = new System.Drawing.Point(519, 352);
            this.txtAdminMaritalStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminMaritalStatus.Name = "txtAdminMaritalStatus";
            this.txtAdminMaritalStatus.ReadOnly = true;
            this.txtAdminMaritalStatus.Size = new System.Drawing.Size(132, 22);
            this.txtAdminMaritalStatus.TabIndex = 18;
            // 
            // lblAdminJoining_Date
            // 
            this.lblAdminJoining_Date.AutoSize = true;
            this.lblAdminJoining_Date.Location = new System.Drawing.Point(377, 272);
            this.lblAdminJoining_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminJoining_Date.Name = "lblAdminJoining_Date";
            this.lblAdminJoining_Date.Size = new System.Drawing.Size(85, 20);
            this.lblAdminJoining_Date.TabIndex = 17;
            this.lblAdminJoining_Date.Text = "Joining Date";
            // 
            // txtAdminJoining_Date
            // 
            this.txtAdminJoining_Date.Location = new System.Drawing.Point(519, 272);
            this.txtAdminJoining_Date.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminJoining_Date.Name = "txtAdminJoining_Date";
            this.txtAdminJoining_Date.ReadOnly = true;
            this.txtAdminJoining_Date.Size = new System.Drawing.Size(132, 22);
            this.txtAdminJoining_Date.TabIndex = 16;
            // 
            // lblAdminDate_Of_Birth
            // 
            this.lblAdminDate_Of_Birth.AutoSize = true;
            this.lblAdminDate_Of_Birth.Location = new System.Drawing.Point(375, 189);
            this.lblAdminDate_Of_Birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminDate_Of_Birth.Name = "lblAdminDate_Of_Birth";
            this.lblAdminDate_Of_Birth.Size = new System.Drawing.Size(87, 20);
            this.lblAdminDate_Of_Birth.TabIndex = 15;
            this.lblAdminDate_Of_Birth.Text = "Date of Birth";
            // 
            // txtAdminDate_Of_Birth
            // 
            this.txtAdminDate_Of_Birth.Location = new System.Drawing.Point(519, 192);
            this.txtAdminDate_Of_Birth.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminDate_Of_Birth.Name = "txtAdminDate_Of_Birth";
            this.txtAdminDate_Of_Birth.ReadOnly = true;
            this.txtAdminDate_Of_Birth.Size = new System.Drawing.Size(132, 22);
            this.txtAdminDate_Of_Birth.TabIndex = 14;
            // 
            // lblAdminGender
            // 
            this.lblAdminGender.AutoSize = true;
            this.lblAdminGender.Location = new System.Drawing.Point(392, 120);
            this.lblAdminGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminGender.Name = "lblAdminGender";
            this.lblAdminGender.Size = new System.Drawing.Size(56, 20);
            this.lblAdminGender.TabIndex = 13;
            this.lblAdminGender.Text = "Gender";
            // 
            // txtAdminGender
            // 
            this.txtAdminGender.Location = new System.Drawing.Point(519, 120);
            this.txtAdminGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminGender.Name = "txtAdminGender";
            this.txtAdminGender.ReadOnly = true;
            this.txtAdminGender.Size = new System.Drawing.Size(132, 22);
            this.txtAdminGender.TabIndex = 12;
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.Location = new System.Drawing.Point(56, 271);
            this.lblAdminEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(42, 20);
            this.lblAdminEmail.TabIndex = 11;
            this.lblAdminEmail.Text = "Email";
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Location = new System.Drawing.Point(153, 275);
            this.txtAdminEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.ReadOnly = true;
            this.txtAdminEmail.Size = new System.Drawing.Size(132, 22);
            this.txtAdminEmail.TabIndex = 10;
            // 
            // lblAdminPhone
            // 
            this.lblAdminPhone.AutoSize = true;
            this.lblAdminPhone.Location = new System.Drawing.Point(49, 351);
            this.lblAdminPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminPhone.Name = "lblAdminPhone";
            this.lblAdminPhone.Size = new System.Drawing.Size(49, 20);
            this.lblAdminPhone.TabIndex = 9;
            this.lblAdminPhone.Text = "Phone";
            // 
            // txtAdminPhone
            // 
            this.txtAdminPhone.Location = new System.Drawing.Point(153, 353);
            this.txtAdminPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminPhone.Name = "txtAdminPhone";
            this.txtAdminPhone.ReadOnly = true;
            this.txtAdminPhone.Size = new System.Drawing.Size(132, 22);
            this.txtAdminPhone.TabIndex = 8;
            // 
            // lblAdminAddress
            // 
            this.lblAdminAddress.AutoSize = true;
            this.lblAdminAddress.Location = new System.Drawing.Point(36, 191);
            this.lblAdminAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminAddress.Name = "lblAdminAddress";
            this.lblAdminAddress.Size = new System.Drawing.Size(59, 20);
            this.lblAdminAddress.TabIndex = 7;
            this.lblAdminAddress.Text = "Address";
            // 
            // txtAdminAddress
            // 
            this.txtAdminAddress.Location = new System.Drawing.Point(153, 197);
            this.txtAdminAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminAddress.Name = "txtAdminAddress";
            this.txtAdminAddress.ReadOnly = true;
            this.txtAdminAddress.Size = new System.Drawing.Size(132, 22);
            this.txtAdminAddress.TabIndex = 6;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(51, 111);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(47, 20);
            this.lblAdminName.TabIndex = 5;
            this.lblAdminName.Text = "Name";
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(153, 120);
            this.txtAdminName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.ReadOnly = true;
            this.txtAdminName.Size = new System.Drawing.Size(132, 22);
            this.txtAdminName.TabIndex = 4;
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminId.Location = new System.Drawing.Point(84, 44);
            this.lblAdminId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(20, 20);
            this.lblAdminId.TabIndex = 3;
            this.lblAdminId.Text = "Id";
            // 
            // txtAdminId
            // 
            this.txtAdminId.Location = new System.Drawing.Point(153, 42);
            this.txtAdminId.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminId.Name = "txtAdminId";
            this.txtAdminId.ReadOnly = true;
            this.txtAdminId.Size = new System.Drawing.Size(132, 22);
            this.txtAdminId.TabIndex = 2;
            // 
            // btnAdminUpdate
            // 
            this.btnAdminUpdate.Location = new System.Drawing.Point(576, 496);
            this.btnAdminUpdate.Name = "btnAdminUpdate";
            this.btnAdminUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAdminUpdate.TabIndex = 22;
            this.btnAdminUpdate.Text = "Update";
            this.btnAdminUpdate.UseSelectable = true;
            this.btnAdminUpdate.Click += new System.EventHandler(this.BtnAdminUpdate_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 427);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 20);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(153, 427);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(132, 22);
            this.txtSalary.TabIndex = 24;
            // 
            // pnlAdminDashboard
            // 
            this.pnlAdminDashboard.Controls.Add(this.mtManageWaiter);
            this.pnlAdminDashboard.Controls.Add(this.mtManageManager);
            this.pnlAdminDashboard.Controls.Add(this.lblUserName);
            this.pnlAdminDashboard.Controls.Add(this.lblWelcome);
            this.pnlAdminDashboard.Controls.Add(this.mtAddEmployee);
            this.pnlAdminDashboard.Controls.Add(this.mtOrder);
            this.pnlAdminDashboard.Controls.Add(this.mtManageAdmin);
            this.pnlAdminDashboard.Controls.Add(this.mtFinancials);
            this.pnlAdminDashboard.Controls.Add(this.mtTable);
            this.pnlAdminDashboard.Controls.Add(this.btnLogOut);
            this.pnlAdminDashboard.Controls.Add(this.mtMenu);
            this.pnlAdminDashboard.HorizontalScrollbarBarColor = true;
            this.pnlAdminDashboard.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAdminDashboard.HorizontalScrollbarSize = 12;
            this.pnlAdminDashboard.Location = new System.Drawing.Point(274, -1);
            this.pnlAdminDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAdminDashboard.Name = "pnlAdminDashboard";
            this.pnlAdminDashboard.Size = new System.Drawing.Size(775, 564);
            this.pnlAdminDashboard.TabIndex = 9;
            this.pnlAdminDashboard.VerticalScrollbarBarColor = true;
            this.pnlAdminDashboard.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAdminDashboard.VerticalScrollbarSize = 13;
            // 
            // mtManageWaiter
            // 
            this.mtManageWaiter.ActiveControl = null;
            this.mtManageWaiter.Location = new System.Drawing.Point(575, 120);
            this.mtManageWaiter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtManageWaiter.Name = "mtManageWaiter";
            this.mtManageWaiter.Size = new System.Drawing.Size(164, 122);
            this.mtManageWaiter.Style = MetroFramework.MetroColorStyle.Green;
            this.mtManageWaiter.TabIndex = 11;
            this.mtManageWaiter.Text = "Manage Waiter";
            this.mtManageWaiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtManageWaiter.UseSelectable = true;
            this.mtManageWaiter.Click += new System.EventHandler(this.MtManageWaiter_Click);
            // 
            // mtManageManager
            // 
            this.mtManageManager.ActiveControl = null;
            this.mtManageManager.Location = new System.Drawing.Point(376, 120);
            this.mtManageManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtManageManager.Name = "mtManageManager";
            this.mtManageManager.Size = new System.Drawing.Size(170, 122);
            this.mtManageManager.Style = MetroFramework.MetroColorStyle.Green;
            this.mtManageManager.TabIndex = 10;
            this.mtManageManager.Text = "Manage Manager";
            this.mtManageManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtManageManager.UseSelectable = true;
            this.mtManageManager.Click += new System.EventHandler(this.MtManageManager_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(675, 42);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(38, 20);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(597, 42);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(70, 20);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome,";
            // 
            // mtAddEmployee
            // 
            this.mtAddEmployee.ActiveControl = null;
            this.mtAddEmployee.BackColor = System.Drawing.Color.White;
            this.mtAddEmployee.Location = new System.Drawing.Point(6, 120);
            this.mtAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtAddEmployee.Name = "mtAddEmployee";
            this.mtAddEmployee.Size = new System.Drawing.Size(155, 122);
            this.mtAddEmployee.Style = MetroFramework.MetroColorStyle.Green;
            this.mtAddEmployee.TabIndex = 7;
            this.mtAddEmployee.Text = "Add Employee";
            this.mtAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAddEmployee.UseSelectable = true;
            this.mtAddEmployee.Click += new System.EventHandler(this.MtEmployee_Click);
            // 
            // pnlMyProfile
            // 
            this.pnlMyProfile.Controls.Add(this.mtMyProfile);
            this.pnlMyProfile.Controls.Add(this.ptbAdmin);
            this.pnlMyProfile.HorizontalScrollbarBarColor = true;
            this.pnlMyProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMyProfile.HorizontalScrollbarSize = 12;
            this.pnlMyProfile.Location = new System.Drawing.Point(-7, 78);
            this.pnlMyProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMyProfile.Name = "pnlMyProfile";
            this.pnlMyProfile.Size = new System.Drawing.Size(270, 484);
            this.pnlMyProfile.Style = MetroFramework.MetroColorStyle.Teal;
            this.pnlMyProfile.TabIndex = 8;
            this.pnlMyProfile.VerticalScrollbarBarColor = true;
            this.pnlMyProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMyProfile.VerticalScrollbarSize = 13;
            // 
            // mtMyProfile
            // 
            this.mtMyProfile.ActiveControl = null;
            this.mtMyProfile.Location = new System.Drawing.Point(4, 351);
            this.mtMyProfile.Margin = new System.Windows.Forms.Padding(4);
            this.mtMyProfile.Name = "mtMyProfile";
            this.mtMyProfile.Size = new System.Drawing.Size(266, 79);
            this.mtMyProfile.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtMyProfile.TabIndex = 3;
            this.mtMyProfile.Text = "My Profile";
            this.mtMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtMyProfile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtMyProfile.UseSelectable = true;
            this.mtMyProfile.Click += new System.EventHandler(this.MtMyProfile_Click);
            // 
            // ptbAdmin
            // 
            this.ptbAdmin.Image = global::Restaurant_Management.Properties.Resources.admin_png_icon_7;
            this.ptbAdmin.Location = new System.Drawing.Point(26, 97);
            this.ptbAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.ptbAdmin.Name = "ptbAdmin";
            this.ptbAdmin.Size = new System.Drawing.Size(224, 193);
            this.ptbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAdmin.TabIndex = 2;
            this.ptbAdmin.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 554);
            this.Controls.Add(this.pnlAdminDashboard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMyProfile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminDashboard";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.pnlAdminProfile.ResumeLayout(false);
            this.pnlAdminProfile.PerformLayout();
            this.pnlAdminDashboard.ResumeLayout(false);
            this.pnlAdminDashboard.PerformLayout();
            this.pnlMyProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtMenu;
        private MetroFramework.Controls.MetroTile mtTable;
        private MetroFramework.Controls.MetroTile mtFinancials;
        private MetroFramework.Controls.MetroButton btnLogOut;
        private MetroFramework.Controls.MetroTile mtManageAdmin;
        private MetroFramework.Controls.MetroTile mtOrder;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile mtAddEmployee;
        private MetroFramework.Controls.MetroPanel pnlMyProfile;
        private MetroFramework.Controls.MetroTile mtMyProfile;
        private System.Windows.Forms.PictureBox ptbAdmin;
        private MetroFramework.Controls.MetroPanel pnlAdminProfile;
        private MetroFramework.Controls.MetroButton btnAdminUpdate;
        private MetroFramework.Controls.MetroLabel lblAdminPhone;
        private System.Windows.Forms.TextBox txtAdminPhone;
        private MetroFramework.Controls.MetroLabel lblAdminAddress;
        private System.Windows.Forms.TextBox txtAdminAddress;
        private MetroFramework.Controls.MetroLabel lblAdminName;
        private System.Windows.Forms.TextBox txtAdminName;
        private MetroFramework.Controls.MetroLabel lblAdminId;
        private System.Windows.Forms.TextBox txtAdminId;
        private MetroFramework.Controls.MetroLabel lblAdminMarital_Status;
        private MetroFramework.Controls.MetroLabel lblAdminJoining_Date;
        private MetroFramework.Controls.MetroLabel lblAdminDate_Of_Birth;
        private MetroFramework.Controls.MetroLabel lblAdminGender;
        private MetroFramework.Controls.MetroLabel lblAdminEmail;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private MetroFramework.Controls.MetroPanel pnlAdminDashboard;
        private System.Windows.Forms.TextBox txtAdminMaritalStatus;
        private System.Windows.Forms.TextBox txtAdminJoining_Date;
        private System.Windows.Forms.TextBox txtAdminDate_Of_Birth;
        private System.Windows.Forms.TextBox txtAdminGender;
        private MetroFramework.Controls.MetroLabel lblAdminBlood_Group;
        private System.Windows.Forms.TextBox txtAdminBlood_Group;
        private MetroFramework.Controls.MetroLabel lblUserName;
        private MetroFramework.Controls.MetroLabel lblWelcome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtSalary;
        private MetroFramework.Controls.MetroTile mtManageManager;
        private MetroFramework.Controls.MetroTile mtManageWaiter;
    }
}