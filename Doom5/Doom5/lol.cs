using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Doom5
{
    class lol : Form
    {
        Bitmap bmp = new Bitmap(640, 480);

        public lol()
        {
            this.BackgroundImage = bmp;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
