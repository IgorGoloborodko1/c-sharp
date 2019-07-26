using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square("square1");
            square.Side = 10;

            var isoscelesTriangle = new IsoscelesTriangle("isoscelesTriangle1");
            isoscelesTriangle.Base = 5;
            isoscelesTriangle.Heigth = 10;

            var circle = new Circle("circle1");
            circle.Radius = 13;

            var rectangle = new Rectangle("rectangle1");
            rectangle.Length = 11;
            rectangle.Width = 3;

            var triangle = new Triangle("triangle1");
            triangle.Heigth = 2;
            triangle.Base = 18;

            Shape[] shapes =
            {
                square,
                isoscelesTriangle,
                circle,
                rectangle,
                triangle
            };

            foreach(var i in shapes)
            {
                Console.WriteLine("Shape name is: {0} and its area is: {1}", i.GetName(), i.GetArea());
            }
            Console.ReadLine();
        }
    }
}
