using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Square : Figure
    {
        private int side;
        public Square(int x, int y, int side)
        {
            this.side = side;
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack(PictureBox pic, Bitmap bitmap)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Black, 50);
            gr.DrawRectangle(pen, this.x - (this.side / 2), this.y - (this.side / 2), this.side, this.side);
            pic.Image = bitmap;
        }
        public override void HideDrawingBackGround(Bitmap bitmap)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.Clear(Color.White);
        }
    }
}
