using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingSigFigs
{
    class Program
    {
        static string MakeNumber (int sigFigs, int power)
        {
            List<string> firstDigit = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            List<string> allDigits = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random rnd = new Random();

            if (power < 0)
            {
                string value = "0.";
                for (int placeholder = power + 1; placeholder < 0; placeholder++)
                {
                    value += "0";
                }

                value += firstDigit[rnd.Next(0, 9)];
                for (int digit = 0; digit < sigFigs - 1; digit++)
                {
                    value += allDigits[rnd.Next(0, 10)];
                }

                return value;
            }
            else if (sigFigs - power < 2)
            {
                string value = firstDigit[rnd.Next(0, 9)];
                for (int digit = 0; digit < sigFigs - 1; digit++)
                {
                    if (digit != sigFigs - 2)
                    {
                        value += allDigits[rnd.Next(0, 10)];
                    }
                    else
                    {
                        value += firstDigit[rnd.Next(0, 9)];
                    }
                }

                for (int placeholder = 0; placeholder < power - sigFigs + 1; placeholder++)
                {
                    value += "0";
                }

                return value;
            }
            else
            {
                string value = firstDigit[rnd.Next(0, 9)];
                int decimalLocation = power + 1;
                for (int digit = 1; digit < sigFigs + 1; digit++)
                {
                    if (digit == decimalLocation)
                    {
                        value += ".";
                    }
                    else
                    {
                        value += allDigits[rnd.Next(0, 10)];
                    }
                }

                return value;
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            string value;

            for (int x = 0; x < 4; x++)
            {
                int sigFigs = rnd.Next(1, 7);
                int power = rnd.Next(-5, 9);
                value = MakeNumber(sigFigs, power);

                Console.WriteLine("ID the number of sig figs in: {0}", value);
                int answer = int.Parse(Console.ReadLine());
                if (answer == sigFigs)
                {
                    Console.WriteLine("CORRECT!  :-)");
                }
                else
                {
                    Console.WriteLine("Sorry, the value {0} has {1} sig figs.", value, sigFigs);
                }
            }

            Console.ReadLine();
        }
    }
}
