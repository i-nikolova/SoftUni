using System;
using System.Text;

namespace _01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="Done")
            {
                string[] cmd = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmd[0];

                switch (command)
                {
                    case "TakeOdd":
                        password = CommandTakeOdd(password);
                        break;
                    case "Cut":
                        password = CommandCut(password, int.Parse(cmd[1]), int.Parse(cmd[2]));
                        break;
                    case "Substitute":
                        password = CommandSubstitute(password, cmd[1], cmd[2]);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }

        private static string CommandSubstitute(string password, string substring, string substitute)
        {
            if (password.Contains(substring))
            {
                password = password.Replace(substring, substitute);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }
            return password;
        }

        private static string CommandCut(string password, int index, int length)
        {
            password = password.Remove(index, length);
            Console.WriteLine(password);
            return password;
        }

        private static string CommandTakeOdd(string password)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < password.Length; i++)
            {
                if (i%2==1)
                {
                    sb.Append(password[i]);
                }
            }
            Console.WriteLine(sb);
            return sb.ToString();
        }
    }
}
