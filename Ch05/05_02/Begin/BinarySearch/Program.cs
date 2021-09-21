using System;
using static System.Console;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueNeeded = 42;
            int[] myArray = new int[] { 1, 4, 15, 18, 33, 40, 42, 50, 51, 65, 77, 82, 97, 100 };

            WriteLine("our array contains: ");
            Array.ForEach(myArray, x => Write(x + " "));

            Write("\nthe result of our search for " + valueNeeded + " is: ");
            WriteLine(binarySearch(myArray, valueNeeded));
            ReadLine();
        }

        public static int binarySearch(int[] searchedArray, int numberToFind)
        {
            int firstIndex = 0;
            int lastIndex = searchedArray.Length - 1;

            while (firstIndex <= lastIndex)
            {
                int midpoint = (firstIndex + lastIndex) / 2;
                if (numberToFind < searchedArray[midpoint])
                {
                    lastIndex = midpoint - 1;
                }
                else if(numberToFind > searchedArray[midpoint])
                {
                    firstIndex = midpoint + 1;
                }
                else
                {
                    return midpoint;
                }
            }

            return -1;
        }
    }
}
