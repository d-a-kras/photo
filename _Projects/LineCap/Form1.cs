using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LineCap
{
    public partial class frmLineCap : Form
    {
        Font fnt = new Font("Arial", 14, FontStyle.Bold);
        Pen pen = new Pen(Color.Black, 12);

        public frmLineCap()
        {
            InitializeComponent();
        }

        private void frmLineCap_Paint(object sender, PaintEventArgs e)
        {
            //номер стиля:
            int n = 0;
            int dy = 32;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //перебираем все стили концов линий в перечислении: 
            foreach (System.Drawing.Drawing2D.LineCap lc in Enum.GetValues(typeof(System.Drawing.Drawing2D.LineCap)))
            {
                e.Graphics.DrawString(lc.ToString(), fnt, Brushes.Blue, 10, 10 + n * dy);
                pen.StartCap = pen.EndCap = lc;
                e.Graphics.DrawLine(pen, 180, 20 + n * dy, this.Width - 20, 20 + n * dy);
                ++n;
            } 
        }
    }
}


