using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.RemoteSystems;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace XAMLPongDemo
{
    internal class Circle : IDrawable, ICollidable
    {
        public int X {  get; set; } 
        public int Y { get; set; }  
        public int Radius { get; set; }
        public Color Color{ get; set; }

        public CanvasBitmap Image { get; set; }

        // copied from rectangle from GPT
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

        public void Draw(CanvasDrawingSession session)
        {
            //session.DrawCircle(X, Y, Radius, Color);
            if  ( Image != null )
            {
                session.DrawImage(Image, X, Y);
            }
            
        }

        public int GetBottomEdgeY()
        {
            if ( Image != null)
            {
                return Y + (int)Image.Bounds.Height;
            }

            return Y;
           
        }

        public int GetLeftEdgeX()
        {
            return X;
        }

        public int GetRightEdgeX()
        {
           if ( Image != null)
            {
                return X + (int)Image.Bounds.Width;
            }
            return X;
        }

        public int GetTopEdgeY()
        {
            return Y;
        }
    }
}
