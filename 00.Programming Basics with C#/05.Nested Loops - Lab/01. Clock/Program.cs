﻿using System;

namespace _01._Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int h = 0; h <= 23; h++)
            {
                for (int n = 0; n <= 59; n++)
                {
                    Console.WriteLine($"{h}:{n}");
                }
            }
        }
    }
}
