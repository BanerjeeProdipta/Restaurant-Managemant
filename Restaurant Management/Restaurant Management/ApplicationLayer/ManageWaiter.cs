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
    public partial class ManageWaiter : MetroFramework.Forms.MetroForm
    {
        AdminDashboard ad;
        WaiterRepository wrepo = new WaiterRepository();
        public ManageWaiter(AdminDashboard ad)
        {
            InitializeComponent();
            this.ad = ad;
        }

        private void PopulateGridView()
        {
            this.dgvWaiter.AutoGenerateColumns = false;
            this.dgvWaiter.DataSource = wrepo.GetAll();
            this.dgvWaiter.Refresh();
            this.dgvWaiter.ClearSelection();
        }

        private void SearchGridView(String Name)
        {
            this.dgvWaiter.AutoGenerateColumns = false;
            this.dgvWaiter.DataSource = wrepo.Search(Name);
            this.dgvWaiter.Refresh();
            this.dgvWaiter.ClearSelection();
        }
        private void ManageWaiter_Load(object sender, EventArgs e)
        {

            PopulateGridView();
        }

        private void TileWaiterBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ad.Show();
        }

        private void MtEmployeeEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvWaiter.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            else if (this.dgvWaiter.SelectedRows.Count == 1)
            {
                pnlGridWaiter.Hide();
                pnlEdit.Show();
                this.txtAddId.Text = this.dgvWaiter.CurrentRow.Cells["AppId"].Value.ToString();
                this.txtAddName.Text = this.dgvWaiter.CurrentRow.Cells["AddName"].Value.ToString();
                this.txtAddAddress.Text = this.dgvWaiter.CurrentRow.Cells["AddAddress"].Value.ToString();
                this.txtAddEmail.Text = this.dgvWaiter.CurrentRow.Cells["AddEmail"].Value.ToString();
                this.txtAddPhone.Text = this.dgvWaiter.CurrentRow.Cells["AddPhone"].Value.ToString();
                this.dtDate_Of_Birth.Text = this.dgvWaiter.CurrentRow.Cells["AddDate_Of_Birth"].Value.ToString();
                this.dtJoining_Date.Text = this.dgvWaiter.CurrentRow.Cells["AddJoining_Date"].Value.ToString();
                this.cmbMaritalStatus.Text = this.dgvWaiter.CurrentRow.Cells["AddMarital_Status"].Value.ToString();
                this.cmbBlood_Group.Text = this.dgvWaiter.CurrentRow.Cells["AddBlood_Group"].Value.ToString();
                this.txtSalary.Text = this.dgvWaiter.CurrentRow.Cells["AddSalary"].Value.ToString();
                MessageBox.Show("Data has been pushed from grid.");
            }
        }

        private void TileEditBack_Click(object sender, EventArgs e)
        {
            pnlGridWaiter.Show();
        }

        private void MtEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvWaiter.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string appid = this.dgvWaiter.CurrentRow.Cells["appid"].Value.ToString();
            bool decision = wrepo.Delete(appid);

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
