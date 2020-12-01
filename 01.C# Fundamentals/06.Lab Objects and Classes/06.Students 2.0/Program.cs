using System;
using System.Collections.Generic;


namespace _06.Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentInformation = input.Split();

                if (IsExisting(students, studentInformation[0], studentInformation[1]))
                {
                    Student student = GetStudent(students, studentInformation[0], studentInformation[1]);
                    student.FirstName = studentInformation[0];
                    student.LastName = studentInformation[1];
                    student.Age = int.Parse(studentInformation[2]);
                    student.Hometown = studentInformation[3];
                }
                else
                {
                    Student student = new Student();
                    student.FirstName = studentInformation[0];
                    student.LastName = studentInformation[1];
                    student.Age = int.Parse(studentInformation[2]);
                    student.Hometown = studentInformation[3];

                    students.Add(student);
                }

            }

            string city = Console.ReadLine();
            foreach (Student studen in students)
            {
                if (studen.Hometown == city)
                {
                    Console.WriteLine($"{studen.FirstName} { studen.LastName} is { studen.Age } years old.");
                }
            }
        }

        public static bool IsExisting(List<Student> students, string fistName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == fistName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;

        }

        public static Student GetStudent(List<Student> students, string fistName, string lastName)
        {
            Student existingStudet = null;

            foreach (Student student in students)
            {
                if (student.FirstName == fistName && student.LastName == lastName)
                {
                    existingStudet = student;
                }
            }

            return existingStudet;
        }
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }
        }
    }
}
