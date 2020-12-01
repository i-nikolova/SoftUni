using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudent = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < numberOfStudent; i++)
            {
                string studenName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (students.ContainsKey(studenName))
                {
                    students[studenName].Add(grade);
                }
                else
                {
                    students.Add(studenName, new List<double>() { grade });
                }
            }
            students=students.Where(x => x.Value.Average() >= 4.5).OrderByDescending(x=>x.Value.Average()).ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in students)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value.Average():f2}");
            }
        }
    }
}
