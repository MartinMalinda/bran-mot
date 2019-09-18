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

            canvas.Height = 500;//outputs double
            canvas.Width = 500;//outputs double

            //// Fill the canvas with a checkerboard pattern.

            //double columns = canvas.Width / 10;
            //double rows = canvas.Height / 10;
            double originX = 0;
            double originY = 0;
            double size = canvas.Width / 10;

            for (int i = 0; i < 10; i++)
            {
                //foxDraw.SetStrokeThicknes(0);
                for (int cols = 0; cols < 10; cols+=2)
                {
                    if (i%2 == 0)
                    {
                        foxDraw.SetFillColor(Colors.Black);
                        foxDraw.DrawRectangle(originX, originY, size, size);
                        originX = originX + size * 2;
                    }
                    else
                    {
                        foxDraw.SetFillColor(Colors.Black);
                        foxDraw.DrawRectangle(originX+size, originY, size, size);
                        originX = originX + size * 2;
                    }
                }
                originX = 0;
                originY = originY + size;
            }

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}