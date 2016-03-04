using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using rv; //добавьте ссылку!

namespace Pie
{
    public partial class frmPie : Form
    {
        //координаты мышки:
        Point pt;
        //рамка:
        Rectangle ramka;

        //сектор:
        struct Sector
        {
            public Rectangle rect;
            public Color clr;
            public float startAngle;
            public float sweepAngle;
        }
        Queue<Sector> sectors = new Queue<Sector>();

        //КОНСТРУКТОР ФОРМЫ
        public frmPie()
        {
            InitializeComponent();
        }

        //НАЖИМАЕМ КНОПКУ МЫШКИ
        private void pbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            //нажата левая кнопка мышки:
            if (e.Button == MouseButtons.Left)
            {
                ramka.Location = Control.MousePosition;
                //запоминаем координаты мышки:
                pt.X = e.X;
                pt.Y = e.Y;
            }
        }
        //ПЕРЕМЕЩАЕМ МЫШКУ
        private void pbDraw_MouseMove(object sender, MouseEventArgs e)
        {
            //нажата левая кнопка мышки:
            if ((e.Button & MouseButtons.Left) > 0)
            {
                //останавливаем таймер,
                //иначе портится рамка:
                tmrFill.Stop();
                if (this.pbDraw.ClientRectangle.Contains(new Point(e.X, e.Y)))
                {
                   //стираем рамку:
                   ControlPaint.DrawReversibleFrame(ramka, 
                                                    this.BackColor,
                                                    FrameStyle.Dashed);
                  ramka.Size = (Size)Control.MousePosition 
                                  - (Size)ramka.Location;

                   //рисуем рамку:
                  ControlPaint.DrawReversibleFrame(ramka, 
                                                   this.BackColor,
                                                   FrameStyle.Dashed);
                }
            }
            //координаты мышки:
            //this.Text = e.X.ToString("N4") + "    " + e.Y.ToString("N4");
        }
        //ОТПУСКАЕМ КНОПКУ МЫШКИ
        private void pbDraw_MouseUp(object sender, MouseEventArgs e)
        {
            //удаляем рамку:
            ControlPaint.DrawReversibleFrame(ramka, 
                                             this.BackColor,
                                             FrameStyle.Dashed);
            //добавляем прямоугольник:
            Sector sec = new Sector();
            //сектор сначала пустой:
            sec.startAngle = 0.0f;
            sec.sweepAngle = 0.0f;
            //цвет сектора - случайный:
            sec.clr = rvColor.RandomColor();
            //размеры сектора = 
            //размерам рамки:
            sec.rect = new Rectangle(pt.X, pt.Y, 
                      ramka.Width, ramka.Height);
            //ставим новый сектор в хвост очереди:
            sectors.Enqueue(sec);
            //обнуляем размеры рамки:
            ramka.Size = new Size(0, 0);
            //обновляем сцену:
            pbDraw.Invalidate();
            //запускаем таймер:
            tmrFill.Start();
        }

        //РИСУЕМ СЦЕНУ
        private void pbDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //рисуем качественно:
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            ////рисуем все сектора:
            //foreach (Sector sec in sectors)
            //{
            //    g.FillPie(new SolidBrush(Color.FromArgb(80,sec.clr)), 
            //              sec.rect, sec.startAngle, sec.sweepAngle);
            //    g.DrawPie(new Pen(Color.Black, 2.0f), sec.rect, 
            //              sec.startAngle, sec.sweepAngle);
            //}

            //рисуем все дуги:
            foreach (Sector sec in sectors)
            {
                g.DrawArc(new Pen(Color.Black, 2.0f), sec.rect, 
                          sec.startAngle, sec.sweepAngle);
            }
        }

        //НАРАЩИВАЕМ СЕКТОРА
        private void tmrFill_Tick(object sender, EventArgs e)
        {
            //извлекаем все сектора из очереди:
            for (int i = 0; i < sectors.Count; ++i )
            {
               Sector sec = sectors.Dequeue();
               //если сектор еще не полный,
               if (sec.sweepAngle < 360.0f)
               {
                   //увеличиваем угол:
                   sec.sweepAngle += 1.0f;
               }
               //крутим радиус:
               else
               {
                   sec.startAngle += 1.0f;
               }
               //возвращаем сектор в очередь:
               sectors.Enqueue(sec);
               //обновляем сцену:
               pbDraw.Invalidate();
           }
        }

        //СТИРАЕМ ВСЕ СЕКТОРА
        private void btnClear_Click(object sender, EventArgs e)
        {
            tmrFill.Stop();
            sectors.Clear();
            pbDraw.Invalidate();
        }


    }
}
