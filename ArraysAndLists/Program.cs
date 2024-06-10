using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            /* Create a list of type int
             * Name the list "evens"
             */
            List<int> evens = new List<int>();

            /* Create another list of type int
             * Name the list "odds"
             */
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
            * iterate through the array you populated with 10 numbers.
            * Inside the scope of the loop,
            * check to see if each number in the array is even or odd.
            * If the number is even, add it to the evens list.
            * If the number is odd, add it to the odds list.
            */
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }


            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */
            Console.WriteLine("EVENS:");
            foreach (int even in evens)
            {
                Console.WriteLine(even);
            }

            /* Using a for loop,
             * display the numbers in your "odds" list
             */
            Console.WriteLine("\nODDS:");
            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }
        }
    }
}
