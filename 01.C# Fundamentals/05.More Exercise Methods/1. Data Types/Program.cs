using System;

namespace _1._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "string")
            {
                Console.WriteLine(DataType(Console.ReadLine()));

            }
            else if (type == "real")
            {
                Console.WriteLine($"{DataType(double.Parse(Console.ReadLine())):f2}");

            }
            else if (type == "int")
            {
                Console.WriteLine(DataType(int.Parse(Console.ReadLine())));

            }
        }

        static int DataType (int number)
        {
            return number * 2;
        }
        static double DataType(double number)
        {
            return number * 1.5;
        }
        static string DataType(string text)
        {
            return  $"${text}$";
        }
    }
}
