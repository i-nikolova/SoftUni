using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfpersons = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < numberOfpersons; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                family.AddMember(new Person(data[0], int.Parse(data[1])));
            }

            Console.WriteLine(family.GetOldestMember().ToString()); 
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public override string ToString()
            {
                return $"{Name} {Age}";
            }
        }

        public class Family
        {
            public List<Person> Person { get; set; } = new List<Person>();

            public void AddMember (Person person)
            {
                Person.Add(person);
            }
            public Person GetOldestMember()
            {

                return Person.OrderByDescending(x => x.Age).First();
            }
        }

    }
}
