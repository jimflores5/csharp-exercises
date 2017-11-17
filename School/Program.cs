using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        

        static void Main(string[] args)
        {


        }

    }

    public class Student
    {
        public static Dictionary<string, int> students = new Dictionary<string, int>();
        public string Name { get; private set; }
        public int StudentId { get; private set; }
        public int Credits { get; private set; }
        public double Gpa { get; private set; }
        

        public Student(string name, int studentId, int credits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            Credits = credits;
            Gpa = gpa;

            students.Add(name, studentId);
        }

        public Student(string name, int studentId)  //This sets the default credits & gpa to 0 then calls the 1st constructor.
            : this(name, studentId, 0, 0) { }

    }

    public class Course
    {
        private List<Student> Roster = null;
        public string CourseName { get; set; }
        public int CourseID { get; private set; }
        public int Credits = 3;

        public Course(List<Student> roster)
        {
            this.Roster = roster;
        }

        public Course(string courseName, int courseID, List<Student> roster)
        {
            CourseName = courseName;
            CourseID = courseID;
            Roster = roster;
        }

    }
}
