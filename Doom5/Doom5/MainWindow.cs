using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Doom5
{
    class MainWindow : Form
    {
        Bitmap bmp = new Bitmap(16, 12);
        Graphics g;

        public MainWindow()
        {
            bmp.SetPixel(1, 1, Color.Black);
            bmp.SetPixel(1, 11, Color.Black);
            bmp.SetPixel(7, 7, Color.Black);
            bmp.SetPixel(15, 11, Color.Black);
            bmp.SetPixel(15, 1, Color.Black);

            this.SuspendLayout();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.CenterToScreen();
            g = this.CreateGraphics();
            g.InterpolationMode = InterpolationMode.NearestNeighbor;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g.DrawImage(bmp, 0, 0, this.Width, this.Height);
        }
    }
}
