using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class ShortWorkExperience : BonusStrategy
    {
        const double bonus = 0.01;

        public double CalculateSalary(double sal, int years)
        {
            Console.WriteLine("The employee has short work experience and the bonus is: " + (bonus * years) * 100 + "%");
            return ((sal * (bonus * years)) + sal);
        }

    }
}
