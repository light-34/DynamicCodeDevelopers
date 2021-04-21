using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class UsualGrade: IGrade
    {
        public void learn(string Message)
        {
            Console.WriteLine("{0} - Enrolled to the Usual Grade.", Message);//Method Log to display simple message
        }
    }
}
