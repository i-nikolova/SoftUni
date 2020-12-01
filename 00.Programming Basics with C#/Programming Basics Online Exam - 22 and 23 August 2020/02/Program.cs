using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int blood = int.Parse(Console.ReadLine());

            int totalPower = people * power;

            if (totalPower>blood)
            {
                int pointLeft = totalPower - blood;
                Console.WriteLine($"Illidan has been slain! You defeated him with {pointLeft} points.");
            }
            else
            {
                int pointNeeded = blood - totalPower;
                Console.WriteLine($"You are not prepared! You need {pointNeeded} more points.");
            }
        }
    }
}
