using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    class N1N2Problem
    {
        //Write a method in C# that takes two values, n1 and n2, as arguments and multiply the n1 by itself n2 times. In other words, calculate n1n2 and then return the result to the main function that will display the result.
        public static void Multiply()
        {
            N1N2Problem p = new N1N2Problem();
            double n1, n2;
            Console.WriteLine("Enter n1 Value:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n2 Value:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The n1^n2 Is :" + p.Cal(n1, n2));
            Console.ReadKey();
        }
        private double Cal(double n1, double n2)
        {
            n1 = Math.Pow(n1, n2);
            return n1;
        }

    
}
}
