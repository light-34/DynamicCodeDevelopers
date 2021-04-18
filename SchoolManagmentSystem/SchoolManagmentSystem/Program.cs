using System;
using System.Collections.Generic;

namespace SchoolManagmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("\t\t\t\tCalculation of the Total Salary an Employee Per Month\n");
            Console.WriteLine("\t\t-----------------------------------------------------------------------------");

            List<double> tot = new List<double>();
            String choice;
            do
            {
                
                Console.WriteLine("\nEnter the salary rate of employee: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the work experience of employee: ");
                int years = Convert.ToInt32(Console.ReadLine());

                CalculTotalSalary calcTotSal = new CalculTotalSalary();
                BonusStrategy bsShort = new ShortWorkExperience();
                BonusStrategy bsMedium = new MediumWorkExperience();
                BonusStrategy bsLong = new LongWorkExperience();

                if (years >= 1 && years <= 5)
                {
                    calcTotSal.SetStrategy(bsShort);
                    salary = calcTotSal.CalculateSalary(salary, years);
                    Console.WriteLine("The salary per month total: " + Math.Round(salary,2));
                    tot.Add(salary);
                }

                else if (years > 5 && years <= 15)
                {
                    calcTotSal.SetStrategy(bsMedium);
                    salary = calcTotSal.CalculateSalary(salary, years);
                    Console.WriteLine("The salary per month total: " + Math.Round(salary, 2));
                    tot.Add(salary);
                }

                else if (years > 15)
                {
                    calcTotSal.SetStrategy(bsLong);
                    salary = calcTotSal.CalculateSalary(salary, years);
                    Console.WriteLine("The salary per month total: " + Math.Round(salary, 2));
                    tot.Add(salary);
                }else
                {
                    Console.WriteLine("Employee does not have any experience, he will not be credited with a bonus");
                    tot.Add(salary);
                }

                Console.WriteLine("\nDo you want to calculate the salary else? y/n");
                choice = Console.ReadLine();
            } while (choice !="n");
            double totalsal = 0;
            int count;
            foreach (var item in tot)
            {
                totalsal += item;
            }
            count = tot.Count;
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("\nThe total number of employees is : " + count);
            Console.WriteLine("\nThe total salary of employees is: "  + Math.Round(totalsal, 2) +  ", and average salary is: " + Math.Round((totalsal/count),2));
        }
    }
}
