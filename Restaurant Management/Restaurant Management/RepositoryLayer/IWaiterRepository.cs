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
    interface IWaiterRepository
    {
        bool Save(WaiterEntity er);
        bool Delete(string WaiterId);

        DataTable Search(String Name);

        DataTable GetAll();

        WaiterEntity MyProfileLoad(String u);

        WaiterEntity ConvertToEntity(DataRow row);

        string AutoLoadWaiterId();


    }
}
