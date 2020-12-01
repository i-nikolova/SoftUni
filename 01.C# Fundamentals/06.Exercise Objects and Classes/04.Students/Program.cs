using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            ListOfStudent studentList = new ListOfStudent();
            studentList.AllStudents = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] data = Console.ReadLine().Split();
                Student student = new Student(data[0], data[1], double.Parse(data[2]));
                studentList.AllStudents.Add(student);

            }

            ListOfStudent orderedList = new ListOfStudent();
            orderedList.AllStudents = studentList.AllStudents.OrderByDescending(student=>student.Grade).ToList();
            foreach (Student student in orderedList.AllStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }

        public class Student
        {
            public Student()
            {

            }
            public Student(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
        }
        public class ListOfStudent
        {
            public ListOfStudent()
            {
                Student student = new Student();
            }
            public List<Student> AllStudents { get; set; }
        }
    }
}
