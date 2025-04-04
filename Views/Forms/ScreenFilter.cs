using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Therapheye.Views.Forms
{
    public abstract partial class ScreenFilter : Form
    {
        //mejores valores: apertureSize = 10; apertureSpacing = 40; filterOpacity = 0.3;
        public int apertureSize = 50;
        public int apertureSpacing = 100;
        public double filterOpacity = 0.1;
        public Color filterColor = Color.Black;

        // Se define la constante WS_EX_TRANSPARENT con el valor 0x20, que se utiliza para hacer que el formulario sea transparente al clickear en él
        private const int WS_EX_TRANSPARENT = 0x20;

        // Se importa la función SetWindowLong de la librería user32.dll para cambiar los atributos de la ventana del formulario
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        // Se importa la función GetWindowLong de la librería user32.dll para obtener los atributos de la ventana del formulario
        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        public ScreenFilter()
        {
            InitializeComponent();

            // Habilitar la transparencia de la ventana
            this.BackColor = Color.Magenta; // Establecer el color de fondo del formulario a magenta
            this.TransparencyKey = Color.Magenta; // Establecer el color de transparencia a magenta

            this.WindowState = FormWindowState.Maximized; // Maximiza el formulario al iniciarse
            this.FormBorderStyle = FormBorderStyle.None; // Establece el estilo del borde del formulario como "None" para eliminarlo
            this.TopMost = true; // Establece el formulario como "TopMost" para que esté siempre encima de otras ventanas
            this.ShowInTaskbar = false;

            // Establece el estilo de la ventana como "Transparent" para que sea transparente
            // Esto se hace utilizando la función SetWindowLong y GetWindowLong para modificar el estilo de la ventana
            SetWindowLong(this.Handle, -20, GetWindowLong(this.Handle, -20) | WS_EX_TRANSPARENT);
        }

        protected abstract override void OnPaint(PaintEventArgs e);



        //{
            ////this.BackColor = Color.Black; // Se colorea todo el fondo del formulario de color negro //linea del color por defecto
            //this.BackColor = filterColor;
            //this.Opacity = filterOpacity; // Se aplica la transparencia asginada al formulario

            //// Dibujar las elipses magenta en el formulario
            //for (int x = 0; x < this.ClientSize.Width; x += apertureSpacing)
            //{
            //    for (int y = 0; y < this.ClientSize.Height; y += apertureSpacing)
            //    {
            //        RectangleF apertureRect = new RectangleF(x - (apertureSize / 2), y - (apertureSize / 2), apertureSize, apertureSize);
            //        e.Graphics.FillEllipse(Brushes.Magenta, apertureRect);
            //    }
            //}
        //}
    }
}
