using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    public class Circle : Shape
    {
        public int Radious { get; set; }
        public Circle(int radious)
        {
            Radious = radious;
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
