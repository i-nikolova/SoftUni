using System;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userName = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            

            foreach (var username in userName)
            {
                bool isInvalid = false;
                if (username.Length<3 || username.Length>16)
                {
                    continue;
                }
                foreach (var ch in username)
                {
                    if (!char.IsLetterOrDigit(ch) && ch !='-' && ch!='_')
                    {
                        isInvalid = true;
                        break;
                    }
                }
                if (!isInvalid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
