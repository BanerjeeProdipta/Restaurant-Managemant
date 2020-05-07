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
    class WaiterRepository : IWaiterRepository
    {
        public bool Save(WaiterEntity er)
        {

            try
            {
                string query = "select * from Waiter where appid = '" + er.WaiterId + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into Waiter values ('" + er.WaiterId + "','" + er.WaiterName + "','" + er.WaiterAddress + "','" + er.WaiterEmail + "','" + er.WaiterPhone + "','" + er.WaiterGender + "','" + er.WaiterDateOfBirth + "','" + er.WaiterJoiningDate + "','" + er.WaiterMaritalStatus + "','" + er.WaiterBloodGroup + "','" + er.WaiterSalary + "');";
                }
                else
                {
                    //query = "Update  Waiter set Name = '" + er.WaiterName + "','" + er.WaiterAddress + "','" + er.WaiterEmail + "','" + er.WaiterPhone + "','" + er.WaiterGender + "','" + er.WaiterDateOfBirth + "','" + er.WaiterJoiningDate + "','" + er.WaiterMaritalStatus + "','" + er.WaiterBloodGroup + "','" + er.WaiterSalary + "' where appid = '" + er.WaiterId + "'";

                    query = @"update Waiter
                        set Name = '" + er.WaiterName + @"',
                        Address = " + er.WaiterAddress + @",
                        Email = " + er.WaiterEmail + @",
                        Phone = '" + er.WaiterPhone + @"',
                        Gender = '" + er.WaiterGender + @"'
                        Date_Of_Birth = '" + er.WaiterDateOfBirth + @"',
                        Joining_Date = '" + er.WaiterJoiningDate + @"'
                        Marital_Status = '" + er.WaiterMaritalStatus + @"',
                        Blood_Group = '" + er.WaiterBloodGroup + @"'
                        Salary = '" + er.WaiterSalary + @"',
                        where AppId = '" + er.WaiterId + "';";
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



        public bool Delete(string WaiterId)
        {
            string query = "delete from Waiter where appid = '" + WaiterId + "'";
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
                string query = "select * from Waiter where Name = '" + Name + "';";
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
                string query = "select * from Waiter;";
                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }
        }


        /* public List<EmployeeValidation> GetEmployee(string EmployeeId)
         {
             return 0;
         }


         public List<EmployeeValidation> GetAllEmployee()
         {
             return 0;
         }

         public List<EmployeeValidation> searchEmployee(string text)
         {
             return 0;
         }
         */


        public WaiterEntity MyProfileLoad(String u)
        {
            string sql = "select * from Waiter where AppId = '" + u + "';";
            var ds = DataAccess.GetDataSet(sql);
            return this.ConvertToEntity(ds.Tables[0].Rows[0]);



        }

        public WaiterEntity ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var w = new WaiterEntity();
            w.WaiterId = row["AppId"].ToString();
            w.WaiterName = row["Name"].ToString();
            w.WaiterAddress = row["Address"].ToString();
            w.WaiterBloodGroup = row["Blood_Group"].ToString();
            w.WaiterDateOfBirth = row["Date_Of_Birth"].ToString();
            w.WaiterEmail = row["Email"].ToString();
            w.WaiterPhone = row["Phone"].ToString();
            w.WaiterGender = row["Gender"].ToString();
            w.WaiterMaritalStatus = row["Marital_Status"].ToString();
            w.WaiterJoiningDate = row["Joining_Date"].ToString();
            w.WaiterSalary = row["Salary"].ToString();
            return w;



        }
        public string AutoLoadWaiterId()
        {
            string id = "select isnull(max(cast(Id as int)),0)+1 from Waiter";
            var dt = DataAccess.GetDataTable(id);
            string i = dt.Rows[0][0].ToString();
            return i;
        }
    }
}
