using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;                  //Enables use of StringBuilder.

//1) Make a program similar to GradebookDict, but which takes in students names and ID numbers (as integers) instead of names and grades. 
//In this case, however, the keys should be integers (the IDs) and the values should be strings (the names). 
//Modify the roster printing code accordingly.

//2) In one of the Gradebook programs (it doesn't matter which), modify the code that prints out the class roster near the end of the 
//program to use the StringBuilder class.

namespace SimpleGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;
            string id;
            StringBuilder roster = new StringBuilder();

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.WriteLine("ID number: ");
                id = Console.ReadLine();
                if (id != "")
                {
                    // Get the student's name
                    Console.Write("Student name: ");
                    newStudent = Console.ReadLine();

                    students.Add(int.Parse(id), newStudent);
                }
            }
            while (id != "");

            // Print roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Value + " (" + student.Key + ")");
            }
            Console.ReadLine();

            //Print roster using StringBuilder
            foreach (KeyValuePair<int, string> student in students) 
            {
                roster.Append(student+"\n");
            }
            Console.WriteLine(roster);
            Console.ReadLine();
        }
    }
}
