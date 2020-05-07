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
    public partial class ViewMenu : MetroFramework.Forms.MetroForm
    {
        Manager_Dashboard md;
       
        MenuRepository mr = new MenuRepository();
        public ViewMenu(Manager_Dashboard md)
        {
            InitializeComponent();
            this.md = md;
            PopulateGridApetizer();
            PopulateGridBeverage();
            PopulateGridDessert();
            PopulateGridMainCourse();
        }

        

        private void PopulateGridApetizer()
        {
            this.dgvApetizer.AutoGenerateColumns = false;
            this.dgvApetizer.DataSource = mr.GetApetizer();
            this.dgvApetizer.Refresh();
            this.dgvApetizer.ClearSelection();
        }

        private void PopulateGridDessert()
        {
            this.dgvDessert.AutoGenerateColumns = false;
            this.dgvDessert.DataSource = mr.GetDessert();
            this.dgvDessert.Refresh();
            this.dgvDessert.ClearSelection();
        }

        private void PopulateGridMainCourse()
        {
            this.dgvMainCourse.AutoGenerateColumns = false;
            this.dgvMainCourse.DataSource = mr.GetMainCourse();
            this.dgvMainCourse.Refresh();
            this.dgvMainCourse.ClearSelection();
        }

        private void PopulateGridBeverage()
        {
            this.dgvBeverage.AutoGenerateColumns = false;
            this.dgvBeverage.DataSource = mr.GetBeverage();
            this.dgvBeverage.Refresh();
            this.dgvBeverage.ClearSelection();
        }
        private void ViewMenu_Load(object sender, EventArgs e)
        {
            PopulateGridApetizer();
            PopulateGridBeverage();
            PopulateGridDessert();
            PopulateGridMainCourse();

        }

        private void TileBack_Click(object sender, EventArgs e)
        {
            md.Show();
            this.Close();
        }
    }
}
