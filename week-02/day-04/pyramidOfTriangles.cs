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

            canvas.Width = 500;
            canvas.Height = 500;

            double triangleSize = 20;

            double center = canvas.Width / 2;


            for (double i = 0; i <= canvas.Height; i+=triangleSize)
            {
                foxDraw.SetStrokeColor(Colors.Black);
                foxDraw.SetStrokeThicknes(1);
                //lines point to right bottom
                foxDraw.DrawLine(center - i/2, i, canvas.Width - i, canvas.Height);
                //lines point to left bottom
                foxDraw.DrawLine(center + i / 2, i, 0 + i, canvas.Height);
                //horizontal Lines
                foxDraw.DrawLine(center - (i / 2), i, center + (i / 2), i);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}