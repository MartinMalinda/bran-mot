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

            // Create a function that draws a single line and takes 3 parameters:
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.


            for (int i = 0; i <= 500; i+= 20)
            {
                //starts from top left, increments by 20 across the X axis
                LinesToTheCenter(foxDraw, i, 0);
                //starts from bottom left, increments by 20 across the X axis
                LinesToTheCenter(foxDraw, i, 500);
                //starts from top left, increments by 20 across the Y axis
                LinesToTheCenter(foxDraw, 0, i);
                //starts from top right, increments by 20 across the y axis
                LinesToTheCenter(foxDraw, 500, i);
            }

        }
        public static void LinesToTheCenter(FoxDraw foxDraw, int originX, int originY) {
            double center = 500 / 2;
            foxDraw.SetStrokeThicknes(1);
            foxDraw.SetStrokeColor(Colors.LightSeaGreen);
            foxDraw.DrawLine(originX, originY, center, center);

        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}