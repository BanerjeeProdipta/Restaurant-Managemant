using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.EntityLayer
{
    class CartEntity
    {

        private string item;
        private string table;
        private float price;
        private int quantity;
        private string cartIdGenerate;
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Item
        {
            get { return item; }
            set { item = value; }
        }

        public string CartIdGenerate
        {
            get { return cartIdGenerate; }
            set { cartIdGenerate = "Order-" + value.PadLeft(4,'0'); }
        }

        public string Table
        {
            get { return table; }
            set { table = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

    }
}
