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
    interface IManagerRepository
    {
        bool Save(ManagerEntity er);
        bool Delete(string ManagerId);

        DataTable Search(String Name);
        DataTable GetAll();



        ManagerEntity MyProfileLoad(String u);

        ManagerEntity ConvertToEntity(DataRow row);

        string AutoLoadManagerId();


    }
}
