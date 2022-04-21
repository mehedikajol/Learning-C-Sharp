using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    public class Shape
    {
        public virtual double CalculateArea(Shape shape)
        {
            var totalArea = 0.0;
            if (shape is Triangle)
            {
                var triangle = shape as Triangle;
                var totalSide = triangle.Side1 + triangle.Side2 + triangle.Side3;
                var halfTotal = totalSide / 2.0;
                totalArea = Math.Sqrt(halfTotal * (halfTotal - triangle.Side1) * (halfTotal - triangle.Side2) * (halfTotal - triangle.Side3));
            }
            else if (shape is Rectangle)
            {
                var rectangle = shape as Rectangle;
                totalArea = rectangle.Side1 * rectangle.Side2;
            }
            else if (shape is Circle)
            {
                var circle = shape as Circle;
                totalArea = Math.PI * circle.Radious * circle.Radious;
            }
            return Math.Round((Double)totalArea, 2);

        }

        public virtual double CalculatePerimeter(Shape shape)
        {
            var perimeter = 0.0;
            if (shape is Triangle)
            {
                var triangle = shape as Triangle;
                perimeter = triangle.Side1 + triangle.Side2 + triangle.Side3;
            }
            else if (shape is Rectangle)
            {
                var rectangle = shape as Rectangle;
                perimeter = rectangle.Side1 + rectangle.Side2;
            }
            else if (shape is Circle)
            {
                var circle = shape as Circle;
                perimeter = 2 * Math.PI * circle.Radious;
            }
            return Math.Round((double)perimeter, 2);
        }
    }
}
