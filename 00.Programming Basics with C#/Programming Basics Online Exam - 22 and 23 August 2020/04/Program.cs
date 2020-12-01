using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double totalSimple = budget;
            double totalComplex = budget;
            double totalBudget = budget;

            for (int i = 0; i < months; i++)
            {
                double budgetPerMonthSimple = budget * 0.03;
                totalSimple += budgetPerMonthSimple; 
            }
            for (int j = 0; j < months; j++)
            {
                double budgetPerMonthComplex = totalComplex * 0.027; ;
                totalBudget = budgetPerMonthComplex;
                totalComplex += totalBudget;
            }

            Console.WriteLine($"Simple interest rate: {Math.Round(totalSimple,2):f2} lv.");
            Console.WriteLine($"Complex interest rate: {Math.Round(totalComplex,2):f2} lv." );

            if (totalSimple>totalComplex)
            {
                double moneyWin = totalSimple - totalComplex;
                Console.WriteLine($"Choose a simple interest rate. You will win {Math.Round(moneyWin,2):f2} lv.");
            }
            else
            {
                double moneyWin = totalComplex - totalSimple;
                Console.WriteLine($"Choose a complex interest rate. You will win {Math.Round(moneyWin, 2):f2} lv.");

            }
            

        }
    }
}
