using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _05.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List < Student > students = new List<Student>();
            while ((input = Console.ReadLine())!= "end")
            {
                string[] studentInformation = input.Split();
                Student student = new Student();
                student.FirstName = studentInformation[0];
                student.LastName = studentInformation[1];
                student.Age = int.Parse(studentInformation[2]);
                student.Hometown = studentInformation[3];

                students.Add(student);
            }

            string city = Console.ReadLine();
            foreach (Student studen in students)
            {
                if (studen.Hometown==city)
                {
                    Console.WriteLine($"{studen.FirstName} { studen.LastName} is { studen.Age } years old.");
                }
            }
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
