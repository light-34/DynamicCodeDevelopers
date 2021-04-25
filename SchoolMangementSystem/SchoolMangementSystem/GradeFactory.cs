using System;
using System.Collections;
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
            Console.WriteLine("\t\t\t\tAcceptation a new student\n");
            Console.WriteLine("\t\t-----------------------------------------------------------------------------");
            string gtype;
            IGrade model;
            ArrayList slist = new ArrayList();
            Console.WriteLine("Please, Enter the First name");
            fname = Console.ReadLine();
            Console.WriteLine("Please, Enter the Last name");
            lname = Console.ReadLine();
            Console.WriteLine("Please, Enter the roll Number");
            rollNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, Enter the reg Date");
            regdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please, Enter the english Mark");
            mark = double.Parse(Console.ReadLine());
            gtype = "";
                
            Students student = new Students(fname, lname, rollNumber, regdate, mark, gtype);
                
            smark = student.getEnglishMarks();
            if (smark > 4) { type = "Normal"; }
            else { type = "Not accepted"; }
                
            switch (type)
            {
                case "Normal":
                    model = new UsualGrade();
                    student.SetGradetype("Usual Grade");
                    break;
                case "Not accepted":
                    model = new PreparatorGrade();
                    student.SetGradetype("Preparatory Grade");
                    break;
                default:
                    model = null;
                    student.SetGradetype("Usual Grade");
                    break;
            }
            slist.Add(fname);
            slist.Add(lname);
            slist.Add(student.getrollNumber());
            slist.Add(student.getRegDate().ToString("d"));
            slist.Add(student.getEnglishMarks());
            slist.Add(student.getGradetype());
            foreach (var item in slist)
                Console.Write(item + " ");
            Console.WriteLine();    
            return model;
        }
    }
}
