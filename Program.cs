using System;
using System.Collections.Generic;

namespace Quilt
{
    public class Shape
    {
        public string Name { get; }
        public string Color { get; set; }
        public string Input;
        public object ui;

        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Let's build a quilt!");
        }
        
        
        while(Input) == "L"))
        {
            Console.WriteLine("\n--Pick the shape you would like to add--");
            Console.WriteLine("S Add a square");
            Console.WriteLine("R Add a rectangle");
            Console.WriteLine("T Add a triangle");
            Console.WriteLine("L List shapes");
            Input = Console.Readline();
  
            if(Input == "S")
            {
            Square squareS = new Square();
            Console.WriteLine("Enter the side of the square: ");
            squareS.Side1 = Convert.ToInt32(Console.Readline());
            Console.WriteLine("Enter the color of the square: ");
            squareS.Color = Console.Readline();
            Console.WriteLine($"The area of your square is: " + squareS.GetArea());

            shapes.Add(new Square(squareS.Side1 squareS.Color));
            

            if(Input == "R")
            {
            Rectangle rectangleR = new Rectangle();
            Console.WriteLine("Enter the side of the rectanlge: ");
            rectangleR.Side1 = Convert.ToInt32(Console.Readline());
            Console.WriteLine("Enter the color of the rectangle: ");
            rectangleR.Color = Console.Readline();
            Console.WriteLine($"The area of your rectangle is: " + rectanlgeR.GetArea());


            shapes.Add(new Rectangle(rectangleR.Side1, rectangleR.Side2 rectangleR.Color));

            if(Input) == "T")
            {
            Triangle triangleT = new Triangle();
            Console.WriteLine("Enter the side of the triangle: ");
            triangleT.Side1 = Convert.ToInt32(Console.Readline());
            Console.WriteLine("Enter the color of the triangle: ");
            triangleT.Color = Console.Readline();
            Console.WriteLine($The area of your square is: " + triangleT.GetArea());

            shapes.Add(new Triangle(triangleT.Side1, triangleT.Side2, triangleT.Side3, triangleT.Color));

           if (Input) == "L")
           {
           List shapesL = new List();
           Console.WriteLine("Square, Rectangle, Triangle: ");  
    }
}
