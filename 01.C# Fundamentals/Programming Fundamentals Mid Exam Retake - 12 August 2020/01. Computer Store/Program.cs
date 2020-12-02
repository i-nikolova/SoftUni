using System;

namespace Problem_1._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;
            double taxes = 0;
            double totalSumTaxes = 0;
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "special" || input == "regular")
                {
                    break;
                }
                double partPrice = double.Parse(input);
                if (partPrice<=0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalSum += partPrice;
                    taxes += partPrice * 0.20;
                }
               

                input = Console.ReadLine();
                
            }
            totalSumTaxes = totalSum + taxes;
            if (input=="special")
            {
                totalSumTaxes *= 0.90;
            }
            if (totalSumTaxes==0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!\n" +
                                $"Price without taxes: {totalSum:f2}$\n" +
                                $"Taxes: { taxes:f2}$\n" +
                                $"-----------\n" +
                                $"Total price: {totalSumTaxes:f2}$");
            }
            
        }
    }
}
