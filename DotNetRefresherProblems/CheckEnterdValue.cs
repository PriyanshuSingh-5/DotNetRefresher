using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    class CheckEnterdValue
    {
        //Write a C# program that takes one value from the user and checks whether the entered value is a character, integer or special symbol.

        public static void Check()
        {
            Console.Write("Enter a value: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsLetter(input))
            {
                Console.WriteLine($"The entered value '{input}' is a character.");
            }
            else if (char.IsDigit(input))
            {
                Console.WriteLine($"The entered value '{input}' is an integer.");
            }
            else
            {
                Console.WriteLine($"The entered value '{input}' is a special symbol.");
            }

            Console.ReadLine();
        }

    }
}
