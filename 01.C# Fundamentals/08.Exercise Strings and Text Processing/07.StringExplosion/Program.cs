using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            int explosion = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (explosion>0 && input[i]!='>')
                {
                    input = input.Remove(i, 1);
                    explosion--;
                    i--;
                }
                else if (input[i]=='>')
                {
                    explosion += int.Parse(input[i + 1].ToString());
                }
            }
            
            Console.WriteLine(input.ToString());
        }
    }
}
