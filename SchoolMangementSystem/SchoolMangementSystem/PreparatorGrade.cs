﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementSystem
{
    class PreparatorGrade : IGrade
    {
        public void learn(string Message)
        {
            Console.WriteLine("{0} - Enrolled to the Preparator Grade.", Message); ;
            Console.WriteLine("*************************************************************************\n");
        }
    }
}
