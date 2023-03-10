using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    class HeightCategory
    {
        //Program to take height as input and print .its category as Dwarf, Average, and Tall.sample data: Dwarf= below 150, Tall= above 160, avg= between 155 and 160

        public static void CheckHeightCategory()
        {
            int height = 0;

            Console.WriteLine("Enter your Height (in centimeters): ");
            height = int.Parse(Console.ReadLine());

            if (height < 160)
                Console.WriteLine("You are Dwarf person");
            else if ((height >= 160) && (height <= 170))
                Console.WriteLine("You are average height person");
            else if (height >= 170)
                Console.WriteLine("You are tall person");
            else
                Console.WriteLine("Entered height is abnormal");
        }

    }
}

