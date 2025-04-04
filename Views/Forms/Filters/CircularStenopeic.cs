using System.Drawing;
using System.Windows.Forms;

namespace Therapheye.Views.Forms
{
    class CircularStenopeic : ScreenFilter
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            //this.BackColor = Color.Black; // Se colorea todo el fondo del formulario de color negro //linea del color por defecto
            this.BackColor = filterColor;
            this.Opacity = filterOpacity; // Se aplica la transparencia asginada al formulario

            // Dibujar las elipses magenta en el formulario
            for (int x = 0; x < this.ClientSize.Width; x += apertureSpacing)
            {
                for (int y = 0; y < this.ClientSize.Height; y += apertureSpacing)
                {
                    RectangleF apertureRect = new RectangleF(x - (apertureSize / 2), y - (apertureSize / 2), apertureSize, apertureSize);
                    e.Graphics.FillEllipse(Brushes.Magenta, apertureRect);
                }
            }
        }
    }
}
