using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
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

            double quarters = canvas.Width / 4;
            double eighths = canvas.Width / 8;

            for (double rows = 0; rows < canvas.Height; rows+=eighths)
            {
                for (double i = 0; i < canvas.Width; i += eighths)
                {
                    FancyLineThing(foxDraw, canvas, 10, Colors.Green, i, rows, eighths, "top left");
                    FancyLineThing(foxDraw, canvas, 10, Colors.Purple, i, rows, eighths, "bottom right");
                }
            }
           

        }
        public void FancyLineThing(FoxDraw foxDraw, Canvas canvas, int spaceBetween, Color color, double originX, double originY , double size, string direction)
        {
            foxDraw.SetStrokeColor(color);
            for (int lines = 0; lines <= size; lines += spaceBetween)
            {
                switch (direction)
                {
                    case "top left":
                        foxDraw.DrawLine(originX, originY + lines, originX + lines, size + originY);
                        break;
                    case "top right":
                        foxDraw.DrawLine(size + originX, lines + originY, size - lines + originX, size + originY); ;
                        break;
                    case "bottom left":
                        foxDraw.DrawLine(originX, size - lines + originY, lines + originX, originY);
                        break;
                    case "bottom right":
                        foxDraw.DrawLine(size + originX, size - lines + originY, size - lines + originX, originY);
                        break;
                }
            }
        }
        
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}