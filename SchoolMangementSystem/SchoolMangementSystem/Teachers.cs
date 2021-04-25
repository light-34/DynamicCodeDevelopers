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

        public Teachers(string fname, string lname, double salary, DateTime hireDate) : base(fname, lname)
        {
            this.hireDate = hireDate;
            this.salary = salary;
        }
        public DateTime getHireDate()
        {
            return hireDate;
        }

        public double getSalary()
        {
            return salary;
        }
    }
}
