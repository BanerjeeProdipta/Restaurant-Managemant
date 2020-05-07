using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.ApplicationLayer;
using Restaurant_Management.DataLayer;
using Restaurant_Management.RepositoryLayer;
using Restaurant_Management.EntityLayer;

namespace Restaurant_Management.ApplicationLayer
{
    public partial class Table : MetroFramework.Forms.MetroForm

    {
        AdminDashboard ad;
        TableRepository tr = new TableRepository();
        public Table(AdminDashboard ad)
        {
            InitializeComponent();
            this.ad = ad;
            AutoTableAppId();
        }
        private void PopulateGridView()
        {
            this.dgvTable.AutoGenerateColumns = false;
            this.dgvTable.DataSource = tr.GetTable();
            this.dgvTable.Refresh();
            this.dgvTable.ClearSelection();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void AutoTableAppId()
        {
            TableEntity ce = new TableEntity();
            var s = tr.AutoLoadTableId().ToString();
            ce.TableIdGenerate = s;
            txtId.Text = ce.TableIdGenerate;

        }

        private void SearchGridView(String Name)
        {
            this.dgvTable.AutoGenerateColumns = false;
            this.dgvTable.DataSource = tr.Search(Name);
            this.dgvTable.Refresh();
            this.dgvTable.ClearSelection();
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            ActiveControl = txtCapacity;
        }

        private void TileBack_Click(object sender, EventArgs e)
        {
            ad.Show();
            this.Close();
        }

        private void TileSave_Click(object sender, EventArgs e)
        {
            TableEntity ce = new TableEntity();
            AutoTableAppId();
            ce.TableId = txtId.Text;
            ce.Capacity = txtCapacity.Text;
            ce.Status = cmbStatus.Text;
            PopulateGridView();
            

            tr.Save(ce);
        }

        private void MetroTile3_Click(object sender, EventArgs e)
        {
            if (this.dgvTable.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string appid = this.dgvTable.CurrentRow.Cells["Id"].Value.ToString();
            bool decision = tr.Delete(appid);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed.");
                this.PopulateGridView();
            }
            else
                MessageBox.Show("Invalid Id.");
        }

        private void MetroTile4_Click(object sender, EventArgs e)
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
