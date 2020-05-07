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
using Restaurant_Management.EntityLayer;

namespace Restaurant_Management.ApplicationLayer
{
    public partial class ViewCart : MetroFramework.Forms.MetroForm
    {
        Waiter_Dashboard wd;
        CartRepository cr = new CartRepository();
        
        public ViewCart(Waiter_Dashboard wd)
        {
            InitializeComponent();
            this.wd = wd;

        }

        

        private void PopulateGridView()
        {
            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.DataSource = cr.GetCart();
            this.dgvCart.Refresh();
            this.dgvCart.ClearSelection();
        }

        private void ViewCart_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void MtConfirm_Click(object sender, EventArgs e)
        {
            cr.InitiateOrder();
            cr.ClearCart();
            PopulateGridView();
            
        }

        

        private void TileBack_Click_1(object sender, EventArgs e)
        {
            wd.Show();
            this.Close();
           
        }

        private void MetroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MtDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvCart.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string appid = this.dgvCart.CurrentRow.Cells["appid"].Value.ToString();
            bool decision = cr.Delete(appid);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed.");
                this.PopulateGridView();
            }
            else
                MessageBox.Show("Invalid Id.");

            PopulateGridView();
        }

        private void TileDispose_Click(object sender, EventArgs e)
        {
            if (this.dgvCart.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select Table First");
                return;
            }
            else
            {

                TableEntity te = new TableEntity();
                te.TableId = this.dgvCart.CurrentRow.Cells["AppId"].Value.ToString();
                cr.UpdateTable2(te);
                cr.ClearCart();
                PopulateGridView();
            }
           
        }


    }
}
