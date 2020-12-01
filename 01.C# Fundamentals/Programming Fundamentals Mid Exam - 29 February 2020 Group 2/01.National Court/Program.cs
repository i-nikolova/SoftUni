using Microsoft.Win32.SafeHandles;
using System;

namespace _01.National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCountoOfPeoplePerHour = 0;
            for (int i = 0; i < 3; i++)
            {
                totalCountoOfPeoplePerHour += int.Parse(Console.ReadLine());
            }

            int totalPeople = int.Parse(Console.ReadLine());
            int hoursNeeded = 0;
            while (totalPeople>0)
            {
                hoursNeeded++;
                if (hoursNeeded%4==0)
                {
                    continue;
                }

                totalPeople -= totalCountoOfPeoplePerHour;
            }


            Console.WriteLine($"Time needed: {hoursNeeded}h.");

        }
    }
}
