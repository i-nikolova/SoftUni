﻿using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double centuries = double.Parse(Console.ReadLine());
            double years = centuries * 100;
            double days = Math.Floor((centuries * 100) * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries =" +
                $" {years} years = {days:f0} days = {hours:f0} hours = {minutes:f0} minutes");
        }
    }
}
