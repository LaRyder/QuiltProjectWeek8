using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Quilt
{
   public class Square : Shape
    {
        public int side1;

        public override void Draw()
        {
            Console.WriteLine("You made a square for your quilt!");
            base.Draw();
        }

        public Square(string color, int side)
        {
            Name = "Square";
            Color = color;
            side1 = side;
        }

        public Square()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override int GetArea()
        {
            return side1 * side1;
        }

        public Shape CreateSquare()
        {
            Console.WriteLine("You created a square");
            var color = ui.AskForString("Choose a color");
            var side1 = ui.AskForInt("What is the length of a side");

            return new Square(color, side1);
        }
    }
}
