using System;
using System.Collections.Generic;
using System.Linq;

namespace SigFigCalcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Number> numbers = new List<Number>();
            List<string> operators = new List<string> { "+", "-", "*", "/" };

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 2; x++)
                {
                    int sigFigs = rnd.Next(1, 6);
                    int power = rnd.Next(-3, 4);
                    Number number = new Number(sigFigs, power);

                    numbers.Add(number);
                }
                int op = rnd.Next(0, 4);

                Console.WriteLine("{0} {1} {2} = _____?", numbers[y], operators[op], numbers[y+1]);

                Console.WriteLine("{0} sig figs {1} {2} sig figs = _____?", numbers[y].SigFigs, operators[op], numbers[y + 1].SigFigs);
            }

            Console.ReadLine();
        }
    }
}
