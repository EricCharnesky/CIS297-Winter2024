using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_MoreObjectOriented
{
    internal class Rectangle : Polygon
    {
        public Rectangle(string name, int length = 0, int width = 0) : base(4, name)
        {
            SetSideLength(length, 0);
            SetSideLength(width, 1);
        }

        public override void SetSideLength(int sideLength, int sideIndex)
        {
            if (sideLength % 2 == 0)
            {
                base.SetSideLength(sideLength, 0);
                base.SetSideLength(sideLength, 2);
            }
            else
            {
                base.SetSideLength(sideLength, 1);
                base.SetSideLength(sideLength, 3);
            }
        }

        public override double Area()
        {
            return GetSideLength(0) * GetSideLength(1);
        }
    }
}
