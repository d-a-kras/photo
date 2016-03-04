using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Случайные_линии
{
    public partial class frmLines : Form
    {
        int width;
        int height;
        int penWidth = 2;
        Pen pen;
        Random rand= new Random();

        public frmLines()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, penWidth);
            width= this.Width;
            height= this.Height;
        }


        private void btnDraw_Click(object sender, EventArgs e)
        {
           draw();
        }

        private void draw()
        {
            width = this.Width;
            height = this.Height;
            Graphics gr = this.CreateGraphics();
            //чертим цветные линии:
            for (int i = 0; i < 100; ++i)
            {
                //задаем случайные координаты начала и конца линии -->
                //координаты первой точки:
                int x1 = rand.Next(0, width - penWidth / 2 - 1);
                int y1 = rand.Next(0, height - penWidth / 2 - 1);
                // координаты второй точки:
                int x2 = rand.Next(0, width - penWidth / 2 - 1);
                int y2 = rand.Next(0, height - penWidth / 2 - 1);
                //выбираем случайный цвет линии:
                Color clr = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                pen.Color = clr;
                //чертим линию:
                gr.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           draw();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            gr.Clear(Color.Black);
        }

    }
}
