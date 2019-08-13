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
        static double CalculateDiagonal(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        /* Write a function that prints a congratulation to the name supplied as parameter. */
        static void Congratulate(string name)
        {
            Console.WriteLine($"Congratulations, {name}!");
        }
        
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
            int[] stats = new int[5];
            int number = -1;
            while (number != 0)
            {
                Console.WriteLine("Enter a number between 1 and 5 or 0 if you are done.");
                number = int.Parse(Console.ReadLine());
                if (number > 0 && number < 5)
                {
                    stats[number - 1]++;
                }
            }
            Console.WriteLine("Statistics:");
            for (int i = 0; i < stats.Length; i++)
            {
                Console.WriteLine($"{i + 1}s: {stats[i]}");
            }
        }

        /* Create a function ReadArray that returns an int[].
         * It fills the array with numbers that the user supplies (use Console).
         * Create a function that returns the sum of values given an array: int GetSum(int[] array)
         * Create a function that returns the min value among the values in the array: int GetMinValue(int[] array)
         * Run ReadArray, GetSum and GetMinValue and print the results.
         */
        static void Task2()
        {
            int[] array = ReadArray();
            Console.WriteLine("The sum value is " + GetSum(array));
            Console.WriteLine("The min value is " + GetMinValue(array));
        }

        static int[] ReadArray()
        {
            Console.WriteLine("What's the size of the array?");
            int[] array = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum;
        }

        static int GetMinValue(int[] numbers)
        {
            int minValue = int.MaxValue;
            foreach(int i in numbers) {
                if (i < minValue)
                {
                    minValue = i;
                }
            }
            return minValue;
        }

        /* Create a function InsertSpaces that takes in a string and returns a new string with spaces between each letter. */
        static void Task3()
        {
            Console.WriteLine("Write a word and I'll blow it up");
            Console.WriteLine(InsertSpaces(Console.ReadLine()));
        }

        static string InsertSpaces(string s)
        {
            char[] chars = s.ToCharArray();
            char[] charsWithSpaces = new char[chars.Length * 2];

            for (int i = 0; i < chars.Length; i++)
            {
                charsWithSpaces[i * 2] = chars[i];
                charsWithSpaces[i * 2 + 1] = ' ';
            }
            return new string(charsWithSpaces);
        }

        /* Create a function that takes in a string and reverses it. */
        static void Task4()
        {
            Console.WriteLine("Write a word and I'll reverse it");
            Console.WriteLine(Reverse(Console.ReadLine()));
        }

        static string Reverse(string s)
        {
            char[] chars = s.ToCharArray();
            char[] reverseChars = new char[chars.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                reverseChars[chars.Length - i - 1] = chars[i];
            }
            return new string(reverseChars);
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
            string text = Console.ReadLine();
            Console.WriteLine(text.Replace("r", ""));
            Console.WriteLine(text.Replace("th", "z").Replace("r", "rrr"));
        }

        /* Write a program that reads in a sentence and the print the same sentence with every second word in uppercase.
         * Hello, beatuiful world. I am ready for you! =>
         * Hello, BEAUTIFUL world. I AM ready FOR you
         */
        static void Task6()
        {
            string text = Console.ReadLine();
            bool upper = false;
            foreach (string word in text.Split(" "))
            {
                Console.Write((upper ? word.ToUpper() : word.ToLower()) + " ");
                upper = !upper;
            }
            Console.WriteLine();
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
            List<string> tasks = new List<string>();
            int command = -1;
            while (command != 3)
            {
                if (tasks.Count == 0)
                {
                    Console.WriteLine("You don't have any tasks.");
                }
                else
                {
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} {tasks[i]}");
                    }
                }
                Console.WriteLine("1 - Add task\n2 - Remove task\n3 - Exit");
                command = int.Parse(Console.ReadLine());
                if (command == 1)
                {
                    Console.WriteLine("Enter task");
                    tasks.Add(Console.ReadLine());
                }
                else if (command == 2)
                {
                    Console.WriteLine("Enter task number you want to remove");
                    tasks.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                }
                Console.WriteLine();
            }
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
            var words = new Dictionary<string, string>();
            int command = -1;
            while (command != 3)
            {
                Console.WriteLine("1 - Create an entry");
                Console.WriteLine("2 - Test");
                Console.WriteLine("3 - Exit");
                command = int.Parse(Console.ReadLine());
                if (command == 1)
                {
                    Console.Write("English: ");
                    string english = Console.ReadLine();
                    Console.Write("Swedish: ");
                    string swedish = Console.ReadLine();
                    words[english] = swedish;
                } else if (command == 2)
                {
                    Random random = new Random();
                    var keys = new List<string>(words.Keys);
                    while (keys.Count > 0)
                    {
                        int randomIndex = random.Next(keys.Count);
                        string word = keys[randomIndex];
                        Console.WriteLine("Translate " + word);
                        string answer = Console.ReadLine();
                        Console.WriteLine(answer == words[word] ? "Correct!" : "Wrong, the answer is " + words[word]);
                        keys.RemoveAt(randomIndex);
                    }
                }
            }
        }
    }
}
