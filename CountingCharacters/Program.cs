using System;
using System.Collections.Generic;   //Enables lists, arrays and dictionaries.
using System.Linq;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. " +
                "Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis " +
                "massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            string text2 = "BOokkeEper..!";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            var charCounts = new Dictionary<char, int>();

            string tempString = text.ToLower();

            Console.WriteLine(text);
            Console.WriteLine("\nEnter the letter to count in the text listed above:");
            string search = Console.ReadLine().ToLower();

            int frequency = 0;
            foreach (char letter in tempString)
            {
                if (letter.ToString() == search)
                {
                    frequency++;
                }
            }
            Console.WriteLine("The letter '" + search + "' occurs {0} times in the text.", frequency.ToString());
            Console.ReadLine();


            /* foreach (char letter in tempString)
             {
                 if (alphabet.Contains(letter))    
                 {
                     if (!charCounts.ContainsKey(letter))    // ALSO, try if (char.IsLetter(letter))
                     {
                         charCounts.Add(letter, 1);
                     }
                     else
                     {
                         charCounts[letter]++;
                     }
                 }
             }

             foreach (KeyValuePair<char,int> result in charCounts)
             {
                 Console.WriteLine(result.Key + " = " + result.Value);
             }
             Console.ReadLine();
             */

            /* Python code from unit 1:
             * def char_count(text):
                    char_counts = {}   <--- char_counts is a dictionary, as opposed to a list/array.
                    for letter in text:
                        if letter not in char_counts:
                            frequency = text.count(letter)
                            char_counts[letter] = frequency
    
                    return char_counts

                counts = char_count(text)

                for x in counts:
                    print(x+":",counts[x])
              */

        }
    }
}
