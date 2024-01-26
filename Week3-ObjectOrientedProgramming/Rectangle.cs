using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_ObjectOrientedProgramming
{
    internal class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 0;
            width = 0;
        }

        public Rectangle(int length, int width)
        {
            SetLength(length);
            SetWidth(width);
        }

        public int GetLength()
        {
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public void SetLength(int length)
        {
            if ( length < 0 )
            {
                this.length = 0;
            }
            else
            {
                this.length = length;
            }
            
        }

        public void SetWidth(int width)
        {
            if (width < 0)
            {
                this.width = 0;
            }
            else
            {
                this.width = width;
            }
        }

        public int GetArea()
        {
            return length * width;
        }

        public int Perimeter => length * 2 + width * 2;

        public override string ToString()
        {
            return $"Rectangle with length: {length} and width: {width}";
        }
    }
}
