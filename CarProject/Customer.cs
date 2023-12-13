using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class Customer
    {
        private int Id;
        private string Name;
        private int Age;
        private string Address;

        public int id { set { this.Id = value; } get { return this.Id; } }

        public string name { set { this.Name = value; } get { return this.Name; } }
        public int age { set { this.Age = value;} get { return this.Age; } }
        public string  address { set { this.Address  = value;} get { return this.Address ; } }

    }
}
