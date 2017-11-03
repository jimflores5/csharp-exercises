using System;
using System.Collections.Generic; //Enables use of lists.
using System.Linq;

// Write a static method to find the sum of all the even numbers in a list. 
//Within Main, create a list with at least 10 integers and call your method on the list.

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            int sum = 0;

            for (int x = 1; x <= 50; x+=3)
            {
                integers.Add(x);
            }
          

            foreach (int value in integers)
            {
                if (value % 2 == 0)
                {
                    sum += value;
                }
            }

            
            Console.WriteLine("The list of numbers is:");
            integers.ForEach(item => Console.Write(item + ", "));
            Console.WriteLine("\nThe sum of the even numbers in the list = " + sum.ToString() +".");
            Console.ReadLine();
            
        }
    }
}
