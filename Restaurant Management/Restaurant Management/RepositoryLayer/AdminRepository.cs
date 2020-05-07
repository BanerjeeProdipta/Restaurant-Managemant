using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Restaurant_Management.DataLayer;
using Restaurant_Management.EntityLayer;
using Restaurant_Management.ApplicationLayer;
using Restaurant_Management.ValidationLayer;


namespace Restaurant_Management.RepositoryLayer
{
    class AdminRepository
    {
        public bool Save(AdminEntity er)
        {

          //  try
          //  {
                string query = "select * from Admin where appid = '" + er.AdminId + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into Admin values ('" + er.AdminId + "','" + er.AdminName + "','" + er.AdminAddress + "','" + er.AdminEmail + "','" + er.AdminPhone + "','" + er.AdminGender + "','" + er.AdminDateOfBirth + "','" + er.AdminJoiningDate + "','" + er.AdminMaritalStatus + "','" + er.AdminBloodGroup + "','" + er.AdminSalary + "');";
                }
                else
                {

                          query = "Update Admin set Name = '" + er.AdminName + "',Address= '" + er.AdminAddress + "',Email= '" + er.AdminEmail + "',Phone= '" + er.AdminPhone + "',Gender= '" + er.AdminGender + "',Date_Of_Birth= '" + er.AdminDateOfBirth + "',Joining_Date= '" + er.AdminJoiningDate + "',Marital_Status= '" + er.AdminMaritalStatus+ "',Blood_Group= '" + er.AdminBloodGroup + "',Salary= '" + er.AdminSalary + "' where AppId = '" + er.AdminId + "'";
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
        /*    }
            catch (Exception ex)
            {
                return false;
            }*/
        }



        public bool Delete(string AdminId)
        {
            string query = "delete from Admin where appid = '" + AdminId + "'";
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
                string query = "select * from Admin where Name  LIKE '%@Name%';";
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
                string query = "select * from Admin;";
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


        public AdminEntity MyProfileLoad(String u)
        {
            string sql = "select * from Admin where AppId = '" + u + "';";
            var ds = DataAccess.GetDataSet(sql);
             return this.ConvertToEntity(ds.Tables[0].Rows[0]);
            
            

        }

        public AdminEntity ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var p = new AdminEntity();
            p.AdminId = row["AppId"].ToString();
            p.AdminName = row["Name"].ToString();
            //p.EmployeePost = row["Post"].ToString();
            p.AdminAddress = row["Address"].ToString();
            p.AdminBloodGroup = row["Blood_Group"].ToString();
            p.AdminDateOfBirth = row["Date_Of_Birth"].ToString();
            p.AdminEmail = row["Email"].ToString();
            p.AdminPhone = row["Phone"].ToString();
            p.AdminGender = row["Gender"].ToString();
            p.AdminMaritalStatus = row["Marital_Status"].ToString();
            p.AdminSalary = row["Salary"].ToString();
            p.AdminJoiningDate = row["Joining_Date"].ToString();
            return p;



        }
        public string AutoLoadWaiterId()
        {
            string id = "select isnull(max(cast(Id as int)),0)+1 from Waiter";
            var dt = DataAccess.GetDataTable(id);
            string i = dt.Rows[0][0].ToString();
            return i;
        }
        public string AutoLoadAdminId()
        {
            string id = "select isnull(max(cast(Id as int)),0)+1 from Admin";
            var dt = DataAccess.GetDataTable(id);
            string i = dt.Rows[0][0].ToString();
            return i;
        }
    }
}
