using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Drawing.Imaging;

namespace ScreenShot
{
    public partial class frmScreenShot : Form
    {
        //координаты мышки:
        Point pt;
        //рамка:
        Rectangle ramka;

        public frmScreenShot()
        {
            InitializeComponent();
        }


        //ДЕЛАЕМ СНИМОК ЭКРАНА
        private void btnGraphics_Click(object sender, EventArgs e)
        {
          this.Hide();
          Thread.Sleep(1000);
          Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                  Screen.PrimaryScreen.Bounds.Height);  
          using (Graphics g = Graphics.FromImage(bmp)) 
          { 
             g.CopyFromScreen(0, 0, 0, 0, bmp.Size); 
          } 
          pbScreenShot.Image = bmp;
          pbScreenShot.Size = bmp.Size;
          this.Show();
        }
        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            DLLScreenShot dllss = new DLLScreenShot();
            this.Hide();
            Thread.Sleep(1000);
            //Application.DoEvents();
            Bitmap bmp = dllss.CaptureScreen();
            pbScreenShot.Image = bmp;
            pbScreenShot.Size = bmp.Size;
            this.Show();
        }



        //private void btnRect_Click(object sender, EventArgs e)
        //{
        //    Point pt = this.PointToScreen(new Point(100,100));

        //    Rectangle rect = new Rectangle(btnRect.Location, btnRect.Size);
        //    //Rectangle rect = Screen.GetBounds(btnRect);
        //    Bitmap bmp = new Bitmap(rect.Width, rect.Height);
        //    //  e.Graphics.CopyFromScreen(new Point(10, 10), new Point(100, 100),
        //    //new Size(70, 70));
        //    //Bitmap bmp = new Bitmap(btnRect.Width, btnRect.Height);  
        //    using (Graphics g = Graphics.FromImage(bmp))
        //    {
        //        g.CopyFromScreen(pt, new Point(0, 0), bmp.Size);
        //    }
        //    pbScreenShot.Image = bmp;
        //    //pbScreenShot.Size = bmp.Size;
        //    //this.Show();

        //    //Bitmap bmp = (Bitmap)pbScreenShot.Image;
        //    //bmp= copy(bmp, pt, btnRect.Width, btnRect.Height);
        //    //pbScreenShot.Image = bmp;
        //}

        //Bitmap copy(Bitmap bmp, Point ptSource, int w, int h)
        //{
        //  //Bitmap bmp = new Bitmap(w, h);
        //  using (Graphics g = Graphics.FromImage(bmp)) 
        //  {
        //      g.CopyFromScreen(ptSource, new Point(0, 0), bmp.Size, CopyPixelOperation.MergeCopy); 
        //  }
        //  return bmp;
        //}

        //ЗАПИСЫВАЕМ КАРТИНКУ В ФАЙЛ
        private void btnSave_Click(object sender, EventArgs e)
        {
            //картинка не загружена:
            if (this.pbScreenShot.Image == null) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG|*.jpg;*.jpeg|PNG|*.png|BMP|*.bmp";
            if (sfd.ShowDialog() != DialogResult.OK)
                return;
     
            string fileName = sfd.FileName;
            Bitmap bmp = (Bitmap)pbScreenShot.Image;
            bmp.Save(fileName);
        }

        //НАЖИМАЕМ КНОПКУ МЫШКИ
        private void frmScreenShot_MouseDown(object sender, MouseEventArgs e)
        {
            //нажата левая кнопка мышки:
            if (e.Button == MouseButtons.Left)
            {
                ramka.Location = Control.MousePosition;
                //запоминаем координаты мышки:
                pt.X = e.X;
                pt.Y = e.Y;
            }
            //this.Text = pt.ToString();
        }
        //ПЕРЕМЕЩАЕМ МЫШКУ
        private void frmScreenShot_MouseMove(object sender, MouseEventArgs e)
        {
             //нажата левая кнопка мышки:
            if ((e.Button & MouseButtons.Left) > 0)
            {
                //if (pbScreenShot.ClientRectangle.Contains(new Point(e.X, e.Y)))
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
            //this.Text = pt.ToString();
        }
        //ОТПУСКАЕМ КНОПКУ МЫШКИ
        private void frmScreenShot_MouseUp(object sender, MouseEventArgs e)
        {
            //удаляем рамку:
            ControlPaint.DrawReversibleFrame(ramka, 
                                             this.BackColor,
                                             FrameStyle.Dashed);

            Point p = this.PointToScreen(new Point(pt.X, pt.Y));
            int w = Math.Abs(ramka.Width);
            int h = Math.Abs(ramka.Height);
            Bitmap bmp = new Bitmap(w+1, h+1);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(p, new Point(0, 0), bmp.Size);
            }
            pbScreenShot.Image = bmp;
            pbScreenShot.Size = bmp.Size;

            //обнуляем размеры рамки:
            ramka.Size = new Size(0, 0);
            //обновляем сцену:
            pbScreenShot.Invalidate();
        }

        //СТИРАЕМ КАРТИНКУ
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (pbScreenShot.Image == null) return;
            Graphics.FromImage(pbScreenShot.Image).Clear(Color.White);
            pbScreenShot.Invalidate();
        }


    }
}
