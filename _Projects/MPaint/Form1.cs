using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using rv;

namespace MPaint
{
    public partial class frmMPaint : Form
    {
        public frmMPaint()
        {
            InitializeComponent();
        }

        private void btnMPaint_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 12; ++i)
            {
                //ширина:
                int width = 50 + rvColor.rand.Next(100);
                //высота:
                int height = 25 + rvColor.rand.Next(60);
                //случайный цвет:
                Color clr = rvColor.RandomColor();
                //выбираем случайные координаты:  
                int x = rvColor.rand.Next(btnMPaint.Width - width);
                int y = rvColor.rand.Next(btnMPaint.Height - height);
                //рисуем цветной прямоугольник:
                e.Graphics.DrawRectangle(new Pen(clr, 6.0f), x, y, width, height);
                this.Text = sender.ToString();
            }
        }

        private void frmMPaint_Paint(object sender, PaintEventArgs e)
        {
            btnMPaint_Paint(sender, e);
            //btnMPaint.Invalidate();
        }

        //ПЕРЕРИСОВЫВАЕМ БОЛЬШУЮ КНОПКУ
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnMPaint.Refresh();
        }

        private void btnInvalidate_Click(object sender, EventArgs e)
        {
            //btnMPaint.Invalidate(true);
            //btnMPaint.Invalidate();
            btnMPaint.Invalidate(new Rectangle(0,0,128,128));
            btnMPaint.Update();
        }
    }
}
