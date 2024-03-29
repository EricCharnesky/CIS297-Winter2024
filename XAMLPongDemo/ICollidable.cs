using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLPongDemo
{
    internal interface ICollidable
    {
        int GetLeftEdgeX();
        int GetRightEdgeX();
        int GetBottomEdgeY();
        int GetTopEdgeY();

        bool DidCollide(ICollidable other);

    }
}
