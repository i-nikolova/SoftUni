using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            string line = string.Empty;
            while ((line = Console.ReadLine())!="buy")
            {
                List<string> input = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string name = input[0];
                double price = double.Parse(input[1]);
                double qty = double.Parse(input[2]);
                Product product = new Product(name, price, qty);
                if (products.ContainsKey(name))
                {
                    products[name].Qty += qty;
                    products[name].Price = price;

                }
                else
                {
                    products.Add(name, product);
                }
                
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Price*product.Value.Qty:f2}");
            }

            
           
        }

        public class Product
        {
            public string ProductName { get; set; }
            public double Price { get; set; }
            public double Qty { get; set; }

            public Product(string name, double price, double qty)
            {
                this.ProductName = name;
                this.Price = price;
                this.Qty = qty;
            }
        }
    }
}
