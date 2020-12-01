using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            int allPeople = 0;
            int peopleMusala = 0;
            int peopleMonblan = 0;
            int peopleKili = 0;
            int peopleK2 = 0;
            int peopleEverest = 0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());
                allPeople += numberOfPeople;
                if (numberOfPeople <= 5)
                {
                    peopleMusala += numberOfPeople;
                }
                else if (numberOfPeople > 5 && numberOfPeople <= 12)
                {
                    peopleMonblan += numberOfPeople;
                }
                else if (numberOfPeople > 12 && numberOfPeople <= 25)
                {
                    peopleKili += numberOfPeople;
                }
                else if (numberOfPeople > 25 && numberOfPeople <= 40)
                {
                    peopleK2 += numberOfPeople;
                }
                else
                {
                    peopleEverest += numberOfPeople;
                }
            }
            double avgPeopleMusala = peopleMusala * 1.0 / allPeople * 100;
            double avgPeopleMonblan = peopleMonblan * 1.0 / allPeople * 100;
            double avgPeopleKili = peopleKili * 1.0 / allPeople * 100;
            double avgPeopleK2 = peopleK2 * 1.0 / allPeople * 100;
            double avgPeopleEverest = peopleEverest * 1.0 / allPeople * 100;

            Console.WriteLine($"{avgPeopleMusala:f2}%");
            Console.WriteLine($"{avgPeopleMonblan:f2}%");
            Console.WriteLine($"{avgPeopleKili:f2}%");
            Console.WriteLine($"{avgPeopleK2:f2}%");
            Console.WriteLine($"{avgPeopleEverest:f2}%");


        }
    }
}

