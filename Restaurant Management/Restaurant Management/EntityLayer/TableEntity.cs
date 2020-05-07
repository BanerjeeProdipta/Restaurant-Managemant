using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.EntityLayer
{
    class TableEntity
    {
        private string tableId;
        private string tableIdGenerate;
        private string capacity;
        private string status;
       
        public string TableId
        {
            get { return tableId; }
            set { tableId = value; }
        }
        public string TableIdGenerate
        {
            get { return tableIdGenerate; }
            set { tableIdGenerate = "T-" + value.PadLeft(2, '0'); ; }
        }

        public string Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }


    }
}
