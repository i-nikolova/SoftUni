using System;


namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {



            string[] input = Console.ReadLine().Split();
            int[] currentNum = new int[input.Length];
            for (int i = 0; i < currentNum.Length; i++)
            {
                currentNum[i] = int.Parse(input[i]);
            }

            while (currentNum.Length != 0)
            {

                int[] newArr = new int[currentNum.Length - 1];
                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = currentNum[i] + currentNum[i + 1];
                }
                currentNum = newArr;

            }

            Console.WriteLine(String.Join(" ", currentNum));


        }
    }
}
