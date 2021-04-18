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
            Console.WriteLine("{0} - Enrolled a usual grade.", Message);//Method Log to display simple message
        }
    }
}
