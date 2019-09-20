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

            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).

            double maxSize = canvas.Height;
            Color[] colors = { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet};            

            for (int i = 0; i < colors.Length; i++)
            {
                CenteredRainbow(foxDraw, maxSize, colors[i]);
                maxSize-=15;
            }

        }

        public static void CenteredRainbow(FoxDraw foxDraw, double size, Color color)
        {
            double center = (100 / 2) - (size / 2);
            foxDraw.SetStrokeThicknes(0);
            foxDraw.SetFillColor(color);
            foxDraw.DrawRectangle(center, center, size, size);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}