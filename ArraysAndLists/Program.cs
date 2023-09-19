using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10            
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (var num in array)
            {
                int numberEven = num % 2;
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }
            for (int i = 0; i < evens.Count; i++)
            {
                Console.WriteLine($"{evens[i]} is an even number");
            }

            for (int i = 0; i > odds.Count; i++)
            {
                Console.WriteLine($"{odds[i]} is an odd number");
            }

            // Display the list of even numbers creatively using foreach loop
            Console.WriteLine("List of Even Numbers:");
            foreach (var even in evens)
            {
                Console.WriteLine($"Even: {even}");
            }

            // Display the list of odd numbers creatively using for loop
            Console.WriteLine("\nList of Odd Numbers:");
            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine($"Odd: {odds[i]}");

            }
        }
    }
}



