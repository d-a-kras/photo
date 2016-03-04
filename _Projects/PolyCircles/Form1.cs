using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using rv; //добавьте ссылку!

namespace PolyCircles
{
    public partial class frmCircles : Form
    {
        Bitmap bmp = null;
        Graphics g = null;

        //КОНСТРУКТОР ФОРМЫ
        public frmCircles()
        {
            InitializeComponent();
            //создаем буферную поверхность рисования:
            bmp = new Bitmap(pbDraw.Width, pbDraw.Height);
            g = Graphics.FromImage(bmp);
            //рисуем качественно:
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //запускаем таймер:
            tmDraw.Start();
            pbDraw.Image = bmp; 
        }

        //РИСУЕМ ФИГУРЫ
        private void tmrDraw_Tick(object sender, EventArgs e)
        {
            //drawCircle(10);
            //drawRect(5);
            drawPoly(3);
            //обновляем сцену:
            //pbDraw.Image = bmp; 
            pbDraw.Invalidate();
        }
        //РИСУЕМ ЗАДАННОЕ ЧИСЛО КРУЖКОВ
        void drawCircle(int n)
        {
            for (int i = 0; i < n; ++i)
            {
                //радиус:
                int radius = 5 + rvColor.rand.Next(10);
                //случайный цвет:
                Color clr = rvColor.RandomColor();
                //выбираем случайные координаты:  
                int x = rvColor.rand.Next(pbDraw.Width - radius);
                int y = rvColor.rand.Next(pbDraw.Height - radius);
                //рисуем цветной кружок:
                //g.FillEllipse(new SolidBrush(clr), x, y, 2 * radius, 2 * radius);
                g.DrawEllipse(new Pen(clr, 2.0f), x, y, 2 * radius, 2 * radius);
            }
        }
        //РИСУЕМ ЗАДАННОЕ ЧИСЛО ПРЯМОУГОЛЬНИКОВ
        void drawRect(int n)
        {
            for (int i = 0; i < n; ++i)
            {
                //ширина:
                int width = 50 + rvColor.rand.Next(100);
                //высота:
                int height = 25 + rvColor.rand.Next(60);
                //случайный цвет:
                Color clr = rvColor.RandomColor();
                //выбираем случайные координаты:  
                int x = rvColor.rand.Next(pbDraw.Width - width);
                int y = rvColor.rand.Next(pbDraw.Height - height);
                //рисуем цветной прямоугольник:
                g.FillRectangle(new SolidBrush(clr), x, y, width, height);
                //g.DrawRectangle(new Pen(clr, 6.0f), x, y, width, height);
            }
        }

        //РИСУЕМ ЗАДАННОЕ ЧИСЛО МНОГОУГОЛЬНИКОВ
        void drawPoly(int n)
        {
            for (int i = 0; i < n; ++i)
            {
                Point[] points = new Point[3];
                //вершина 1:
                points[0].X = rvColor.rand.Next(pbDraw.Width);
                points[0].Y = rvColor.rand.Next(pbDraw.Height);
                //вершина 2:
                points[1].X = rvColor.rand.Next(pbDraw.Width);
                points[1].Y = rvColor.rand.Next(pbDraw.Height);
                //вершина 3:
                points[2].X = rvColor.rand.Next(pbDraw.Width);
                points[2].Y = rvColor.rand.Next(pbDraw.Height);
                //случайный цвет:
                Color clr = rvColor.RandomColor();

                //рисуем цветные линии:
                //g.DrawLines(new Pen(clr, 5.0f), points);
                //рисуем цветные многоугольники:
                g.FillPolygon(new SolidBrush(clr), points);
                g.DrawPolygon(new Pen(Color.Black, 5.0f), points);
                //g.DrawPolygon(new Pen(clr, 5.0f), points);
            }
        }

        //СТИРАЕМ ВСЕ КРУЖКИ
        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }


    }
}
