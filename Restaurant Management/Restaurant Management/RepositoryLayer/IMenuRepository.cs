using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Restaurant_Management.DataLayer;
using Restaurant_Management.EntityLayer;
using Restaurant_Management.ApplicationLayer;

namespace Restaurant_Management.RepositoryLayer
{
    interface IMenuRepository
    {
        bool Save(MenuEntity er);
        bool Delete(string MenuId);

        DataTable Search(String Name);

        DataTable GetAll();

        MenuEntity MyProfileLoad(String u);

        MenuEntity ConvertToEntity(DataRow row);

        string AutoLoadMenuId();


    }
}
