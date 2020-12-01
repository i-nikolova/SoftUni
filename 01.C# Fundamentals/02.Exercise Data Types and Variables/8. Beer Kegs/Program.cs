using System;

namespace _8._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfKegs = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double volume = 0;
            double maxVolume = double.MinValue;
            for (int i = 0; i < numbersOfKegs; i++)
            {
                string modelOgKef = Console.ReadLine();
                double raduius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                volume = Math.PI * raduius * raduius * height;
                if (volume>maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = modelOgKef;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
