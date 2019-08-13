using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    public abstract class Person
    {
        public string Name { get; set; }
        public bool IsMinor { get { return age < 18; } }
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public abstract void PrintGreeting();

        public void PrintInfo()
        {
            Console.WriteLine("My name is " + Name + ", I am " + age + " years old.");
        }
    }
}
