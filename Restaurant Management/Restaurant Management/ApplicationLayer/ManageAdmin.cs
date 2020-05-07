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

namespace Restaurant_Management.ApplicationLayer
{
    public partial class ManageAdmin : MetroFramework.Forms.MetroForm
    {
        AdminDashboard ad;
        AdminRepository arepo = new AdminRepository();

        
        public ManageAdmin(AdminDashboard ad)
        {
            InitializeComponent();
            this.ad = ad;
        }

        private void PopulateGridView()
        {
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.DataSource = arepo.GetAll();
            this.dgvAdmin.Refresh();
            this.dgvAdmin.ClearSelection();
        }

        private void SearchGridView(String Name)
        {
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.DataSource = arepo.Search(Name);
            this.dgvAdmin.Refresh();
            this.dgvAdmin.ClearSelection();
        }

        private void ManageAdmin_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void TileBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ad.Show();
        }

        private void TileEditBack_Click(object sender, EventArgs e)
        {
            pnlGridAdmin.Show();
            //pnlEdit.Hide();
           
        }

        private void MtEmployeeEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvAdmin.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            else if(this.dgvAdmin.SelectedRows.Count == 1)
            {
                pnlGridAdmin.Hide();
                pnlEdit.Show();
                this.txtAddId.Text = this.dgvAdmin.CurrentRow.Cells["AppId"].Value.ToString();
                this.txtAddName.Text = this.dgvAdmin.CurrentRow.Cells["AddName"].Value.ToString();
                this.txtAddAddress.Text = this.dgvAdmin.CurrentRow.Cells["AddAddress"].Value.ToString();
                this.txtAddEmail.Text = this.dgvAdmin.CurrentRow.Cells["AddEmail"].Value.ToString();
                this.txtAddPhone.Text = this.dgvAdmin.CurrentRow.Cells["AddPhone"].Value.ToString();
                this.dtDate_Of_Birth.Text = this.dgvAdmin.CurrentRow.Cells["AddDate_Of_Birth"].Value.ToString();
                this.dtJoining_Date.Text = this.dgvAdmin.CurrentRow.Cells["AddJoining_Date"].Value.ToString();
                this.cmbMaritalStatus.Text = this.dgvAdmin.CurrentRow.Cells["AddMarital_Status"].Value.ToString();
                this.cmbBlood_Group.Text = this.dgvAdmin.CurrentRow.Cells["AddBlood_Group"].Value.ToString();
                this.txtSalary.Text = this.dgvAdmin.CurrentRow.Cells["AddSalary"].Value.ToString();
                MessageBox.Show("Data has been pushed from grid.");
            }

        }

        private void MtEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvAdmin.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string appid = this.dgvAdmin.CurrentRow.Cells["appid"].Value.ToString();
            bool decision = arepo.Delete(appid);

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
    }
}
