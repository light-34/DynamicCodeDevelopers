using System;

namespace SchoolMangementSystem
{
    class Program
    {

        static void Main(string[] args)
        {
               
            do
            {
                Console.WriteLine("                 School Management System");
                Console.WriteLine("1. Accept a new student");
                Console.WriteLine("2. Participate in a competition");
                Console.WriteLine("3. Calculate total salary of employee");
                Console.WriteLine("4. Calculate Average Mark of a Student");
                Console.WriteLine("99. Exit");
                string menuitem = Console.ReadLine();
                switch (menuitem)
                {
                    case "1":
                        acceptStudent();
                        break;
                    case "2":
                        compitate();
                        break;
                    case "3":
                        calculateSalaryEmpl();
                        break;
                    case "4":
                        Marks mark = new Marks();
                        mark.getMarks();
                        break;
                    case "99":
                        Environment.Exit(0); ;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (true);
        }
        private static void compitate()
        {
            // participator
            Students student = new Students("Vasya", "Ivanov", 2, DateTime.Now, 5.6, "Usual Grade");
            // answer
            Answer answer = new Answer();
            // answer the questions
            student.Competite(answer);
            // need to prove a question
            Experiment experiment = new Experiment();
            // use a adapter
            IQuestion experimentQuestion = new ExperimentToQuestionAdapter(experiment);
            // proving a question
            student.Competite(experimentQuestion);
        }

        private static void acceptStudent()
        {
            GradeFactory gradeFactory = GradeFactory.GetGradeModel();
            IGrade grade = gradeFactory.GetGrade();
            grade.learn("New student: ");
        }

        private static void calculateSalaryEmpl()
        {
            CalculateSalaryEmployee calculateSal = new CalculateSalaryEmployee();
            calculateSal.CalculateSalaryEmpl();
        }


    }
}
