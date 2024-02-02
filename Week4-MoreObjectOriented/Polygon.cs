using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_MoreObjectOriented
{
    internal class Polygon
    {
        private List<int> sideLengths;

        public string Name { get; set; }

        public Polygon(int numberOfSides, string name) {
            sideLengths = new List<int>(numberOfSides);
            for ( int index = 0; index < numberOfSides; index++ )
            {
                sideLengths.Add(0);
            }
            Name = name;

        }

        public virtual void SetSideLength(int sideLength, int sideIndex) {
            sideLengths[sideIndex] = sideLength;
        }

        public int GetSideLength(int sideIndex)
        {
            return sideLengths[sideIndex];
        }

        public override string ToString()
        {
            return $"{Name} Area:{Area()} Perimeter:{Perimeter}";
        }

        public int Perimeter => sideLengths.Sum();

        public virtual double Area() => throw new NotImplementedException();
    }
}
