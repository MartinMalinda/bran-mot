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

            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            //(canvas.Height/2) - (x[i]/2) true center

            int[] sizes = { 30, 50, 20 };
            Color[] colors = { Colors.Blue, Colors.Green, Colors.Red };

            for (int i = 0; i < 3; i++)
            {
                DrawSquaresInCenter(foxDraw, sizes[i], colors[i]);
            }

        }

        public static void DrawSquaresInCenter(FoxDraw foxDraw, int size, Color color)
        {
            double center= (100 / 2) - (size / 2);
            foxDraw.SetFillColor(Colors.Transparent);
            foxDraw.SetStrokeColor(color);
            foxDraw.SetStrokeThicknes(3);
            foxDraw.DrawRectangle(center, center, size, size);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}