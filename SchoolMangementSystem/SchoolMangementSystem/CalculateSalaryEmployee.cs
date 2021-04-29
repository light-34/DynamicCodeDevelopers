using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class CalculateSalaryEmployee
    {
        public void CalculateSalaryEmpl()
        {
            Console.WriteLine("\t\t\t\tCalculation of the Total Salary an Employee Per Month\n");
            Console.WriteLine("\t\t\t*********************************************************************");

            List<double> tot = new List<double>();
            Dictionary<string, double> empl = new Dictionary<string, double>();
            string choice;
            Teachers teacher;

            do
            {
                DateTime crtDate = DateTime.Now;
                double salary;
                DateTime hireDate;
                string fname, lname;
                Console.WriteLine("Please, Enter the First name of employee");
                fname = Console.ReadLine();
                Console.WriteLine("Please, Enter the Last name of employee");
                lname = Console.ReadLine();
                Console.WriteLine("Enter the salary of employee: ");
                salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please, Enter the hire date of employee");
                hireDate = DateTime.Parse(Console.ReadLine());
                int years = Math.Abs(hireDate.Year - crtDate.Year);

                teacher = new Teachers(fname, lname, salary, hireDate);

                CalculTotalSalary calcTotSal = new CalculTotalSalary();
                BonusStrategy bsShort = new ShortWorkExperience();
                BonusStrategy bsMedium = new MediumWorkExperience();
                BonusStrategy bsLong = new LongWorkExperience();

                if (years >= 1 && years <= 5)
                {
                    Console.WriteLine("*************************************************************************\n");
                    calcTotSal.SetStrategy(bsShort);
                    salary = calcTotSal.CalculateSalary(salary, years);
                    Console.WriteLine("The salary per month total: " + Math.Round(salary, 2));
                    tot.Add(salary);
                    empl.Add(lname, salary);
                }

                else if (years > 5 && years <= 15)
                {
                    Console.WriteLine("*************************************************************************\n");
                    calcTotSal.SetStrategy(bsMedium);
                    salary = calcTotSal.CalculateSalary(salary, years);
                    Console.WriteLine("The salary per month total: " + Math.Round(salary, 2));
                    tot.Add(salary);
                    empl.Add(teacher.getLName(), salary);
                }

                else if (years > 15)
                {
                    Console.WriteLine("*************************************************************************\n");
                    calcTotSal.SetStrategy(bsLong);
                    salary = calcTotSal.CalculateSalary(salary, years);
                    Console.WriteLine("The salary per month total: " + Math.Round(salary, 2));
                    tot.Add(salary);
                    empl.Add(teacher.getLName(), salary);
                }
                else
                {
                    Console.WriteLine("*************************************************************************\n");
                    Console.WriteLine("Employee does not have any experience, he will not be credited with a bonus");
                    tot.Add(salary);
                    empl.Add(teacher.getLName(), salary);

                }

                Console.WriteLine("\nDo you add employee else? y/n");
                choice = Console.ReadLine();
            } while (choice != "n");
            double totalsal = 0;
            int count;
            foreach (var item in tot)
            {
                totalsal += item;
            }
            Console.WriteLine("*************************************************************************");


            foreach (KeyValuePair<string, double> item in empl)
            {
                Console.Write("The employee " + item.Key + " has total salary per month: ");
                Console.WriteLine(item.Value);
            }


            count = tot.Count;
            Console.WriteLine("\nThe total number of employees is : " + count);
            Console.WriteLine("\nThe total salary of employees is: " + Math.Round(totalsal, 2) + ", " +
                "and average salary is: " + Math.Round((totalsal / count), 2) + "\n");
            Console.WriteLine("*************************************************************************");
        }
    }
}

