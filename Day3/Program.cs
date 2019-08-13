using System;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1();            
        }

        static void Example1()
        {
            var people = new List<Person>
            {
                new Student("Maria", 30),
                new Student("Stina", 20),
                new Student("Alexandra", 40),
                new Teacher("Antonina", 30),
                new Student("Malin", 25)
            };
            foreach (Person person in people)
            {
                person.PrintGreeting();
            }
        }

        /* Create an abstract class Shape with 2 subclasses: Rectangle and Circle.
         * Rectangle should have a dubclass Square.
         * Add an abstract method to Shape called double CalculateArea() and implement it in the subclasses.
         * Create a list of shapes with at least 3 shapes.
         * Iterate through them and print the area of each shape.
         */
        static void Task1()
        {
        }
    }
}
