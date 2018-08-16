using System;

namespace P01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstSentence = (Console.ReadLine()).Split();
            string[] secondSentence = (Console.ReadLine()).Split();

            EqualWords(firstSentence, secondSentence);
        }

        //Checking which array is shorter and which one is longer
        static void EqualWords(string[] firstArr, string[] secondArr)
        {
            if (firstArr.Length > secondArr.Length)
            {
                ComparingArrays(secondArr, firstArr);

            }
            else
            {
                ComparingArrays(firstArr, secondArr);
            }
        }

        //Comparing elements
        static void ComparingArrays(string[] shorterArr, string[] longerArr)
        {
            //Total
            int longestCommonEnd = 0;


            //Cycle from Left to Right
            if (shorterArr[0] == longerArr[0])
            {
                //Variables
                int firstEqualElementPos = 0;
                int numberOfEqualElements = 0;
                int longestCommonEndStartIndex = 0;

                bool isFirstEqualFound = true;
                bool isItConsecutive = false;

                //Cycle Body
                for (int indexShorterArr = 0; indexShorterArr < shorterArr.Length; indexShorterArr++)
                {
                    for (int indexLongerArr = 0; indexLongerArr < longerArr.Length; indexLongerArr++)
                    {
                        //Checking if equal or not
                        if (shorterArr[indexShorterArr] == longerArr[indexLongerArr])
                        {
                            //Getting the First Symbol in a sequance
                            if (isFirstEqualFound == true && isItConsecutive == false)
                            {
                                firstEqualElementPos = indexShorterArr;
                                isFirstEqualFound = false;
                                isItConsecutive = true;
                            }

                            //Jumping To The Next Symbol
                            if (indexShorterArr < shorterArr.Length - 1)
                            {
                                indexShorterArr++;
                            }

                            //Counting The Consecutive Elements
                            numberOfEqualElements++;

                            //Checking if its the longest common end
                            if (longestCommonEnd <= numberOfEqualElements)
                            {
                                longestCommonEnd = numberOfEqualElements;
                                longestCommonEndStartIndex = firstEqualElementPos;
                            }
                        }
                        else
                        {
                            //Resting the number of consecutive elemts
                            numberOfEqualElements = 0;
                            firstEqualElementPos = 0;

                            //Reseting the first and cansecutive check
                            isFirstEqualFound = true;
                            isItConsecutive = false;
                            break;
                        }
                    }
                }
            }
            
            //Cycle from Right To Left
            else if (shorterArr[shorterArr.Length - 1] == longerArr[longerArr.Length - 1])
            {
                //Variables
                int firstEqualElementPos = 0;
                int numberOfEqualElements = 0;
                int longestCommonEndStartIndex = 0;

                bool isFirstEqualFound = true;
                bool isItConsecutive = false;

                //Cycle Body
                for (int indexShorterArr = shorterArr.Length - 1; indexShorterArr >= 0; indexShorterArr--)
                {
                    for (int indexLongerArr = longerArr.Length - 1; indexLongerArr >= 0; indexLongerArr--)
                    {
                        //Checking if equal or not
                        if (shorterArr[indexShorterArr] == longerArr[indexLongerArr])
                        {
                            //Getting the First Symbol in a sequance
                            if (isFirstEqualFound == true && isItConsecutive == false)
                            {
                                firstEqualElementPos = indexShorterArr;
                                isFirstEqualFound = false;
                                isItConsecutive = true;
                            }

                            //Jumping To The Next Symbol
                            if (indexShorterArr > 0)
                            {
                                indexShorterArr--;
                            }

                            //Counting The Consecutive Elements
                            numberOfEqualElements++;

                            //Checking if its the longest common end
                            if (longestCommonEnd <= numberOfEqualElements)
                            {
                                longestCommonEnd = numberOfEqualElements;
                                longestCommonEndStartIndex = firstEqualElementPos;
                            }
                        }
                        else
                        {
                            //Resting the number of consecutive elemts
                            numberOfEqualElements = 0;
                            firstEqualElementPos = 0;

                            //Reseting the first and cansecutive check
                            isFirstEqualFound = true;
                            isItConsecutive = false;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(longestCommonEnd);
        }
    }
}
