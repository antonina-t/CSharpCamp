using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class Circle : Shape
    {
        private readonly int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
