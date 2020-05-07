using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.DataLayer;
using Restaurant_Management.RepositoryLayer;
using Restaurant_Management.EntityLayer;
using Restaurant_Management.ValidationLayer;

namespace Restaurant_Management.ApplicationLayer
{
    public partial class AdminDashboard : MetroFramework.Forms.MetroForm
    {
        public LoginPage lp;
        public String id;
        
        public AdminDashboard(LoginPage lp,string id)
        {
            InitializeComponent();
            this.lp = lp;
            this.id = id;
            AdminRepository emp = new AdminRepository();
            var et = emp.MyProfileLoad(this.id);
           
            lblUserName.Text = et.AdminName;

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();

            lp.Show();
            
        }


        private void MtEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee emp = new AddEmployee(this);
            this.Hide();
            emp.Show();

        }

        private void MtMyProfile_Click(object sender, EventArgs e)
        {
            if (mtMyProfile.Text == "My Profile")
            {
                mtMyProfile.Text = "Back";
                pnlAdminDashboard.Hide();
                AdminRepository emp = new AdminRepository();
                var et = emp.MyProfileLoad(this.id);

                txtAdminId.Text = et.AdminId;
                txtAdminName.Text = et.AdminName;
                txtAdminEmail.Text = et.AdminEmail;
                txtAdminGender.Text = et.AdminGender;
                txtAdminJoining_Date.Text = et.AdminJoiningDate;
                txtAdminMaritalStatus.Text = et.AdminMaritalStatus;
                txtAdminPhone.Text = et.AdminPhone;
                txtAdminBlood_Group.Text = et.AdminBloodGroup;
                txtAdminDate_Of_Birth.Text = et.AdminDateOfBirth;
                txtAdminAddress.Text = et.AdminAddress;
                txtSalary.Text = et.AdminSalary;
                
                
                


            }
            else if (mtMyProfile.Text == "Back")
            {
                mtMyProfile.Text = "My Profile";
                pnlAdminDashboard.Show();

            }
        }

        private void BtnAdminUpdate_Click(object sender, EventArgs e)
        {
            AdminRepository emp = new AdminRepository();
            var et = emp.MyProfileLoad(this.id);
            if (btnAdminUpdate.Text == "Update")
            {
              
                txtAdminName.ReadOnly = false;
                txtAdminAddress.ReadOnly = false;
                txtAdminEmail.ReadOnly = false;
                txtAdminPhone.ReadOnly = false;

               // if (IsValidToSave())
               // {
                    et.AdminName = txtAdminName.Text;
                    et.AdminEmail = txtAdminEmail.Text;
                    et.AdminAddress = txtAdminAddress.Text;
                    et.AdminPhone = txtAdminPhone.Text;

                    //btnAdminUpdate.Text = "Done";
               // }
                btnAdminUpdate.Text = "Done";
            }
            else if(btnAdminUpdate.Text == "Done")
            {

                et.AdminName = txtAdminName.Text;
                    et.AdminEmail = txtAdminEmail.Text;
                    et.AdminAddress = txtAdminAddress.Text;
                    et.AdminPhone = txtAdminPhone.Text;
                emp.Save(et);
                btnAdminUpdate.Text = "Update";
                txtAdminName.ReadOnly = true;
                txtAdminAddress.ReadOnly = true;
                txtAdminEmail.ReadOnly = true;
                txtAdminPhone.ReadOnly = true;

            }

        }

        private bool IsValidToSave()
        {
            if (Validation.IsIntValid(this.txtAdminId.Text) && Validation.IsStringValid(this.txtAdminName.Text)
                && Validation.IsEmailValid(this.txtAdminEmail.Text) && Validation.IsStringValid(this.txtAdminGender.Text)
                && Validation.IsStringValid(this.txtAdminJoining_Date.Text) && Validation.IsStringValid(this.txtAdminMaritalStatus.Text)
                && Validation.IsPhoneValid(this.txtAdminPhone.Text) && Validation.IsStringValid(this.txtAdminBlood_Group.Text)
                && Validation.IsStringValid(this.txtAdminDate_Of_Birth.Text) && Validation.IsStringValid(this.txtAdminAddress.Text))

                return true;

            else
                return false;
        }

        private void MtMenu_Click(object sender, EventArgs e)
        {
            Menu me = new Menu(this);
            me.Show();
            this.Hide();
        }

        private void MtTable_Click(object sender, EventArgs e)
        {
            Table ta = new Table(this);
            ta.Show();
            this.Hide(); 
        }

        private void MtManageManager_Click(object sender, EventArgs e)
        {
            ManageManager mm = new ManageManager(this);
            this.Hide();
            mm.Show();

        }

        private void MtManageAdmin_Click(object sender, EventArgs e)
        {
            ManageAdmin ma = new ManageAdmin(this);
            this.Hide();
            ma.Show();
        }

        private void MtManageWaiter_Click(object sender, EventArgs e)
        {
            ManageWaiter mw = new ManageWaiter(this);
            this.Hide();
            mw.Show();
        }

        private void MtOrder_Click(object sender, EventArgs e)
        {
            Order or = new Order(this);
            or.Show();
            this.Hide();
        }

        private void MtFinancials_Click(object sender, EventArgs e)
        {
            AdminFinancial af = new AdminFinancial(this);
            af.Show();
            this.Hide();
        }

        private void MtFinancials_Click_1(object sender, EventArgs e)
        {
            AdminFinancial af = new AdminFinancial(this);
            af.Show();
            this.Hide();
        }

        private void MtOrder_Click_1(object sender, EventArgs e)
        {
            Order or = new Order(this);
            or.Show();
            this.Hide();
        }
    }
}
