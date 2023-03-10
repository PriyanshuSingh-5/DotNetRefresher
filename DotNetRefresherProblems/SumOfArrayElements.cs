using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    class SumOfArrayElements
    {
        //Write a C# program to compute the sum of all the elements of an array of integers. 
        public static void SumOfArraydata()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Compute the sum of the elements in the array
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            // Print the sum of the elements
            Console.WriteLine("Sum of the elements in the array: {0}", sum);
        }
    }
}
