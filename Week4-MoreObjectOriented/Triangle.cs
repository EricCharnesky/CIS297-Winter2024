using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_MoreObjectOriented
{
    internal class Triangle : Polygon
    {
        public Triangle(string name) : base(3, name)
        {
        }

        public override double Area()
        {
            double semiPerimeter = Perimeter / 2;
            double result = Math.Sqrt(semiPerimeter * (semiPerimeter - GetSideLength(0))
                * (semiPerimeter - GetSideLength(1))
                * (semiPerimeter - GetSideLength(2)));
            return result;

        }
    }
}
