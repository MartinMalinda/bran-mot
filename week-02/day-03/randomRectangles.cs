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

            // draw four different size and color rectangles.
            // avoid code duplication.
            int[] widths = { 30, 50, 20, 36 };
            int[] heights = { 60, 10, 50, 24 };
            int[] x = { 2, 6, 10, 30 };
            int[] y = { 8, 34, 66, 12 };
            Color[] colors = { Colors.Blue, Colors.Green, Colors.Red, Colors.Purple };

            for (int i = 0; i < 4; i++)
            {
                DrawRandomRectangle(foxDraw, x[i], y[i], widths[i], heights[i], colors[i]);
            }
            
        }
        public static void DrawRandomRectangle (FoxDraw foxDraw, int startX, int startY, int width, int height, Color color)
        {
            foxDraw.SetFillColor(color);
            foxDraw.DrawRectangle(startX, startY, width, height);
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}