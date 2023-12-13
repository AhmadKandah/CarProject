using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class Suppliers
        
    {
        private int Id;
        private string Name;
        private string  Address;

        public int id{ set { this.Id = value; } get { return this.Id; } }

        public string name { set { this.Name = value; } get { return this.Name; } }
        public string address { set { this.Address = value; }get { return this.Address; } }
    }
}
