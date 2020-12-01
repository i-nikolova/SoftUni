using System;
using System.Collections.Generic;

namespace _04.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Songs> songs = new List<Songs>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");
                Songs song = new Songs();
                song.TypeList = data[0];
                song.Name = data[1];
                song.Time = data[2];

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Songs song in songs)
                {
                    if (song.TypeList==typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }

        public class Songs
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
