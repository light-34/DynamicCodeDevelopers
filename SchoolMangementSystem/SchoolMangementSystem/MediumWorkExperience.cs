using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class MediumWorkExperience : BonusStrategy
    {
        const double bonus = 0.03;
        public double CalculateSalary(double sal, int years)
        {
            Console.WriteLine("The employee has medium work experience and the bonus is: " + (bonus * years) * 100 + "%");
            return ((sal * (bonus * years)) + sal);
        }
    }
}
