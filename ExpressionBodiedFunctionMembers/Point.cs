using System;

namespace ExpressionBodiedFunctionMembers
{
    public class Point : ICloneable
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public void Print() => Console.WriteLine("{0} {1}", this.X, this.Y);

        public object Clone() => new Point(this.X, this.Y);

        public void Move(int x, int y)
        {
            this.X += x;
            this.Y += y;
        }
    }
}
