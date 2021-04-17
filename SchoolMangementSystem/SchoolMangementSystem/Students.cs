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
        private double englishMark;

        public Students(string fname, string lname, int rollNumber, DateTime regDate, double englishMark) : base(fname, lname)
        {
            this.rollNumber = rollNumber;
            this.regDate = regDate;
            this.englishMark = englishMark;
        }
    }
}
