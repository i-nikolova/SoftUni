using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="End")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(data[0], data[1], int.Parse(data[2]));
                persons.Add(person);
                persons = persons.OrderBy(x => x.Age).ToList();
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString()); 
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public Person(string name, string id, int age)
            {
                this.Name = name;
                this.ID = id;
                this.Age = age;
            }

            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        }
    }
}
