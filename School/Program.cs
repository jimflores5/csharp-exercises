using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John");
            Student mary = new Student("Mary");
            john.Credits = 10;
            john.Gpa = 2.33;
            mary.Credits = 88;
            mary.Gpa = 3.95;
            Console.WriteLine(john);
            Console.WriteLine(mary);
            Console.ReadLine();

            john.AddGrade(3, 88.6);
            mary.AddGrade(4, 93.2);
            Console.WriteLine(john);
            Console.WriteLine(mary);
            Console.ReadLine();
        }

    }

    public class Student
    {
        public static Dictionary<string, int> students = new Dictionary<string, int>();
        private static int nextStudentId = 1;
        public string Name { get; private set; }
        public int StudentId { get; private set; }
        public int Credits { get; set; }
        public double Gpa { get; set; }
        
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

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            int scaledGrade;
            double totalQualityScore = Gpa * Credits;

            if (grade < 60)
            {
                scaledGrade = 0;
            }
            else if (grade < 70)
            {
                scaledGrade = 1;
            }
            else if (grade < 80)
            {
                scaledGrade = 2;
            }
            else if (grade < 90)
            {
                scaledGrade = 3;
            }
            else
            {
                scaledGrade = 4;
            }
            int newQualScore = courseCredits * scaledGrade;
            Credits += courseCredits;
            Gpa = Math.Round((totalQualityScore + newQualScore) / Credits,2);
        }

        public string GetGradeLevel()
        {
            if (Credits <= 29)
            {
                return "Freshman";
            }
            else if (Credits <= 59)
            {
                return "Sophomore";
            }
            else if (Credits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        public override String ToString()
        {
            string studentInfo = String.Format("Name: {0} \n ID: {1} \n Credits/Grade Level: {3}/{2} \n GPA: {4} \n",Name,StudentId,GetGradeLevel(),Credits,Gpa);
            return studentInfo;
        }

        public override bool Equals(Object o)
        {
            if (o == this)
            {
                return true;
            }

            if (o == null)
            {
                return false;
            }

            if (o.GetType() != GetType())
            {
                return false;
            }

            Student studentObj = o as Student;
            return StudentId == studentObj.StudentId;
        }

        public override int GetHashCode()
        {
            return StudentId;
        }

    }

    public class Course
    {
        private List<Student> Roster = null;
        public string CourseName { get; set; }
        public int CourseID { get; private set; }
        public int Credits { get; private set; }

        public Course(List<Student> roster)
        {
            this.Roster = roster;
        }

        public Course(string courseName, int credits, List<Student> roster)
        {
            CourseName = courseName;
            Credits = credits;
            Roster = roster;
        }

        public override String ToString()
        {
            string courseInfo = String.Format("Course Name: {0}, Credits: {1} \n", CourseName,Credits);
            return courseInfo;
        }

        public override bool Equals(Object o)
        {
            if (o == this)
            {
                return true;
            }

            if (o == null)
            {
                return false;
            }

            if (o.GetType() != GetType())
            {
                return false;
            }

            Course courseObj = o as Course;
            return CourseID == courseObj.CourseID;
        }

        public override int GetHashCode()
        {
            return CourseID;
        }

    }
}
