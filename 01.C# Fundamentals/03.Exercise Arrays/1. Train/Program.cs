using System;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] trainPlaces = new int[int.Parse(Console.ReadLine())];
            int totalPlaces = 0;
            for (int i = 0; i < trainPlaces.Length; i++)
            {
                trainPlaces[i] = int.Parse(Console.ReadLine());
                totalPlaces += trainPlaces[i];
            }
            for (int j = 0; j < trainPlaces.Length; j++)
            {
                Console.Write($"{trainPlaces[j]} ");
            }
            Console.WriteLine();
            Console.WriteLine(totalPlaces);
            
        }
    }
}
