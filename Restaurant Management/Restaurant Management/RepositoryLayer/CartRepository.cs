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
    class CartRepository
    {
        public bool Save(CartEntity er)
        {

            try
            {





                String query = "Insert into Cart values ('" + er.Id + "','" + er.Item + "','" + er.Table + "','" + er.Price + "','" + er.Quantity + "');";


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

        public bool SaveFinancial(FinancialEntity er)
        {

            try
            {





                String query = "Insert into Financial values ('" + er.Id + "','" + er.OrderId + "','" + er.Table + "','" + er.Bill + "');";


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
        public void SaveOrder(CartEntity er)
        {

            try
            {



                string query = "Insert into OrderData values ('" + er.Id + "','" + er.Item + "','" + er.Table + "','" + er.Quantity + "','" + er.Price + "');";
                DataAccess.ExecuteQuery(query);



            }
            catch (Exception ex)
            {
                return;
            }
        }

        public bool Delete(string Id)
        {
            string query = "delete from OrderData where appid = '" + Id + "'";
            int count = DataAccess.ExecuteQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }

        public void InitiateOrder()
        {
            string query = "select * from Cart;";
            var dt = DataAccess.GetDataTable(query);


            for (int ax = 0; ax < dt.Rows.Count; ax++)
            {
                var c = ConvertToEntity(dt.Rows[ax]);
                SaveOrder(c);
            }

        }

        public DataTable GetCart()
        {
            try
            {
                string query = "select * from Cart;";
                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }

        }

        public DataTable GetOrder()
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
        public DataTable GetFinancial()
        {
            try
            {
                string query = "select * from Financial;";
                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }

        }

        public string BillGenerate(string Id)
        {
           // try
           // {
                string query = "select * from OrderData Where AppId = '" + Id + "'";
                var dt = DataAccess.GetDataTable(query);
                float total = 0;

                for (int ax = 0; ax < dt.Rows.Count; ax++)
                {
                    var c = ConvertToEntity(dt.Rows[ax]);
                    total += c.Price;

                }
                return total.ToString();
          //  }
          //  catch (Exception exception)
          //  {
         //       return "Hell";
         //   }

        }

        public DataTable GetMenu()
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

        public DataTable GetTable()
        {
            try
            {
                string text = "Available";
                string query = "select * from TableData Where Status = '" + text + "'";

                var dt = DataAccess.GetDataTable(query);
                return dt;
            }
            catch (Exception exception)
            {
                return null;
            }

        }

        public void UpdateTable(TableEntity er)
        {
            try
            {
                string text = "UnAvailable";
                string query = "Update TableData set Status = '" + text + "' where AppId = '" + er.TableId + "';";
                DataAccess.ExecuteQuery(query);

            }
            catch (Exception exception)
            {
                return;
            }

        }

        public void UpdateTable2(TableEntity er)
        {
            try
            {
                string text = "Available";
                string query = "Update TableData set Status = '" + text + "' where AppId = '" + er.TableId + "';";
                DataAccess.ExecuteQuery(query);

            }
            catch (Exception exception)
            {
                return;
            }

        }


        public string AutoLoadOrderId()
        {
            try
            {
                string id = "select isnull(max(cast(Id as int)),0)+1 from OrderData";
                var dt = DataAccess.GetDataTable(id);
                string i = dt.Rows[0][0].ToString();
                return i;
            }
            catch (Exception ex)
            {
                return "Hell";
            }
        }

        public string AutoLoadFinanceId()
        {
            try
            {
                string id = "select isnull(max(cast(Id as int)),0)+1 from Financial";
                var dt = DataAccess.GetDataTable(id);
                string i = dt.Rows[0][0].ToString();
                return i;
            }
            catch (Exception ex)
            {
                return "Hell";
            }
        }

        public void ClearCart()
        {
            string query = "delete from Cart";
            DataAccess.ExecuteQuery(query);

        }

        public CartEntity ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var c = new CartEntity();
            c.Id = row["Id"].ToString();
            c.Item = row["Item"].ToString();
            c.Quantity = Int32.Parse(row["Quantity"].ToString());
            c.Table = row["Table_Seat"].ToString();
            c.Price = float.Parse(row["Price"].ToString());


            return c;



        }

        public CartEntity ConvertToOrderEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var c = new CartEntity();
            c.Id = row["Id"].ToString();
            c.Item = row["Item"].ToString();
            c.Quantity = Int32.Parse(row["Quantity"].ToString());
            c.Table = row["Table_Seat"].ToString();
            c.Price = float.Parse(row["Price"].ToString());


            return c;



        }
    }
}
