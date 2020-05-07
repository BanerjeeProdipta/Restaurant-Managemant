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
    public partial class ViewWaiters : MetroFramework.Forms.MetroForm

    {
        Manager_Dashboard md;
        WaiterRepository wr = new WaiterRepository();
        public ViewWaiters(Manager_Dashboard md)
        {
            InitializeComponent();
            this.md = md;
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            this.dgvWaiter.AutoGenerateColumns = false;
            this.dgvWaiter.DataSource = wr.GetAll();
            this.dgvWaiter.Refresh();
            this.dgvWaiter.ClearSelection();
        }

        private void SearchGridView(String Name)
        {
            this.dgvWaiter.AutoGenerateColumns = false;
            this.dgvWaiter.DataSource = wr.Search(Name);
            this.dgvWaiter.Refresh();
            this.dgvWaiter.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateGridView();
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

        private void TileBack_Click(object sender, EventArgs e)
        {
            md.Show();
            this.Close();
        }
    }
}
