using System;
using System.Collections.Generic;
namespace Geometri_opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Assignment A & B

            Console.WriteLine(("").PadRight(50, '-'));
            Console.WriteLine("Assignment A & B:");
            Console.WriteLine(("").PadRight(50, '-'));
           
            //initialize  new square object
            Shape sq = new Square(25);
            Console.WriteLine($"initializing a square with equal sides of: {sq.A} \n");
            Console.WriteLine($"the perimeter of the square is: {sq.Calc_perimeter()}");
            Console.WriteLine($"the Area of the Square is: {sq.Calc_Area()}");
            Console.WriteLine(("").PadRight(50, '-'));

            //initialize  new square object
            Shape sq2 = new Square(50);
            Console.WriteLine($"initializing a square with equal sides of: {sq2.A} \n");
            Console.WriteLine($"the perimeter of the square is: {sq2.Calc_perimeter()}");
            Console.WriteLine($"the Area of the Square is: {sq2.Calc_Area()}");

            #endregion

            #region Assignment C

            Console.WriteLine(("").PadRight(50, '-'));
            Console.WriteLine("Assignment C & D & E & F:");
            Console.WriteLine(("").PadRight(50, '-'));

            //new parallelogram shape
            Shape para = new Parallelogram(3, 5, 20);
            Console.WriteLine($"the Area of the Parallelogram is: {para.Calc_Area()}");
            Console.WriteLine($"the Perimeter of the Parallelogram is: {para.Calc_perimeter()}");
            Console.WriteLine(("").PadRight(50, '-'));

            //new trapez shape
            Shape trap = new Trapez(5, 10, 2, 10);
            Console.WriteLine($"the Area of the Trapez is: {trap.Calc_Area()}");
            Console.WriteLine($"the Perimeter of the Trapez is: {trap.Calc_perimeter()}");
            Console.WriteLine(("").PadRight(50, '-'));

            //new triangle shape
            Shape triangle = new Triangle(10, 10);
            Console.WriteLine($"the Area of the Triangle is: {triangle.Calc_Area()}");
            Console.WriteLine($"the Perimeter of the Triangle is: {triangle.Calc_perimeter()}");
            Console.WriteLine(("").PadRight(50, '-'));

            //new rectangle shape
            Shape rectangle = new Rectangel(15, 30);
            Console.WriteLine($"the Area of the Rectangle is: {rectangle.Calc_Area()}");
            Console.WriteLine($"the Perimeter of the Rectangle is: {rectangle.Calc_perimeter()}");
            Console.WriteLine(("").PadRight(50, '-'));
            #endregion

            #region Assignment G

            Console.WriteLine(("").PadRight(50, '-'));
            Console.WriteLine("Assignment G:");
            Console.WriteLine(("").PadRight(50, '-'));
            List<Shape> shapes = new List<Shape>();
            shapes.Add(para);
            shapes.Add(trap);
            shapes.Add(triangle);
            shapes.Add(rectangle);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"calculating Area for shape: {shape.Calc_Area()}\n" +
                $"calculating Perimeter for shape: {shape.Calc_perimeter()}");
                Console.WriteLine(("").PadRight(50, '-'));
            }
            
            #endregion


            Console.ReadKey();
        }
    }
}
