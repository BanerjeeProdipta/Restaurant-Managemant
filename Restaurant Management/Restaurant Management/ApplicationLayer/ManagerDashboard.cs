using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.RepositoryLayer;
using Restaurant_Management.EntityLayer;
using Restaurant_Management.ValidationLayer;

namespace Restaurant_Management.ApplicationLayer
{
    public partial class Manager_Dashboard : MetroFramework.Forms.MetroForm
    {
        public LoginPage lp;
        public String id;
        ManagerRepository mr = new ManagerRepository();
        public Manager_Dashboard(LoginPage lp, string id)
        {
            InitializeComponent();
            this.lp = lp;
            this.id = id;
            
            var et = mr.MyProfileLoad(this.id);

            lblUserName.Text = et.ManagerName;
        }

        private void Manager_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void MtMyProfile_Click(object sender, EventArgs e)
        {
            if (mtMyProfile.Text == "My Profile")
            {
                mtMyProfile.Text = "Back";
                pnlAdminDashboard.Hide();
                
                var et = mr.MyProfileLoad(this.id);

                txtMangerId.Text = et.ManagerId;
                txtManagerName.Text = et.ManagerName;
                txtManagerEmail.Text = et.ManagerEmail;
                txtManagerGender.Text = et.ManagerGender;
                txtManagerJoining_Date.Text = et.ManagerJoiningDate;
                txtManagerMaritalStatus.Text = et.ManagerMaritalStatus;
                txtManagerPhone.Text = et.ManagerPhone;
                txtManagerBlood_Group.Text = et.ManagerBloodGroup;
                txtManagerDate_Of_Birth.Text = et.ManagerDateOfBirth;
                txtManagerAddress.Text = et.ManagerAddress;
                txtSalary.Text = et.ManagerSalary;





            }
            else if (mtMyProfile.Text == "Back")
            {
                mtMyProfile.Text = "My Profile";
                pnlAdminDashboard.Show();

            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var et = mr.MyProfileLoad(this.id);
            if (btnEdit.Text == "Edit")
            {

                txtManagerName.ReadOnly = false;
                txtManagerAddress.ReadOnly = false;
                txtManagerEmail.ReadOnly = false;
                txtManagerPhone.ReadOnly = false;

                
                    et.ManagerName = txtManagerName.Text;
                    et.ManagerEmail = txtManagerEmail.Text;
                    et.ManagerAddress = txtManagerAddress.Text;
                    et.ManagerPhone = txtManagerPhone.Text;

                    btnEdit.Text = "Done";
                

            }

            else if (btnEdit.Text == "Done")
            {
                //if (IsValidToSave())
               // {
                    et.ManagerName = txtManagerName.Text;
                    et.ManagerEmail = txtManagerEmail.Text;
                    et.ManagerAddress = txtManagerAddress.Text;
                    et.ManagerPhone = txtManagerPhone.Text;


                    mr.Save(et);
                    btnEdit.Text = "Edit";
                    txtManagerName.ReadOnly = true;
                    txtManagerAddress.ReadOnly = true;
                    txtManagerEmail.ReadOnly = true;
                    txtManagerPhone.ReadOnly = true;
             //   }
             //   else
             //   {
              //      MessageBox.Show("Invalid Fields!");
             //   }

            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            lp.Show();
        }

        private void MtViewWaiter_Click(object sender, EventArgs e)
        {
            ViewWaiters vw = new ViewWaiters(this);
            vw.Show();
            this.Hide();

        }

        private void MtMenu_Click(object sender, EventArgs e)
        {
            ViewMenu vm = new ViewMenu(this);
            vm.Show();
            this.Hide();
        }

        private void MtTable_Click(object sender, EventArgs e)
        {
            ViewTable vt = new ViewTable(this);
            vt.Show();
            this.Hide();

        }

        private void MtOrder_Click(object sender, EventArgs e)
        {
            ViewOrder vo = new ViewOrder(this);
            this.Hide();
            vo.Show();
        }



        private bool IsValidToSave()
        {
            if (Validation.IsIntValid(this.txtMangerId.Text) && Validation.IsStringValid(this.txtManagerName.Text)
                && Validation.IsEmailValid(this.txtManagerEmail.Text) && Validation.IsStringValid(this.txtManagerGender.Text)
                && Validation.IsStringValid(this.txtManagerJoining_Date.Text) && Validation.IsStringValid(this.txtManagerMaritalStatus.Text)
                && Validation.IsPhoneValid(this.txtManagerPhone.Text) && Validation.IsStringValid(this.txtManagerBlood_Group.Text)
                && Validation.IsStringValid(this.txtManagerDate_Of_Birth.Text) && Validation.IsStringValid(this.txtManagerAddress.Text))

                return true;

            else
                return false;
        }

        private void MtBillGenerate_Click(object sender, EventArgs e)
        {
            ManagerGenarateBill mgb = new ManagerGenarateBill(this);
            mgb.Show();
            this.Hide();
        }

        private void MtFinancials_Click(object sender, EventArgs e)
        {
            ManagerFinancial mf = new ManagerFinancial(this);
            mf.Show();
            this.Hide();
        }
    }
}
