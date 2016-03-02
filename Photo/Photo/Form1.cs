﻿using System;
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
                    Image p = Image.FromFile(ofd.FileName);
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
    }
}