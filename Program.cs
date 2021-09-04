using System;

namespace Quilt
{
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Let's build a quilt!");
        }

        public class Square : Shape
        {
            public override void Draw()
            {
            Console.WriteLine("You made a square for your quilt!");
            base.Draw();
            }
        }

        public class Rectangle : Shape
        {
            public override void Draw()
            {
            Console.WriteLine("You made a rectangle for your quilt!");
            base.Draw();
            }
        }

        public class Triangle : Shape
        {
            public override void Draw()
            {
            Console.WriteLine("You made a triangle for your quilt!");
            base.Draw();
            }
        }
    }
}