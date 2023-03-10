using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    class PrimeNumbers
    {
        //Write a C# program to find prime numbers from 1 to 100.
        public static void PrimenumbersBTW1To100()
        {
            bool isPrime = true;
            int i, j;
            //Calculate and display the Prime number  
            Console.WriteLine("Prime Numbers are : ");
            for (i = 2; i <= 100; i++)
            {
                for (j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
