using System;
using System.Linq;
using System.Text;

namespace _03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = string.Empty;
            while ((input = Console.ReadLine())!="find")
            {
                int keyValue = 0;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < input.Length; i++)
                {
                    sb.Append((char)((int)(input[i])-key[keyValue]));
                    keyValue++;
                    if (keyValue==key.Length)
                    {
                        keyValue = 0;
                    }      
                }

                int lastIndexType = 0;
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i].ToString()=="&")
                    {
                        lastIndexType = i;
                    }
                }

                string typeOfItem = sb.ToString().Substring(sb.ToString().IndexOf('&') + 1, lastIndexType - sb.ToString().IndexOf('&') - 1);
                string coordinates = sb.ToString().Substring(sb.ToString().IndexOf('<') + 1, sb.ToString().IndexOf('>') - sb.ToString().IndexOf('<') - 1); ;

                Console.WriteLine($"Found {typeOfItem} at {coordinates}");
            }
        }
    }
}
