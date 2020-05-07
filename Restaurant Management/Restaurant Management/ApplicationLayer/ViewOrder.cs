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
    public partial class ViewOrder : MetroFramework.Forms.MetroForm
    {
        Manager_Dashboard md;

        OrderRepository or = new OrderRepository();

        public ViewOrder(Manager_Dashboard md)
        {
            InitializeComponent();
            this.md = md;
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

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            PopulateGridView();
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

        private void TileBack_Click(object sender, EventArgs e)
        {
            md.Show();
            this.Hide();
        }

        private void PnlMenuManage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
