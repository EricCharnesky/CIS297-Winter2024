using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_MoreObjectOriented
{
    internal class Trapezoid : Polygon

    {
        // instead of const we use readonly
        public static readonly int BASE_SIDE_INDEX = 0;
        public static readonly int TOP_SIDE_INDEX = 2;
        public static readonly int LEFT_SIDE_INDEX = 1;
        public static readonly int RIGHT_SIDE_INDEX = 3;
        public Trapezoid(string name) : base(4, name)
        {

        }

        public string getTrapezoid()
        {
            return "I'm a trapezoid";
        }

        public override void SetSideLength(int sideLength, int sideIndex)
        {
            if (sideIndex == LEFT_SIDE_INDEX || sideIndex == RIGHT_SIDE_INDEX)
            {
                base.SetSideLength(sideLength, 1);
                base.SetSideLength(sideLength, 3);
            }
            else
            {
                base.SetSideLength(sideLength, sideIndex);
            }
        }

        public override double Area()
        {
            // a^2 + b^2 == c^2
            // c^2 - a^2 == b^2 ( height )
            // b == sqrt(c^2 - a^2)

            // ChatGPT might know? Prompt: "how do you calculate the area of a trapezoid in c# given a list of side lengths where side 0 and 2 are the top and bottom parallel sides"
            var bottom = GetSideLength(0); // first base
            var top = GetSideLength(2); // second base
            var side = GetSideLength(1); // one of the sides
            var height = Math.Sqrt(side * side - ((bottom + top) * (bottom - top)) / 4);

            double area = 0.5 * (bottom + top) * height;

            return area;
        }
    }
}
