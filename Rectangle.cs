using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Quilt
{
    public class Rectangle : Shape
    {
        public int side1;
        public int side2;

        public override void Draw()
        {
            Console.WriteLine("You made a rectangle for your quilt!");
            base.Draw();
        }

        public Rectangle(string Color, int side)
        {
            Name = "Rectangle";
            Color = color;
            side1 = side;
        }

        public Rectangle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public override int GetArea()
        {
            return side1 * side1;
        }
        public Shape CreateRectangle()
        {
            Console.WriteLine("You created a rectangle");
            var color = ui.AskForString("Choose a color");
            var side1 = ui.AskForInt("What is the length of a side");

            return new Rectangle(color, side1);
        }
    }
}