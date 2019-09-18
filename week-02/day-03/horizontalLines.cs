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

            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the foxDraw
            // and draws a 50 long horizontal line from that point.
            // Draw at least 3 lines with that function using a loop.
            int startX = 10;
            int startY = 10;
            for (int i = 0; i < 3; i++)
            {
                DrawHorizontalLine(foxDraw, startX, startY, Colors.Purple);

                startX += 20;
                startY += 20;
            }

        }
        public void DrawHorizontalLine(FoxDraw foxDraw, int startX, int startY, Color color)
        {
            int endX = startX + 50;
            //foxDraw.SetStrokeColor(color);
            foxDraw.SetStrokeColor(color);
            foxDraw.DrawLine(startX, startY, endX, startY);
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}