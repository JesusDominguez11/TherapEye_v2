using System.Drawing;
using System.Windows.Forms;

namespace Therapheye.Views.Forms.Filters
{
    class BlueLight : ScreenFilter
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            //this.BackColor = Color.Black; // Se colorea todo el fondo del formulario de color negro
            this.BackColor = Color.FromArgb(255, 255, 80, 0);
            //this.BackColor = Color.DarkOrange;
            this.Opacity = filterOpacity; // Se aplica la transparencia asginada al formulario
        }
    }
}
