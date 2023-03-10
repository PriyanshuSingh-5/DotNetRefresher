using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRefresherProblems
{
    class ReverseASentence
    {
        //Write a C# program to reverse the words of a sentence. 
        public static void RevereseWordsOfSentence()
        {
            // Ask user to enter a sentence
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            // Split sentence into words using space as delimiter
            string[] words = sentence.Split(' ');

            // Reverse the words in the array
            Array.Reverse(words);

            // Join the reversed words into a sentence
            string reversedSentence = string.Join(" ", words);

            // Print the reversed sentence
            Console.WriteLine("Reversed sentence: {0}", reversedSentence);
        }
    }
}
