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
    class OrderRepository 
    {
        
        public DataTable Search(String Name)
        {
            try
            {
                string query = "select * from OrderData Where AppId = '" + Name + "';";
                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public DataTable GetAll()
        {

            try
            {
                string query = "select * from OrderData;";
                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
        public bool Delete(string OrderId)
        {
            string query = "delete from OrderData where AppId = '" + OrderId + "'";
            int count = DataAccess.ExecuteQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }


    }
}
