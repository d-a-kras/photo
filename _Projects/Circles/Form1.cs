using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Circles
{
    public partial class frmCircles : Form
    {
        //число кружков:
        const int NUM_CIRCLE= 20;
        struct Circle
        {
            public Rectangle rect;
            public Color clr;
            public Circle(int left, int top, int diameter)
            {
                rect = new Rectangle(left,top,diameter, diameter);
                clr = Color.FromArgb(255,0,0,0);
            }
        }
        //массив кружков:
        Circle[] circ= new Circle[NUM_CIRCLE];
        //и диаметр:
        int diameter = 60;
        //индекс перетаскиваемого кружка:
        int dragCircle=NUM_CIRCLE-1;

        //флаг перетаскивания:
        bool flgMove = false;
        Point pt;

        public frmCircles()
        {
            InitializeComponent();
            //начальные значения свойств кружков:
            for (int i = 0; i < NUM_CIRCLE; ++i)
            {
              circ[i] = new Circle(i*10, i*10, diameter);
            }
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.frmCircles_MouseWheel);
        }
        private void frmCircles_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                ++circ[dragCircle].rect.Width;
            else
                --circ[dragCircle].rect.Width;
            circ[dragCircle].rect.Height=circ[dragCircle].rect.Width;
            this.Refresh();
        }


        private void hsbR_Scroll(object sender, ScrollEventArgs e)
        {
          setColor();
        }

        private void hsbG_Scroll(object sender, ScrollEventArgs e)
        {
          setColor();
        }
        private void hsbB_Scroll(object sender, ScrollEventArgs e)
        {
          setColor();
        }
        private void hsbA_Scroll(object sender, ScrollEventArgs e)
        {
          setColor();
        }
        void setColor(){
          int r = hsbR.Value;
          int g = hsbG.Value;
          int b = hsbB.Value;
          int a = hsbA.Value;
          lblR.Text= r.ToString();
          lblG.Text= g.ToString();
          lblB.Text= b.ToString();
          lblA.Text= a.ToString();
          circ[dragCircle].clr= Color.FromArgb(a,r, g, b);
          this.Refresh(); 
        }
        //Color getColor()
        //{
        //  int r = hsbR.Value;
        //  int g = hsbG.Value;
        //  int b = hsbB.Value;
        //  return Color.FromArgb(r, g, b);
        //}

        //РИСУЕМ КРУЖКИ
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.White);

            for (int i = 0; i < NUM_CIRCLE; ++i)
            {
              brush = new SolidBrush(circ[i].clr);
              g.FillEllipse(brush, circ[i].rect);
            }

            Pen pen = new Pen(Color.Fuchsia, 2);
            g.DrawEllipse(pen, circ[dragCircle].rect);
          
            brush.Dispose();
            pen.Dispose();
        }

        //НАЖИМАЕМ ЛЕВУЮ КНОПКУ МЫШКИ
        private void frmCircles_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor= Cursors.Hand;
            flgMove= true;
            pt= Cursor.Position;

            int n = -1;
            int minDist = 10000;
            //передвигаем кружок, на котором
            //нажата мышка:
            for (int i = 0; i < NUM_CIRCLE; ++i)
            {
                int centerX = circ[i].rect.X + circ[i].rect.Width / 2;
                int centerY = circ[i].rect.Y + circ[i].rect.Width / 2;
                int dist = (centerX - e.X) * (centerX - e.X) + (centerY - e.Y) * (centerY - e.Y);
                //на кружке:
                if ((dist < circ[i].rect.Width * circ[i].rect.Width / 4) && (dist < minDist))
                {
                    n = i;
                    minDist = dist;
                }
            }
            if (n > -1)
            {
                Circle c = circ[n];
                for (int i = n+1; i < NUM_CIRCLE; ++i)
                {
                    circ[i-1] = circ[i];
                }
                circ[NUM_CIRCLE-1] = c;
                dragCircle = NUM_CIRCLE-1;
                this.Refresh();
            }
        }

        //ПЕРЕМЕЩАЕМ КРУЖОК МЫШКОЙ
        private void frmCircles_MouseMove(object sender, MouseEventArgs e)
        {
          if(flgMove)
          {
            int newX= circ[dragCircle].rect.X + (Cursor.Position.X - pt.X);
            int newY= circ[dragCircle].rect.Y + (Cursor.Position.Y - pt.Y);
            circ[dragCircle].rect.X= newX;
            circ[dragCircle].rect.Y= newY;
            //выводим координаты метки в заголовке формы:
            this.Text= circ[dragCircle].rect.Location.ToString();
            //запоминаем новые координаты курсора:
            pt= Cursor.Position;

            this.Refresh(); 
          }
        }

        //ОТПУСКАЕМ КНОПКУ МЫШКИ
        private void frmCircles_MouseUp(object sender, MouseEventArgs e)
        {
            flgMove= false;
            this.Cursor= Cursors.Default;
        }

    }
}

