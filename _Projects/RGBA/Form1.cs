using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RGBA
{
    public partial class frmRGBA : Form
    {
        //число кружков:
        const int NUM_CIRCLE= 3;
        //массив кружков:
        Rectangle[] rect= new Rectangle[NUM_CIRCLE];
        //их цвета:
        Color[] clr= new Color[NUM_CIRCLE];
        //и диаметр:
        int diameter = 160;
        //индекс перетаскиваемого кружка:
        int dragCircle=NUM_CIRCLE-1;

        //флаг перетаскивания:
        bool flgMove = false;
        Point pt;

        public frmRGBA()
        {
            InitializeComponent();
            //начальные значения свойств кружков:
            rect[0].X = 0;
            rect[0].Y = 0;
            rect[0].Width = diameter;
            rect[0].Height = diameter;
            clr[0] = Color.Red;
            rect[1].X = 55;
            rect[1].Y = 55;
            rect[1].Width = diameter;
            rect[1].Height = diameter;
            clr[1] = Color.Green;
            rect[2].X = 111;
            rect[2].Y = 111;
            rect[2].Width = diameter;
            rect[2].Height = diameter;
            clr[2] = Color.Blue;
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
          clr[0]= Color.FromArgb(r, 0, 0);
          clr[1]= Color.FromArgb(0, g, 0);
          clr[2]= Color.FromArgb(0, 0, b);
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
            int a= hsbA.Value;
            Color color;
            SolidBrush brush = new SolidBrush(Color.White);

            for (int i = 0; i < NUM_CIRCLE; ++i)
            {
              if (i == dragCircle) continue;
              color = Color.FromArgb(a, clr[i]);
              brush = new SolidBrush(color);
              g.FillEllipse(brush, rect[i]);
            }

            //передвигаемый кружок:
            color = Color.FromArgb(a, clr[dragCircle]);
            brush = new SolidBrush(color);
            g.FillEllipse(brush, rect[dragCircle]);
          
            brush.Dispose();
        }

        //НАЖИМАЕМ ЛЕВУЮ КНОПКУ МЫШКИ
        private void frmRGBA_MouseDown(object sender, MouseEventArgs e)
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
                int centerX = rect[i].X + diameter / 2;
                int centerY = rect[i].Y + diameter / 2;
                int dist = (centerX - e.X) * (centerX - e.X) + (centerY - e.Y) * (centerY - e.Y);
                //на кружке:
                if ((dist < diameter * diameter / 4) && (dist < minDist))
                {
                    n = i;
                    minDist = dist;
                }
            }
            if (n > -1)
            {
                dragCircle = n;
                this.Refresh();
            }
        }

        //ПЕРЕМЕЩАЕМ КРУЖОК МЫШКОЙ
        private void frmRGBA_MouseMove(object sender, MouseEventArgs e)
        {
          if(flgMove)
          {
            int newX= rect[dragCircle].X + (Cursor.Position.X - pt.X);
            int newY= rect[dragCircle].Y + (Cursor.Position.Y - pt.Y);
            rect[dragCircle].X= newX;
            rect[dragCircle].Y= newY;
            //выводим координаты метки в заголовке формы:
            this.Text= rect[dragCircle].Location.ToString();
            //запоминаем новые координаты курсора:
            pt= Cursor.Position;

            this.Refresh(); 
          }
        }

        //ОТПУСКАЕМ КНОПКУ МЫШКИ
        private void frmRGBA_MouseUp(object sender, MouseEventArgs e)
        {
            flgMove= false;
            this.Cursor= Cursors.Default;
        }
    }
}

