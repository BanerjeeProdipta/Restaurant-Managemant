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
    public partial class ManagerFinancial : MetroFramework.Forms.MetroForm
    {
        Manager_Dashboard md;
        CartRepository cr = new CartRepository();
        
        public ManagerFinancial(Manager_Dashboard md)
        {
            InitializeComponent();
            this.md = md;
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            this.dgvFinancial.AutoGenerateColumns = false;
            this.dgvFinancial.DataSource = cr.GetFinancial();
            this.dgvFinancial.Refresh();
            this.dgvFinancial.ClearSelection();
        }

        private void ManagerFinancial_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void TileBack_Click(object sender, EventArgs e)
        {
            md.Show();
            this.Close();
        }
    }
}
