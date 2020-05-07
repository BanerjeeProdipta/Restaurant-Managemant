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
using Restaurant_Management.ValidationLayer;

namespace Restaurant_Management.ApplicationLayer
{
    public partial class ManageManager : MetroFramework.Forms.MetroForm
    {
        AdminDashboard ad;
        ManagerRepository mrepo = new ManagerRepository();


        public ManageManager(AdminDashboard ad)
        {
            InitializeComponent();
            this.ad = ad;
        }

        private void PopulateGridView()
        {
            this.dgvManager.AutoGenerateColumns = false;
            this.dgvManager.DataSource = mrepo.GetAll();
            this.dgvManager.Refresh();
            this.dgvManager.ClearSelection();
        }

        private void SearchGridView(String Name)
        {
            this.dgvManager.AutoGenerateColumns = false;
            this.dgvManager.DataSource = mrepo.Search(Name);
            this.dgvManager.Refresh();
            this.dgvManager.ClearSelection();
        }

        private void ManageManager_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void MtEmployeeEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvManager.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            else if (this.dgvManager.SelectedRows.Count == 1)
            {
                pnlGridManager.Hide();
                pnlEdit.Show();
                //validation
                if (IsValidToSave())
                {
                    this.txtAddId.Text = this.dgvManager.CurrentRow.Cells["AppId"].Value.ToString();
                    this.txtAddName.Text = this.dgvManager.CurrentRow.Cells["AddName"].Value.ToString();
                    this.txtAddAddress.Text = this.dgvManager.CurrentRow.Cells["AddAddress"].Value.ToString();
                    this.txtAddEmail.Text = this.dgvManager.CurrentRow.Cells["AddEmail"].Value.ToString();
                    this.txtAddPhone.Text = this.dgvManager.CurrentRow.Cells["AddPhone"].Value.ToString();
                    this.dtDate_Of_Birth.Text = this.dgvManager.CurrentRow.Cells["AddDate_Of_Birth"].Value.ToString();
                    this.dtJoining_Date.Text = this.dgvManager.CurrentRow.Cells["AddJoining_Date"].Value.ToString();
                    this.cmbMaritalStatus.Text = this.dgvManager.CurrentRow.Cells["AddMarital_Status"].Value.ToString();
                    this.cmbBlood_Group.Text = this.dgvManager.CurrentRow.Cells["AddBlood_Group"].Value.ToString();
                    this.txtSalary.Text = this.dgvManager.CurrentRow.Cells["AddSalary"].Value.ToString();
                    MessageBox.Show("Data has been pushed from grid.");
                }
                else
                {
                    MessageBox.Show("Invalid Fields!\nPlease Try Again.");
                }
            }
        }

        private void TileEditBack_Click(object sender, EventArgs e)
        {
            pnlGridManager.Show();
        }

        private void TileBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ad.Show();
        }

        private void MtEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvManager.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string appid = this.dgvManager.CurrentRow.Cells["appid"].Value.ToString();
            bool decision = mrepo.Delete(appid);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed.");
                this.PopulateGridView();
            }
            else
                MessageBox.Show("Invalid Id.");
        }

        private void MtEmployeeSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                PopulateGridView();
            }
            else
            {
                SearchGridView(txtSearch.Text);
            }
        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            
            PopulateGridView();
        }


        private bool IsValidToSave()
        {
            if (Validation.IsIntValid(this.txtAddId.Text) && Validation.IsStringValid(this.txtAddName.Text)
                && Validation.IsEmailValid(this.txtAddEmail.Text)
                && Validation.IsStringValid(this.dtJoining_Date.Text) && Validation.IsStringValid(this.cmbMaritalStatus.Text)
                && Validation.IsPhoneValid(this.txtAddPhone.Text) && Validation.IsStringValid(this.cmbBlood_Group.Text)
                && Validation.IsStringValid(this.dtDate_Of_Birth.Text) && Validation.IsStringValid(this.txtAddAddress.Text))

                return true;

            else
                return false;
        }
    }
}
