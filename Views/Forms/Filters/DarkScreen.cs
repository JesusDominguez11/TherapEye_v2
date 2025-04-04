using System.Drawing;
using System.Windows.Forms;

namespace Therapheye.Views.Forms.Filters
{
    class DarkScreen : ScreenFilter
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = Color.Black; // Se colorea todo el fondo del formulario de color negro
            this.Opacity = filterOpacity; // Se aplica la transparencia asginada al formulario
        }
    }
}
