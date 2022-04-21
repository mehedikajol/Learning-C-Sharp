using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    public class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(30, 40, 50);
            Console.WriteLine("Area of Triangle is: " + triangle.CalculateArea(triangle) + " squre unit.");
            Console.WriteLine("Perimeter of Triangle is: " + triangle.CalculatePerimeter(triangle) + " unit.\n");

            var reactangle = new Rectangle(30, 40);
            Console.WriteLine("Area of Reactangle is: " + reactangle.CalculateArea(reactangle) + " squre unit.");
            Console.WriteLine("Perimeter of Reactangle is: " + reactangle.CalculatePerimeter(reactangle) + " unit.\n");

            var circle = new Circle(10);
            Console.WriteLine("Area of Circle is: " + circle.CalculateArea(circle) + " squre unit.");
            Console.WriteLine("Perimeter of Circle is: " + circle.CalculatePerimeter(circle) + " unit.\n");
        }
    }
}
