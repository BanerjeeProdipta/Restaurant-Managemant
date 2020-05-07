using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Restaurant_Management.ApplicationLayer;
using Restaurant_Management.DataLayer;
using Restaurant_Management.EntityLayer;


namespace Restaurant_Management.RepositoryLayer
{
    class TableRepository
    {
        public bool Save(TableEntity er)
        {

            try
            {
                string query = "select * from TableData where appid = '" + er.TableId + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into TableData values ('" + er.TableId + "','" + er.Capacity + "','" + er.Status + "');";
                }
                else
                {
                    
                    //query = "Update  Manager set Name = '" + er.ManagerName + "','" + er.ManagerAddress + "','" + er.ManagerEmail + "','" + er.ManagerPhone + "','" + er.ManagerGender + "','" + er.ManagerDateOfBirth + "','" + er.ManagerJoiningDate + "','" + er.ManagerMaritalStatus + "','" + er.ManagerBloodGroup + "','" + er.ManagerSalary + "' where appid = '" + er.ManagerId + "'";
                }

                int count = DataAccess.ExecuteQuery(query);

                if (count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable GetTable()
        {
            try
            {

                string query = "select * from TableData";
                var dt = DataAccess.GetDataTable(query);
                return dt;

            }
            catch (Exception exception)
            {
                return null;
            }

        }

        public bool Delete(string TableId)
        {
            string query = "delete from TableData where AppId = '" + TableId + "'";
            int count = DataAccess.ExecuteQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }

        public DataTable Search(String Name)
        {
            try
            {
                string query = "select * from TableData where Name = '" + Name + "';";
                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public string AutoLoadTableId()
        {
            try
            {
                string id = "select isnull(max(cast(Id as int)),0)+1 from TableData";
                var dt = DataAccess.GetDataTable(id);
                string i = dt.Rows[0][0].ToString();
                return i;
            }
            catch (Exception ex)
            {
                return "Hell";
            }
        }
    }
}
