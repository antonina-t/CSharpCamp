using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override void PrintGreeting()
        {
            Console.Write("Good morning! I am a teacher. ");
            PrintInfo();
        }
    }
}
