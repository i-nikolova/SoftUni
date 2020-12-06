using System;

namespace _01.Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBatches = int.Parse(Console.ReadLine());
            int totalBoxes = 0;
            for (int i = 0; i < numberOfBatches; i++)
            {
                int boxesPerBatch = 0;
                int flour = int.Parse(Console.ReadLine());
                int sugar = int.Parse(Console.ReadLine());
                int cocoa = int.Parse(Console.ReadLine());

                int flourCups = flour / 140;
                int sugarSpoons = sugar / 20;
                int cocoaSpoons = cocoa / 10;

                if (flourCups==0 || sugarSpoons==0 || cocoaSpoons==0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.") ;
                    continue;
                }
                else
                {
                    double totalCokiesPerBake = ((140 + 10 + 20) * Math.Min((Math.Min(flourCups, sugarSpoons)), cocoaSpoons))*1.0 / 25;
                    boxesPerBatch = (int) Math.Floor(totalCokiesPerBake) / 5;
                    Console.WriteLine($"Boxes of cookies: {boxesPerBatch}");
                    totalBoxes += boxesPerBatch;
                }
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
