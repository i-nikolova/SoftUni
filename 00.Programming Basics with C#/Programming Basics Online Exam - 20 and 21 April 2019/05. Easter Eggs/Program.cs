using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalEggs = int.Parse(Console.ReadLine());
            int countRed = 0;
            int countOrange = 0;
            int countBlue = 0;
            int countGreen = 0;

            int maxEggs = int.MinValue;
            string maxColor = "";


            for (int i = 0; i < totalEggs; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        countRed++;
                        if (countRed>maxEggs)
                        {
                            maxEggs = countRed;
                            maxColor = color;
                        }
                        break;
                    case "orange":
                        countOrange++;
                        if (countOrange > maxEggs)
                        {
                            maxEggs = countOrange;
                            maxColor = color;
                        }
                        break;
                    case "blue":
                        countBlue++;
                        if (countBlue > maxEggs)
                        {
                            maxEggs = countBlue;
                            maxColor = color;
                        }
                        break;
                    case "green":
                        countGreen++;
                        if (countGreen > maxEggs)
                        {
                            maxEggs = countGreen;
                            maxColor = color;
                        }
                        break;
                    default:
                        break;
                }
                
            }
            Console.WriteLine($"Red eggs: {countRed}");
            Console.WriteLine($"Orange eggs: {countOrange}");
            Console.WriteLine($"Blue eggs: {countBlue}");
            Console.WriteLine($"Green eggs: {countGreen}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {maxColor}");


        }
    }
}
