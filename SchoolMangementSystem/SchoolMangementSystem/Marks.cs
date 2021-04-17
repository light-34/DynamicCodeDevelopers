using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class Marks
    {
        private double midtermOne;
        private double midtermTwo;
        private double midtermThree;
        private double final;

        public Marks(double midtermOne, double midtermTwo, double midtermThree, double final)
        {
            this.midtermOne = midtermOne;
            this.midtermTwo = midtermTwo;
            this.midtermThree = midtermThree;
            this.final = final;
        }
    }
}
