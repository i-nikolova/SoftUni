using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _07.Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Box> boxes = new List<Box>();

            while ((input =Console.ReadLine()) != "end" )
            {
                string[] data = input.Split();
                Box box = new Box();
                box.SerialNumber = data[0];
                box.Item.Name = data[1];
                box.Item.Price = decimal.Parse(data[3]);
                box.Quantity = int.Parse(data[2]);
                box.PriceBox = CalculateBoxPrice(box.Item.Price, box.Quantity);
                boxes.Add(box);
            }
            List<Box> orderedBoxes =  boxes.OrderByDescending(box => box.PriceBox).ToList();
            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
            }
        }

        private static decimal CalculateBoxPrice(decimal price, int quantity)
        {
            return price* quantity;
        }

        public class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
        public class Box
        {
            public Box()
            {
                Item = new Item();
            }
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int Quantity { get; set; }
            public decimal PriceBox { get; set; }
        }
    }
}
