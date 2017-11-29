using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGenerator
{
    class MultChoice: Question
    {
        public Dictionary<string, string> Answers { get; set; }
        public int NumberOfChoices { get; set; }
        public string CorrectAnswer { get; set; }

        public MultChoice (string text, int points, Dictionary<string, string> answers, int choices, string correct):base(text,points)
        {
            Answers = answers;
            NumberOfChoices = choices;
            CorrectAnswer = correct;
        }

        public MultChoice():base()
        {

            Console.WriteLine("How many options?");
            int options = int.Parse(Console.ReadLine());
            List<string> letters = new List<string> { "A", "B", "C", "D", "E", "F" };
            Dictionary<string, string> answers = new Dictionary<string, string>();

            for (int x = 0; x < options; x++)
            {
                Console.WriteLine("Option {0}:", letters[x]);
                string option = Console.ReadLine();
                answers.Add(letters[x], option);
            }
            Console.WriteLine("Which option is correct?");
            string correct = Console.ReadLine();

            Answers = answers;
            CorrectAnswer = correct;
        }

    }
}
