using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Doom5
{
    class MainWindow : Form
    {
        Bitmap bmp = new Bitmap(640, 480);

        public MainWindow()
        {

            this.BackgroundImage = bmp;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
