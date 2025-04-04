using System.Drawing;
using System.Windows.Forms;

namespace Therapheye.Views.Forms.Filters
{
    class HexagonalStenopeic : ScreenFilter
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = filterColor; // Se colorea todo el fondo del formulario de color negro
            this.Opacity = filterOpacity; // Se aplica la transparencia asginada al formulario

            //// Dibujar las elipses magenta en el formulario
            //for (int x = 0; x < this.ClientSize.Width; x += apertureSpacing)
            //{
            //    for (int y = 0; y < this.ClientSize.Height; y += apertureSpacing)
            //    {
            //        RectangleF apertureRect = new RectangleF(x - (apertureSize / 2), y - (apertureSize / 2), apertureSize, apertureSize);
            //        e.Graphics.FillEllipse(Brushes.Magenta, apertureRect);
            //    }
            //}

            // Dibujar los hexágonos magenta en el formulario
            for (int x = 0; x < this.ClientSize.Width; x += apertureSpacing)
            {
                for (int y = 0; y < this.ClientSize.Height; y += apertureSpacing)
                {
                    PointF point1 = new PointF(x, y - (apertureSize / 2));
                    PointF point2 = new PointF(x + (apertureSize / 2), y - (apertureSize / 4));
                    PointF point3 = new PointF(x + (apertureSize / 2), y + (apertureSize / 4));
                    PointF point4 = new PointF(x, y + (apertureSize / 2));
                    PointF point5 = new PointF(x - (apertureSize / 2), y + (apertureSize / 4));
                    PointF point6 = new PointF(x - (apertureSize / 2), y - (apertureSize / 4));
                    PointF[] points = { point1, point2, point3, point4, point5, point6 };
                    e.Graphics.FillPolygon(Brushes.Magenta, points);
                }
            }
        }
    }
}
