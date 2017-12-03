using System;
using System.Collections.Generic;
using System.Text;

namespace SigFigCalcs
{
    class Number
    {
        public int SigFigs { get; set; }
        public string Value { get; set; }

        public Number (int sigFigs, string value)
        {
            SigFigs = sigFigs;
            Value = value;
        }

        public Number(int sigFigs, int power)
        {
            SigFigs = sigFigs;
            Value = MakeNumber(sigFigs, power);
        }

        public override string ToString()
        {
            return this.Value;
        }

        static public string MakeNumber(int sigFigs, int power)
        {
            List<string> firstDigit = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            List<string> allDigits = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random rnd = new Random();

            if (power < 0) //Generates a value <1 with preceeding placeholer zeros (e.g. 0.00305).
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
            else if (sigFigs - power < 2) //Generates a value >1 with trailing placeholer zeros (e.g. 305000).
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
            else //Generates a value >1 with sig figs on both sides of the decimal (e.g. 10.070).
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
    }
}
