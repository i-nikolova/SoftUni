using System;

namespace _06.AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double length = double.Parse(Console.ReadLine());
                double area = length * length;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "rectangle")

            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double area = length * width;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "circle")

            {
                double radius = double.Parse(Console.ReadLine());
                double area = radius * radius * Math.PI;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "triangle")

            {
                double length = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());
                double area = (length * hight) / 2;
                Console.WriteLine($"{area:f3}");


            }
        }
    }
}
