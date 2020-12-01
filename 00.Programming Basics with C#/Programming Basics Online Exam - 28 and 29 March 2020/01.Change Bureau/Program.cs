using System;

namespace Exams
{
    class Program
    {
        static void Main(string[] args)
        {
            double currBitcoin = 1168;
            double currUSD = 1.76;
            double currUan = currUSD*0.15;
            double currEUR = 1.95;

            int numberOfBitcoins = int.Parse(Console.ReadLine());
            double numberOfUan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double sumBitcoins = numberOfBitcoins * currBitcoin;
            double sumUan = (numberOfUan * currUan);
            double sumEUR = ((sumBitcoins + sumUan))/ currEUR;
            double sumCommision = sumEUR * (commision/100);
            double money = sumEUR - sumCommision;

            Console.WriteLine($"{money:f2}");
            




        }
    }
}
