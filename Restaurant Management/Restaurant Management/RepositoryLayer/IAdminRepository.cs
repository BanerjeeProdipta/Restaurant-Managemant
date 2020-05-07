using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Restaurant_Management.DataLayer;
using Restaurant_Management.EntityLayer;
using Restaurant_Management.RepositoryLayer;
using Restaurant_Management.ApplicationLayer;

namespace Restaurant_Management.RepositoryLayer
{
    interface IAdminRepository
    {
        bool Save(AdminEntity r);

        bool Delete(string AdminId);

        DataTable Search(String Name);
        
        DataTable GetAll();





        AdminEntity MyProfileLoad(string u);

        AdminEntity ConvertToEntity(DataRow row);

        string AutoLoadAdminId();
    }
}
