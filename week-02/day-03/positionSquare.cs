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

            canvas.Height = 100;
            canvas.Width = 100;

            // create a function that draws one square and takes 3 parameters:
            // the x and y coordinates of the square's top left corner
            // and the foxDraw and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.

            int[] widths = { 30, 50, 20 };
            int[] x = { 2, 6, 10};
            int[] y = { 8, 34, 66 };
            Color[] colors = { Colors.Blue, Colors.Green, Colors.Red };

            for (int i = 0; i < 3; i++)
            {
                DrawFiftySquare(foxDraw, x[i], y[i], widths[i], colors[i]);
            }
            
        }
        public static void DrawFiftySquare (FoxDraw foxDraw, int startX, int startY, int width, Color color)
        {
            foxDraw.SetFillColor(color);
            foxDraw.DrawRectangle(startX, startY, width, width);
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}