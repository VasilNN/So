using System;
using System.Collections.Generic;

namespace EP02.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            string consoleInput = string.Empty;
            List<string> courcesList = new List<string>();

            while ((consoleInput = Console.ReadLine()) != "course start")
            {
                //Get Inital Input
                if (consoleInput.Contains(","))
                {
                    courcesList.AddRange(consoleInput.Split(", ", StringSplitOptions.RemoveEmptyEntries));
                }
                else
                {
                    //Split the input
                    string[] separatedInput = consoleInput.Split(":");

                    //Check the length and add if three
                    string command = separatedInput[0];
                    string lesson1 = separatedInput[1];
                    string lesson2 = "";
                    if (separatedInput.Length == 3)
                    {
                        lesson2 = separatedInput[2];
                    }

                    //Add:{lessonTitle}
                    if (command == "Add" && courcesList.Contains(lesson1) == false)
                    {
                        courcesList.Add(lesson1);
                    }

                    //Insert:{lessonTitle}:{index} 
                    if (command == "Insert" && courcesList.Contains(lesson1) == false)
                    {
                        int tempIndex = int.Parse(lesson2);
                        if (tempIndex < courcesList.Count)
                        {
                            courcesList.Insert(tempIndex, lesson1);
                        }
                    }

                    //Remove:{lessonTitle} 
                    if (command == "Remove" && courcesList.Contains(lesson1) == true)
                    {
                        courcesList.Remove(lesson1);
                        if (courcesList.Contains(lesson1 + "-Exercise"))
                        {
                            courcesList.Remove(lesson1 + "-Exercise");
                        }
                    }

                    //Swap:{lessonTitle}:{lessonTitle} 
                    if (command == "Swap" && courcesList.Contains(lesson1) && courcesList.Contains(lesson2))
                    {
                        int lessonOneIndex = courcesList.IndexOf(lesson1);
                        int lessonTwoIndex = courcesList.IndexOf(lesson2);

                        courcesList.Remove(lesson1);
                        courcesList.Remove(lesson2);

                        //If there is Exercise
                        string lessonOneExercis = lesson1 + "-Exercise";
                        string lessonTwoExercis = lesson2 + "-Exercise";

                        if (lessonOneIndex < lessonTwoIndex)
                        {
                            courcesList.Insert(lessonOneIndex, lesson2);
                            courcesList.Insert(lessonTwoIndex, lesson1);

                            //Place the exercises after their lessons
                            if (courcesList.Contains(lessonOneExercis))
                            {

                                lessonOneIndex = courcesList.IndexOf(lesson1);

                                courcesList.Remove(lessonOneExercis);
                                courcesList.Insert(lessonOneIndex + 1, lessonOneExercis);

                            }
                            if (courcesList.Contains(lessonTwoExercis))
                            {
                                lessonTwoIndex = courcesList.IndexOf(lesson2);

                                courcesList.Remove(lessonTwoExercis);
                                courcesList.Insert(lessonTwoIndex + 1, lessonTwoExercis);

                            }
                        }
                        else
                        {
                            courcesList.Insert(lessonTwoIndex, lesson1);
                            courcesList.Insert(lessonOneIndex, lesson2);

                            //Place the exercises after their lessons
                            if (courcesList.Contains(lessonTwoExercis))
                            {

                                lessonTwoIndex = courcesList.IndexOf(lesson2);

                                courcesList.Remove(lessonTwoExercis);
                                courcesList.Insert(lessonTwoIndex + 1, lessonTwoExercis);

                            }
                            if (courcesList.Contains(lessonOneExercis))
                            {
                                lessonOneIndex = courcesList.IndexOf(lesson1);

                                courcesList.Remove(lessonOneExercis);
                                courcesList.Insert(lessonOneIndex + 1, lessonOneExercis);

                            }
                        }
                    }

                    //Exercise:{lessonTitle} 
                    if (command == "Exercise")
                    {
                        if (courcesList.Contains(lesson1) == false)
                        {
                            courcesList.Add(lesson1);
                        }
                        if (courcesList.Contains(lesson1 + "-Exercise") == false)
                        {
                            string addedExercis = lesson1 + "-Exercise";
                            int lesson1Index = courcesList.IndexOf(lesson1) + 1;
                            courcesList.Insert(lesson1Index, addedExercis);
                        }
                    }
                }
            }
            for (int index = 0; index < courcesList.Count; index++)
            {
                Console.WriteLine($"{index + 1}.{courcesList[index]}");
            }
        }
    }
}
