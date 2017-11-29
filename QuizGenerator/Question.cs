using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGenerator
{
    class Question
    {
        public string Text { get; private set; }
        public int Points { get; private set; }
        
        public Question (string text, int points)
        {
            Text = text;
            Points = points;
        }

        public Question()
        {
            Console.WriteLine("Please enter the question to be asked:");
            Text = Console.ReadLine();
            Console.WriteLine("How many points is this question worth?");
            Points = int.Parse(Console.ReadLine());
        }
    }
}
