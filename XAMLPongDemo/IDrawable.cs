using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLPongDemo
{
    internal interface IDrawable
    {
        void Draw(CanvasDrawingSession session);
    }
}
