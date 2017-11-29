using System;

namespace QuizGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstQuery = new MultChoice();

            Console.WriteLine(firstQuery.Text);
            foreach (var answer in firstQuery.Answers)
            {
                Console.WriteLine(answer.Key, answer.Value);
            }
            Console.ReadLine();
            
        }
    }
}
