using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class Teachers : Persons
    {
        private DateTime hireDate;
        private double salary;

        public Teachers(string fname, string lname, double salary, DateTime hire) : base(fname, lname)
        {
            this.hireDate = hire;
            this.salary = salary;
        }
    }
}
