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
using Restaurant_Management.EntityLayer;
using Restaurant_Management.RepositoryLayer;
using Restaurant_Management.ApplicationLayer;
using Restaurant_Management.ValidationLayer;


namespace Restaurant_Management.ApplicationLayer
{
    
    public partial class AddEmployee : MetroFramework.Forms.MetroForm
    {
        public AdminDashboard ad;
        public AddEmployee(AdminDashboard ad)
        {
            InitializeComponent();
            this.ad = ad;


        }

        

        

        private void BtnSave_Click(object sender, EventArgs e)
        {
            WaiterEntity w = new WaiterEntity();
            WaiterRepository repo = new WaiterRepository();
            ManagerEntity m = new ManagerEntity();
            ManagerRepository mepo = new ManagerRepository();
            AdminRepository arepo = new AdminRepository();
            AdminEntity a = new AdminEntity();
            if (rbGenderFemale.Checked == true || rbGenderMale.Checked == true)
            {
                if (cmbPost.Text == "Waiter")
                {
                    if (IsValidToSave())
                    {

                        w.WaiterName = txtAddName.Text;
                        w.WaiterId = txtAddId.Text;
                        w.WaiterAddress = txtAddAddress.Text;
                        w.WaiterEmail = txtAddEmail.Text;
                        w.WaiterPhone = txtAddPhone.Text;
                        if (rbGenderFemale.Checked == true)
                        {
                            w.WaiterGender = "Female";
                        }
                        else if (rbGenderMale.Checked == true)
                        {
                            w.WaiterGender = "Male";
                        }
                        else
                            MessageBox.Show("Please Select A Gender");

                        w.WaiterDateOfBirth = dtDate_Of_Birth.Value.ToString();
                        w.WaiterJoiningDate = dtJoining_Date.Value.ToString();
                        w.WaiterMaritalStatus = cmbMaritalStatus.Text;

                        w.WaiterBloodGroup = cmbBlood_Group.Text;
                        w.WaiterSalary = txtSalary.Text;

                        repo.Save(w);
                        Denied();
                        clear();
                        AutoWaiterAppId();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Fields");
                    }
                }
                else if (cmbPost.Text == "Admin")
                {
                    if (IsValidToSave())
                    {
                        a.AdminName = txtAddName.Text;
                        a.AdminId = txtAddId.Text;
                        a.AdminAddress = txtAddAddress.Text;
                        a.AdminEmail = txtAddEmail.Text;
                        a.AdminPhone = txtAddPhone.Text;
                        if (rbGenderFemale.Checked == true)
                        {
                            a.AdminGender = "Female";
                        }
                        else if (rbGenderMale.Checked == true)
                        {
                            a.AdminGender = "Male";
                        }

                        a.AdminDateOfBirth = dtDate_Of_Birth.Value.ToString();
                        a.AdminJoiningDate = dtJoining_Date.Value.ToString();
                        m.ManagerMaritalStatus = cmbMaritalStatus.Text;

                        a.AdminBloodGroup = cmbBlood_Group.Text;
                        a.AdminSalary = txtSalary.Text;

                        arepo.Save(a);
                        //Denied();
                        clear();

                        AutoManagerAppId();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Fiels");
                    }


                }
                else if (cmbPost.Text == "Manager")
                {
                    if (IsValidToSave())
                    {
                        m.ManagerName = txtAddName.Text;
                        m.ManagerId = txtAddId.Text;
                        m.ManagerAddress = txtAddAddress.Text;
                        m.ManagerEmail = txtAddEmail.Text;
                        m.ManagerPhone = txtAddPhone.Text;
                        if (rbGenderFemale.Checked == true)
                        {
                            m.ManagerGender = "Female";
                        }
                        else if (rbGenderMale.Checked == true)
                        {
                            m.ManagerGender = "Male";
                        }

                        m.ManagerDateOfBirth = dtDate_Of_Birth.Value.ToString();
                        m.ManagerJoiningDate = dtJoining_Date.Value.ToString();
                        m.ManagerMaritalStatus = cmbMaritalStatus.Text;

                        m.ManagerBloodGroup = cmbBlood_Group.Text;
                        m.ManagerSalary = txtSalary.Text;

                        mepo.Save(m);
                        //Denied();
                        clear();

                        AutoAdminAppId();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Fields");
                        
                    }


                }
                else
                    MessageBox.Show("Please Select An Employee Type");
            }
            else
            {
                MessageBox.Show("Please Select A Gender");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
           
            clear();
        }

        private void AutoWaiterAppId()
        {
            WaiterRepository emp = new WaiterRepository();
            WaiterEntity en = new WaiterEntity();
            var s = emp.AutoLoadWaiterId();
            en.WaiterIdGenerate = s;
            txtAddId.Text = en.WaiterIdGenerate;

        }

        private void AutoManagerAppId()
        {
            ManagerRepository emp = new ManagerRepository();
            ManagerEntity en = new ManagerEntity();
            var s = emp.AutoLoadManagerId();
            en.ManagerIdGenerate = s;
            txtAddId.Text = en.ManagerIdGenerate;

        }

        private void AutoAdminAppId()
        {
            AdminRepository emp = new AdminRepository();
            AdminEntity en = new AdminEntity();
            var s = emp.AutoLoadAdminId();
            en.AdminIdGenerate = s;
            txtAddId.Text = en.AdminIdGenerate;

        }
        private void clear()
            {
            txtAddName.Text= "";
            txtAddAddress.Text = "";
            txtAddEmail.Text = "";
            txtAddPhone.Text = "";
            cmbBlood_Group.Text = "";
            txtSalary.Text = "";
        }
        private void Access()
        {
            txtAddName.ReadOnly = false;
            txtAddAddress.ReadOnly = false;
            txtAddEmail.ReadOnly = false;
            txtAddPhone.ReadOnly = false;
            rbGenderMale.Enabled = true;
            rbGenderFemale.Enabled = true;
            dtDate_Of_Birth.Enabled = true;
            dtJoining_Date.Enabled = true;
            cmbMaritalStatus.Enabled = true;
            cmbBlood_Group.Enabled = true;
            txtSalary.ReadOnly = false;
        }

        private void Denied()
        {
            txtAddName.ReadOnly = true;
            txtAddAddress.ReadOnly = true;
            txtAddEmail.ReadOnly = true;
            txtAddPhone.ReadOnly = true;
            rbGenderMale.Enabled = false;
            rbGenderFemale.Enabled = false;
            dtDate_Of_Birth.Enabled = false;
            dtJoining_Date.Enabled = false;
            cmbMaritalStatus.Enabled = false;
            cmbBlood_Group.Enabled = false;
            txtSalary.ReadOnly = true;
        }

        private void CmbPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbPost.Text == "Waiter")
            {
                AutoWaiterAppId();
                Access();


            }
            if (cmbPost.Text == "Manager")
            {
                Access();
                AutoManagerAppId();
            }
            if(cmbPost.Text == "Admin")
            {
                Access();
                AutoAdminAppId();
            }
        }

        private void TileBack_Click(object sender, EventArgs e)
        {

            this.Close();
            ad.Show();
            Denied();
            clear();
        }


        private bool IsValidToSave()
        {
            if (Validation.IsStringValid(this.txtAddId.Text) && Validation.IsStringValid(this.txtAddName.Text)
                && Validation.IsEmailValid(this.txtAddEmail.Text) && Validation.IsStringValid(this.txtAddAddress.Text)
                && Validation.IsPhoneValid(this.txtAddPhone.Text) && Validation.IsStringValid(this.txtSalary.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TileBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ad.Show();
            Denied();
            clear();
        }
    }
}
