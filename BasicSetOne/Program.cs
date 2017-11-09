using System;
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


            // 3) Create a Person class that has three properties: FirstName, LastName, and Age.
            //    Person should have two constructors: one that requires all properties to be set,
            //    and an overloaded constructor that only requires a firstName and age.
            //    Instantiate two Person objects form the Person class.

            Person jay = new Person("Jay", "Jackson", 22);
            Person paul = new Person("Paul", 83);


            // 4) White a doMath method that takes three parameters: operation, numOne, and numTwo.
            //    The method should then return correct calculations based upon the arguments.
            //
            //    For example:
            //    doMath('add', 2, 2) returns 4
            //    doMath('add', 2, 2) returns 4
            //    
            //    The method should handle add, subtract, multiply, divide, and mod(modulus).
            //    If an unknown operator is used it should write "Operation not available" to the console.

            double doMath(string operation, double numOne, double numTwo)
            {
                switch (operation.ToLower())
                {
                    case "add":
                        return numOne + numTwo;
                    case "subtract":
                        return numOne - numTwo;
                    case "multiply":
                        return numOne * numTwo;
                    case "divide":
                        return numOne / numTwo;
                    case "mod":
                        return numOne % numTwo;
                    default:
                        Console.WriteLine("Operation not available.");
                        return 0;
                }


                // 5) Given an array of ints, write a method to total all the values that are even numbers.

                // Standard
                int sumEvens(int[] numbers)
                {
                    int total = 0;
                    foreach (int n in numbers)
                    {
                        if (n%2==0)
                        {
                            total += n;
                        }
                    }
                    return total;
                }

                // Using LINQ
                int sumEvensLinqOne(int[] numbers)
                {
                    var evens = from n in numbers
                                where n % 2 == 0
                                select n;
                    return evens.Sum();
                }
                
                // One line
                int sumEvensLinqTwo(int[] numbers)
                {
                    return (from n in numbers where n % 2 == 0 select n).Sum();
                }
            }
        }
    }
}
