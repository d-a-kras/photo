using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                    pictureBox1.SetBounds(10,10,p.Width,p.Height);
                    pictureBox1.Image = p;
                   
                    
                }
                catch (Exception ) {
                    
                };
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(p);
            Bitmap rez=new Bitmap(50,50);
            Graphics graphics = Graphics.FromImage(rez); // Graphics для рисования на smallImage
            graphics.DrawImage(b, new Point(-25, -25)); // Рисуем bigImage на smallImage, где (-25, -25) координата положения верхнего левого угла bigImage на smallImage
            graphics.Dispose(); // Закрываем graphics
            pictureBox1.Image = rez;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            SaveFileDialog sfd=new SaveFileDialog();
            
            sfd.ShowDialog();
            if (sfd.FileName!=null) {
                b.Save(sfd.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


    }
}
