using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    class FindOperators
    {//Write a program using a switch statement that takes one character value from the user and checks whether the entered value is an arithmetic operator, logical operator, conditional operator, relational operator or something else.

        public static void CheckOperator()
        {
            Console.Write("Enter an operator: ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (op)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '%':
                    Console.WriteLine("Arithmetic operator");
                    break;
                case '>':
                case '<':
               
                    Console.WriteLine("Relational operator");
                    break;
                case '&':
                case '|':
                case '!':
                    Console.WriteLine("Logical operator");
                    break;
                case '?':
                case ':':
                    Console.WriteLine("Conditional operator");
                    break;
                default:
                    Console.WriteLine("Something else");
                    break;
            }
        }
    }
}
