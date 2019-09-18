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

            // Draw a box that has different colored lines on each edge.

            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(25, 25, 100, 25);

            foxDraw.SetStrokeColor(Colors.Blue);
            foxDraw.DrawLine(25, 100, 100, 100);

            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(25, 25, 25, 100);

            foxDraw.SetStrokeColor(Colors.Yellow);
            foxDraw.DrawLine(100, 25, 100, 100);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}