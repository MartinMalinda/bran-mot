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

            double yPos = 24;
            double xPos = (canvas.Width / 2) - 12;

            for (int rows = 1; rows <= 14; rows++)
            {
                if (rows <= 4)
                {
                    for (int cols = 1; cols <= rows; cols++)
                    {
                        DrawHexTop(foxDraw, xPos, yPos);
                        xPos += 36;
                    }
                    xPos = ((canvas.Width / 2) - 12) - (rows * 18);
                }
                else if (rows >= 5 && rows <= 10)
                {
                    xPos = ((canvas.Width / 2) - 12) - 54;
                    for (int cols = 1; cols <= 4; cols++)
                    {
                        if(rows %2 == 0)
                        {
                            DrawHexTop(foxDraw, xPos, yPos);
                            xPos += 36;
                        }
                        else
                        {
                            DrawHexBottom(foxDraw, xPos, yPos);
                            xPos += 36;
                        }
                    }
                    //xPos = ((canvas.Width / 2) - 12) - 54;
                }
                else 
                {
                    xPos = ((canvas.Width / 2) - 12) - 54;
                    for (int cols = 4; cols >= 1; cols--)
                    {
                        DrawHexBottom(foxDraw, xPos, yPos);
                        xPos += 36;
                    }
                }
                yPos += 12;
            }
                
        

            //draw rows
            //for (int rows = 1; rows <= 4; rows++)
            //{
            //    for (int cols = rows; cols > 0; cols--)
            //    {
            //        DrawHexTop(foxDraw, xPos, yPos);
            //        xPos += 36;
            //    }
            //    xPos = ((canvas.Width / 2) - 12) -(rows * 18);
            //    yPos += 12;
            //}
            //xPos = ((canvas.Width / 2) - 12) - (3 * 18);
            //for (int rows = 5; rows < 12; rows++)
            //{
            //    for (int cols = 4; cols > 0; cols--)
            //    {
            //        if (rows % 2 == 0)
            //        {
            //            DrawHexTop(foxDraw, xPos, yPos);
            //            xPos += 36;
            //        }
            //        else
            //        {
            //            DrawHexBottom(foxDraw, xPos, yPos);
            //            xPos += 36;
            //        }
            //    }
            //    xPos = ((canvas.Width / 2) - 12) - (3 * 18);
            //    yPos += 12;
            //}
            //xPos = ((canvas.Width / 2) - 12) - (2 * 18);
            //for (int rows = 14; rows < 17; rows++)
            //{
            //    for (int columns = 17-rows; columns > 0; columns--)
            //    {
            //        DrawHexBottom(foxDraw, xPos, yPos);
            //        xPos += 36;
            //    }
            //    xPos = ((canvas.Width / 2) - 12) + ((17-rows) * 18);
            //    yPos += 12;
            //}


        }
        public void DrawHexTop (FoxDraw foxDraw, double originX, double originY)
        {
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(originX, originY + 12, originX + 6, originY);
            //foxDraw.DrawLine(originX + 6, originY, originX + 18, originY);
            foxDraw.DrawLine(originX + 18, originY, originX + 24, originY + 12);
        }
        public void DrawHexBottom(FoxDraw foxDraw, double originX, double originY)
        {
            foxDraw.SetStrokeColor(Colors.Blue);
            foxDraw.DrawLine(originX, originY, originX + 6, originY + 12);
            //foxDraw.DrawLine(originX + 6, originY + 12, originX + 18, originY + 12);
            foxDraw.DrawLine(originX + 18, originY+12, originX + 24, originY);
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}