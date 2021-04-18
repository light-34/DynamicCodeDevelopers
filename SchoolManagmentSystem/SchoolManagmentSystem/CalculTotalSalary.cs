using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem
{
    internal class CalculTotalSalary
    {
        private BonusStrategy currBonusStr;

        internal void SetStrategy(BonusStrategy bs)
        {
            currBonusStr = bs;
        }

        public double CalculateSalary(double salary, int years)
        {
            return currBonusStr.CalculateSalary(salary, years);
        }
    }
}
