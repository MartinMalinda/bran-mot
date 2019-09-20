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

            FancyLineThing(foxDraw, canvas, 20, Colors.Green, "top left");
            FancyLineThing(foxDraw, canvas, 20, Colors.Purple, "bottom right");
        }
        public void FancyLineThing(FoxDraw foxDraw, Canvas canvas, int spaceBetween, Color color, string origin)
        {
            int incrementer = spaceBetween;
            foxDraw.SetStrokeColor(color);
            for (int lines = 0; lines <= canvas.Width; lines += spaceBetween)
            {
                switch (origin)
                {
                    case "top left":
                        foxDraw.DrawLine(0, lines, lines, canvas.Width);
                        break;
                    case "top right":
                        foxDraw.DrawLine(canvas.Width, lines, canvas.Width - lines, canvas.Height); ;
                        break;
                    case "bottom left":
                        foxDraw.DrawLine(0, canvas.Height - lines, lines, 0);
                        break;
                    case "bottom right":
                        foxDraw.DrawLine(canvas.Width, canvas.Height - lines, canvas.Width - lines, 0);
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