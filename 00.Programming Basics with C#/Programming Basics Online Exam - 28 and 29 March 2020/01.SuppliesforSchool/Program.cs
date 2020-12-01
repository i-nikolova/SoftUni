using System;

namespace _01.SuppliesforSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePen = 5.80;
            double priceMarker = 7.20;
            double pricePreparat = 1.20;

            int numberOfPens = int.Parse(Console.ReadLine());
            int numberOfMarkers = int.Parse(Console.ReadLine());
            double litlersOfPreparat = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double sumPens = numberOfPens * pricePen;
            double sumMarkers = numberOfMarkers * priceMarker;
            double sumPreparat = litlersOfPreparat * pricePreparat;
            double SumMaterials = sumMarkers + sumPens + sumPreparat;
            double SumAfterDiscount =SumMaterials - SumMaterials * discount / 100;

            Console.WriteLine($"{SumAfterDiscount:f3}");


        }
    }
}
