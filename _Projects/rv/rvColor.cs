using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Imaging;

namespace rv
{
    public static class rvColor
    {
        public static Random rand = new Random();

        //СЛУЧАЙНЫЙ ЦВЕТ
        public static Color RandomColor()
        {
            //Random rand = new Random(); //повторяется, если сразу вызывать
            return Color.FromArgb(255, rand.Next(0,255), rand.Next(0,255), rand.Next(0,255));
        }

        //ИНВЕРТИРОВАННЫЙ ЦВЕТ
        public static Color InvertColor(Color clr)
        {
            return Color.FromArgb(255-clr.R, 255-clr.G, 255-clr.B);
        }

        //ОТТЕНКИ СЕРОГО
        public static ImageAttributes Grayscale()
        {
            //создаем матрицу цвета:
            ColorMatrix cm = new ColorMatrix(new float[][] {
                             new float[] {0.3f, 0.3f, 0.3f, 0, 0},
                             new float[] {0.59f, 0.59f, 0.59f, 0, 0},
                             new float[] {0.11f, 0.11f, 0.11f, 0, 0},
                             new float[] {0, 0, 0, 1, 0},
                             new float[] {0, 0, 0, 0, 1}
                             });
            //создаем новые атрибуты:
            ImageAttributes ia = new ImageAttributes();
            ia.SetColorMatrix(cm);
            return ia;
        }

        //НЕГАТИВ
        public static ImageAttributes Negativ()
        {
            //создаем матрицу цвета:
            ColorMatrix cm = new ColorMatrix(new float[][] {
                             new float[] {-1, 0, 0, 0, 0},
                             new float[] {0, -1, 0, 0, 0},
                             new float[] {0, 0, -1, 0, 0},
                             new float[] {0, 0, 0, 1, 0},
                             new float[] {0, 0, 0, 0, 1}
                             });
            //создаем новые атрибуты:
            ImageAttributes ia = new ImageAttributes();
            ia.SetColorMatrix(cm);
            return ia;
        }

        //ОСВЕТЛЯЕМ ИЗОБРАЖЕНИЕ
        public static ImageAttributes Brightness(float v)
        {
            //создаем матрицу цвета:
            ColorMatrix cm = new ColorMatrix(new float[][] {
                             new float[] {1, 0, 0, 0, 0},
                             new float[] {0, 1, 0, 0, 0},
                             new float[] {0, 0, 1, 0, 0},
                             new float[] {0, 0, 0, 1, 0},
                             new float[] {v, v, v, 0, 1}         
                             });
            //создаем новые атрибуты:
            ImageAttributes ia = new ImageAttributes();
            ia.SetColorMatrix(cm);
            return ia;
        }

        //ПРОЗРАЧНОСТЬ
        public static ImageAttributes Transparency(float v)
        {
            //создаем матрицу цвета:
            ColorMatrix cm = new ColorMatrix();
            //cm.Matrix33 = 0;
            //cm.Matrix43 = v;
            cm.Matrix33 = v;

            //ColorMatrix cm = new ColorMatrix(new float[][] {
            //                 new float[] {1, 0, 0, 0, 0},
            //                 new float[] {0, 1, 0, 0, 0},
            //                 new float[] {0, 0, 1, 0, 0},
            //                 new float[] {0, 0, 0, 0.5f, 0},
            //                 new float[] {0, 0, 0, 0, 1}         
            //                 });
            //создаем новые атрибуты:
            ImageAttributes ia = new ImageAttributes();
            ia.SetColorMatrix(cm);
            return ia;
        }
    }
}
