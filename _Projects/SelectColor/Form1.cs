using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelectColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color clr = Color.White;
            ColorDialog cd = new ColorDialog();
            cd.Color = clr;
            if (cd.ShowDialog() == DialogResult.OK)
                clr = cd.Color;
            this.BackColor = clr;
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            Color clr = Color.White;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                clr = colorDialog1.Color;
            this.BackColor = clr;
        }
    }
}
