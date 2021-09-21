using System;
using static System.Console;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int myValue = 7;
            int[] myArray = new int[] { 1, 3, 5, 6, 7, 10, 12, 15, 60 };

            WriteLine("the array contains:  ");
            Array.ForEach(myArray, x => Write(x + " "));

            Write($"\n the result of our linear search for {myValue} is: ");
            WriteLine(linearSearch(myArray, myValue));
            ReadLine();
        }

        public static int linearSearch(int[] searchedArray, int searchedNumber)
        {
            for (int i = 0; i < searchedArray.Length; i++)
            {
                if(searchedArray[i] == searchedNumber)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
