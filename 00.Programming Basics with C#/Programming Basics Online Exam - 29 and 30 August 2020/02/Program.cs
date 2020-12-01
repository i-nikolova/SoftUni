using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {

            int qtyTickets = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            int pricePerTicket = int.Parse(Console.ReadLine());

            int totalPrice = qtyTickets * pricePerTicket;
            if (totalPrice>budget)
            {
                Console.WriteLine($"The budget of {budget}$ is not enough. Your client can't buy {qtyTickets} tickets with this budget!" );
            }
            else
            {
                int moneyLeft = budget - totalPrice;
                Console.WriteLine($"You can sell your client {qtyTickets} tickets for the price of { totalPrice}$!");
                Console.WriteLine($"Your client should become a change of {moneyLeft}$!");
            }
        }
    }
}
