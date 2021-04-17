using System;

namespace SchoolMangementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                 School Management System");
            Console.WriteLine("1. Accept a new student");
            Console.WriteLine("2. Participate in a competition");
            string menuitem = Console.ReadLine();
            switch (menuitem)
            {
                case "1":
                    acceptStudent();
                    break;
                case "2":
                    compitate();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }

        private static void compitate()
        {
            throw new NotImplementedException();
        }

        private static void acceptStudent()
        {
            GradeFactory gradeFactory = GradeFactory.GetGradeModel();
            IGrade grade = GradeFactory.GetGrade();
            grade.learn("Message from Main");
        }
    }
}
