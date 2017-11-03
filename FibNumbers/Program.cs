using System;
using System.Collections.Generic; //Enables use of lists.
using System.Linq;

//Create and initialize in a single line an array with the following values: 
//1, 1, 2, 3, 5, 8. Then loop through the array and print out each value.

// Then have some fun by asking the user to determine the length of the LIST.

namespace FibNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 1;
            int third;
            int length;
            List<int> fibSeq = new List<int>();

            /* This fulfills the first part of the task.
             * 
            int[] fibSeq = {1, 1, 2, 3, 5, 8 };

            for (int x=0; x < fibSeq.Length; x++)
            {
                Console.WriteLine(fibSeq[x]);
            }

            Console.ReadLine();
            */

            // This fulfills the second part of the task.
            do
            {
                Console.WriteLine("From 1 - 10 values, how far should the Fibonacci sequence go?");
                length = int.Parse(Console.ReadLine());
                if (length < 1 | length > 10)
                {
                    Console.WriteLine("Please select a sequence length from 1 to 10 values.\n");
                }

            } while (length < 1 | length > 10);

            for (int x = 0; x <= length; x++)
            {
                if (x == 0 | x == 1)
                {
                    fibSeq.Add(x);
                }
                else
                {
                    third = first + second;
                    first = second;
                    second = third;
                    fibSeq.Add(third);
                }
            }

            Console.WriteLine("The first {0} Fibonacci numbers are:",length);
            for (int x = 0; x < fibSeq.Count; x++)
            {
                Console.WriteLine(fibSeq[x]);
            }
            Console.ReadLine();
        }
    }
}
