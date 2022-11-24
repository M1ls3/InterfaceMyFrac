using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Rhomb : Figure
    {
        private int diagonal_a, diagonal_b;
        public Rhomb(int x, int y, int diagonal_a, int diagonal_b)
        {
            this.x = x;
            this.y = y;
            this.diagonal_a = diagonal_a;
            this.diagonal_b = diagonal_b;

        }
        private Point[] GetCurrPoints()
        {
            return new Point[]
            {
                new Point(this.x+(diagonal_a/2),this.y),
                new Point(this.x-(diagonal_a/2),this.y),
                new Point(this.x, this.y-(diagonal_b/2)),
                new Point(this.x, this.y+(diagonal_b/2)),
                new Point(this.x+(diagonal_a/2),this.y),
                new Point(this.x, this.y-(diagonal_b/2)),
                new Point(this.x, this.y+(diagonal_b/2)),
                new Point(this.x-(diagonal_a/2),this.y),

            };
        }
        public override void DrawBlack(PictureBox pic, Bitmap bitmap)
        {
            Graphics gr = Graphics.FromImage(bitmap);  
            gr.DrawLines(Pens.Black, GetCurrPoints());
            pic.Image = bitmap;
        }
        public override void HideDrawingBackGround(Bitmap bitmap)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.Clear(Color.White);
        }

    }
}
