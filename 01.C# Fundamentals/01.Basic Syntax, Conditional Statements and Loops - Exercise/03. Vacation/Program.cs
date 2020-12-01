using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPeople = int.Parse(Console.ReadLine());
            string typeVacation = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerPerson = 0;
            double totalPrice = 0;
            switch (typeVacation)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 8.45;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 10.90;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60;
                            break;
                        case "Sunday":
                            pricePerPerson = 16;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 15;
                            break;
                        case "Saturday":
                            pricePerPerson = 20;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            totalPrice = totalPeople * pricePerPerson;

            if (totalPeople >= 30 && typeVacation== "Students")
            {
                totalPrice *= 0.85;
            }
            else if (totalPeople>=100 && typeVacation == "Business")
            {
                totalPrice -= 10 * pricePerPerson;
            }
            else if (totalPeople >=10 && totalPeople<=20 && typeVacation == "Regular")
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: { totalPrice:f2}");
        }
    }
}
