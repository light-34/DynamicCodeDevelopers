using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem
{
    internal interface BonusStrategy
    {
        double CalculateSalary(double salary, int years);
    }
}
