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
    class MenuRepository : IMenuRepository
    {
        public bool Save(MenuEntity er)
        {

            try
            {
                string query = "select * from Menu where Appid = '" + er.MenuId + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into Menu values ('" + er.MenuId + "','" + er.MenuName + "','" + er.MenuCategory + "','" + er.MenuPrice + "');";
                }
                else
                {
                    query = "Update  Menu set price = '" +  er.MenuPrice + "' where appid = '" + er.MenuId + "'";
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



        public bool Delete(string MenuId)
        {
            string query = "delete from Menu where AppId = '" + MenuId + "'";
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
                string query = "select * from Menu where Name = '" + Name + "';";
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
                string query = "select * from Menu;";
                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public DataTable GetApetizer()
        {
            try
            {
                string Name = "Appetizer";
                string query = "select * from Menu where Category = '" + Name + "';";
                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public DataTable GetMainCourse()
        {
            try
            {
                string Name = "Main Course";
                string query = "select * from Menu where Category = '" + Name + "';";
                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public DataTable GetDessert()
        {
            try
            {
                string Name = "Dessert";
                string query = "select * from Menu where Category = '" + Name + "';";
                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public DataTable GetBeverage()
        {
            try
            {
                string Name = "Beverage";
                string query = "select * from Menu where Category = '" + Name + "';";
                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public MenuEntity MyProfileLoad(String u)
        {
            string sql = "select * from Manager where AppId = '" + u + "';";
            var ds = DataAccess.GetDataSet(sql);
            return this.ConvertToEntity(ds.Tables[0].Rows[0]);



        }

        public MenuEntity ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var m = new MenuEntity();
            m.MenuId = row["AppId"].ToString();
            m.MenuName = row["Name"].ToString();
            m.MenuCategory = row["Category"].ToString();
            m.MenuPrice = row["Price"].ToString();
            
            return m;



        }
        public string AutoLoadMenuId()
        {
            string id = "select isnull(max(cast(Id as int)),0)+1 from Menu";
            var dt = DataAccess.GetDataTable(id);
            string i = dt.Rows[0][0].ToString();
            return i;
        }
    }
}
