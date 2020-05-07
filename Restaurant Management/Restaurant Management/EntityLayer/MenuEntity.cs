using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Restaurant_Management.DataLayer;
using Restaurant_Management.ApplicationLayer;
using Restaurant_Management.RepositoryLayer;
using Restaurant_Management.EntityLayer;

namespace Restaurant_Management.EntityLayer
{
    class MenuEntity
    {
        private string menuId;
        private string menuName;
        private string menuCategory;
        private string menuIdGenerate;
        private string menuPrice;

        public string MenuId
        {
            get { return menuId; }
            set { menuId = value; }
        }
        public string MenuIdGenerate
        {
            get { return menuIdGenerate; }
            set { menuIdGenerate = "F-" + value.PadLeft(2, '0'); }
        }

        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }
        public string MenuCategory
        {
            get { return menuCategory; }
            set { menuCategory = value; }
        }

        public string MenuPrice
        {
            get { return menuPrice; }
            set { menuPrice = value; }
        }





    }
}

