using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class Rectangle : Shape
    {
        private readonly int a;
        private readonly int b;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override double CalculateArea()
        {
            return a * b;
        }
    }
}
