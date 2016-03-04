using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LineJoin
{
    public partial class frmLineJoin : Form
    {
        const int MAX_LINES = 15;
        Pen pen = new Pen(Color.Black, 12);
        Random rand = new Random();
        int width;
        int height;
        System.Drawing.Drawing2D.LineJoin lj = System.Drawing.Drawing2D.LineJoin.Bevel;
        //массив координат отрезков:
        Point[] pt = new Point[MAX_LINES];

        public frmLineJoin()
        {
            InitializeComponent();
            width = this.Width;
            height = this.Height;
            NewLines();
        }

        private void frnLineJoin_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = 
              System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(Color.Black);

            pen.LineJoin = lj;

            //выбираем случайный цвет линии:
            Color clr = Color.FromArgb(rand.Next(0, 255), 
                                       rand.Next(0, 255), 
                                       rand.Next(0, 255));
            pen.Color = clr;
            //чертим линии:
            e.Graphics.DrawLines(pen, pt);
        }

        private void btnBevel_Click(object sender, EventArgs e)
        {
            lj = System.Drawing.Drawing2D.LineJoin.Bevel; 
            this.Refresh();
        }

        private void btnMiter_Click(object sender, EventArgs e)
        {
            lj = System.Drawing.Drawing2D.LineJoin.Miter; 
            this.Refresh();
        }

        private void btnMiterClipped_Click(object sender, EventArgs e)
        {
            lj = System.Drawing.Drawing2D.LineJoin.MiterClipped; 
            this.Refresh();
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            lj = System.Drawing.Drawing2D.LineJoin.Round; 
            this.Refresh();
        }

        private void btnNewLines_Click(object sender, EventArgs e)
        {
            NewLines();
        }

        private void NewLines()
        {
            for (int i = 0; i < MAX_LINES; ++i)
                pt[i] = new Point(rand.Next(10, width - 20),
                                  rand.Next(0, height - 100));
            this.Refresh();
        }


    }
}


