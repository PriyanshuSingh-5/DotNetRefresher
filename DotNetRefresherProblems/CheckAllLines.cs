using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    class CheckAllLines
    {
        //Write a program that takes three points (x1, y1), (x2, y2) and (x3, y3) from the user and the program will check wheteher or not all the three points fall on one straight line.

        public static void CheckLinesFallsintoOneLine()
        {
            Console.WriteLine("Enter the coordinates of three points:");

            Console.Write("Point 1 (x1, y1): ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Point 2 (x2, y2): ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Point 3 (x3, y3): ");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double slope1 = (y2 - y1) / (x2 - x1);
            double slope2 = (y3 - y2) / (x3 - x2);

            if (slope1 == slope2)
            {
                Console.WriteLine("The three points fall on the same straight line.");
            }
            else
            {
                Console.WriteLine("The three points do not fall on the same straight line.");
            }
        }
    }
}
