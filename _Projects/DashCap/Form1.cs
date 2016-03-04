using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DashCap
{
    public partial class frmDashCap : Form
    {
        Font fnt= new Font("Arial", 14, FontStyle.Bold);
        Pen pen = new Pen(Color.Black, 24);

        public frmDashCap()
        {
            InitializeComponent();
        }


        private void frmDashStyle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            draw(e, 0,"Default");
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            draw(e, 4, "AntiAlias");
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            draw(e, 8,"HighQuality");
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            draw(e, 12,"HighSpeed");
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            draw(e, 16,"None");
        }

        private void draw(PaintEventArgs e, int n, string s)
        {
            int dy = 32;
            e.Graphics.DrawString(s, fnt, Brushes.Red, 10, n * dy);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            e.Graphics.DrawString("Flat", fnt, Brushes.Blue, 10, 30 + n * dy);
            pen.DashCap = System.Drawing.Drawing2D.DashCap.Flat;
            e.Graphics.DrawLine(pen, 150, 40 + n * dy, this.Width-20, 40 + n * dy);
            ++n;
            e.Graphics.DrawString("Round", fnt, Brushes.Blue, 10, 30 + n * dy);
            pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            e.Graphics.DrawLine(pen, 150, 40 + n * dy, this.Width-20, 40 + n * dy);
            ++n;
            e.Graphics.DrawString("Triangle", fnt, Brushes.Blue, 10, 30 + n * dy);
            pen.DashCap = System.Drawing.Drawing2D.DashCap.Triangle;
            e.Graphics.DrawLine(pen, 150, 40 + n * dy, this.Width-20, 40 + n * dy); 
        }
    }
}
