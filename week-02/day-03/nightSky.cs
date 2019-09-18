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

            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)

            Random randomNumber = new Random();

            //set sky
            foxDraw.SetBackgroundColor(Colors.Black);
            //generate random number of loops
            int loops = randomNumber.Next(100, 200);

            for (int i = 0; i < loops; i++)
            {
                //generate random star positions
                int originX = randomNumber.Next(0, 500);
                int originY = randomNumber.Next(0, 500);

                //generate random star sizes
                int size = randomNumber.Next(1, 5);

                //array of all grays
                Color[] grays = { Colors.Gray, Colors.DarkGray, Colors.DarkSlateGray, Colors.DimGray, Colors.LightGray, Colors.LightSlateGray, Colors.SlateGray };

                //Choose a random gray
                Color shadeOfGray = grays[randomNumber.Next(0, grays.Length)];

                foxDraw.SetFillColor(shadeOfGray);
                foxDraw.DrawRectangle(originX, originY, size, size);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}