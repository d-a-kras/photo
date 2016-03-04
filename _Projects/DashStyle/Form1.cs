using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DashStyle
{
    public partial class frmDashStyle : Form
    {
        Font fnt= new Font("Arial", 14, FontStyle.Bold);
        Pen pen = new Pen(Color.Black, 4);

        public frmDashStyle()
        {
            InitializeComponent();
        }


        private void frmDashStyle_Paint(object sender, PaintEventArgs e)
        {
            //номер стиля:
            int n = 0;
            int dy = 32;
            //перебираем все стили линий в перечислении: 
            foreach (System.Drawing.Drawing2D.DashStyle ds in Enum.GetValues(typeof(System.Drawing.Drawing2D.DashStyle)))
            {
                e.Graphics.DrawString(ds.ToString(), fnt, Brushes.Blue, 10, 10 + n * dy);
                pen.DashStyle = ds;
                if (ds == System.Drawing.Drawing2D.DashStyle.Custom)
                    pen.DashPattern = new float[] {1,2, 2,2, 3,2, 4,2, 5,2, 6,2, 7,2};

                e.Graphics.DrawLine(pen, 150, 20 + n * dy, this.Width-20, 20 + n * dy);
                ++n;
            } 
        }
    }
}
