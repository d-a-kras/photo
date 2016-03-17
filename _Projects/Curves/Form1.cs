using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using rv; //добавьте ссылку!
using System.Drawing.Drawing2D;

namespace Curves
{
    public partial class frmCurves : Form
    {
        //макс. число кружков:
        const int NUM_CIRCLES = 12;
        //диаметр кружков:
        const int diameter = 16;
        struct Circle
        {
            public Rectangle rect;
            public Color clr;
            public Circle(int left, int top)
            {
                rect = new Rectangle(left, top, diameter, diameter);
                clr = Color.FromArgb(200, rvColor.RandomColor());
            }
            public Point getCenter()
            {
                return new Point(rect.Left + diameter/2, 
                                 rect.Top + diameter/2);
            }
        }
        //массив кружков:
        Circle[] circ = new Circle[NUM_CIRCLES];

        //индекс перетаскиваемого кружка:
        int dragCircle = 0;
        //число кружков:
        int numCircles = 0;
        //флаг перетаскивания:
        bool flgMove = false;
        Point pt;
        //натяжение кривой:
        float tension = 0.50f;

        //КОНСТРУКТОР ФОРМЫ
        public frmCurves()
        {
            InitializeComponent();
            numCircles = 3;
            //создаем три точки:
            for (int i = 0; i < numCircles; ++i)
            {
                int x = 10 + rvColor.rand.Next(pbDraw.Width - 20);
                int y = 10 + rvColor.rand.Next(pbDraw.Height - 20);
                circ[i] = new Circle(x, y);
            }
        }

        //РИСУЕМ КРУЖКИ
        private void pbDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //рисуем качественно:
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            SolidBrush brush = new SolidBrush(Color.LightGray);
            Pen pen = new Pen(Color.Gray, 1);

            //рисуем линии между кружками:
            Point[] points= new Point[numCircles];
            for (int i = 0; i < numCircles; ++i)
            {
                points[i] = circ[i].getCenter();
            }  
            ////чертим кривую:
            //g.DrawLines(pen, points);
            //pen = new Pen(Color.Black, 2);
            //g.DrawCurve(pen, points, tension);
            
            ////чертим замкнутую кривую:
            //g.DrawPolygon(pen, points);
            //pen = new Pen(Color.Black, 2);
            //g.DrawClosedCurve(pen, points, tension, FillMode.Alternate);

            //рисуем замкнутую кривую:
            //g.FillClosedCurve(brush, points, FillMode.Alternate, tension);
            //brush = new SolidBrush(Color.LightBlue);
            g.FillClosedCurve(brush, points, FillMode.Winding, tension);
            pen = new Pen(Color.Black, 2);
            g.DrawPolygon(pen, points);

            //рисуем кружки:
            for (int i = 0; i < numCircles; ++i)
            {
                brush = new SolidBrush(circ[i].clr);
                g.FillEllipse(brush, circ[i].rect);
            }

            pen = new Pen(Color.Fuchsia, 2);
            g.DrawEllipse(pen, circ[dragCircle].rect);

            brush.Dispose();
            pen.Dispose();
        }

        //НАЖИМАЕМ ЛЕВУЮ КНОПКУ МЫШКИ
        private void pbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor= Cursors.Hand;
            flgMove= true;
            pt= Cursor.Position;

            int n = -1;
            int minDist = 10000;
            //мышка на кружке?
            for (int i = 0; i < numCircles; ++i)
            {
                int centerX = circ[i].getCenter().X;
                int centerY = circ[i].getCenter().Y;
                int dist = (centerX - e.X) * (centerX - e.X) + (centerY - e.Y) * (centerY - e.Y);
                //на кружке:
                if ((dist < circ[i].rect.Width * circ[i].rect.Width / 4) && (dist < minDist))
                {
                    n = i;
                    minDist = dist;
                }
            }
            //мышка на кружке -> передвигаем его:
            if (n > -1)
            {
                dragCircle = n;
                pbDraw.Invalidate();
            }
            //иначе добавляем новый кружок:
            else
            {
                if (numCircles < NUM_CIRCLES)
                {
                    ++numCircles;
                    int x = e.X;
                    int y = e.Y;
                    circ[numCircles-1] = new Circle(x, y);
                    dragCircle = numCircles-1;
                    pbDraw.Invalidate();
                }
            }
        }

        //ПЕРЕМЕЩАЕМ КРУЖОК МЫШКОЙ
        private void pbDraw_MouseMove(object sender, MouseEventArgs e)
        {
          if(flgMove)
          {
            int newX= circ[dragCircle].rect.X + (Cursor.Position.X - pt.X);
            int newY= circ[dragCircle].rect.Y + (Cursor.Position.Y - pt.Y);
            circ[dragCircle].rect.X= newX;
            circ[dragCircle].rect.Y= newY;
            //выводим координаты метки в заголовке формы:
            //this.Text= circ[dragCircle].rect.Location.ToString();
            //запоминаем новые координаты курсора:
            pt= Cursor.Position;
            pbDraw.Invalidate();
          }
        }
        //ОТПУСКАЕМ КНОПКУ МЫШКИ
        private void pbDraw_MouseUp(object sender, MouseEventArgs e)
        {
            flgMove= false;
            this.Cursor = Cursors.Default;
        }

        //ИЗМЕНЯЕМ НАТЯЖЕНИЕ КРИВОЙ
        private void tbTension_Scroll(object sender, EventArgs e)
        {
            tension = (float)tbTension.Value / 100;
            lblTension.Text = "Натяжение = " + tension.ToString("N2");
            pbDraw.Invalidate();
        }

        //СТИРАЕМ ЛИШНИЕ ТОЧКИ
        private void btnClear_Click(object sender, EventArgs e)
        {
            numCircles = 3;
            dragCircle = numCircles - 1;
            pbDraw.Invalidate();
        }

        



    }
}
