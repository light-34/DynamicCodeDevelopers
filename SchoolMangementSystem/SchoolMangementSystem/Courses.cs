using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class Courses
    {
        private string semester;
        private string courseName;
        private int courseCode;
        private int credit;

        public Courses(string semester, string courseName, int courseCode, int credit)
        {
            this.semester = semester;
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.credit = credit;
        }
    }
}
