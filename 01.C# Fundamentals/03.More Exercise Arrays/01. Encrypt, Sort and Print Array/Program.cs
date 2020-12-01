using System;

namespace More_Exercises_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfsequence = int.Parse(Console.ReadLine());
            int charCode = 0;
            int[] numberSequence = new int[numberOfsequence];
            for (int i = 0; i < numberOfsequence; i++)
            {
                int sum = 0;
                string sequence = Console.ReadLine();
                
                for (int j = 0; j < sequence.Length; j++)
                {
                    charCode = (int)sequence[j];
                    if (sequence[j]=='a'|| sequence[j] == 'A' || sequence[j] == 'e' ||
                        sequence[j] == 'E' || sequence[j] == 'I' || sequence[j] == 'i' ||
                        sequence[j] == 'o' || sequence[j] == 'O' || sequence[j] == 'u' ||
                        sequence[j] == 'U' )
                    {
                        sum += charCode * sequence.Length;
                    }
                    else
                    {
                        sum += charCode / sequence.Length;
                    }
                    
                }
                numberSequence[i] = sum;
               
            }
            Array.Sort(numberSequence);
            foreach (int number in numberSequence)
            {
                Console.WriteLine(number);
            }
        }
    }
}
