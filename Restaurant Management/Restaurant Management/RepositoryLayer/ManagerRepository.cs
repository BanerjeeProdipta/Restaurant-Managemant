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
    class ManagerRepository : IManagerRepository
    {
        public bool Save(ManagerEntity er)
        {

            try
            {
                string query = "select * from Manager where appid = '" + er.ManagerId + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into Manager values ('" + er.ManagerId + "','" + er.ManagerName + "','" + er.ManagerAddress + "','" + er.ManagerEmail + "','" + er.ManagerPhone + "','" + er.ManagerGender + "','" + er.ManagerDateOfBirth + "','" + er.ManagerJoiningDate + "','" + er.ManagerMaritalStatus + "','" + er.ManagerBloodGroup + "','" + er.ManagerSalary + "');";
                }
                else
                {
                    //query = "Update  Manager set Name = '" + er.ManagerName + "','" + er.ManagerAddress + "','" + er.ManagerEmail + "','" + er.ManagerPhone + "','" + er.ManagerGender + "','" + er.ManagerDateOfBirth + "','" + er.ManagerJoiningDate + "','" + er.ManagerMaritalStatus + "','" + er.ManagerBloodGroup + "','" + er.ManagerSalary + "' where appid = '" + er.ManagerId + "'";

                    query = @"update Manager
                        set Name = '" + er.ManagerName + @"',
                        Address = " + er.ManagerAddress + @",
                        Email = " + er.ManagerEmail + @",
                        Phone = '" + er.ManagerPhone + @"',
                        Gender = '" + er.ManagerGender + @"'
                        Date_Of_Birth = '" + er.ManagerDateOfBirth + @"',
                        Joining_Date = '" + er.ManagerJoiningDate + @"'
                        Marital_Status = '" + er.ManagerMaritalStatus + @"',
                        Blood_Group = '" + er.ManagerBloodGroup + @"'
                        Salary = '" + er.ManagerSalary + @"',
                        where AppId = '" + er.ManagerId + "';";
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



        public bool Delete(string ManagerId)
        {
            string query = "delete from Manager where AppId = '" + ManagerId + "'";
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
                string query = "select * from Manager Where Name LIKE '%+@Name+%';";
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
                string query = "select * from Manager;";
                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
        
         


        public ManagerEntity MyProfileLoad(String u)
        {
            string sql = "select * from Manager where AppId = '" + u + "';";
            var ds = DataAccess.GetDataSet(sql);
            return this.ConvertToEntity(ds.Tables[0].Rows[0]);



        }

        public ManagerEntity ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var m = new ManagerEntity();
            m.ManagerId = row["AppId"].ToString();
            m.ManagerName = row["Name"].ToString();
            m.ManagerAddress = row["Address"].ToString();
            m.ManagerBloodGroup = row["Blood_Group"].ToString();
            m.ManagerDateOfBirth = row["Date_Of_Birth"].ToString();
            m.ManagerEmail = row["Email"].ToString();
            m.ManagerPhone = row["Phone"].ToString();
            m.ManagerGender = row["Gender"].ToString();
            m.ManagerMaritalStatus = row["Marital_Status"].ToString();
            m.ManagerJoiningDate = row["Joining_Date"].ToString();
            m.ManagerSalary = row["Salary"].ToString();
            return m;



        }
        public string AutoLoadManagerId()
        {
            string id = "select isnull(max(cast(Id as int)),0)+1 from Manager";
            var dt = DataAccess.GetDataTable(id);
            string i = dt.Rows[0][0].ToString();
            return i;
        }
    }
}
