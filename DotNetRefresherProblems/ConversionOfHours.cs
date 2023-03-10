using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    class ConversionOfHours
    {
        //Write a C# program that converts hours into minutes and seconds.

        public static void Conversion()
        {
            Console.Write("Enter the number of hours: ");
            int hours = int.Parse(Console.ReadLine());

            int minutes = hours * 60;
            int seconds = hours * 3600;

            Console.WriteLine("{0} hours is equal to {1} minutes and {2} seconds.", hours, minutes, seconds);
        }
    }
}
