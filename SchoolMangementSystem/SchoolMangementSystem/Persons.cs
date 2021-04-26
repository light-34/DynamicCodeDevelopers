using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class Persons
    {
        private string fname;
        private string lname;

        public Persons(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }
        public string getFName()
        {
            return fname;
        }
        public string getLName()
        {
            return lname;
        }
    }
}
