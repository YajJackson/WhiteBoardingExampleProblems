﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSetOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Create a method that accepts two Names as parameters and then returns
            //    the full name by implementing concatenation.

            string FullName(string first, string last)
            {
                return first + " " + last;
            }

            // 2) Create a method that accepts two numbers as parameters and then returns
            //    their product

            double Multiply(double numOne, double numTwo)
            {
                return numOne * numTwo;
            }
        }
    }
}
