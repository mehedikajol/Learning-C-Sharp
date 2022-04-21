using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    public class Triangle : Shape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;  
        }
        public override double CalculateArea(Shape shape)
        {
            return base.CalculateArea(shape);
        }
        public override double CalculatePerimeter(Shape shape)
        {
            return base.CalculatePerimeter(shape);
        }
    }
}
