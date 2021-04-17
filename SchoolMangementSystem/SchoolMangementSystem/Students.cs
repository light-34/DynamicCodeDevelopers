using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class Students : Persons
    {
        private int rollNumber;
        private DateTime regDate;

        public Students(string fname, string lname, int roll, DateTime date) : base(fname, lname)
        {
            this.rollNumber = roll;
            this.regDate = date;
        }
    }
}
