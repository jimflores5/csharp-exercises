using System;
using System.Collections.Generic;   //Enables lists, arrays and dictionaries.
using System.Linq;
using System.Text;                  //Enables use of StringBuilder.

namespace LiveCodingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            var grades = new List<float>();
            var students = new Dictionary<string,double>();

            names.Add("Bob");
            names.Add("Nobody");

            students.Add("Bob", 73.5);
            students.Add("Mary", 96.3);
            students.Add("Rutabaga", 99.9);
            students.Add("Nobody", 83.4);
            
            if (names.Contains("Bob"))
            {
                //do something
            }
            else if (names.Count > 5)
            {
                //do something else
            }
            else
            {
                //do this if all else fails
            }

            foreach (KeyValuePair<string,double> student in students) // try 'foreach (var student in students)'
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }
            Console.ReadLine();

            foreach (var name in students.Keys)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
