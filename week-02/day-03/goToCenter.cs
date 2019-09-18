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
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.
            canvas.Height = 100;
            canvas.Width = 100;

            DrawLineToCenter(foxDraw, 0, 0);
            DrawLineToCenter(foxDraw, 70, 10);
            DrawLineToCenter(foxDraw, 10, 30);
        }
        public void DrawLineToCenter(FoxDraw foxDraw, int startX, int startY)
        {
            double middle = 50;
            foxDraw.SetStrokeColor(Colors.Blue);
            foxDraw.DrawLine(startX, startY, middle, middle);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}