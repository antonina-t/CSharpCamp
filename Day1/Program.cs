using System;

namespace Pink
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1();
        }

        static void Example1()
        {
            Console.WriteLine("Hello World!");
        }

        /* Change World to your name and run the program */
        static void Task1()
        {
        }

        /* Data types */
        static void Example2()
        {
            string name = "Tonya";
            int age = 30;
            double height = 1.73;
            bool isAwesome = true;
            Console.WriteLine("Hello, my name is " + name);
            Console.WriteLine("I am " + age + " years old");
            Console.WriteLine("My height is " + height + "m");
            Console.WriteLine("Am I awesome? " + isAwesome);
        }

        /* Create 4 variables of different types and print them in a text */
        static void Task2()
        {
        }

        /* Variable declaration and assignment */
        static void Example3()
        {
            int number;
            string firstName;
            number = 2 + 3;
            firstName = "Antonina";
            int anotherNumber = -1;
            char ampersand = '&';
            number = 0;
            firstName = "Vanja";
            anotherNumber = number;

        }

        /* How many variables exist after execution of each line? Note their values at each line */
        static void Task3()
        {
            int number = 5;
            number = 10;
            double progress = 0.1;
            progress = 0.5;
            number = -8;
            int otherNumber = 6;
            number = otherNumber;
        }

        /* Swap two variables using an extra variable */
        static void Task4()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(a + " " + b);

            // Swap variables

            Console.WriteLine(a + " " + b);
        }

        /* Reading user input */
        static void Example5()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Hello, {0}", name);
            Console.WriteLine($"Hello, {name}");

            Console.WriteLine("What is your favourite number?");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            Console.WriteLine($"{number * 2} is twice as much!");
        }

        /* Read two numbers and print their sum */
        static void Task5()
        {
        }

        /* Operators
         * arithmetic: + - * / % += -= *= /= ++ --
         * logical: ! && ||
         * ternary: ? :
         */
        static void Example6()
        {
            string hello = "Hello" + " " + "world";
            int i = (5 + 20 - 7) / 3;
            i++;
            i--;
            i += 5;
            i -= 10;
            i *= 10;
            double d = (1.5 - 3) / 7;
            bool b = (i > 5 && i < 3) || (i + 1) * 2 == 3 || i % 2 == 0;
            string value = i == 6 ? "yes" : "no";
        }

        /* Write a program that counts seconds since the lesson started.
         * It should ask the user for number of hours, minutes and seconds and the print the total number of seconds */
        static void Task6()
        {
            Console.WriteLine("I'm bored. Let's count the seconds since we started learning C#.");
        }

        /* Convert km/h speed to m/s */
        static void Task7()
        {
        }

        /* Ask the user 3 yes/no questions. Check if all the answers are correct and print "Success" or "Failure" */
        static void Task8()
        {
        }

        /* If-statements */
        static void Example9()
        {
            Console.WriteLine("Write a number and I'll tell you the truth!");
            int number = int.Parse(Console.ReadLine());
            if (number > 5)
            {
                Console.WriteLine(number + " is larger than 5.");
            }
            else if (number < 5)
            {
                Console.WriteLine(number + " is smaller than 5.");
            }
            else
            {
                Console.WriteLine(number + " is equal to 5.");
            }
        }

        /* Ask the user for two numbers, a < b. Print which one is larger. Don't forget about the equals case! */
        static void Task9()
        {
        }

        /* while-loop */
        static void Example10()
        {
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine(count);
                count++;
            }
        }

        /* Print numbers 10 to 1 using a while-loop */
        static void Task10()
        {
        }

        /* for-loop */
        static void Example11()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        /* Ask the user how many times she wants to be motivated. Print "You're te best!" the given number of times. */
        static void Task11()
        {
        }

        /* Print the following pattern using loops:
        
        *
        **
        ***   
        ****   
        *****   
        ****   
        ***   
        **     
        *       
        
        */
        static void Task12()
        {
        }

        /* Random */
        static void Example13()
        {
            Random random = new Random();
            int value = random.Next(2);
            Console.WriteLine("Take a guess: 0 or 1?");
            int guess = int.Parse(Console.ReadLine());
            Console.WriteLine(guess == value ? "You're lucky!" : "Better luck next time!");
        }

        /* Make the user guess a random number between 1 and 3 until she gets it right. */
        static void Task13()
        {
        }

        /* Use Math */
        static void Example14()
        {
            Console.WriteLine($"Pi = {Math.PI}");
            Console.WriteLine($"Pi = {Math.Round(Math.PI)}");
            Console.WriteLine($"Pi = {Math.Round(Math.PI, 2)}");
            Console.WriteLine();
        }

        /* Write a program that calculates the area of a circle, given a radius that the user supplies.
         * Round the answerr to two decimals. */
        static void Task14()
        {
        }

        /* Write a program that calculates the diagonal of a TV given its width and height. */
        static void Task15()
        {
        }

        /* Use DateTime */
        static void Example16()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            DateTime tomorrow = today.AddDays(1);
            Console.WriteLine(tomorrow);
            var timeTillTomorrow = tomorrow.Subtract(now);
            Console.WriteLine((int)timeTillTomorrow.TotalMinutes + " minutes till tomorrow");
        }

        /* Write a program that calculates the number of days till your next birthday. */
        static void Task16()
        {
        }
    }
}
