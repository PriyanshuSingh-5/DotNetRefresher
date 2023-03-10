using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    class ConvertDate
    {
        //Write a C#  program to convert entered days into years , months and weeks.
        public static void ConvertDaysToYearsMonths()
        {
            int num = 0;
            int years = 0;
            int weeks = 0;
            int days = 0;


            Console.Write("Enter number of days: ");
            num = Convert.ToInt32(Console.ReadLine());

            years = num / 365;
            weeks = (num % 365) / 7;
            days = (num % 365) % 7;

            Console.WriteLine("Years : " + years);
            Console.WriteLine("Weeks : " + weeks);
            Console.WriteLine("Days  : " + days);

        }
    }
}
