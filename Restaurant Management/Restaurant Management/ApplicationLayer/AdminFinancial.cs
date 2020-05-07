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
    public partial class AdminFinancial : MetroFramework.Forms.MetroForm
    {
        AdminDashboard ad;
        CartRepository cr = new CartRepository();
        public AdminFinancial(AdminDashboard ad)
        {
            InitializeComponent();
            this.ad = ad;
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            this.dgvFinancial.AutoGenerateColumns = false;
            this.dgvFinancial.DataSource = cr.GetFinancial();
            this.dgvFinancial.Refresh();
            this.dgvFinancial.ClearSelection();
        }

        private void AdminFinancial_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void TileBack_Click(object sender, EventArgs e)
        {
            ad.Show();
            this.Close();
        }
    }
}
