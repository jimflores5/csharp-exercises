using System;
using System.Collections.Generic; //Enables use of lists.
using System.Linq;

//Write a static method to print out each word in a list that has exactly 5 letters.

namespace MoreStringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: " +
                "once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, " +
                "'and what is the use of a book, ' thought Alice 'without pictures or conversation?'";

            List<string> words = new List<string>();

            string aliceMod = alice.Replace(",","");
            words = aliceMod.Split(" ").ToList();

            Console.WriteLine(alice);
            Console.WriteLine("\nThe following words from the phrase eacch have exactly 5 letters:");
            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadLine();

        }
    }
}
