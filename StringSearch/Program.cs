using System;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: " +
                "once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, " +
                "'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string searchFor;
            bool stringFound;

            Console.WriteLine(firstSentence);
            Console.WriteLine();
            Console.WriteLine("For what text would you like to search?  Please enter a letter, word or phrase:");
            searchFor = Console.ReadLine();

            string lowerSentence = firstSentence.ToLower();
            string search = searchFor.ToLower();
            stringFound = lowerSentence.Contains(search);
            if (stringFound) {
                Console.WriteLine($"'{searchFor}' is present in the first sentence of 'Alice in Wonderland'.");
            }
            else
            {
                Console.WriteLine($"'{searchFor}' is NOT present in the first sentence of 'Alice in Wonderland'.");
            }
            Console.ReadLine();

        }
    }
}
