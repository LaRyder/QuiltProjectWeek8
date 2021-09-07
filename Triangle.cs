using System;
using System.Collections.Generic;
using System.Text;

namespace Quilt
{
    public class Triangle : Shape
    {
        public int side1;
        public int side2;
        public int side3;

        public override void Draw()
        {
            Console.WriteLine("You made a triangle for your quilt!");
            base.Draw();
        }

        public Triangle(string color, int side)
        {
            Name = "Triangle";
            Color = color;
            side1 = side;
        }

        public Triangle()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public override int GetArea()
        {
            int s = (side1 + side2 + side3) / 2;
            int x = s - side1;
            int y = s - side2;
            int z = s - side3;
            int answer = Convert.ToInt32(Math.Sqrt(s * x * y * z));

            return answer;
        }
        public Shape CreateTriangle()
        {
            Console.WriteLine("You created a triangle");
            var color = ui.AskForString("Choose a color");
            var side1 = ui.AskForInt("What is the length of a side");

            return new Triangle(color, side1);
        }
    }
}