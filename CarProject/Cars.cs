using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class Cars
    {
        private int Id;
        private string Model;
        private int Year;
        private int Gear;
        private int Km;

        public int id {
            set{ this.Id = value ;} get {return this.Id;} }

        public string model {set { this.Model = value;}get{return this.Model;} }

        public int year { set { this.Year = value; } get{return this.Year; } }

        public int gear { set { this.Year = value; }get{return this.Year;} }
    }
}
