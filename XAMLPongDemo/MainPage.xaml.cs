using Microsoft.Graphics.Canvas.UI.Xaml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XAMLPongDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool ballMovingRight;
        bool ballMovingDown;

        Rectangle leftWall;
        Rectangle rightWall;
        Circle circle;
        Rectangle topPaddle;
        Rectangle bottomPaddle;

        bool userPaddleGoingRight;
        bool userPaddleGoingLeft;

        List<IDrawable> drawables;
        List<ICollidable> upAndDownCollidables;
        List<ICollidable> leftAndRightCollidables;

        public MainPage()
        {
            this.InitializeComponent();

            Window.Current.CoreWindow.KeyDown += Canvas_KeyDown;
            Window.Current.CoreWindow.KeyUp += Canvas_KeyUp;

            userPaddleGoingLeft = false;
            userPaddleGoingRight= false;

            drawables = new List<IDrawable>();
            leftAndRightCollidables = new List<ICollidable>();
            upAndDownCollidables = new List<ICollidable>();


 
            ballMovingRight = true;
            ballMovingDown = true;

            circle = new Circle
            {
                X = 200,
                Y = 200,
                Radius = 20,
                Color = Colors.White
            };

            leftWall = new Rectangle
            {
                X = 50,
                Y = 50,
                Width = 10,
                Height = 400,
                color = Colors.White
            };

            topPaddle = new Rectangle
            {
                X = 200,
                Y = 41,
                Height = 10,
                Width = 80,
                color = Colors.White
            };

            bottomPaddle = new Rectangle
            {
                X = 200,
                Y = 449,
                Height = 10,
                Width = 80,
                color = Colors.White
            };

            rightWall = new Rectangle
            {
                X = 800,
                Y = 50,
                Width = 10,
                Height = 400,
                color = Colors.White
            };



            drawables.Add(leftWall);
            drawables.Add(rightWall);
            drawables.Add(circle);
            drawables.Add(topPaddle);
            drawables.Add(bottomPaddle);

            leftAndRightCollidables.Add(leftWall);
            leftAndRightCollidables.Add(rightWall);

            upAndDownCollidables.Add(topPaddle);
            upAndDownCollidables.Add(bottomPaddle);
        }

        private void Canvas_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs e)
        {
            if (e.VirtualKey == Windows.System.VirtualKey.Left)
            {
                userPaddleGoingLeft = true;
            }
            else if (e.VirtualKey == Windows.System.VirtualKey.Right)
            {
                userPaddleGoingRight = true;
            }
           
        }

        private void Canvas_KeyUp(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs e)
        {
            if (e.VirtualKey == Windows.System.VirtualKey.Left)
            {
                userPaddleGoingLeft = false;
            }
            else if (e.VirtualKey == Windows.System.VirtualKey.Right)
            {
                userPaddleGoingRight = false;
            }
        }

        private void Canvas_Draw(ICanvasAnimatedControl sender, CanvasAnimatedDrawEventArgs args)
        {
            foreach ( var drawable in drawables)
            {
                drawable.Draw(args.DrawingSession);
            }
        }

        private void Canvas_Update(ICanvasAnimatedControl sender, CanvasAnimatedUpdateEventArgs args)
        {
            foreach( var colliable in upAndDownCollidables)
            {
                if (circle.DidCollide(colliable))
                {
                    ballMovingDown = !ballMovingDown;
                }
            }

            foreach (var colliable in leftAndRightCollidables)
            {
                if (circle.DidCollide(colliable))
                {
                    ballMovingRight = !ballMovingRight;
                }
            }


            if ( ballMovingRight )
            {
                circle.X++;
            }
            else
            {
                circle.X--;
            }

            if (ballMovingDown)
            {
                circle.Y++;
            }
            else
            {
                circle.Y--;
            }

            topPaddle.X = circle.X - (topPaddle.Width / 2);

            if (userPaddleGoingLeft)
            {
                if (!bottomPaddle.DidCollide(leftWall))
                {
                    bottomPaddle.X--;
                }
                
            } else if (userPaddleGoingRight)
            {
                if (!bottomPaddle.DidCollide(rightWall))
                {
                    bottomPaddle.X++;
                }
            }
        }
    }
}
