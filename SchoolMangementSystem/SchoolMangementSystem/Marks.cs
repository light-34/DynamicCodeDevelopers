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

        public Marks () { }

        public Marks(double midtermOne, double midtermTwo, double midtermThree, double final)
        {
            this.midtermOne = midtermOne;
            this.midtermTwo = midtermTwo;
            this.midtermThree = midtermThree;
            this.final = final;
        }

        //This method is designed to get data from user
        public void getMarks ()
        {
            Console.WriteLine("                 Average Calculation System");
            Console.WriteLine("**********************************************************\n");
            Console.WriteLine("Please enter Student's Name");
            string name = Console.ReadLine();
            Console.WriteLine("\nPlease enter Student's Last Name");
            string lname = Console.ReadLine();
            Console.WriteLine("\nPlease enter Student's Roll Number");
            int roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter first midterm mark");
            double midOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter second midterm mark");
            double midTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter third midterm mark");
            double midThree = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter final exam mark");
            double final = Convert.ToDouble(Console.ReadLine());
            Students student = new Students(name, lname, roll);

            double average = semesterAverageMark(new Marks(midOne, midTwo, midThree, final));
            printMarks(student, average);
           
        }

        //This method is designed to get a Marks type parameter
        //and calculate average
        public double semesterAverageMark(Marks mark)
        {
            ISemester semester = new Semester();
            semester = new MidtermOne(semester, mark.midtermOne);
            semester = new MidtermTwo(semester, mark.midtermTwo);
            semester = new MidtermThree(semester, mark.midtermThree);
            semester = new FinalExam(semester, mark.final);

            return semester.averageMark() / 4;
        }

        //This method is designed to get a Students type parameter and 
        //a double parameter to display data
        public void printMarks(Students student, double average)
        {
            Console.WriteLine("**********************************************************************************************************************************\n");
            Console.WriteLine($"Student Avarage Mark Info \nFull Name : {student.getLName()}, {student.getFName()} \nRoll Number : {student.getRollNumber()} \nAverage Mark : {average}\n");
            Console.WriteLine("**********************************************************************************************************************************\n");
        }
    }
}
