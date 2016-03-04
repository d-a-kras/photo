using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Цветные_линии
{
    public partial class frmColorLines : Form
    {
        int width;
        int height;
        //отношение высоты окна к ширине:
        double ratio;
        int penWidth = 1;
        Pen pen;

        public frmColorLines()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, penWidth);
            width = this.Width;
            height = this.Height;
            ratio= (double)height / width;
        }

        private void draw()
        { 
          Graphics gr = this.CreateGraphics();
          
          //чертим цветные линии:
          for (int x = 0; x <= width; x += 10)
          {
              pen.Color = Color.Red;
              gr.DrawLine(pen, 0, (int)(x * ratio), width - x, 0);
              pen.Color = Color.Yellow;
              gr.DrawLine(pen, 0, (int)((width - x) * ratio), width - x, (int)(width * ratio));
              pen.Color = Color.Blue;
              gr.DrawLine(pen, width - x, (int)(0 * ratio), width, (int)((width - x) * ratio));
              pen.Color = Color.Green;
              gr.DrawLine(pen, width - x, (int)(width * ratio), width, (int)(x * ratio));
          }
        }

        private void frmColorLines_Paint(object sender, PaintEventArgs e)
        {
            draw();
        }
    }
}
