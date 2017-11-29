using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGenerator
{
    class Quiz
    {
        public Dictionary<int, string> Questions { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

        public Quiz(Dictionary<int, string> questions, string name)
        {
            Questions = questions;
            Name = name;
        }
    }
}
