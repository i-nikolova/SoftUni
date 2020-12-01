using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int depositDue = int.Parse(Console.ReadLine());
            double yearInterest = double.Parse(Console.ReadLine());

            double interestAmount = (deposit * yearInterest)/100;
            double monthlyInterest = interestAmount / 12;
            double finalDeposit = deposit + (depositDue * monthlyInterest);

            Console.WriteLine($"{finalDeposit:f2}");
        }
    }
}
