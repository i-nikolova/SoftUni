using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();

            string resourse = string.Empty;
            while ((resourse = Console.ReadLine()) != "stop")
            {
                int resourseValue = int.Parse(Console.ReadLine());
                if (resourses.ContainsKey(resourse))
                {
                    resourses[resourse] += resourseValue;
                }
                else
                {
                    resourses.Add(resourse, resourseValue);
                }
            }

            foreach (var pair in resourses)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
