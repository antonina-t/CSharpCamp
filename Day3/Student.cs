using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public override void PrintGreeting()
        {
            Console.Write("Yo! I am a student. ");
            PrintInfo();
        }
    }
}
