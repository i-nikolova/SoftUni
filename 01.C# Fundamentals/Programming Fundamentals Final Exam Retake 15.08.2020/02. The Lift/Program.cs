using System;
using System.Linq;

namespace Problem_2._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeole = int.Parse(Console.ReadLine());
            int[] liftState = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            for (int i = 0; i < liftState.Length; i++)
            {
                while (numberOfPeole !=0 && liftState[i]<4)
                {
                    liftState[i]++;
                    numberOfPeole--;
                }                
            }

            if (numberOfPeole > 0)
            {
                Console.WriteLine($"There isn't enough space! {numberOfPeole} people in a queue!\n" +
                    $"{string.Join(' ', liftState)}");
            }
            else if (numberOfPeole==0 && liftState[liftState.Length-1]!=4)
            {
                Console.WriteLine($"The lift has empty spots!\n" +
                    $"{string.Join(' ', liftState)}");
            }
            else
            {
                Console.WriteLine($"{string.Join(' ', liftState)}");
            }

        }
    }
}
