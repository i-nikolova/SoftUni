using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> nonNumbers = new List<string>();
            List<int> numbers = new List<int>();
            List<int> take = new List<int>();
            List<int> skip = new List<int>();
            int indexForSkipping = 0;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    numbers.Add(int.Parse(text[i].ToString()));
                }
                else
                {
                    nonNumbers.Add(text[i].ToString());
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i%2==0)
                {
                    take.Add(numbers[i]);
                }
                else
                {
                    skip.Add(numbers[i]);
                }
            }

            for (int i = 0; i < take.Count; i++)
            {
                List<string> temp = new List<string>(nonNumbers);
                temp = temp.Skip(indexForSkipping).Take(take[i]).ToList();
                result.Append(string.Join("", temp));
                indexForSkipping += take[i] + skip[i];
            }

            Console.WriteLine(result.ToString());
        }
    }
}
