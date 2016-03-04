using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace PenBrush
{
    public partial class frmPenBrush : Form
    {
        public frmPenBrush()
        {
            InitializeComponent();
        }

        private void frmPenBrush_Paint(object sender, PaintEventArgs e)
        {
            //толщина линий:
            int penWidth = 40;
            e.Graphics.SmoothingMode =
              System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //цвета градиентной кисти:
            Color clr1= Color.Yellow;
            Color clr2= Color.Red;
            
            //длина линии:
            float len= 260.0f;
            //отступ начала линии от центра формы:
            float r = 48.0f;
            //чертим 8 стрелок через 45 градусов:
            for (int i = 0; i < 8; ++i)
            {
                double angle = Math.PI/4*i;
                double x1= this.ClientRectangle.Width/2+r* Math.Cos(angle);
                double y1= this.ClientRectangle.Height/2+r* Math.Sin(angle);
                double x2= x1+len* Math.Cos(angle);
                double y2= y1+len* Math.Sin(angle);
                PointF pt1 = new PointF((float)x1, (float)y1);
                PointF pt2 = new PointF((float)x2+1, (float)y2+1);
                LinearGradientBrush lgb = 
                    new LinearGradientBrush (pt1, pt2, clr1, clr2);
                Pen pen = new Pen(lgb, penWidth);
                pen.EndCap = LineCap.ArrowAnchor;
                e.Graphics.DrawLine(pen, (float)x1,(float)y1,(float)x2,(float)y2);               
            }
        }
    }
}
