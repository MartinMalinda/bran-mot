using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            canvas.Height = 500;//outputs double
            canvas.Width = 500;//outputs double

            // Create a function that takes 2 parameters:
            // A list of (x, y) points and foxDraw
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}

            int[,] boxPoints = { { 10, 10 }, { 290, 10 }, { 290, 290 }, { 10, 290 } };
            int[,] shape = { { 50, 100 }, { 70, 70 }, { 80, 90 }, { 90, 90 }, { 100, 70 }, { 120, 100 }, { 85, 130 }, { 50, 100 } };
            
            ConnectTheDots(foxDraw, boxPoints);
            ConnectTheDots(foxDraw, shape); 
            
        }
        public static void ConnectTheDots(FoxDraw foxDraw, int[,] pointsToConnect) {
            int max = pointsToConnect.GetLength(0);
            int endX = 0;
            int endY = 0;
            for (int i = 0; i < max; i++)
            {
                int originX = pointsToConnect[i, 0];
                int originY = pointsToConnect[i, 1];
                //detect if it's the last element of the array so that you can tell the line to connect to the start
                if (i == max - 1) {
                    endX = pointsToConnect[0, 0];
                    endY = pointsToConnect[0, 1];
                }
                else
                {
                    endX = pointsToConnect[i + 1, 0];
                    endY = pointsToConnect[i + 1, 1];
                }

                foxDraw.SetStrokeThicknes(1);
                foxDraw.SetStrokeColor(Colors.Green);
                foxDraw.DrawLine(originX, originY, endX, endY);
            }

        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}