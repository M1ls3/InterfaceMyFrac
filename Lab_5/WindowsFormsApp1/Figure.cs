using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public abstract class Figure
    {
        protected int x, y;
        public abstract void DrawBlack(PictureBox pic, Bitmap bitmap);
        public abstract void HideDrawingBackGround(Bitmap bitmap);
        public void MoveRight(PictureBox pic, Bitmap bitmap)
        {
            Timer timer1 = new Timer();
            timer1.Interval = 15;
            timer1.Start();
            timer1.Tick += new EventHandler((o, ev) =>
            {
                HideDrawingBackGround(bitmap);
                this.x += 1;
                DrawBlack(pic, bitmap);
                if (this.x >= pic.Width - 50)
                {
                    timer1.Stop();
                    return;
                }
            });
        }
    }
}
