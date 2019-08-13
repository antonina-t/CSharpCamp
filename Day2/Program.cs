using System;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task8();
        }

        /* Functions */
        static int DoubleUp(int number)
        {
            return number * 2;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void PrintHello()
        {
            Console.WriteLine("Hello!");
        }

        /* Write a function that calculates the diagonal of a rectangle with sides a and b. */

        /* Write a function that prints a congratulation to the name supplied as parameter. */
        
        /* Arrays */
        static void Example1()
        {
            int[] numbers = new int[4]; // 4 is the size of the array
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;

            PrintArrayInfo(numbers);
            Console.WriteLine();

            numbers = new int[] { 1, 2, 3, 4 };
            PrintArrayInfo(numbers);

        }

        static void PrintArrayInfo(int[] numbers)
        {
            Console.WriteLine("The size of the array is " + numbers.Length);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"The number at index {i} is {numbers[i]}");
            }
        }

        /* Write a program that asks the user to enter numbers between 1 and 5 or 0 to stop.
         * It then prints statistics: how many 1s, 2s, 3s, 4s, and 5s were received.
         * Use an array to store stats.
         */
        static void Task1()
        {
        }

        /* Create a function ReadArray that returns an int[].
         * It fills the array with numbers that the user supplies (use Console).
         * Create a function that returns the sum of values given an array: int GetSum(int[] array)
         * Create a function that returns the min value among the values in the array: int GetMinValue(int[] array)
         * Run ReadArray, GetSum and GetMinValue and print the results.
         */
        static void Task2()
        {
        }

        /* Create a function InsertSpaces that takes in a string and returns a new string with spaces between each letter. */
        static void Task3()
        {
        }

        /* Create a function that takes in a string and reverses it. */
        static void Task4()
        {
        }

        /* string methods */
        static void Example5()
        {
            string text = Console.ReadLine();
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.Trim());
            Console.WriteLine(text.Substring(1));
            Console.WriteLine(text.Replace(" ", ""));
            string[] words = text.Split(" ");
        }

        /* Read in a string and replace letters in it so that it sounds like some accent.
         * For example, replace th with z to make it sound french.
         */
        static void Task5()
        {
        }

        /* Write a program that reads in a sentence and the print the same sentence with every second word in uppercase.
         * Hello, beatuiful world. I am ready for you! =>
         * Hello, BEAUTIFUL world. I AM ready FOR you
         */
        static void Task6()
        {
        }

        /* Lists */
        static void Example7()
        {
            List<string> fruits = new List<string>
            {
                "Banana",
                "Apple",
                "Orange",
                "Grapefruit"
            };

            fruits.Add("Peach");
            fruits.RemoveAt(2);
            fruits.Remove("Orange");
            fruits.Sort();

            Console.WriteLine("I have " + fruits.Count + " fruits in my basket. The first one is " + fruits[0] + ".");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

        /* Write a program for handling TODOs. Use List<string>
         * It should have 3 modes: Press 1 to Add task, Press 2 to Remove task, Press 3 to Exit.
         * Efter each step it should print the list of todos, like so:
         * 1 - wake up
         * 2 - code
         * 3 - sleep
        */
        static void Task7()
        {
        }

        /* Dictionaries */
        static void Example8()
        {
            var stats = new Dictionary<int, int>
            {
                [0] = 1,
                [3] = 2
            };
            stats[4] = 3;
            stats[4] = 4;
            stats.TryAdd(4, 5);
            stats.Add(5, 5);
            stats.Remove(4);
            stats.Add(4, 5);
            stats.Remove(2);
            foreach (var entry in stats)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            var words = new Dictionary<string, int>
            {
                ["hello"] = 1,
                ["world"] = 1
            };
            words["hello"]++;
            words["galaxy"] = 0;
            words["galaxy"]++;

            foreach (var entry in words)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        /* Write a program for studying Swedish (or another language).
         * Use Dictionary<string, string> to store translations from English to Swedish.
         * It should have 3 modes: Press 1 to Create an entry, Press 2 to Test, Press 3 to Exit.
         * Create an entry mode asks the user for an English word and its translation to Swedish and stores it.
         * Test mode asks the user to translate all the words in the dictionary in random order.
         * After each answer it says whether the answer is correct. If not, it shows the correct annswer.
        */
        static void Task8()
        {
        }
    }
}
