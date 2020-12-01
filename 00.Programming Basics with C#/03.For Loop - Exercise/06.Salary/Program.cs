using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Facebook = 150;
            const int Instagram = 100;
            const int Reddit = 50;

            int openedTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i <= openedTabs ; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                string tabAdress = Console.ReadLine();
               
                if (tabAdress=="Facebook")
                {
                    salary -= Facebook;
                }
                else if (tabAdress=="Instagram")
                {
                    salary -= Instagram;
                }
                else if (tabAdress=="Reddit")
                {
                    salary -= Reddit;
                }
            }
            if (salary>0)
            {
                Console.WriteLine(salary);
            }
            
            
        }
    }
}
