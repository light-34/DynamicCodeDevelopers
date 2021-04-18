using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
        internal interface BonusStrategy
        {
            double CalculateSalary(double salary, int years);
        }
    
}
