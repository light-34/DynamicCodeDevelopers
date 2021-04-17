using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    internal class GradeFactory
    {
        private GradeFactory() { }

        private static GradeFactory uniqueInstance = new GradeFactory();
        public static GradeFactory GetGradeModel()
        {
            return uniqueInstance;
        }
        internal IGrade GetGrade()//FACTORY METHOD
        {
            double mark, smark;
            int rollNumber;
            DateTime regdate;
            string type, fname, lname;
            Console.WriteLine("Please, Enter the First name");
            fname = Console.ReadLine();
            Console.WriteLine("Please, Enter the Last name");
            lname = Console.ReadLine();
            Console.WriteLine("Please, Enter the roll Number");
            rollNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, Enter the reg Date");
            regdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please, Enter the english Mark");
            mark = Double.Parse(Console.ReadLine());

            Students student = new Students(fname, lname, rollNumber, regdate, mark);
            smark = student.getEnglishMarks();
            if (smark > 4) { type = "Normal"; }
            else { type = "Not accepted"; }
            IGrade model;
            switch (type)
            {
                case "Normal":
                    model = new UsualGrade();
                    break;
                case "Not accepted":
                    model = new PreparatorGrade();
                    break;
                default:
                    model = null;
                    break;
            }
            return model;
        }
    }
}
