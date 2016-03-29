using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            progressBar1.Visible = false;
            
        }

        public static Bitmap image;
        public static string full_name_of_image = "\0";
        public static UInt32[,] pixel;
        public int div, offset;
        public int kernel_w, kernel_h;
        public int[,] kernel;
        public Bitmap  nashville1, win;
        public float w, h;

      

        //открытие изображения
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    full_name_of_image = open_dialog.FileName;
                    image = new Bitmap(open_dialog.FileName);
                    //this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    
          
                    pictureBox1.Invalidate(); //????
                    //получение матрицы с пикселями
                    pixel = new UInt32[image.Height, image.Width];
                    progressBar1.Maximum = image.Height;
                    progressBar1.Step = 1;
                    progressBar1.Value = 0;
                    for (int y = 0; y < image.Height; y++)
                    {
                        progressBar1.PerformStep();
                        for (int x = 0; x < image.Width; x++)
                            pixel[y, x] = (UInt32)(image.GetPixel(x, y).ToArgb());
                    }
                    
                    w = image.Width;
                    h = image.Height;

                    if (image.Width >= 800 && image.Width >= image.Height)
                    {
                        float k = (float)image.Width / 800;
                        w = 800;
                        h = image.Height / k;
                    }
                    else if (image.Height >= 600 && image.Width < image.Height)
                    {
                        float k = (float)image.Height / 600;
                        h = 600;
                        w = image.Width / k;

                    }
                    image= new Bitmap(image, (int)w, (int)h);

                    
                    this.Width = image.Width + 40;
                    this.Height = image.Height + 75;
                    this.pictureBox1.Size = image.Size;
                    pictureBox1.Image = image;
                    

                }
                catch
                {
                    full_name_of_image = "\0";
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        //сохранение изображения
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                //string format = full_name_of_image.Substring(full_name_of_image.Length - 4, 4);
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //яркость контрастность
        private void яркостьконтрастностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Form2 BrightnessForm = new Form2(this);
                BrightnessForm.ShowDialog(); //just 'Show' for the control Form1
            }
            else MessageBox.Show("Выбирите файл");
        }

        //цветовой Баланс
        private void цветовойБалансToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Form3 ColorBalanceForm = new Form3(this);
                ColorBalanceForm.ShowDialog();
            }

            else MessageBox.Show("Выбирите файл");
        }

        //Повышение резкости
        private void повыситьРезкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                pixel = Filter.matrix_filtration(image.Width, image.Height, pixel, Filter.N1, Filter.sharpness);
                FromPixelToBitmap();
                FromBitmapToScreen();
            }

            else MessageBox.Show("Выбирите файл");
        }

        //размыть
        private void размытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //преобразование из UINT32 to Bitmap
        public static void FromPixelToBitmap()
        {
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    image.SetPixel(x, y, Color.FromArgb((int)pixel[y, x]));
        }

        //преобразование из UINT32 to Bitmap по одному пикселю
        public static void FromOnePixelToBitmap(int x, int y, UInt32 pixel)
        {
            image.SetPixel(y, x, Color.FromArgb((int)pixel));
        }

        //вывод на экран
        public void FromBitmapToScreen()
        {
            pictureBox1.Image = image;
        }

  

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void чБToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                PixelFormat pxf = PixelFormat.Format24bppRgb;
                Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
                Bitmap bmpData2 = new Bitmap(image);
                BitmapData bmpData = bmpData2.LockBits(rect, ImageLockMode.ReadWrite, pxf);
                IntPtr ptr = bmpData.Scan0;
                int numBytes = bmpData.Stride * image.Height;
                int widthBytes = bmpData.Stride;
                byte[] rgbValues = new byte[numBytes];
                Marshal.Copy(ptr, rgbValues, 0, numBytes);
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                progressBar1.Step = 1;
                progressBar1.Maximum = rgbValues.Length/3;
                for (int counter = 0; counter < rgbValues.Length; counter += 3)
                {
                    progressBar1.PerformStep();
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
                progressBar1.Visible = false;
            }

            else MessageBox.Show("Выбирите файл");
        }

        private void зеркалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = (int)h;
            progressBar1.Step = 1;
            if (image != null)
            {
                Bitmap bp = new Bitmap(image);
                for (int y = 0; y <= image.Height - 1; y++)
                {
                    progressBar1.PerformStep();

                    for (int x = 1; x < (image.Width - 1) / 2; x++)
                    {
                        Color oldColor1 = bp.GetPixel(x, y);
                        Color oldColor2 = bp.GetPixel(image.Width - 1 * x, y);
                        bp.SetPixel(image.Width - 1 * x, y, oldColor1);
                        bp.SetPixel(x, y, oldColor2);
                    }
                }
                image = bp;
                pictureBox1.Image = bp;
            }

            else MessageBox.Show("Выбирите файл");
            progressBar1.Visible = false;
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                progressBar1.Visible = true;
                progressBar1.Maximum = image.Width;
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                Bitmap bp = new Bitmap(image);
                for (int x = 0; x <= image.Width - 1; x++)
                {
                    progressBar1.PerformStep();
                    for (int y = 0; y <= image.Height - 1; y++)
                    {
                        Color oldColor = bp.GetPixel(x, y);
                        Color newColor;
                        newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                        bp.SetPixel(x, y, newColor);
                    }
                }
                image = bp;
                pictureBox1.Image = bp;
                progressBar1.Value = 0;
                progressBar1.Visible = false;
            }
            else MessageBox.Show("Выбирите файл");
        }
    
         void sharpen()
        {
            kernel = new int[3, 3];

            kernel[0, 0] = -1;
            kernel[1, 0] = -1;
            kernel[2, 0] = -1;

            kernel[0, 1] = -1;
            kernel[1, 1] = 9;
            kernel[2, 1] = -1;

            kernel[0, 2] = -1;
            kernel[1, 2] = -1;
            kernel[2, 2] = -1;


            div = 1;
            offset = 0;
            kernel_h = kernel_w = 3;
        }

        void blur(int k)
        {
            kernel = new int[k, k];

            for (int i = 0; i < k; i++) {
                for (int j = 0; j < k;j++ )
                {
                    kernel[i, j] = 1;
                }
            }

                div = k*k;
            offset = 0;
            kernel_h = kernel_w = k;
        }

        void cold()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = (int)w;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            win = new Bitmap(Properties.Resources.ramka, (int)w, (int)h);

            Bitmap dst = new Bitmap(image);
            Bitmap dst1 = new Bitmap(image);
            Bitmap dsp = new Bitmap(win);

            for(int x=0; x<(int)w; x++)
            {
                progressBar1.PerformStep();
                var color = new Color();
                var color1 = new Color();
                for (int y = 0; y < (int)h; y++)
                {
                    color = dst1.GetPixel(x, y);
                    color1 = dsp.GetPixel(x, y);

                    float brght = color.GetBrightness();

                    byte r = color.R;
                    byte g = color.G;
                    byte b = color.B;

                    float brght1 = color1.GetBrightness();

                    byte r1 = color1.R;
                    byte g1 = color1.G;
                    byte b1 = color1.B;

                    r = (byte)((r * 0.35 + ((brght) * r + (1 - brght) * 100) * 0.65));
                    b = (byte)((b * 0.7 + ((1 - brght) * b + (brght) * 255) * 0.3));

                    dst.SetPixel(x, y, Color.FromArgb((byte)(r * (1 - brght1) + r1 * brght1), (byte)(g * (1 - brght1) + g1 * brght1), (byte)(b * (1 - brght1) + b1 * brght1)));
                }
            }
            image = dst;
            pictureBox1.Image = dst;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }

        void kern()
        {

            if (image != null)
            {
                Bitmap bp = new Bitmap(image);
                Bitmap bp1 = new Bitmap(image);
                progressBar1.Visible = true;
                progressBar1.Maximum = (int)w;
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                for(int x=kernel_h / 2;x< (int)w - kernel_h / 2 - 1;x++)
           {
               progressBar1.PerformStep();
               var color = new Color();
               int rSum = 0, gSum = 0, bSum = 0;
               
               for (int y = kernel_w / 2; y < (int)h - kernel_w / 2 - 1; y++)
               {
                  
                   for (int j = 0; j < kernel_h; j++)
                   {
                       

                       for (int i = 0; i < kernel_w; i++)
                       {
                           //progressBar1.PerformStep();
                           color = bp1.GetPixel(x - kernel_h / 2 + i, y - kernel_h / 2 + j);
                           
                           byte r = color.R;
                           byte g = color.G;
                           byte b = color.B;
                           int a = kernel[i, j];

                           rSum += r * a;
                           gSum += g * a;
                           bSum += b * a;
                       }

                   }
                   rSum /= div;
                   gSum /= div;
                   bSum /= div;

                   rSum += offset;
                   gSum += offset;
                   bSum += offset;

                   if (rSum > 255) rSum = 255;
                   if (rSum < 0) rSum = 0;

                   if (gSum > 255) gSum = 255;
                   if (gSum < 0) gSum = 0;

                   if (bSum > 255) bSum = 255;
                   if (bSum < 0) bSum = 0;

                   bp.SetPixel(x, y, Color.FromArgb((byte)rSum, (byte)gSum, (byte)bSum));
                   rSum = gSum = bSum = 0;
               }

           }
                
                image = bp;
                pictureBox1.Image = bp;
            }
            progressBar1.Visible = false;

           
        }

        void hope()
        {
           Bitmap dst = new Bitmap(image);
           Bitmap dst1 = new Bitmap(image);
           progressBar1.Visible = true;
           progressBar1.Maximum = (int)w;
           progressBar1.Step = 1;
           progressBar1.Value = 0;
            for(int x=0;x< (int)(w - 1);x++)
                   {
                       progressBar1.PerformStep();
                       var color = new Color();
                       for (int y = 0; y < (int)h - 1; y++)
                       {
                           color = dst1.GetPixel(x, y);

                           float brght = color.GetBrightness();
                           byte r = color.R;
                           byte g = color.G;
                           byte b = color.B;

                           if (brght <= 0.35)
                           {
                               r = 0;
                               g = 50;
                               b = 77;
                           };
                           if (brght > 0.35 & brght <= 0.55)
                           {
                               r = 215;
                               g = 26;
                               b = 33;
                           };
                           if (brght > 0.55)
                           {
                               r = 252;
                               g = 228;
                               b = 168;
                           };

                           dst.SetPixel(x, y, Color.FromArgb(r, g, b));
                       }
                   }

            image = dst;
            pictureBox1.Image = dst;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }

        void nashville()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = (int)w;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            win = new Bitmap(Properties.Resources.nashville, (int)w, (int)h);
           Bitmap dst = new Bitmap(image);
           Bitmap dst1 = new Bitmap(image);
            Bitmap dsp = new Bitmap(win);

            for(int x=0;x<(int)w;x++)
            {
                progressBar1.PerformStep();
                var color = new Color();
                var color1 = new Color();
                for (int y = 0; y < (int)h; y++)
                {
                    color = dst1.GetPixel(x, y);
                    color1 = dsp.GetPixel(x, y);
                    float brght = color.GetBrightness();

                    byte r = color.R;
                    byte g = color.G;
                    byte b = color.B;

                    byte r1 = color1.R;
                    byte g1 = color1.G;
                    byte b1 = color1.B;

                    b = (byte)(255 * brght);

                    dst.SetPixel(x, y, Color.FromArgb((byte)(r * 0.55 + r1 * 0.45), (byte)(g * 0.95 + g1 * 0.05), (byte)(b * 0.6 + b1 * 0.4)));

                }
            }
            image = dst;
            pictureBox1.Image = dst;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            
        }

        void willow()
        {
            if (image != null)
            {
                progressBar1.Visible = true;
                progressBar1.Maximum = (int)w;
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                win = new Bitmap(Properties.Resources.willow1, (int)w, (int)h);
                Bitmap dst = new Bitmap(image);
                Bitmap dst1 = new Bitmap(image);
                Bitmap dsp = new Bitmap(win);

                for (int x = 0; x < (int)w; x++)
                {
                    progressBar1.PerformStep();
                    var color = new Color();
                    var color1 = new Color();
                    for (int y = 0; y < (int)h; y++)
                    {
                        color = dst1.GetPixel(x, y);
                        color1 = dsp.GetPixel(x, y);
                        float brght = color.GetBrightness();

                        byte r = color.R;
                        byte g = color.G;
                        byte b = color.B;

                        float brght1 = color1.GetBrightness();
                        byte r1 = color1.R;
                        byte g1 = color1.G;
                        byte b1 = color1.B;

                        g = b = r;

                        dst.SetPixel(x, y, Color.FromArgb((byte)(r * (1 - brght1) + r1 * brght1), (byte)(g * (1 - brght1) + g1 * brght1), (byte)(b * (1 - brght1) + b1 * brght1)));

                    }
                }
                image = dst;
                pictureBox1.Image = image;
                progressBar1.Value = 0;
                progressBar1.Visible = false;
            }
        }

        void heat()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = (int)w;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            win = new Bitmap(Properties.Resources.vignette, (int)w, (int)h);
            Bitmap dst = new Bitmap(image);
            Bitmap dst1 = new Bitmap(image);
            Bitmap dsp = new Bitmap(win);

           for(int x=0;x<(int)w;x++)
            {
                progressBar1.PerformStep();
                var color = new Color();
                var color1 = new Color();
                for (int y = 0; y < (int)h; y++)
                {
                    color = dst1.GetPixel(x, y);
                    color1 = dsp.GetPixel(x, y);

                    float brght = color.GetBrightness();
                    float brght1 = color1.GetBrightness();
                
                    byte r = color.R;
                    byte g = color.G;
                    byte b = color.B;

                    byte r1 = color1.R;
                    byte g1 = color1.G;
                    byte b1 = color1.B;

                 //   g = (byte)((g * 0.65 + ((brght) * g + (1 - brght) * 120) * 0.35));


                    g = (byte)((g * 0.75 + ((1-brght) * g + (brght) *120) * 0.25));
                    r = (byte)((r * 0.75 + ((1 - brght) * r + (brght) * 255) * 0.25));
                    b = (byte)((b * 0.6 + ((1 - brght) * b + (brght) * 25) * 0.4));

                  // dst.SetPixel(x, y, Color.FromArgb((byte)( r1 ), (byte)( g1 ), (byte)( b1 )));
                    dst.SetPixel(x, y, Color.FromArgb((byte)(r * brght1 + r1 * (1 - brght1)), (byte)(g * brght1 + g1 * (1 - brght1)), (byte)(b * brght1 + b1 * (1-brght1))));
                }
            }


            image = dst;
            pictureBox1.Image = dst;
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        void bp()
        {
            GC.Collect();
            win = new Bitmap(Properties.Resources.pb, (int)w, (int)h);
            Bitmap dst = new Bitmap(image);
           Bitmap dsp = new Bitmap(win);
           progressBar1.Visible = true;
           progressBar1.Maximum = (int)w;
           progressBar1.Step = 1;
           progressBar1.Value = 0;
            for(int x=0;x<(int)w;x++)
            {
                progressBar1.PerformStep();
                var color = new Color();
                var color1 = new Color();
                for (int y = 0; y < (int)h; y++)
                {
                    color = dst.GetPixel(x, y);
                    color1 = dsp.GetPixel(x, y);
                    float brght = color.GetBrightness();

                    byte r = color.R;
                    byte g = color.G;
                    byte b = color.B;

                    float brght1 = color1.GetBrightness();
                    byte r1 = color1.R;
                    byte g1 = color1.G;
                    byte b1 = color1.B;

                    if (brght < 0.15)
                    {
                        b = 50;
                    }

                    dst.SetPixel(x, y, Color.FromArgb((byte)(r * 0.3 + r1 * 0.7), (byte)(g * 0.9 + g1 * 0.1), (byte)(b * 0.9 + b1 * 0.1)));

                }
            }

            image = dst;
            pictureBox1.Image = dst;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
          
        }

        void collage()
        {
            GC.Collect();


            win = new Bitmap(Properties.Resources.collage, (int)(w + w / 10), (int)(h + h / 10));

           Bitmap dsp = new Bitmap(image);

           Bitmap dst = new Bitmap(win);
           progressBar1.Visible = true;
           progressBar1.Maximum = (int)w/2;
           progressBar1.Step = 1;
           progressBar1.Value = 0;


           for(int x=0; x<(int)(w / 2);x++)
           {
               progressBar1.PerformStep();
               var color = new Color();


               for (int y = 0; y < (int)(h / 2); y++)
               {
                   color = dsp.GetPixel(x, y);


                   float brght = color.GetBrightness();


                   byte r = color.R;
                   byte g = color.G;
                   byte b = color.B;

                   if (brght < 0.15)
                   {
                       b = 100;
                   }

                   if (brght >= 0.15 & brght < 0.3)
                   {
                       r = 50;
                       b = 50;
                   }

                   if (brght >= 0.3 & brght < 0.85)
                   {
                       r = 255;
                       g = 0;
                       b = 50;
                   }

                   if (brght >= 0.85)
                   {
                       g = 200;
                       b = 100;
                   }
                   dst.SetPixel((int)(x + w / 30), (int)(y + h / 30), Color.FromArgb(r, g, b));

                   /////////////////////////////////////////////
                   r = color.R;
                   g = color.G;
                   b = color.B;

                   if (brght < 0.15)
                   {
                       r = 20;
                       g = 20;
                   }

                   if (brght >= 0.15 & brght < 0.3)
                   {
                       g = 150;
                       b = 150;
                   }

                   if (brght >= 0.3 & brght < 0.85)
                   {
                       r = 55;
                       b = 255;
                   }

                   if (brght >= 0.85)
                   {
                       r = 190;
                       g -= 50;
                       b = 255;
                   }
                   dst.SetPixel((int)(x + 17 * w / 30), (int)(y + h / 30), Color.FromArgb(r, g, b));

                   /////////////////////////////////////////////
                   r = color.R;
                   g = color.G;
                   b = color.B;

                   if (brght < 0.15)
                   {
                       b = 75;
                       r = 75;
                   }

                   if (brght >= 0.15 & brght < 0.3)
                   {
                       r = 50;
                       b = 150;
                   }

                   if (brght >= 0.3 & brght < 0.85)
                   {
                       r = 255;
                       g = 175;
                       // b = 250;
                   }

                   if (brght >= 0.85)
                   {
                       g = 200;
                       b = 100;
                   }
                   dst.SetPixel((int)(x + 17 * w / 30), (int)(y + 17 * h / 30), Color.FromArgb(r, g, b));

                   /////////////////////////////////////////////
                   r = color.R;
                   g = color.G;
                   b = color.B;

                   if (brght < 0.15)
                   {
                       b = 100;
                       g = 100;
                   }

                   if (brght >= 0.15 & brght < 0.3)
                   {
                       r = 50;
                       b = 50;
                   }

                   if (brght >= 0.3 & brght < 0.85)
                   {
                       r -= 10;
                       g = 250;
                       b += 25;
                   }

                   if (brght >= 0.85)
                   {
                       g = 210;
                       b = 150;
                       r = 15;
                   }
                   dst.SetPixel((int)(x + w / 30), (int)(y + 17 * h / 30), Color.FromArgb(r, g, b));

               }
           }
           image = dst;
            pictureBox1.Image = dst;
            progressBar1.Value = 0;
            progressBar1.Visible = false;

        }



        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            sharpen();
            kern();
            
        }

        private void чБ2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            willow();
          
        }

        private void рамка1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            cold();
           
        }

        private void эффектКрасныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hope();
        }

        private void старинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            nashville();
            
        }

        private void эффектКраскиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bp();
        }

        private void эффект2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            heat();
        }

        private void коллажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            collage();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void слабоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                blur(3);
                kern();
            }

            else MessageBox.Show("Выбирите файл");
        }

        private void среднееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                blur(5);
                kern();
            }

            else MessageBox.Show("Выбирите файл");
        }

        private void сильноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                blur(7);
                kern();
            }

            else MessageBox.Show("Выбирите файл");
        }

     
    
     }




}
