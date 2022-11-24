using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Squere
        {
            Figure square = new Square(30, pictureBox2.Height / 2, 50);
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            square.MoveRight(pictureBox2, bitmap);
        }

        private void button2_Click(object sender, EventArgs e) // Circle
        {
            Figure circle = new Circle(50, pictureBox1.Height / 2, 50);
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            circle.MoveRight(pictureBox1, bitmap);
        }

        private void button3_Click(object sender, EventArgs e) // Rhomb
        {
            Figure rhomb = new Rhomb(30, pictureBox3.Height / 2, 70, 100);
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            rhomb.MoveRight(pictureBox3, bitmap);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
