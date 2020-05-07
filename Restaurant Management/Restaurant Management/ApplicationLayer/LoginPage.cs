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

namespace Restaurant_Management
{
    public partial class LoginPage : MetroFramework.Forms.MetroForm
    {
        public LoginPage()
        {
            InitializeComponent();
            txtLoginPassword.UseSystemPasswordChar = true;
        }
        private void Clear()
        {

            this.txtLoginId.Text = "";
            this.txtLoginPassword.Text = "";
        }

        private void MetroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbShowPassword.Checked)
            {
                txtLoginPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtLoginPassword.UseSystemPasswordChar = false;

            }
        }

        private void MbtnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtLoginPassword.Text != "" && this.txtLoginId.Text != "")
            {
                UserLoginEntity user = new UserLoginEntity();
                user.UserId= txtLoginId.Text.Trim();
                user.UserPassword = txtLoginPassword.Text;


                UserLoginRepository emp = new UserLoginRepository();

                if (emp.UserLoginValidation(user))
                {
                    if (user.UserId.Substring(0, 1) == "A")
                    {

                        MessageBox.Show("Admin");
                        AdminDashboard admin = new AdminDashboard(this, user.UserId);
                        this.Hide();
                        admin.Show();
                        Clear();

                    }
                    else if (user.UserId.Substring(0, 1) == "W")
                    {
                        MessageBox.Show("Waiter");
                        Waiter_Dashboard wd = new Waiter_Dashboard(this, user.UserId);
                        this.Hide();
                        wd.Show();
                        Clear();
                    }

                    else if (user.UserId.Substring(0, 1) == "M")
                    {
                        MessageBox.Show("Manager");
                        Manager_Dashboard md = new Manager_Dashboard(this,user.UserId);
                        this.Hide();
                        md.Show();
                        Clear();
                    }

                    else
                    {
                        MessageBox.Show("Invalid Form Of Id!");
                        Clear();

                    }

                }
                else
                {
                    MessageBox.Show("Invalid Id or Password", "Login Failed");
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Insert ID or Password", "Login Failed");
                Clear();
            }


        }
    }
}
