using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetRefresherProblems
{
    class LinqProblems
    {
        //Write a program in C# to find the positive numbers from a list of numbers using two where conditions in LINQ Query

        public static void FindListOfPositive()
        {
            int[] numbers = {
                1, 3, 6, 9, 10, -4, -2, -3, -88, 12, 19,  14
            };

            var nQuery =
            from VrNum in numbers
            where VrNum > 0
            where VrNum < 10
            select VrNum;
            Console.Write("\nThe numbers within the range of 1 to 10 are : \n");
            foreach (var VrNum in nQuery)
            {
                Console.Write("{0}  ", VrNum);
            }
            Console.ReadLine();
        }

        //Write a program in C# to find the number of an array and the square of each number in LINQ Query.

        public static void SquareOfNumbersInArray()
        {
            var arr = new[] { 6, 7, 8, 9 };

            var sqaure = from int Number in arr
                         let SqrNo = Number * Number
                         select new { Number, SqrNo };

            foreach (var a in sqaure)
                Console.WriteLine(a);

            Console.ReadLine();

        }

    }
}

