using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace _10.__SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] command = input.Split(":");
                switch (command[0])
                {
                    case "Add":
                        CommandAdd(schedule, command[1]);
                        break;
                    case "Insert":
                        CommandInsert(schedule, command[1], int.Parse(command[2]));
                        break;
                    case "Remove":
                        CommandRemove(schedule, command[1]);
                        break;
                    case "Swap":
                        CommandSwap(schedule, command[1], command[2]);
                        break;
                    case "Exercise":
                        CommandExercise(schedule, command[1]);
                        break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }

        }

        private static void CommandExercise(List<string> schedule, string lesson)
        {
            if (schedule.Contains(lesson) &&
                !schedule.Contains(lesson+"-Exercise"))
            {
                schedule.Insert(schedule.IndexOf(lesson) + 1, lesson + "-Exercise");
            }
            else if (!schedule.Contains(lesson))
            {
                schedule.Add(lesson);
                schedule.Add(lesson + "-Exercise");
            }
        }

        private static void CommandSwap(List<string> schedule, string lessonOne, string lessonTwo)
        {
            if (schedule.Contains(lessonOne) && schedule.Contains(lessonTwo))
            {
                int indexOne = schedule.IndexOf(lessonOne);
                int indexTwo = schedule.IndexOf(lessonTwo);
                if (schedule.Contains(lessonOne + "-Exercise") && schedule.Contains(lessonTwo + "-Exercise"))
                {
                    schedule[indexTwo] = lessonOne;
                    schedule[indexTwo+1] = lessonOne + "-Exercise";
                    schedule[indexOne] = lessonTwo;
                    schedule[indexOne + 1] = lessonTwo + "-Exercise";
                }
                else if (schedule.Contains(lessonOne + "-Exercise") && !schedule.Contains(lessonTwo + "-Exercise"))
                {
                    schedule[indexTwo] = lessonOne;
                    schedule.Insert(indexTwo + 1, lessonOne + "-Exercise");
                    schedule[indexOne] = lessonTwo;
                    schedule.RemoveAt(indexOne + 1);
                }
                else if (!schedule.Contains(lessonOne + "-Exercise") && schedule.Contains(lessonTwo + "-Exercise"))
                {
                    schedule[indexTwo] = lessonOne;
                    schedule.RemoveAt(indexTwo + 1);
                    schedule[indexOne] = lessonTwo;
                    schedule.Insert(indexOne + 1, lessonTwo + "-Exercise");
                }
                else
                {
                    schedule[indexOne] = lessonTwo;
                    schedule[indexTwo] = lessonOne;
                }
            }   
        }

        private static void CommandRemove(List<string> schedule, string lesson)
        {
            if (schedule.Contains(lesson))
            {
                schedule.RemoveAt(schedule.IndexOf(lesson));
            }
            if (schedule.IndexOf(lesson + "-Exercise") != -1)
            {
                schedule.RemoveAt(schedule.IndexOf(lesson));
            }
        }

        private static void CommandInsert(List<string> schedule, string lesson, int index)
        {
            if (!schedule.Contains(lesson))
            {
                schedule.Insert(index, lesson);
            }
        }

        private static void CommandAdd(List<string> schedule, string lesson)
        {
            if (!schedule.Contains(lesson))
            {
                schedule.Add(lesson);
            }
        }
    }
}
