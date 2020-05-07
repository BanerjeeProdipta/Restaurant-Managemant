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
    public partial class ManagerGenarateBill : MetroFramework.Forms.MetroForm
    {
        Manager_Dashboard md;
        CartRepository cr = new CartRepository();
        FinancialEntity fe = new FinancialEntity();

        public ManagerGenarateBill(Manager_Dashboard md)
        {
            InitializeComponent();
            this.md = md;
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.DataSource = cr.GetOrder();
            this.dgvOrder.Refresh();
            this.dgvOrder.ClearSelection();
        }

        private void ManagerGenarateBill_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            if (this.dgvOrder.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            else if (this.dgvOrder.SelectedRows.Count == 1)
            {
                this.txtOrderId.Text = this.dgvOrder.CurrentRow.Cells["OrderId"].Value.ToString();
                this.txtTable.Text = this.dgvOrder.CurrentRow.Cells["Table_Seat"].Value.ToString();
                this.txtBill.Text = cr.BillGenerate(this.dgvOrder.CurrentRow.Cells["OrderId"].Value.ToString());
            }
        }

        public void Clear()
        {
            txtOrderId.Text = "";
            txtTable.Text = "";
            txtBill.Text = "";
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            TableEntity te = new TableEntity();
            fe.OrderId = txtOrderId.Text;
            fe.Bill = float.Parse(txtBill.Text);
            fe.Table = txtTable.Text;
            te.TableId = fe.OrderId;
            fe.Id = cr.AutoLoadFinanceId();
            cr.SaveFinancial(fe);
            cr.UpdateTable2(te);
            Clear();

        }

        private void TileBack_Click(object sender, EventArgs e)
        {
            md.Show();
            this.Close();
        }
    }
    }
