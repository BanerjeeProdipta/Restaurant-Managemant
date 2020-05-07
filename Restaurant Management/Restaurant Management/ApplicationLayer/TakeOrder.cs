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
    public partial class TakeOrder : MetroFramework.Forms.MetroForm
    {
        CartRepository cr = new CartRepository();
        CartEntity ce = new CartEntity();
        

        Waiter_Dashboard wd;
        public TakeOrder(Waiter_Dashboard wd)
        {
            InitializeComponent();
            this.wd = wd;
            AutoCartAppId();
        }

        private void Clear()
        {
            txtItem.Text = "";
            txtPrice.Text = "";
            cmbQuantity.Text = "";
            //txtTable.Text = "";
        }
        private void PopulateGridView()
        {
            this.dgvMenu.AutoGenerateColumns = false;
            this.dgvMenu.DataSource = cr.GetMenu();
            this.dgvMenu.Refresh();
            this.dgvMenu.ClearSelection();
        }

        private void PopulateGridViewTable()
        {
            this.dgvTable.AutoGenerateColumns = false;
            this.dgvTable.DataSource = cr.GetTable();
            this.dgvTable.Refresh();
            this.dgvTable.ClearSelection();
        }
        private void TakeOrder_Load(object sender, EventArgs e)
        {
            PopulateGridView();
            AutoCartAppId();
            PopulateGridViewTable();
            

        }

        

        private void AutoCartAppId()
        {
            
            var s = cr.AutoLoadOrderId().ToString();
            ce.CartIdGenerate = s;
            txtId.Text = ce.CartIdGenerate;

        }

        private void MtAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtItem.Text == "" || txtPrice.Text == "" || cmbQuantity.Text == "" || txtTable.Text == "")
            {
                MessageBox.Show("Please Fill up the Fields");
            }
            else
            {

                AutoCartAppId();
                ce.Id = txtId.Text;
                ce.Item = txtItem.Text;
                ce.Price = float.Parse(txtPrice.Text) * Int32.Parse(cmbQuantity.Text);
                ce.Quantity = Int32.Parse(cmbQuantity.Text);
                ce.Table = txtTable.Text;
                

                cr.Save(ce);
                Clear();

            }

        }

        

        private void TileBack_Click(object sender, EventArgs e)
        {
            this.Close();
            wd.Show();
            //cr.UpdateTable(te);
            Clear();
            dgvTable.Enabled = true;
            
        }

        private void TileAdd_Click(object sender, EventArgs e)
        {
            if (this.dgvMenu.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            else
            {
                this.txtItem.Text = this.dgvMenu.CurrentRow.Cells["FoodName"].Value.ToString();
                this.txtPrice.Text = this.dgvMenu.CurrentRow.Cells["Price"].Value.ToString();
            }
        }


        private void TileAddTable_Click(object sender, EventArgs e)
        {
            TableEntity te = new TableEntity();

            if (this.dgvTable.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            else
            {
                this.txtTable.Text = this.dgvTable.CurrentRow.Cells["Table"].Value.ToString();
                te.TableId = txtTable.Text;
                cr.UpdateTable(te);
                dgvTable.Enabled = false;
            }
        }
    }
}
