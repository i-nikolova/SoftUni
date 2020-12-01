using System;
using System.Text;

namespace _01.ActivationKeys
{
    class Program
    {

        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="Generate")
            {
                string[] cmdArgs = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch (command)
                {
                    case "Contains":
                        CommandContains(key,cmdArgs[1]);
                        break;
                    case "Flip":
                        if (cmdArgs[1]=="Upper")
                        {
                            key = CommandUpperFlip(key, int.Parse(cmdArgs[2]), int.Parse(cmdArgs[3]));

                        }
                        else
                        {
                            key = CommandLowerFlip(key, int.Parse(cmdArgs[2]), int.Parse(cmdArgs[3]));
                        }
                        break;
                    case "Slice":
                        key = CommandSlice(key, int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {key}");
        }

        private static string CommandLowerFlip(string key, int startIndex, int endIndex)
        {
            string substring = key.Substring(startIndex, endIndex - startIndex).ToLower();
            key = key.Remove(startIndex, endIndex - startIndex);
            key = key.Insert(startIndex, substring);

            Console.WriteLine(key);
            return key;
        }

        private static string CommandUpperFlip(string key, int startIndex, int endIndex)
        {
            string substring = key.Substring(startIndex, endIndex - startIndex).ToUpper();
            key = key.Remove(startIndex, endIndex - startIndex);
            key = key.Insert(startIndex, substring);

            Console.WriteLine(key);
            return key;
        }

        private static string CommandSlice(string key, int startIndex, int endIndex)
        {
            key = key.Remove(startIndex, endIndex - startIndex);

            Console.WriteLine(key);

            return key;
        }


        private static void CommandContains(string key, string substring)
        {
            if (key.Contains(substring))
            {
                Console.WriteLine($"{key} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }
    }
}
