using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DotNetRefresherProblems
{
    class Fileproblem
    {
        //Write a c# program to find whether the given file path exist , if not create the path.
        public static void CheckFilepath()
        {
            // Ask user to enter a file path
            Console.Write("Enter a file path: ");
            string filePath = Console.ReadLine();

            // Check if the file path exists
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                // Create the directory if it doesn't exist
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                Console.WriteLine("Created directory: {0}", Path.GetDirectoryName(filePath));
            }
            else
            {
                Console.WriteLine("Directory already exists: {0}", Path.GetDirectoryName(filePath));
            }
        }

        ///Write a c# program to find whether the given file path exist , if exist read data from the text file.
        ///
        public static void ReadFromFile()
        {
            // Ask user to enter a file path
            Console.Write("Enter a file path: ");
            string filePath = Console.ReadLine();

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the data from the file
                string data = File.ReadAllText(filePath);
                Console.WriteLine("Data in the file: {0}", data);
            }
            else
            {
                Console.WriteLine("File does not exist: {0}", filePath);
            }
        }
    }
}
