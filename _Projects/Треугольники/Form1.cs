using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using rv; //добавьте ссылку!

//ПРОГРАММА ДЛЯ ВЫЧЕРЧИВАНИЯ  
//ТРЕУГОЛЬНИКА ИЗ ТРЕУГОЛЬНИКОВ
namespace Треугольники
{
    public partial class frmTreangles : Form
    {
      //толщина контура:
      float penWidth= 1.0f;
      //длина стороны треугольника:
      int size= 32; 
      //цвет контура:
      Color penColor = Color.Yellow;

      Bitmap bmp = null;
      Graphics g = null;

        public frmTreangles()
        {
            InitializeComponent();
            //создаем буферную поверхность рисования:
            bmp = new Bitmap(pbDraw.Width, pbDraw.Height);
            g = Graphics.FromImage(bmp);
            //рисуем качественно:
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pbDraw.Image = bmp;
            drawTreangles();
        }

        //РИСУЕМ ТРЕУГОЛЬНИКИ
        void drawTreangles()
        {
          int width= pbDraw.Width;
          int height= pbDraw.Height;
          //координаты левого угла верхнего треугольника:
          double x1= width/2- size/2;
          double y1= 10;
          //высота треугольников:
          float dy= size * (float)Math.Sin(rvMath.Grad2Rad(60));
          //запоминаем начальные значения:
          double yt = y1;
          double xt = x1;

          //рисуем столбики из треугольников:
          for (int j = 0; j <= 14; ++j)
          {
              //левый столбик:
              y1 = yt + j * dy * 1.5;
              x1 = xt - size / 4 * 3 * j; 
              for (int i = 1; i <= 15 - 1.5 * j; ++i)
              {
                  drawTre((float)x1, (float)y1, dy);
                  y1 += dy;
              }
              //правый столбик:
              y1 = yt + j * dy * 1.5;
              x1 = xt + size / 4 * 3 * j;
              for (int i = 1; i <= 15 - 1.5 * j; ++i)
              {
                  drawTre((float)x1, (float)y1, dy);
                  y1 += dy;
              }
          }
          pbDraw.Invalidate();
        }
        //ЧЕРТИМ ТРЕУГОЛЬНИК
        void drawTre(float x, float y, float dy)
        {
            PointF[] points = new PointF[3];
            //вершина 1:
            points[0].X = x;
            points[0].Y = y;
            //вершина 2:
            points[1].X = x + size;// -2;
            points[1].Y = y;
            //вершина 3:
            points[2].X = x + size / 2;// -2;
            points[2].Y = y + dy;
            g.DrawPolygon(new Pen(penColor, penWidth), points);
            //вершина 1:
            points[0].X = x+1;
            points[0].Y = y+1;
            //вершина 2:
            points[1].X = x + size-1;
            points[1].Y = y+1;
            //вершина 3:
            points[2].X = x + size / 2;
            points[2].Y = y + dy-1;
            g.DrawPolygon(new Pen(penColor, penWidth), points);
        }
    }
}
