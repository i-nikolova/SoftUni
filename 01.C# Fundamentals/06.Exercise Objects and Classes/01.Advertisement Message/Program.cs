using System;
using System.Collections.Generic;

namespace _01.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>
            { "Excellent product.", "Such a great product."
            , "I always use that product."
            , "Best product of its category."
            , "Exceptional product."
            , "I can’t live without this product." };

            List<string> events = new List<string>
            { "Now I feel good."
            , "I have succeeded with this product."
            , "Makes miracles. I am happy of the results!"
            , "I cannot believe but now I feel awesome."
            , "Try it yourself, I am very satisfied."
            , "I feel great!" };

            List<string> autors = new List<string>
            { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            List<string> cities = new List<string>
             {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            int messeages = int.Parse(Console.ReadLine());

            for (int i = 0; i < messeages; i++)
            {
                string randomPhrase = string.Empty;
                string randomEvent = string.Empty;
                string randomAutor = string.Empty;
                string randomCity = string.Empty;

                Random randomIndex = new Random();
                randomPhrase = phrases[randomIndex.Next(0, phrases.Count)];
                randomEvent = events[randomIndex.Next(0, events.Count)];
                randomAutor = autors[randomIndex.Next(0, autors.Count)];
                randomCity = cities[randomIndex.Next(0, cities.Count)];

                Console.WriteLine($"{randomPhrase} {randomEvent} {randomAutor} – {randomCity}");
            }

        }

    }
}
