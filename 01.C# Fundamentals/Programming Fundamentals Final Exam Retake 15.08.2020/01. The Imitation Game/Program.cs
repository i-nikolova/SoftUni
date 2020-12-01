using System;

namespace Problem_1._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArr = input.ToCharArray();
            char[] message = inputArr;


            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] commandArr = command.Split('|');
                string commandType = commandArr[0];
                if (commandType == "Insert")
                {
                    int index = int.Parse(commandArr[1]);
                    string value = commandArr[2];
                    Array.Resize(ref message, (message.Length + value.Length));
                    char[] tempMessage = new char[message.Length];
                    Array.Copy(message, tempMessage, (message.Length));
                    for (int i = index; i < message.Length - value.Length; i++)
                    {
                        message[i + value.Length] = tempMessage[i];
                    }
                    if (value.Length==1)
                    {
                        message[index] = value[0];
                    }
                    else
                    {
                        for (int k = 0; k < value.Length; k++)
                        {
                            message[k + index] = value[k];
                        }
                    }
                }



                /*if (i >= index && i <= index + value.Length - 1)
                {
                    if (isInserted)
                    {
                        continue;
                    }
                    else
                    {
                        for (int j = 0; j < value.Length; j++)
                        {
                            message[i + j] = value[j];
                        }
                        isInserted = true;
                    }


                }
                else if (i > index + value.Length - 1)
                {
                    message[i] = inputArr[i - value.Length];
                }
                else
                {
                    message[i] = inputArr[i];
                }*/


                else if (commandType == "ChangeAll")
            {
                char substring = char.Parse(commandArr[1]);
                char replacement = char.Parse(commandArr[2]);
                for (int i = 0; i < message.Length; i++)
                {
                    if (message[i] == substring)
                    {
                        message[i] = replacement;
                    }
                }
            }

            else if (commandType == "Move")
            {
                char[] tempMessage = new char[message.Length];
                Array.Copy(message, tempMessage, (message.Length));
                int lettersMoved = int.Parse(commandArr[1]);
                for (int i = 0; i < message.Length - lettersMoved; i++)
                {
                    message[i] = tempMessage[lettersMoved + i];

                }

                for (int j = 0; j < lettersMoved; j++)
                {
                    message[message.Length - lettersMoved + j] = tempMessage[j];
                }
            }
        }
        string messageStr = new string(message);
        Console.WriteLine($"The decrypted message is: {messageStr} ");
        }
}
}
