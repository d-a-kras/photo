﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace Стрелки
{
    public partial class frmArrows : Form
    {
        //высота горизонта:
        const int GROUND_LEVEL = 560;
        //удаление стрелки:
        const int X_START = 16;
        //ускорение свободного падения:
        const double g = 9.8;

        //флаг перетаскивания:
        bool flgMove = false;
        Point pt;

        //флаг выстрела:
        bool flgShot = false;
        //флаг попадания в цель:
        bool flgGoal = false;

        //координаты траектории стрелы:
        List<PointF> begArrow = new List<PointF>();
        List<PointF> endArrow = new List<PointF>();
        //текущая скорость стрелы:
        List<double> speed = new List<double>();
        //текущий угол стрелы:
        List<double> angle = new List<double>();

        //текущий индекс в списках:
        int id = 0;
        //индекс попадания:
        int idGoal = 0;

        //Мишень
        struct Box
        {
          //координаты ЛВ угла:
          public PointF coords;
          //размеры:
          public Size size; 
          //перо и кисть для рисования:
          public Pen pen;
          public Brush br;

          //габаритный прямоугольник мишени:
          public RectangleF getRect()
          {
              return new RectangleF(coords.X,
                                   coords.Y,
                                   size.Width,
                                   size.Height);
          }
          //рисуем блок:
          public void draw(Graphics g)
          {
              g.FillRectangle(br, getRect());
              g.DrawRectangle(pen, getRect().Left,
                  getRect().Top,
                  getRect().Width,
                  getRect().Height);
          }
        }

        //стрелка:
        struct Arrow
        {
          //координаты центра круга:
          public PointF coordsCircle;
          public int rCircle;
          //перо и кисть для стрелки:
          public Pen pen;
          public Brush br;

          //угол наклона стрелки к горизонту
          //в градусах:
          public double angle;
          //длина стрелки:
          public int len;
          //скорость стрелки:
          public double velocity;
          //координаты стрелки:
          public PointF coords;

          //прямоугольник для рисования кружка:
          public RectangleF getRect()
          {
              return new RectangleF(coordsCircle.X - rCircle,
                                   coordsCircle.Y - rCircle,
                                   2 * rCircle,
                                   2 * rCircle);
          }
          //печатаем в метке высоту кружка:
          public void printH(Label lbl)
          {
              lbl.Text = "Высота = " + getH().ToString();
          }
          public float getH()
          {
              return GROUND_LEVEL - coordsCircle.Y;
          }

          //печатаем угол наклона стрелки:
          public void printAngle(Label lbl)
          {
              lbl.Text = "Угол = " + angle.ToString();
          }
          public double getAngleRad()
          {
              return angle * Math.PI / 180;
          }

          //печатаем начальную скорость:
          public void printV(Label lbl)
          {
              lbl.Text = "Скорость = " + velocity.ToString();
          }

          //печатаем начальное удаление:
          public void printDist(Label lbl)
          {
              lbl.Text = "Дистанция = " + (coordsCircle.X- X_START).ToString();
          }

          //рисуем кружок:
          public void drawCircle(Graphics g)
          {
              g.FillEllipse(br, getRect());
              g.DrawEllipse(new Pen(Color.DarkGreen, 2.0f), getRect());
          }

          //рисуем стрелку:
          public void drawArrow(Graphics g)
          {
              float xEnd = (float)(coords.X + len * Math.Cos(getAngleRad()));
              float yEnd = (float)(coords.Y - len * Math.Sin(getAngleRad()));
              PointF end = new PointF(xEnd, yEnd);
              g.DrawLine(pen, coords, end);
             
          }
        }

        Arrow arrow;
        Box box;

        //КОНСТРУКТОР ФОРМЫ
        public frmArrows()
        {
            InitializeComponent();
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.frmArrows_MouseWheel);

            //создаем стрелку:
            arrow.coordsCircle.X = arrow.coords.X = X_START;
            arrow.coordsCircle.Y = arrow.coords.Y  = 100;

            arrow.rCircle = 8;
            arrow.pen = new Pen(Color.Green, 4.0f);
            arrow.pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            arrow.br = new SolidBrush(Color.LightGreen);
            arrow.angle = 0;
            arrow.len = 48;
            arrow.velocity = 50;

            arrow.printH(lblH);
            arrow.printAngle(lblAngle);
            arrow.printV(lblV);
            arrow.printDist(lblDist);

            //создаем мишень:
            createBox();
        }

        void createBox()
        {
            Random rand = new Random();
            //ширина:
            int w = 16;
            //высота:
            int h = 48 + rand.Next(0,32);
            //размеры:
            box.size = new Size(w,h);
            //случайные координаты:
            int x= 400 + rand.Next(0, ClientSize.Width-400-w-8);
            int y= rand.Next(GROUND_LEVEL - h - 300, GROUND_LEVEL - h);
            box.coords = new Point(x,y);
            //перо и кисть:
            box.pen = new Pen(Color.Red, 2.0f);
            box.br = new SolidBrush(Color.Yellow);
        }

        ////НАЖИМАЕМ КЛАВИШУ
        //private void frmArrows_KeyDown(object sender, KeyEventArgs e)
        //{
        //    //if (sender.GetType() != (Control)frmArrows) return;
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Up:
        //            if (arrow.coords.Y > 16) --arrow.coords.Y;
        //        break;
        //       case Keys.Down:
        //            if (arrow.coords.Y < GROUND_LEVEL-1) ++arrow.coords.Y;
        //        break;
        //       case Keys.Left:
        //            if (arrow.angle > -90) --arrow.angle;
        //        break;
        //       case Keys.Right:
        //            if (arrow.angle < 90) ++arrow.angle;
        //        break;

        //    }
        //        this.Invalidate();
        //        arrow.printH(lblH);
        //        arrow.printAngle(lblAngle);
        //}


        //РИСУЕМ СЦЕНУ
        private void frmArrows_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //рисуем качественно:
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //рисуем линию земли:
            Pen pen = new Pen(Color.Black, 4.0f);
            g.DrawLine(pen, 0, GROUND_LEVEL, 800, GROUND_LEVEL);

            //рисуем мишень:
            box.draw(g);

            //рисуем прицельную траекторию:
            if (!flgShot)
            {
                //вычисляем траекторию:
                createTrajectory();

                //рисуем траекторию на экране,
                //если включен прицел:
                if (chPrizel.Checked)
                {
                    PointF[] pts = new PointF[begArrow.Count];
                    begArrow.CopyTo(pts);
                    //если попали в цель,
                    if (flgGoal)
                        //цвет траектории красный:
                        pen = new Pen(Color.Red, 2.0f);
                    else
                        //мимо - зеленый:
                        pen = new Pen(Color.Green, 2.0f);

                    g.DrawCurve(pen, pts);
                }
            }

            //рисуем кружок:
            arrow.drawCircle(g);
            //рисуем стрелку -->
            //выстрела нет:
            if (!flgShot) arrow.drawArrow(g);
            //выстрел произведен:
            else
            {
                PointF begPt = begArrow.ElementAt(id);
                PointF endPt =  endArrow.ElementAt(id);
                g.DrawLine(arrow.pen, begPt, endPt);
            }
            pen.Dispose();
        }





        ////РИСУЕМ ТРАЕКТОРИЮ
        //public void drawTrajectory(Graphics gr)
        //{
        //    float x = arrow.coordsCircle.X;
        //    float y = arrow.coordsCircle.Y;
        //    gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        //    double dt = 1 / arrow.velocity; // 0.1;
        //    //составляющие скорости:
        //    double vx = arrow.velocity * Math.Cos(arrow.getAngleRad());
        //    double vy = -arrow.velocity * Math.Sin(arrow.getAngleRad());

        //    double ay = g;
        //    while (GROUND_LEVEL - y > 0)
        //    //while (arrow.getH() > 0)
        //    {
        //        vy += ay * dt;
        //        x += (float)(vx * dt);
        //        y += (float)(vy * dt);
        //        //lblH.Text = (GROUND_LEVEL - y).ToString();
        //        //Application.DoEvents();
        //        //gr.DrawEllipse(arrow.pen, x - 1, y - 1, 2, 2);
        //        //gr.DrawEllipse(arrow.pen, x, y, 1, 1);
        //        //проверяем поражение мишени:
        //        RectangleF r = box.getRect();
        //        if(r.Contains(x,y)) //попали
        //           gr.DrawEllipse(new Pen(Color.Red, 2.0f), x, y, 1, 1);
        //        else //мимо:
        //           gr.DrawEllipse(arrow.pen, x, y, 1, 1);

        //        //Thread.Sleep(50);
        //    }


        //    //float xEnd = (float)(coords.X + len * Math.Cos(getAngleRad()));
        //    //float yEnd = (float)(coords.Y - len * Math.Sin(getAngleRad()));
        //    //PointF end = new PointF(xEnd, yEnd);

        //}

        //СОЗДАЕМ ТРАЕКТОРИЮ ПОЛЕТА СТРЕЛЫ
        public void createTrajectory()
        {
            //начальные координаты стрелки:
            float x = arrow.coords.X;
            float y = arrow.coords.Y;
            //приращение времени:
            double dt = 10 / arrow.velocity;
            //составляющие скорости:
            double vx = arrow.velocity * Math.Cos(arrow.getAngleRad());
            double vy = -arrow.velocity * Math.Sin(arrow.getAngleRad());
            //ускорение:
            double ay = g;

            //не попали в цель:
            flgGoal = false;
            idGoal = 0;
            //очищаем списки:
            begArrow.Clear();
            endArrow.Clear();
            speed.Clear();
            angle.Clear();
            
            //заносим в списки начальные условия:
            begArrow.Add(new PointF(x,y));
            begArrow.Add(new PointF(x,y));
            float xEnd = (float)(arrow.coords.X + arrow.len 
                                 * Math.Cos(arrow.getAngleRad()));
            float yEnd = (float)(arrow.coords.Y - arrow.len 
                                 * Math.Sin(arrow.getAngleRad()));
            endArrow.Add(new PointF(xEnd, yEnd));
            endArrow.Add(new PointF(xEnd, yEnd));
            speed.Add(arrow.velocity);
            speed.Add(arrow.velocity);
            angle.Add(arrow.angle);
            angle.Add(arrow.angle);

            while (GROUND_LEVEL - y > 0)
            {
                //новая вертикальная составляющая скорости:
                vy += ay * dt;
                //новые координаты начала стрелы:
                float newX = x + (float)(vx * dt);
                float newY = y + (float)(vy * dt);
                //приращения координат:
                float dx = newX - x;
                float dy = newY - y;
                //запоминаем новые координаты:
                x = newX;
                y = newY;
                //корректируем y-координату Стрелки:
                if (GROUND_LEVEL - y < 0) y = GROUND_LEVEL;
                //заносим новые координаты в список:
                begArrow.Add(new PointF(x, y));

                //вычисляем и запоминаем координаты конца стрелки:
                double k = (double)arrow.len / Math.Sqrt(dx*dx + dy*dy);
                float xe = x + (float)k * dx;
                float ye = y + (float)k * dy;
                endArrow.Add(new PointF(xe, ye));
                //запоминаем скорость и угол:
                speed.Add(Math.Sqrt(vx*vx + vy*vy));
                angle.Add(Math.Atan2(dy,dx));
 
                //проверяем поражение мишени:
                RectangleF r = box.getRect();
                //попали в цель:
                if (!flgGoal && r.Contains(xe, ye))
                {
                    idGoal = endArrow.Count;
                    flgGoal = true;
                }
            }
        }

        //private void frmArrows_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    flgShot = true;
        //   //drawShot(this.CreateGraphics());
        //    this.Invalidate();
        //   //arrow.coords.X = arrow.coordsCircle.X;
        //   //arrow.coords.Y = arrow.coordsCircle.Y;
        //   //this.Invalidate();
        //   //flgShot = false;
        //}
        ////РИСУЕМ ЛЕТЯЩУЮ СТРЕЛКУ
        //private void drawShot(Graphics gr)
        //{
        //    float x = arrow.coords.X;
        //    float y = arrow.coords.Y;
        //    gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        //    double dt = 1 / arrow.velocity; // 0.1;
        //    //составляющие скорости:
        //    double vx = arrow.velocity * Math.Cos(arrow.getAngleRad());
        //    double vy = -arrow.velocity * Math.Sin(arrow.getAngleRad());

        //    double ay = g;
        //    while (GROUND_LEVEL - y > 0)
        //    //while (arrow.getH() > 0)
        //    {
        //        vy += ay * dt;
        //        x += (float)(vx * dt);
        //        y += (float)(vy * dt);
        //        //this.Invalidate(new Rectangle((int)(arrow.coords.X-arrow.len),(int)(arrow.coords.Y-arrow.len), 2*arrow.len, 2*arrow.len));
        //        arrow.coords.X = x;
        //        arrow.coords.Y = y;
        //        //lblH.Text = (GROUND_LEVEL - y).ToString();
        //        //Application.DoEvents();
        //        //gr.DrawEllipse(arrow.pen, x - 1, y - 1, 2, 2);
        //        //gr.DrawEllipse(arrow.pen, x, y, 1, 1);
        //        //проверяем поражение мишени:
        //        RectangleF r = box.getRect();
        //        //if(r.Contains(x,y)) //попали

        //           arrow.drawArrow(gr);
        //    }
        //}

        //НАЖИМАЕМ ЛЕВУЮ КНОПКУ МЫШКИ
        private void frmArrows_MouseDown(object sender, MouseEventArgs e)
        {
          //если стрела в полете, то ничего не делаем:
          if (flgShot) return;
          this.Cursor= Cursors.Hand;
          //двигаем мышку:
          flgMove= true;
          //запоминаем координаты мышки:
          pt= Cursor.Position;
        }
        //ПЕРЕМЕЩАЕМ МЫШКУ
        private void frmArrows_MouseMove(object sender, MouseEventArgs e)
        {
          //двигаем мышку по форме:
          if(flgMove)
          {
              //перемещения мышки:
              float dx = Cursor.Position.X - pt.X;
              float dy = Cursor.Position.Y - pt.Y;
              //в каком направлении больше?
              if(Math.Abs(dx) > Math.Abs(dy))
              //по горизонтали - скорость:
              {
                  if (dx < 0 && arrow.velocity > 0) --arrow.velocity;
                  if (dx > 0 && arrow.velocity < 200) ++arrow.velocity;
                  arrow.printV(lblV);
              }
              else
              //по вертикали - высота:
              {
                 float newY = arrow.coordsCircle.Y + (Cursor.Position.Y - pt.Y);
                 if(newY < 16) newY = 16;
                 if(newY > GROUND_LEVEL-1) newY = GROUND_LEVEL-1;
                 //новая y-координата кружка и стрелки:
                 arrow.coords.Y  = arrow.coordsCircle.Y = newY;
                 //выводим координаты метки в заголовке формы:
                 arrow.printH(lblH);
              }
              //запоминаем новые координаты курсора:
              pt = Cursor.Position;
              //обновляем экран:
              this.Invalidate(); 
          }
        }
        //ОТПУСКАЕМ КНОПКУ МЫШКИ
        private void frmArrows_MouseUp(object sender, MouseEventArgs e)
        {
            flgMove= false;
            this.Cursor= Cursors.Default;
        }
        //КРУТИМ КОЛЕСИКО МЫШКИ
        private void frmArrows_MouseWheel(object sender, MouseEventArgs e)
        {
            int da = e.Delta;
            if (da <  0 && arrow.angle > -90) --arrow.angle;
            if (da >  0 && arrow.angle < 90) ++arrow.angle;
            arrow.printAngle(lblAngle);
            this.Invalidate();
        }


        //СТРЕЛЯЕМ
        private void btnShot_Click(object sender, EventArgs e)
        {
            if (flgShot) return;
            id = 0;
            flgShot = true;
            tmrShot.Start();
        }

        //ЗАРЯЖАЕМ
        private void btnLoad_Click(object sender, EventArgs e)
        {
            flgShot = false;
            arrow.coords.X = arrow.coordsCircle.X;
            arrow.coords.Y = arrow.coordsCircle.Y;
            arrow.printH(lblH);
            arrow.printV(lblV);
            arrow.printAngle(lblAngle);
            arrow.printDist(lblDist);
            createBox();
            this.Invalidate();
        }

        //ТАЙМЕР
        private void tmrShot_Tick(object sender, EventArgs e)
        {
            //пока траектория не закончилась:
            if (++id < begArrow.Count)
            {
               //показываем текущую высоту стрелы:
               PointF begPt = begArrow.ElementAt(id);
               int h = GROUND_LEVEL - (int)begPt.Y;
               lblH.Text = "Высота = " + h.ToString();
               //показываем текущую скорость стрелы:    
               int v= (int)speed.ElementAt(id);
               lblV.Text = "Скорость = " + v.ToString();    
               //показываем текущий угол стрелы:
               int a = (int)(-angle.ElementAt(id) / Math.PI * 180);
               lblAngle.Text = "Угол = " + a.ToString();   
               //показываем гориз. удаление стрелы от точки старта:
               int dist= (int)begArrow.ElementAt(id).X - X_START;
               lblDist.Text = "Дистанция = " + dist.ToString(); 
               this.Invalidate();
            }
            //стрела вонзилась в землю:
            else
            {
                flgShot = false;
                tmrShot.Stop();
                MessageBox.Show("Мазило!", "Стрелки");
            }

            //стрела попала в цель:
            if(id == idGoal)
            {
                tmrShot.Stop();
                MessageBox.Show("Ой, больно!", "Стрелки");
            }
        }

        //ПРИЦЕЛ
        private void chPrizel_CheckedChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

    }
}
