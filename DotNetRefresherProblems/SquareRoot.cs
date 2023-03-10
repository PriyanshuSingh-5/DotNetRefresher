using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    class SquareRoot
    {
        //Write a C# program to find the square root of a given number without using Math.Sqrt() method.
        public static void SquareRootWithoutMathSQRT()
        {

            
                Console.Write("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                double root = 1;
                int i = 0;
                //The Babylonian Method for Computing Square Roots
                while (true)
                {
                    i = i + 1;
                    root = (number / root + root) / 2;
                    if (i == number + 1) { break; }
                }

                //Output
                Console.WriteLine("Square root:{0}", root);

                Console.ReadLine();
            

        }
    }
}
