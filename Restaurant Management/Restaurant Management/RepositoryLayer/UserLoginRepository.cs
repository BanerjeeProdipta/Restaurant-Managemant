using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DataLayer;
using Restaurant_Management.EntityLayer;
using Restaurant_Management.ApplicationLayer;

namespace Restaurant_Management.RepositoryLayer
{
    class UserLoginRepository
    {
        public bool UserLoginValidation(UserLoginEntity u)
        {
            try
            {
                string sql = "select * from Login where Id = '" + u.UserId + "' and Password = '" + u.UserPassword + "';";

                var ds = DataAccess.GetDataSet(sql);
                //MessageBox.Show(this.Ds.Tables[0].Rows.Count.ToString());
                // emp.EmployeeName = ds.Tables[0].Rows[0][1].ToString();
                if (ds.Tables[0].Rows.Count == 1)
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
    }
}
