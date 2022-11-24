using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Circle : Figure
    {
        private int radius;
        public Circle(int x, int y, int radius)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack(PictureBox pic, Bitmap bitmap)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Black, 50);
            gr.DrawEllipse(pen, this.x - (this.radius / 2), this.y - (this.radius / 2), this.radius, this.radius);
            pic.Image = bitmap;
        }
        public override void HideDrawingBackGround(Bitmap bitmap)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.Clear(Color.White);
        }
    }
}
