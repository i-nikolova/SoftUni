﻿using System;
using System.Text;

namespace _04.CeasarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                sb.Append((char)(((int)input[i]) + 3));
            }

            Console.WriteLine(sb.ToString());
            
        }
    }
}
