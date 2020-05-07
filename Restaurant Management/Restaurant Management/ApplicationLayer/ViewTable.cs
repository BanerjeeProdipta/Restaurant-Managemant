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
    public partial class ViewTable : MetroFramework.Forms.MetroForm
    {
        TableRepository tr = new TableRepository();
        Manager_Dashboard md;
        public ViewTable(Manager_Dashboard md)
        {
            InitializeComponent();
            this.md = md;
        }

        private void PopulateGridView()
        {
            this.dgvTable.AutoGenerateColumns = false;
            this.dgvTable.DataSource = tr.GetTable();
            this.dgvTable.Refresh();
            this.dgvTable.ClearSelection();
        }

        private void ViewTable_Load(object sender, EventArgs e)
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
