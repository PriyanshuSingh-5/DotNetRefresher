using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    class CelsiusConversion
    {
        //Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. 
        public static void ConversionFromCelsiusToFaren()
        {
            // Ask user to enter temperature in Celsius
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            // Convert Celsius to Kelvin and print result
            double kelvin = celsius + 273.15;
            Console.WriteLine("{0} degrees Celsius is {1} degrees Kelvin.", celsius, kelvin);

            // Convert Celsius to Fahrenheit and print result
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("{0} degrees Celsius is {1} degrees Fahrenheit.", celsius, fahrenheit);
        }
    }
}
