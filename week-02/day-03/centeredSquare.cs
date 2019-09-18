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

            int squareWidth = 10;
            double squareOrigin = (canvas.Height / 2) - (squareWidth/2);

            // Draw a green 10x10 square to the canvas' center.

            foxDraw.SetFillColor(Colors.Black);
            foxDraw.DrawRectangle(squareOrigin, squareOrigin, squareWidth, squareWidth);
        }
        
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}