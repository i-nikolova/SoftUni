using System;

namespace _3._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int personsPerCourse = int.Parse(Console.ReadLine());
            int countCourses=0;

            for (int i = personsPerCourse; i <= persons; i+=personsPerCourse)
            {
                
                countCourses++;
            }
            if (persons % personsPerCourse !=0)
            {
                countCourses++;
            }
            Console.WriteLine(countCourses);
        }
    }
}
