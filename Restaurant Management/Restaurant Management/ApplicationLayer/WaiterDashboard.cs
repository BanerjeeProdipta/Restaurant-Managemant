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
    public partial class Waiter_Dashboard : MetroFramework.Forms.MetroForm

    {
        public LoginPage lp;
        public String id;
        WaiterRepository wr = new WaiterRepository();
        WaiterEntity we = new WaiterEntity();
        public Waiter_Dashboard(LoginPage lp, string id)
        {
            InitializeComponent();
            this.lp = lp;
            this.id = id;
            WaiterRepository emp = new WaiterRepository();
            var et = emp.MyProfileLoad(this.id);

            lblUserName.Text = et.WaiterName;
        }

        private void Waiter_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void MtMyProfile_Click(object sender, EventArgs e)
        {
            if (mtMyProfile.Text == "My Profile")
            {
                mtMyProfile.Text = "Back";
                pnlWaiterDashboard.Hide();
                
                var et = wr.MyProfileLoad(this.id);

                txtWaiterId.Text = et.WaiterId;
                txtWaiterName.Text = et.WaiterName;
                txtWaiterEmail.Text = et.WaiterEmail;
                txtWaiterGender.Text = et.WaiterGender;
                txtWaiterJoining_Date.Text = et.WaiterJoiningDate;
                txtWaiterMaritalStatus.Text = et.WaiterMaritalStatus;
                txtWaiterPhone.Text = et.WaiterPhone;
                txtWaiterBlood_Group.Text = et.WaiterBloodGroup;
                txtWaiterDate_Of_Birth.Text = et.WaiterDateOfBirth;
                txtWaiterAddress.Text = et.WaiterAddress;
                txtSalary.Text = et.WaiterSalary;





            }
            else if (mtMyProfile.Text == "Back")
            {
                mtMyProfile.Text = "My Profile";
                pnlWaiterDashboard.Show();

            }
        }

        private void TileOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            TakeOrder to = new TakeOrder(this);
            to.Show();
        }

        private void MtViewCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCart vc = new ViewCart(this);
            vc.Show();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            lp.Show();
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var et = wr.MyProfileLoad(this.id);
            if (btnEdit.Text == "Edit")
            {

                txtWaiterName.ReadOnly = false;
                txtWaiterAddress.ReadOnly = false;
                txtWaiterEmail.ReadOnly = false;
                txtWaiterPhone.ReadOnly = false;

                    et.WaiterName = txtWaiterName.Text;
                    et.WaiterEmail = txtWaiterEmail.Text;
                    et.WaiterAddress = txtWaiterAddress.Text;
                    et.WaiterPhone = txtWaiterPhone.Text;

                   

            }
            else if (btnEdit.Text == "Done")
            {
               // if (IsValidToSave())
               // {
                    et.WaiterName = txtWaiterName.Text;
                    et.WaiterEmail = txtWaiterEmail.Text;
                    et.WaiterAddress = txtWaiterAddress.Text;
                    et.WaiterPhone = txtWaiterPhone.Text;


                    wr.Save(et);
                    btnEdit.Text = "Edit";
                    txtWaiterName.ReadOnly = true;
                    txtWaiterAddress.ReadOnly = true;
                    txtWaiterEmail.ReadOnly = true;
                    txtWaiterPhone.ReadOnly = true;
           //     }
              //  else
             //   {
               //     MessageBox.Show("Invalid Fields!");
              //  }

            }
        }

        private void TileMenu_Click(object sender, EventArgs e)
        {
            WaiterMenu wm = new WaiterMenu(this);
            wm.Show();
            this.Hide();

        }

        private bool IsValidToSave()
        {
            if (Validation.IsIntValid(this.txtWaiterId.Text) && Validation.IsStringValid(this.txtWaiterName.Text)
                && Validation.IsEmailValid(this.txtWaiterEmail.Text) && Validation.IsStringValid(this.txtWaiterGender.Text)
                && Validation.IsStringValid(this.txtWaiterJoining_Date.Text) && Validation.IsStringValid(this.txtWaiterMaritalStatus.Text)
                && Validation.IsPhoneValid(this.txtWaiterPhone.Text) && Validation.IsStringValid(this.txtWaiterBlood_Group.Text)
                && Validation.IsStringValid(this.txtWaiterDate_Of_Birth.Text) && Validation.IsStringValid(this.txtWaiterAddress.Text))

                return true;

            else
                return false;
        }
    }
}
