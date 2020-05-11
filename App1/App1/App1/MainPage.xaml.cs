using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Handle_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            var canvas = e.Surface.Canvas;
            using (var paint = new SKPaint())
            {
                paint.Color = Color.Black.ToSKColor();
                paint.TextSize = 30;

                canvas.DrawText("I am text", 15, 15, paint);
            }
        }
    }
}
