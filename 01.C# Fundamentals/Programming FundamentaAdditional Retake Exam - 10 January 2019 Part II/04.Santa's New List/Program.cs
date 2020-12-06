using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Santa_s_New_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, int> children = new Dictionary<string, int>();
            Dictionary<string, int> presents = new Dictionary<string, int>();


            while ((input=Console.ReadLine())!="END")
            {
                string[] cmdArgs = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string childName = cmdArgs[0];
                if (childName=="Remove")
                {
                    string childToRemove = cmdArgs[1];
                    if (children.ContainsKey(childToRemove))
                    {
                        children.Remove(childToRemove);
                    }
                }
                else
                {
                    string typeOfToy = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);
                    if (children.ContainsKey(childName))
                    {
                        children[childName]+=amount;
                    }
                    else
                    {
                        children.Add(childName, amount);
                    }
                    if (presents.ContainsKey(typeOfToy))
                    {
                        presents[typeOfToy] += amount;
                    }
                    else
                    {
                        presents.Add(typeOfToy, amount);
                    }
                }
            }

            Console.WriteLine("Children:");
            foreach (var child in children.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{child.Key} -> {child.Value}");
            }

            Console.WriteLine("Presents:");
            foreach (var present in presents)
            {
                Console.WriteLine($"{present.Key} -> {present.Value}");
            }

        }
    }
}
