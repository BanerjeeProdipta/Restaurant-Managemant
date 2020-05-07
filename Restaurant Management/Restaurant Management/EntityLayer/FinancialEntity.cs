using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.EntityLayer
{
    class FinancialEntity
    {

        private string id;
        private string orderId;
        private string idGenerate;
        private string table;
        private float bill;
        

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }


        public string IdGenerate
        {
            get { return idGenerate; }
            set { idGenerate = "Finance" + value.PadLeft(4, '0'); }
        }

        public string Table
        {
            get { return table; }
            set { table = value; }
        }

        public float Bill
        {
            get { return bill; }
            set { bill = value; }
        }

        

    }
}
