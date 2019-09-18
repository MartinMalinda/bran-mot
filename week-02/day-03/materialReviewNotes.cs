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

            //foxDraw.DrawLine(50, 50, 100, 100);
            //var values = new List<int>() { 100, 150, 50 };

            //foreach (var value in values)
            //{
            //    foxDraw.DrawLine(50, 50, 100, 100);
            //};
            ////colors.[built in color]
            //var dict = new Dictionary<Color, List<int>>();
            //dict.Add(Colors.Pink, new List<int> { 50, 100 }); // 50x100 rectangle, with color of pink
            //dict.Add(Colors.Green, new List<int> { 300, 350 }); // 300x250 rectangle, with color of green

            //var position = 50; // set initial position of the elements that are rendered below

            //foreach (var pair in dict)
            //{
            //    foxDraw.SetFillColor(pair.Key);//set all fills to the color
            //    foreach (var coord in pair.Value)//loop through list to get the items from the list
            //    {
            //        foxDraw.DrawRectangle(position, position, coord, coord);
            //    }
            //    position += 50;

            //}

            //draw this tunnel thing
            
            foxDraw.SetStrokeColor(Colors.Black);//set stroke color
            var fillColor = Colors.White;// set alternate fill color
            for (int i = 0; i < 400; i+=20)//start it at 400
            {
                var size = 400 - i*2;//calculate the initial size, multiply by two because we need to reduce it in both dimensions


                if (i % 40 == 0)
                {
                    fillColor = Colors.Black;
                }
                else
                {
                    fillColor = Colors.White;
                }
                //Also the same thing as above: fillcolor = i %40 == 0 ? fillcolor = Colors.Black : Colors.White;

                foxDraw.SetFillColor(fillColor);//set color of the shape
                foxDraw.DrawRectangle(i, i, size, size);
            }
            foxDraw.DrawLine(0, 0, 400, 400);
            foxDraw.DrawLine(400, 0, 0, 400);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}