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

            double halfHeight = canvas.Height / 2;
            double halfWidth = canvas.Width / 2;

            Color starColor = Colors.CadetBlue;

            FancyLineThing(foxDraw, canvas, 20, starColor, 0, 0, halfHeight, "top right");
            FancyLineThing(foxDraw, canvas, 20, starColor, halfWidth, 0, halfHeight, "top left");
            FancyLineThing(foxDraw, canvas, 20, starColor, 0, halfHeight, halfHeight, "bottom right");
            FancyLineThing(foxDraw, canvas, 20, starColor, halfHeight, halfHeight, halfHeight, "bottom left");

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