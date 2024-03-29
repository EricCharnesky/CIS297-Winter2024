using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace XAMLPongDemo
{
    internal class Rectangle : IDrawable, ICollidable
    {
        public int X { get; set; } 
        public int Y {  get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color color;

        public void Draw(CanvasDrawingSession session)
        {
            session.DrawRectangle(X, Y, Width, Height, color);
        }

        public int GetLeftEdgeX()
        {
            return X;
        }

        public int GetRightEdgeX()
        {
            return X + Width;
        }

        public int GetBottomEdgeY()
        {
            return Y + Height;
        }

        public int GetTopEdgeY()
        {
            return Y;
        }

        // chatgpt: how do you determine if two rectangles intersect in C# code given the four corners of each object
        public bool DidCollide(ICollidable other)
        {
            // r1 is to the right of r2
            if (GetLeftEdgeX() > other.GetRightEdgeX())
                return false;

            // r1 is to the left of r2
            if (GetRightEdgeX() < other.GetLeftEdgeX())
                return false;

            // r1 is below r2
            if (GetTopEdgeY() > other.GetBottomEdgeY())
                return false;

            // r1 is above r2
            if (GetBottomEdgeY() < other.GetTopEdgeY())
                return false;

            // Rectangles intersect
            return true;
        }
    }
}
