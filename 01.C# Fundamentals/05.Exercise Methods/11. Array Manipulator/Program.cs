using System;
using System.Threading;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //invalid count
            //invalid index
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                if (command[0] == "exchange")
                {
                    if (int.Parse(command[1]) > arr.Length || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ExchangeArray(arr, int.Parse(command[1]));
                    }
                }
                else if (command[0] == "max")
                {
                    FindMax(arr, command[1]);
                }
                else if (command[0] == "min")
                {
                    FindMin(arr, command[1]);
                }
                else if (command[0] == "first")
                {
                    if (int.Parse(command[1]) > arr.Length || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        FindFirst(arr, int.Parse(command[1]), command[2]);

                    }
                }
                else if (command[0] == "last")
                {
                    if (int.Parse(command[1]) > arr.Length || int.Parse(command[1]) < 0)
                    {
                        Console.WriteLine("Invalid count");
                        break;
                    }
                    else
                    {
                        FindLast(arr, int.Parse(command[1]), command[2]);
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        static void FindMax(string[] arr, string type)
        {
            int max = int.MinValue;
            int indexOf = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (type == "odd")
                {
                    if (int.Parse(arr[i]) % 2 == 1)
                    {
                        if (int.Parse(arr[i]) > max)
                        {
                            max = int.Parse(arr[i]);
                        }
                    }
                }
                else
                {
                    if (int.Parse(arr[i]) % 2 == 0)
                    {
                        if (int.Parse(arr[i]) > max)
                        {
                            max = int.Parse(arr[i]);
                        }
                    }
                }

            }
            if (max != int.MinValue)
            {
                indexOf = Array.IndexOf(arr, max.ToString());
                Console.WriteLine(indexOf);
            }
            else
            {
                Console.WriteLine("No matches");
            }


        }
        static void FindMin(string[] arr, string type)
        {
            int min = int.MaxValue;
            int indexOf = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (type == "odd")
                {
                    if (int.Parse(arr[i]) % 2 == 1)
                    {
                        if (int.Parse(arr[i]) < min)
                        {
                            min = int.Parse(arr[i]);
                        }
                    }
                }
                else
                {
                    if (int.Parse(arr[i]) % 2 == 0)
                    {
                        if (int.Parse(arr[i]) < min)
                        {
                            min = int.Parse(arr[i]);
                        }
                    }
                }

            }
            if (min != int.MaxValue)
            {
                indexOf = Array.IndexOf(arr, min.ToString());
                Console.WriteLine(indexOf);
            }
            else
            {
                Console.WriteLine("No matches");
            }


        }

        static void FindFirst(string[] arr, int count, string type)
        {
            string[] arrFirst = new string[count];
            int counter = 0;
            if (type == "odd")
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (int.Parse(arr[j].ToString()) % 2 == 1)
                    {
                        arrFirst[counter] = arr[j];
                        counter++;
                        if (counter == count)
                        {
                            break;
                        }
                    }

                }
            }
            else
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (int.Parse(arr[j].ToString()) % 2 == 0)
                    {
                        arrFirst[counter] = arr[j];
                        counter++;
                        if (counter == count)
                        {
                            break;
                        }
                    }

                }
            }
            if (string.Join(",", arrFirst).Replace(",", string.Empty).Length == 0)
            {
                Console.WriteLine("[]");
            }
            else if (string.Join(",", arrFirst).Replace(",", string.Empty).Length == 1)
            {
                Console.WriteLine($"[{string.Join("",((string.Join("", arrFirst).Split("",StringSplitOptions.RemoveEmptyEntries))))}]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", arrFirst)}]");
            }

        }

        static void FindLast(string[] arr, int count, string type)
        {
            string[] arrLast = new string[count];
            int counter = 0;
            if (type == "odd")
            {
                for (int j = arr.Length - 1; j >= 0; j--)
                {
                    if (int.Parse(arr[j].ToString()) % 2 == 1)
                    {
                        arrLast[counter] = arr[j];
                        counter++;
                                if (counter == count)
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int j = arr.Length - 1; j >= 0; j--)
                {
                    if (int.Parse(arr[j].ToString()) % 2 == 0)
                    {
                        arrLast[counter] = arr[j];
                        counter++;
                        if (counter == count)
                        {
                            break;
                        }
                    }
                }
            }
            if (string.Join(",", arrLast).Replace(",", string.Empty).Length == 0)
            {
                Console.WriteLine("[]");
            }
            else if (string.Join(",", arrLast).Replace(",", string.Empty).Length == 1)
            {
                Console.WriteLine($"[{string.Join("", ((string.Join("", arrLast).Split("", StringSplitOptions.RemoveEmptyEntries))))}]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", arrLast)}]");
            }

        }

        static string[] ExchangeArray(string[] arr, int index)
        {
            string[] tempArr = new string[arr.Length - 1 - index];
            string[] tempArr2 = new string[index + 1];
            for (int i = 0; i < tempArr.Length; i++)
            {
                tempArr[i] = arr[index + 1 + i];
            }
            for (int i = 0; i <= index; i++)
            {
                tempArr2[i] = arr[i];
            }
            for (int i = 0; i < tempArr.Length; i++)
            {
                arr[i] = tempArr[i];
            }
            for (int i = 0; i < tempArr2.Length; i++)
            {
                arr[tempArr.Length + i] = tempArr2[i];
            }
            return arr;
        }
    }
}

