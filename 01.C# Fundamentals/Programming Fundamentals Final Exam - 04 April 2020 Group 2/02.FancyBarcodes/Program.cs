using System;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBarcodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBarcodes; i++)
            {
                string barcode = Console.ReadLine();

                Regex validBarcode = new Regex(@"(@[#]+)([A-Z][A-Za-z0-9]{4,}[A-Z])(@[#]+)");

                if (validBarcode.IsMatch(barcode))
                {
                    string productGroupValue = string.Empty;
                    Regex productGroup = new Regex(@"\d+");
                    if (productGroup.IsMatch(barcode))
                    {

                        foreach (Match item in productGroup.Matches(barcode))
                        {
                            productGroupValue += item.Value.ToString();
                        }
                    }
                    else
                    {
                        productGroupValue = "00";
                    }

                    Console.WriteLine($"Product group: {productGroupValue}");

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
