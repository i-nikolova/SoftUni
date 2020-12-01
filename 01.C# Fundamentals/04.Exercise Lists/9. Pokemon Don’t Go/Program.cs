using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int sumOfREmovedValues = 0;
            while (pokemons.Count!=0)
            {
                int index = int.Parse(Console.ReadLine());
                int removePokemonValue = 0;
                if (index<0)
                {
                    sumOfREmovedValues += pokemons[0];
                    removePokemonValue = pokemons[0];
                    pokemons[0]=pokemons[pokemons.Count-1];
                    IncreaseDecrease(pokemons, removePokemonValue);
                    
                }
                else if (index>pokemons.Count-1)
                {
                    sumOfREmovedValues += pokemons[pokemons.Count - 1];
                    removePokemonValue = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    IncreaseDecrease(pokemons, removePokemonValue);
                }
                else
                {
                    removePokemonValue=pokemons[index];
                    sumOfREmovedValues += pokemons[index];
                    pokemons.RemoveAt(index);
                    IncreaseDecrease(pokemons, removePokemonValue);
                }
            }
            Console.WriteLine(sumOfREmovedValues);



        }

        private static void IncreaseDecrease(List<int> pokemons, int removePokemonValue)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i]<=removePokemonValue)
                {
                    pokemons[i] += removePokemonValue;
                }
                else
                {
                    pokemons[i] -= removePokemonValue;
                }
            }
        }
    }
}
