namespace Restaurant_Management.ApplicationLayer
{
    partial class Waiter_Dashboard
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
            this.pnlWaiterDashboard = new MetroFramework.Controls.MetroPanel();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.lblWelcome = new MetroFramework.Controls.MetroLabel();
            this.mtViewCart = new MetroFramework.Controls.MetroTile();
            this.tileMenu = new MetroFramework.Controls.MetroTile();
            this.tileOrder = new MetroFramework.Controls.MetroTile();
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblAdminBlood_Group = new MetroFramework.Controls.MetroLabel();
            this.txtWaiterBlood_Group = new System.Windows.Forms.TextBox();
            this.lblAdminMarital_Status = new MetroFramework.Controls.MetroLabel();
            this.txtWaiterMaritalStatus = new System.Windows.Forms.TextBox();
            this.lblAdminJoining_Date = new MetroFramework.Controls.MetroLabel();
            this.txtWaiterJoining_Date = new System.Windows.Forms.TextBox();
            this.lblAdminDate_Of_Birth = new MetroFramework.Controls.MetroLabel();
            this.txtWaiterDate_Of_Birth = new System.Windows.Forms.TextBox();
            this.lblAdminGender = new MetroFramework.Controls.MetroLabel();
            this.txtWaiterGender = new System.Windows.Forms.TextBox();
            this.lblAdminEmail = new MetroFramework.Controls.MetroLabel();
            this.txtWaiterEmail = new System.Windows.Forms.TextBox();
            this.lblAdminPhone = new MetroFramework.Controls.MetroLabel();
            this.txtWaiterPhone = new System.Windows.Forms.TextBox();
            this.lblAdminAddress = new MetroFramework.Controls.MetroLabel();
            this.txtWaiterAddress = new System.Windows.Forms.TextBox();
            this.lblAdminName = new MetroFramework.Controls.MetroLabel();
            this.txtWaiterName = new System.Windows.Forms.TextBox();
            this.lblAdminId = new MetroFramework.Controls.MetroLabel();
            this.txtWaiterId = new System.Windows.Forms.TextBox();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.pnlMyProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdmin)).BeginInit();
            this.pnlAdminProfile.SuspendLayout();
            this.pnlWaiterDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMyProfile
            // 
            this.pnlMyProfile.Controls.Add(this.mtMyProfile);
            this.pnlMyProfile.Controls.Add(this.ptbAdmin);
            this.pnlMyProfile.HorizontalScrollbarBarColor = true;
            this.pnlMyProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMyProfile.HorizontalScrollbarSize = 12;
            this.pnlMyProfile.Location = new System.Drawing.Point(0, 69);
            this.pnlMyProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMyProfile.Name = "pnlMyProfile";
            this.pnlMyProfile.Size = new System.Drawing.Size(324, 484);
            this.pnlMyProfile.Style = MetroFramework.MetroColorStyle.Teal;
            this.pnlMyProfile.TabIndex = 9;
            this.pnlMyProfile.VerticalScrollbarBarColor = true;
            this.pnlMyProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMyProfile.VerticalScrollbarSize = 13;
            // 
            // mtMyProfile
            // 
            this.mtMyProfile.ActiveControl = null;
            this.mtMyProfile.Location = new System.Drawing.Point(0, 369);
            this.mtMyProfile.Margin = new System.Windows.Forms.Padding(4);
            this.mtMyProfile.Name = "mtMyProfile";
            this.mtMyProfile.Size = new System.Drawing.Size(319, 79);
            this.mtMyProfile.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtMyProfile.TabIndex = 3;
            this.mtMyProfile.Text = "My Profile";
            this.mtMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtMyProfile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtMyProfile.UseSelectable = true;
            this.mtMyProfile.Click += new System.EventHandler(this.MtMyProfile_Click);
            // 
            // ptbAdmin
            // 
            this.ptbAdmin.Image = global::Restaurant_Management.Properties.Resources.clipart1005846;
            this.ptbAdmin.Location = new System.Drawing.Point(41, 95);
            this.ptbAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.ptbAdmin.Name = "ptbAdmin";
            this.ptbAdmin.Size = new System.Drawing.Size(224, 193);
            this.ptbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAdmin.TabIndex = 2;
            this.ptbAdmin.TabStop = false;
            // 
            // pnlAdminProfile
            // 
            this.pnlAdminProfile.Controls.Add(this.pnlWaiterDashboard);
            this.pnlAdminProfile.Controls.Add(this.metroLabel1);
            this.pnlAdminProfile.Controls.Add(this.txtSalary);
            this.pnlAdminProfile.Controls.Add(this.lblAdminBlood_Group);
            this.pnlAdminProfile.Controls.Add(this.txtWaiterBlood_Group);
            this.pnlAdminProfile.Controls.Add(this.lblAdminMarital_Status);
            this.pnlAdminProfile.Controls.Add(this.txtWaiterMaritalStatus);
            this.pnlAdminProfile.Controls.Add(this.lblAdminJoining_Date);
            this.pnlAdminProfile.Controls.Add(this.txtWaiterJoining_Date);
            this.pnlAdminProfile.Controls.Add(this.lblAdminDate_Of_Birth);
            this.pnlAdminProfile.Controls.Add(this.txtWaiterDate_Of_Birth);
            this.pnlAdminProfile.Controls.Add(this.lblAdminGender);
            this.pnlAdminProfile.Controls.Add(this.txtWaiterGender);
            this.pnlAdminProfile.Controls.Add(this.lblAdminEmail);
            this.pnlAdminProfile.Controls.Add(this.txtWaiterEmail);
            this.pnlAdminProfile.Controls.Add(this.lblAdminPhone);
            this.pnlAdminProfile.Controls.Add(this.txtWaiterPhone);
            this.pnlAdminProfile.Controls.Add(this.lblAdminAddress);
            this.pnlAdminProfile.Controls.Add(this.txtWaiterAddress);
            this.pnlAdminProfile.Controls.Add(this.lblAdminName);
            this.pnlAdminProfile.Controls.Add(this.txtWaiterName);
            this.pnlAdminProfile.Controls.Add(this.lblAdminId);
            this.pnlAdminProfile.Controls.Add(this.txtWaiterId);
            this.pnlAdminProfile.Controls.Add(this.btnEdit);
            this.pnlAdminProfile.HorizontalScrollbarBarColor = true;
            this.pnlAdminProfile.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAdminProfile.HorizontalScrollbarSize = 12;
            this.pnlAdminProfile.Location = new System.Drawing.Point(318, -1);
            this.pnlAdminProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAdminProfile.Name = "pnlAdminProfile";
            this.pnlAdminProfile.Size = new System.Drawing.Size(739, 559);
            this.pnlAdminProfile.Style = MetroFramework.MetroColorStyle.Lime;
            this.pnlAdminProfile.TabIndex = 10;
            this.pnlAdminProfile.VerticalScrollbarBarColor = true;
            this.pnlAdminProfile.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAdminProfile.VerticalScrollbarSize = 13;
            // 
            // pnlWaiterDashboard
            // 
            this.pnlWaiterDashboard.Controls.Add(this.lblUserName);
            this.pnlWaiterDashboard.Controls.Add(this.lblWelcome);
            this.pnlWaiterDashboard.Controls.Add(this.mtViewCart);
            this.pnlWaiterDashboard.Controls.Add(this.tileMenu);
            this.pnlWaiterDashboard.Controls.Add(this.tileOrder);
            this.pnlWaiterDashboard.Controls.Add(this.btnLogOut);
            this.pnlWaiterDashboard.HorizontalScrollbarBarColor = true;
            this.pnlWaiterDashboard.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlWaiterDashboard.HorizontalScrollbarSize = 10;
            this.pnlWaiterDashboard.Location = new System.Drawing.Point(0, 2);
            this.pnlWaiterDashboard.Name = "pnlWaiterDashboard";
            this.pnlWaiterDashboard.Size = new System.Drawing.Size(724, 553);
            this.pnlWaiterDashboard.TabIndex = 11;
            this.pnlWaiterDashboard.VerticalScrollbarBarColor = true;
            this.pnlWaiterDashboard.VerticalScrollbarHighlightOnWheel = false;
            this.pnlWaiterDashboard.VerticalScrollbarSize = 10;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(571, 34);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 20);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "UserName";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(475, 34);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(67, 20);
            this.lblWelcome.TabIndex = 12;
            this.lblWelcome.Text = "Welcome";
            // 
            // mtViewCart
            // 
            this.mtViewCart.ActiveControl = null;
            this.mtViewCart.Location = new System.Drawing.Point(160, 362);
            this.mtViewCart.Name = "mtViewCart";
            this.mtViewCart.Size = new System.Drawing.Size(269, 119);
            this.mtViewCart.TabIndex = 11;
            this.mtViewCart.Text = "View Cart";
            this.mtViewCart.UseSelectable = true;
            this.mtViewCart.Click += new System.EventHandler(this.MtViewCart_Click);
            // 
            // tileMenu
            // 
            this.tileMenu.ActiveControl = null;
            this.tileMenu.Location = new System.Drawing.Point(160, 207);
            this.tileMenu.Name = "tileMenu";
            this.tileMenu.Size = new System.Drawing.Size(269, 119);
            this.tileMenu.TabIndex = 10;
            this.tileMenu.Text = "Menu";
            this.tileMenu.UseSelectable = true;
            this.tileMenu.Click += new System.EventHandler(this.TileMenu_Click);
            // 
            // tileOrder
            // 
            this.tileOrder.ActiveControl = null;
            this.tileOrder.Location = new System.Drawing.Point(160, 66);
            this.tileOrder.Name = "tileOrder";
            this.tileOrder.Size = new System.Drawing.Size(269, 119);
            this.tileOrder.TabIndex = 9;
            this.tileOrder.Text = "Take Order";
            this.tileOrder.UseSelectable = true;
            this.tileOrder.Click += new System.EventHandler(this.TileOrder_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(571, 482);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(116, 33);
            this.btnLogOut.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseCustomBackColor = true;
            this.btnLogOut.UseCustomForeColor = true;
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 442);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 20);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(153, 442);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(132, 22);
            this.txtSalary.TabIndex = 22;
            // 
            // lblAdminBlood_Group
            // 
            this.lblAdminBlood_Group.AutoSize = true;
            this.lblAdminBlood_Group.Location = new System.Drawing.Point(389, 439);
            this.lblAdminBlood_Group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminBlood_Group.Name = "lblAdminBlood_Group";
            this.lblAdminBlood_Group.Size = new System.Drawing.Size(87, 20);
            this.lblAdminBlood_Group.TabIndex = 21;
            this.lblAdminBlood_Group.Text = "Blood Group";
            // 
            // txtWaiterBlood_Group
            // 
            this.txtWaiterBlood_Group.Location = new System.Drawing.Point(527, 442);
            this.txtWaiterBlood_Group.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaiterBlood_Group.Name = "txtWaiterBlood_Group";
            this.txtWaiterBlood_Group.ReadOnly = true;
            this.txtWaiterBlood_Group.Size = new System.Drawing.Size(132, 22);
            this.txtWaiterBlood_Group.TabIndex = 20;
            // 
            // lblAdminMarital_Status
            // 
            this.lblAdminMarital_Status.AutoSize = true;
            this.lblAdminMarital_Status.Location = new System.Drawing.Point(385, 359);
            this.lblAdminMarital_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminMarital_Status.Name = "lblAdminMarital_Status";
            this.lblAdminMarital_Status.Size = new System.Drawing.Size(90, 20);
            this.lblAdminMarital_Status.TabIndex = 19;
            this.lblAdminMarital_Status.Text = "Marital Status";
            // 
            // txtWaiterMaritalStatus
            // 
            this.txtWaiterMaritalStatus.Location = new System.Drawing.Point(527, 362);
            this.txtWaiterMaritalStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaiterMaritalStatus.Name = "txtWaiterMaritalStatus";
            this.txtWaiterMaritalStatus.ReadOnly = true;
            this.txtWaiterMaritalStatus.Size = new System.Drawing.Size(132, 22);
            this.txtWaiterMaritalStatus.TabIndex = 18;
            // 
            // lblAdminJoining_Date
            // 
            this.lblAdminJoining_Date.AutoSize = true;
            this.lblAdminJoining_Date.Location = new System.Drawing.Point(385, 282);
            this.lblAdminJoining_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminJoining_Date.Name = "lblAdminJoining_Date";
            this.lblAdminJoining_Date.Size = new System.Drawing.Size(85, 20);
            this.lblAdminJoining_Date.TabIndex = 17;
            this.lblAdminJoining_Date.Text = "Joining Date";
            // 
            // txtWaiterJoining_Date
            // 
            this.txtWaiterJoining_Date.Location = new System.Drawing.Point(527, 282);
            this.txtWaiterJoining_Date.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaiterJoining_Date.Name = "txtWaiterJoining_Date";
            this.txtWaiterJoining_Date.ReadOnly = true;
            this.txtWaiterJoining_Date.Size = new System.Drawing.Size(132, 22);
            this.txtWaiterJoining_Date.TabIndex = 16;
            // 
            // lblAdminDate_Of_Birth
            // 
            this.lblAdminDate_Of_Birth.AutoSize = true;
            this.lblAdminDate_Of_Birth.Location = new System.Drawing.Point(383, 199);
            this.lblAdminDate_Of_Birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminDate_Of_Birth.Name = "lblAdminDate_Of_Birth";
            this.lblAdminDate_Of_Birth.Size = new System.Drawing.Size(87, 20);
            this.lblAdminDate_Of_Birth.TabIndex = 15;
            this.lblAdminDate_Of_Birth.Text = "Date of Birth";
            // 
            // txtWaiterDate_Of_Birth
            // 
            this.txtWaiterDate_Of_Birth.Location = new System.Drawing.Point(527, 202);
            this.txtWaiterDate_Of_Birth.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaiterDate_Of_Birth.Name = "txtWaiterDate_Of_Birth";
            this.txtWaiterDate_Of_Birth.ReadOnly = true;
            this.txtWaiterDate_Of_Birth.Size = new System.Drawing.Size(132, 22);
            this.txtWaiterDate_Of_Birth.TabIndex = 14;
            // 
            // lblAdminGender
            // 
            this.lblAdminGender.AutoSize = true;
            this.lblAdminGender.Location = new System.Drawing.Point(400, 130);
            this.lblAdminGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminGender.Name = "lblAdminGender";
            this.lblAdminGender.Size = new System.Drawing.Size(56, 20);
            this.lblAdminGender.TabIndex = 13;
            this.lblAdminGender.Text = "Gender";
            // 
            // txtWaiterGender
            // 
            this.txtWaiterGender.Location = new System.Drawing.Point(527, 130);
            this.txtWaiterGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaiterGender.Name = "txtWaiterGender";
            this.txtWaiterGender.ReadOnly = true;
            this.txtWaiterGender.Size = new System.Drawing.Size(132, 22);
            this.txtWaiterGender.TabIndex = 12;
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.Location = new System.Drawing.Point(53, 288);
            this.lblAdminEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(42, 20);
            this.lblAdminEmail.TabIndex = 11;
            this.lblAdminEmail.Text = "Email";
            // 
            // txtWaiterEmail
            // 
            this.txtWaiterEmail.Location = new System.Drawing.Point(153, 289);
            this.txtWaiterEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaiterEmail.Name = "txtWaiterEmail";
            this.txtWaiterEmail.ReadOnly = true;
            this.txtWaiterEmail.Size = new System.Drawing.Size(132, 22);
            this.txtWaiterEmail.TabIndex = 10;
            // 
            // lblAdminPhone
            // 
            this.lblAdminPhone.AutoSize = true;
            this.lblAdminPhone.Location = new System.Drawing.Point(46, 368);
            this.lblAdminPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminPhone.Name = "lblAdminPhone";
            this.lblAdminPhone.Size = new System.Drawing.Size(49, 20);
            this.lblAdminPhone.TabIndex = 9;
            this.lblAdminPhone.Text = "Phone";
            // 
            // txtWaiterPhone
            // 
            this.txtWaiterPhone.Location = new System.Drawing.Point(153, 367);
            this.txtWaiterPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaiterPhone.Name = "txtWaiterPhone";
            this.txtWaiterPhone.ReadOnly = true;
            this.txtWaiterPhone.Size = new System.Drawing.Size(132, 22);
            this.txtWaiterPhone.TabIndex = 8;
            // 
            // lblAdminAddress
            // 
            this.lblAdminAddress.AutoSize = true;
            this.lblAdminAddress.Location = new System.Drawing.Point(36, 205);
            this.lblAdminAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminAddress.Name = "lblAdminAddress";
            this.lblAdminAddress.Size = new System.Drawing.Size(59, 20);
            this.lblAdminAddress.TabIndex = 7;
            this.lblAdminAddress.Text = "Address";
            // 
            // txtWaiterAddress
            // 
            this.txtWaiterAddress.Location = new System.Drawing.Point(153, 211);
            this.txtWaiterAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaiterAddress.Name = "txtWaiterAddress";
            this.txtWaiterAddress.ReadOnly = true;
            this.txtWaiterAddress.Size = new System.Drawing.Size(132, 22);
            this.txtWaiterAddress.TabIndex = 6;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(51, 125);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(47, 20);
            this.lblAdminName.TabIndex = 5;
            this.lblAdminName.Text = "Name";
            // 
            // txtWaiterName
            // 
            this.txtWaiterName.Location = new System.Drawing.Point(153, 134);
            this.txtWaiterName.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaiterName.Name = "txtWaiterName";
            this.txtWaiterName.ReadOnly = true;
            this.txtWaiterName.Size = new System.Drawing.Size(132, 22);
            this.txtWaiterName.TabIndex = 4;
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminId.Location = new System.Drawing.Point(84, 58);
            this.lblAdminId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(20, 20);
            this.lblAdminId.TabIndex = 3;
            this.lblAdminId.Text = "Id";
            // 
            // txtWaiterId
            // 
            this.txtWaiterId.Location = new System.Drawing.Point(153, 56);
            this.txtWaiterId.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaiterId.Name = "txtWaiterId";
            this.txtWaiterId.ReadOnly = true;
            this.txtWaiterId.Size = new System.Drawing.Size(132, 22);
            this.txtWaiterId.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(584, 494);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // Waiter_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 554);
            this.Controls.Add(this.pnlAdminProfile);
            this.Controls.Add(this.pnlMyProfile);
            this.Name = "Waiter_Dashboard";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Waiter Dashboard";
            this.Load += new System.EventHandler(this.Waiter_Dashboard_Load);
            this.pnlMyProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdmin)).EndInit();
            this.pnlAdminProfile.ResumeLayout(false);
            this.pnlAdminProfile.PerformLayout();
            this.pnlWaiterDashboard.ResumeLayout(false);
            this.pnlWaiterDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMyProfile;
        private MetroFramework.Controls.MetroTile mtMyProfile;
        private System.Windows.Forms.PictureBox ptbAdmin;
        private MetroFramework.Controls.MetroPanel pnlAdminProfile;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtSalary;
        private MetroFramework.Controls.MetroLabel lblAdminBlood_Group;
        private System.Windows.Forms.TextBox txtWaiterBlood_Group;
        private MetroFramework.Controls.MetroLabel lblAdminMarital_Status;
        private System.Windows.Forms.TextBox txtWaiterMaritalStatus;
        private MetroFramework.Controls.MetroLabel lblAdminJoining_Date;
        private System.Windows.Forms.TextBox txtWaiterJoining_Date;
        private MetroFramework.Controls.MetroLabel lblAdminDate_Of_Birth;
        private System.Windows.Forms.TextBox txtWaiterDate_Of_Birth;
        private MetroFramework.Controls.MetroLabel lblAdminGender;
        private System.Windows.Forms.TextBox txtWaiterGender;
        private MetroFramework.Controls.MetroLabel lblAdminEmail;
        private System.Windows.Forms.TextBox txtWaiterEmail;
        private MetroFramework.Controls.MetroLabel lblAdminPhone;
        private System.Windows.Forms.TextBox txtWaiterPhone;
        private MetroFramework.Controls.MetroLabel lblAdminAddress;
        private System.Windows.Forms.TextBox txtWaiterAddress;
        private MetroFramework.Controls.MetroLabel lblAdminName;
        private System.Windows.Forms.TextBox txtWaiterName;
        private MetroFramework.Controls.MetroLabel lblAdminId;
        private System.Windows.Forms.TextBox txtWaiterId;
        private MetroFramework.Controls.MetroPanel pnlWaiterDashboard;
        private MetroFramework.Controls.MetroButton btnLogOut;
        private MetroFramework.Controls.MetroTile tileMenu;
        private MetroFramework.Controls.MetroTile tileOrder;
        private MetroFramework.Controls.MetroTile mtViewCart;
        private MetroFramework.Controls.MetroLabel lblUserName;
        private MetroFramework.Controls.MetroLabel lblWelcome;
        private MetroFramework.Controls.MetroButton btnEdit;
    }
}