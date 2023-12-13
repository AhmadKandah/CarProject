using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class Parts
    {
        private int Id;
        private string Name;
        private int Price;
        private int Quantity;
        private int SupplierId;

        public int id {  set { this.Id = value;} get { return this.Id; }}

        public string name { set { this.Name = value; } get { return this.Name; } }

        public int price { set { this.Price = value; } get{ return this.Price;  } }

        public int quantity { set { this.Quantity = value; }get { return this.Quantity; } }

        public int supplierId { set { this.SupplierId = value; }get { return this.SupplierId; } }




        

    }
}
