using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class Students : Persons
    {
        private int rollNumber;
        private DateTime regDate;
        private double englishMark;
        private string gradetype;

        private static bool result = false;

        public Students(string fname, string lname, int rollNumber, DateTime regDate, double englishMark, string gradetype) : base(fname, lname)
        {
            this.rollNumber = rollNumber;
            this.regDate = regDate;
            this.englishMark = englishMark;
            this.gradetype = gradetype;
        }

        public Students(string fname, string lname, int rollNumber) : base(fname, lname)
        {
            this.rollNumber = rollNumber;
        }

        internal void Competite(IQuestion question)
        {
            string dquestion;
            if (!result)
            {
                do
                {
                    Console.WriteLine("\t\t\t\tPLease, choose the question from 1 to 5\n");
                    Console.WriteLine("\t\t********************************************************************");
                    int choice = Int32.Parse(Console.ReadLine());
                    Dictionary<int, string> questions = new Dictionary<int, string>()
                {
                    { 1, "A" },
                    { 2, "B" },
                    { 3, "C" },
                    { 5, "D" }

                };
                    if (questions.ContainsKey(choice))
                    {
                        dquestion = questions[choice];
                        Console.WriteLine("Your question is " + dquestion);
                        result = true;
                    }
                    else Console.WriteLine("Wrong question number! Choose correct number of the question");
                } while (!result);
            }
            else
            {
                Console.WriteLine("PLease, Prove your question");
            }
            question.Explain();
            Console.WriteLine("*************************************************************************");
        }

        internal int getRollNumber()
        {
            return rollNumber;
        }

        internal DateTime getRegDate()
        {
            return regDate;
        }

        internal double getEnglishMarks()
        {
            return englishMark;
        }

        internal string getGradetype()
        {
            return gradetype;
        }
        internal void SetGradetype(string gtype)
        {
            this.gradetype = gtype;
        }

    }
}
