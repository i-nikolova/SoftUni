using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace _05.Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string inputPeople = Console.ReadLine();
            if (inputPeople.Contains(";"))
            {
                string[] peopleData = inputPeople.Split(";", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < peopleData.Length; i++)
                {
                    string[] data = peopleData[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                    Person person = new Person(data[0], double.Parse(data[1]));
                    people.Add(person);
                }
            }
            else
            {
                string[] data = inputPeople.Split("=", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(data[0], double.Parse(data[1]));
                people.Add(person);
            }

            string inputProducts = Console.ReadLine();
            if (inputProducts.Contains(";"))
            {
                string[] productData = inputProducts.Split(";", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < productData.Length; i++)
                {
                    string[] data = productData[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                    Product product = new Product(data[0], double.Parse(data[1]));
                    products.Add(product);
                }
            }
            else
            {
                string[] data = inputProducts.Split("=", StringSplitOptions.RemoveEmptyEntries);
                Product product = new Product(data[0], double.Parse(data[1]));
                products.Add(product);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine())!="END")
            {
                string[] productBuyed = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                people[people.FindIndex(x => x.Name == productBuyed[0])].
                    BuyingProducts(products[products.FindIndex(p => p.ProductName == productBuyed[1])]);
            }

            foreach (var person in people)
            {
                if (person.Products.Count>0)
                {
                    Console.WriteLine(person.ToString()); 
                }
                else
                {
                    Console.Write($"{person.Name} - Nothing bought");
                }

            }
        }

        public class Person
        {
            public string Name { get; set; }
            public double Money { get; set; }
            public List<Product> Products { get; set; } = new List<Product>();

            public Person(string name,double money)
            {
                this.Name = name;
                this.Money = money;
            }

            public void BuyingProducts(Product product)
            {
                if (product.Price>Money)
                {
                    Console.WriteLine($"{Name} can't afford {product.ProductName}");
                }
                else
                {
                    Money -= product.Price;
                    Products.Add(product);
                    Console.WriteLine($"{Name} bought {product.ProductName.ToString()}");
                }
            }

            public override string ToString()
            {
                return $"{Name} - {string.Join(", ", Products)}";
            }

        }
        public class Product
        {
            public string ProductName { get; set; }
            public double Price { get; set; }

            public Product(string name,double price )
            {
                this.ProductName = name;
                this.Price = price;
            }

            public override string ToString()
            {
                return $"{ProductName}";
            }
        }
    }
}
