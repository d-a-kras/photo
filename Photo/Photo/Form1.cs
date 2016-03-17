using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        Image p;

        public Form1()
        {
            InitializeComponent();
            // pictureBox1.set
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void чБФилтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void обрезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (ofd.FileName == null)
            {
                MessageBox.Show("Не выбран файл");

            }
            else
            {
                try
                {
                    p = Image.FromFile(ofd.FileName);
                    pictureBox1.SetBounds(10, 30, p.Width, p.Height);
                    pictureBox1.Image = p;


                }
                catch (Exception)
                {

                };
            }
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.ShowDialog();
            if (sfd.FileName != null)
            {
                b.Save(sfd.FileName);
            }
        }

        private void обрезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void обрезатьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(p);
            Bitmap rez = new Bitmap(50, 50);
            Graphics graphics = Graphics.FromImage(rez); // Graphics для рисования на smallImage
            graphics.DrawImage(b, new Point(-25, -25)); // Рисуем bigImage на smallImage, где (-25, -25) координата положения верхнего левого угла bigImage на smallImage
            graphics.Dispose(); // Закрываем graphics
            pictureBox1.Image = rez;
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void чБToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PixelFormat pxf = PixelFormat.Format24bppRgb;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);
            Bitmap bmpData2 = new Bitmap(p);
            BitmapData bmpData = bmpData2.LockBits(rect, ImageLockMode.ReadWrite, pxf);
            IntPtr ptr = bmpData.Scan0;
            int numBytes = bmpData.Stride * p.Height;
            int widthBytes = bmpData.Stride;
            byte[] rgbValues = new byte[numBytes];
            Marshal.Copy(ptr, rgbValues, 0, numBytes);
            for (int counter = 0; counter < rgbValues.Length; counter += 3)
            {
                int value = rgbValues[counter] + rgbValues[counter + 1] + rgbValues[counter + 2];
                byte color_b = 0;
                color_b = Convert.ToByte(value / 3);
                rgbValues[counter] = color_b;
                rgbValues[counter + 1] = color_b;
                rgbValues[counter + 2] = color_b;
            }
            Marshal.Copy(rgbValues, 0, ptr, numBytes);
            bmpData2.UnlockBits(bmpData);
            pictureBox1.Image = bmpData2;
        }

        private void зеркалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bp = new Bitmap(p);
            for (int y = 0; y <= p.Height - 1; y++)  
            {
                for (int x = 1; x < (p.Width - 1)/2; x++)
                
                {
                    Color oldColor1 = bp.GetPixel(x, y);
                    Color oldColor2 = bp.GetPixel(p.Width - 1 * x, y);
                    bp.SetPixel(p.Width - 1 * x, y, oldColor1);
                    bp.SetPixel(x, y, oldColor2);
                }
            }
            p = bp;
            pictureBox1.Image = bp;
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bp = new Bitmap(p);
            for (int x = 0; x <= p.Width - 1; x++)
            {
                for (int y = 0; y <= p.Height - 1; y++)
                {
                    Color oldColor = bp.GetPixel(x, y);
                    Color newColor;
                    newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                    bp.SetPixel(x, y, newColor);
                }
            }
            p = bp;
            pictureBox1.Image = bp;
        }

        private void очистиьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
