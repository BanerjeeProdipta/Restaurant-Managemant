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
    public partial class Order : MetroFramework.Forms.MetroForm
    {
        AdminDashboard ad;
        OrderRepository or = new OrderRepository();
        public Order(AdminDashboard ad)
        {
            InitializeComponent();
            this.ad = ad;
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.DataSource = or.GetAll();
            this.dgvOrder.Refresh();
            this.dgvOrder.ClearSelection();
        }

        private void SearchGridView(String Name)
        {
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.DataSource = or.Search(Name);
            this.dgvOrder.Refresh();
            this.dgvOrder.ClearSelection();
        }
        private void Order_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void TileBack_Click(object sender, EventArgs e)
        {
            ad.Show();
            this.Close();

        }

        private void TileDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvOrder.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string appid = this.dgvOrder.CurrentRow.Cells["appid"].Value.ToString();
            bool decision = or.Delete(appid);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed.");
                this.PopulateGridView();
            }
            else
                MessageBox.Show("Invalid Id.");
        }

        private void TileSearch_Click(object sender, EventArgs e)
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
