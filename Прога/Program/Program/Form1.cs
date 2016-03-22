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
            
        }

        public static Bitmap image;
        public static string full_name_of_image = "\0";
        public static UInt32[,] pixel;

        //открытие изображения
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    full_name_of_image = open_dialog.FileName;
                    image = new Bitmap(open_dialog.FileName);
                    //this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Width = image.Width + 40;
                    this.Height = image.Height + 75;
                    this.pictureBox1.Size = image.Size;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate(); //????
                    //получение матрицы с пикселями
                    pixel = new UInt32[image.Height, image.Width];
                    for (int y = 0; y < image.Height; y++)
                        for (int x = 0; x < image.Width; x++)
                            pixel[y, x] = (UInt32)(image.GetPixel(x, y).ToArgb());
                }
                catch
                {
                    full_name_of_image = "\0";
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            if (full_name_of_image != "\0")
            {
                pixel = Filter.matrix_filtration(image.Width, image.Height, pixel, Filter.N2, Filter.blur);
                FromPixelToBitmap();
                FromBitmapToScreen();
            }

            else MessageBox.Show("Выбирите файл");
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

        private void Form1_Load(object sender, EventArgs e)
        {

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

            else MessageBox.Show("Выбирите файл");
        }

        private void зеркалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Bitmap bp = new Bitmap(image);
                for (int y = 0; y <= image.Height - 1; y++)
                {
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
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Bitmap bp = new Bitmap(image);
                for (int x = 0; x <= image.Width - 1; x++)
                {
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
            }
            else MessageBox.Show("Выбирите файл");
        }
    }
}
