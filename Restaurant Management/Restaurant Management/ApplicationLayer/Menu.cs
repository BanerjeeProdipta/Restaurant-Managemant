using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.DataLayer;
using Restaurant_Management.EntityLayer;
using Restaurant_Management.RepositoryLayer;

namespace Restaurant_Management.ApplicationLayer
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public AdminDashboard ad;
        MenuRepository mepo = new MenuRepository();
        
        public Menu(AdminDashboard ad)
        {
            InitializeComponent();
            this.ad = ad;
            AutoMenuAppId();
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            this.dgvMenu.AutoGenerateColumns = false;
            this.dgvMenu.DataSource = mepo.GetAll();
            this.dgvMenu.Refresh();
            this.dgvMenu.ClearSelection();
        }

        private void SearchGridView(String Name)
        {
            this.dgvMenu.AutoGenerateColumns = false;
            this.dgvMenu.DataSource = mepo.Search(Name);
            this.dgvMenu.Refresh();
            this.dgvMenu.ClearSelection();
        }


        private void TileAdd_Click(object sender, EventArgs e)
        {
            MenuEntity me = new MenuEntity();

            if (cmbMenuCategory.Text == "" || txtMenuName.Text == "" || txtMenuPrice.Text == "")
            {
                MessageBox.Show("Please Fill Up The Fields");
            }
            else
            {
                me.MenuName = txtMenuName.Text;
                me.MenuPrice = txtMenuPrice.Text;
                me.MenuCategory = cmbMenuCategory.Text;
                mepo.Save(me);
                PopulateGridView();
                Clear();
            }



        }

        private void Clear()
        {

            txtMenuName.Text = "";
            txtMenuPrice.Text = "";
            cmbMenuCategory.Text = "";

        }
        private void AutoMenuAppId()
        {
            MenuRepository emp = new MenuRepository();
            MenuEntity en = new MenuEntity();
            var s = emp.AutoLoadMenuId();
            en.MenuIdGenerate = s;
            txtMenuId.Text= en.MenuIdGenerate;



        }

        private void TileBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ad.Show();

        }

        private void TileDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvMenu.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string appid = this.dgvMenu.CurrentRow.Cells["Id"].Value.ToString();
            bool decision = mepo.Delete(appid);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed.");
                this.PopulateGridView();
            }
            else
                MessageBox.Show("Invalid Id.");
        }

        private void TileSave_Click(object sender, EventArgs e)
        {
            MenuEntity men = new MenuEntity();
            if (cmbMenuCategory.Text == "" || txtMenuName.Text == "" || txtMenuPrice.Text == "")
            {
                MessageBox.Show("Please Fill Up The Fields");
            }
            else
            {
                men.MenuId = txtMenuId.Text;
                men.MenuName = txtMenuName.Text;
                men.MenuPrice = txtMenuPrice.Text;
                men.MenuCategory = cmbMenuCategory.Text;
                mepo.Save(men);
                Clear();
            }
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

        private void TxtSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
