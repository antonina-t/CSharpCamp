using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class Square : Rectangle
    {
        private readonly int a;
        private readonly int b;

        public Square(int a) : base(a, a)
        {
        }
    }
}
