using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class Salels
    {
        private int Id;
        private int Total;
        private int CarId;
        private int CustomerId;
        public int id { set { this.Id = value; } get { return this.Id; } }
        public int total { set { this.Total  = value; } get { return this.Total ; } } 
        public int carid { set { this.CarId  = value; } get { return this.CarId ; } }
        public int customerid { set { this.CustomerId  = value; } get { return this.CustomerId ; } }
     
    }
}
