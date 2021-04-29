using System;
using System.Collections;
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
        private Hashtable avHash = new Hashtable();
        

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
            string inChoice = "y";
            do {
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

                Console.WriteLine("Do you want to save this information? (Y/N)");
                string choice = Console.ReadLine();

                if (String.Equals(choice, "y", StringComparison.OrdinalIgnoreCase))
                {
                    avHash.Add(student.getRollNumber(), average);
                    Console.WriteLine("Data Saved\n");
                    Console.WriteLine("**********************************************************\n");
                }
                else
                {
                    Console.WriteLine("Data Deleted\n");
                    Console.WriteLine("**********************************************************\n");
                }

                Console.WriteLine("Do you want to continue to calculate? (Y/N)");
                inChoice = Console.ReadLine();

            } while (String.Equals(inChoice, "y", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Do you want to display all average marks? (Y/N)");
            string avMarkChoice = Console.ReadLine();
            if (String.Equals(avMarkChoice, "y", StringComparison.OrdinalIgnoreCase))
            {
                foreach (DictionaryEntry item in avHash)
                {
                    Console.WriteLine($"Roll No : {item.Key} - Average : {item.Value}");
                }
                Console.WriteLine("\n**********************************************************\n");
            }
            else
            {
                Console.WriteLine("Module Terminated\n");
                Console.WriteLine("**********************************************************\n");
            }


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
            Console.WriteLine("**********************************************************\n");
            Console.WriteLine($"Student Avarage Mark Info \nFull Name : {student.getLName()}, {student.getFName()} \nRoll Number : {student.getRollNumber()} \nAverage Mark : {average}\n");
            Console.WriteLine("**********************************************************\n");
        }
    }
}
