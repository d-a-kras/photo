using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HSV
{
    public partial class frmHSV : Form
    {
        Color color= Color.Black;
        public frmHSV()
        {
            InitializeComponent();
            updateColor(1);
            updateColor(2);
        }

        private void tbR_Scroll(object sender, EventArgs e)
        {
            lblR.Text = tbR.Value.ToString();
            color = Color.FromArgb(int.Parse(lblR.Text), int.Parse(lblG.Text), int.Parse(lblB.Text));
            updateColor(1);
        }
        private void tbG_Scroll(object sender, EventArgs e)
        {
            lblG.Text = tbG.Value.ToString();
            color = Color.FromArgb(int.Parse(lblR.Text), int.Parse(lblG.Text), int.Parse(lblB.Text));
            updateColor(1);
        }

        private void tbB_Scroll(object sender, EventArgs e)
        {
            lblB.Text = tbB.Value.ToString();
            color = Color.FromArgb(int.Parse(lblR.Text), int.Parse(lblG.Text), int.Parse(lblB.Text));
            updateColor(1);
        }

        private void updateColor(int mode)
        {
            if (mode == 1) //ползунки RGB
            {
                float h = color.GetHue();
                float s = color.GetSaturation();
                float v = color.GetBrightness();
                //устанавливаем движки:
                tbH.Value = (int)h;
                tbS.Value = (int)(s * 100.0);
                tbV.Value = (int)(v * 100.0);
                //обновляем метки:
                lblH.Text = tbH.Value.ToString();
                lblS.Text = tbS.Value.ToString();
                lblV.Text = tbV.Value.ToString();
            }
            else          //ползунки HSV
            {
                byte r = color.R;
                byte g = color.G;
                byte b = color.B;
                tbR.Value = r;
                tbG.Value = g;
                tbB.Value = b;
                lblR.Text = tbR.Value.ToString();
                lblG.Text = tbG.Value.ToString();
                lblB.Text = tbB.Value.ToString();
            }
            lblColor.BackColor = color;
        }

        private void tbH_Scroll(object sender, EventArgs e)
        {
            lblH.Text = tbH.Value.ToString();
            color = HSV2RGB(int.Parse(lblH.Text), int.Parse(lblS.Text), int.Parse(lblV.Text));
            updateColor(2);
        }

        private void tbS_Scroll(object sender, EventArgs e)
        {
            lblS.Text = tbS.Value.ToString();
            color = HSV2RGB(int.Parse(lblH.Text), int.Parse(lblS.Text), int.Parse(lblV.Text));
            updateColor(2);
        }

        private void tbV_Scroll(object sender, EventArgs e)
        {
            lblV.Text = tbV.Value.ToString();
            color = HSV2RGB(int.Parse(lblH.Text), int.Parse(lblS.Text), int.Parse(lblV.Text));
            updateColor(2);
        }

        public static Color HSV2RGB(double h, double s, double v)
        {
            s = s / 100.0;
            v = v / 100.0;
            double r = 0, g = 0, b = 0;

            //оттенки серого:
            if (s == 0)
                r = g = b = v;
            else
            {
                int Hi = (int)Math.Floor(h / 60);
                double f = h / 60 - Hi;

                //цветовые оси:
                double p = v * (1 - s);
                double q = v * (1 - (s * f));
                double t = v * (1 - (s * (1 - f)));

                switch (Hi)
                {
                    case 0:
                        r = v;
                        g = t;
                        b = p;
                        break;
                    case 1:
                        r = q;
                        g = v;
                        b = p;
                        break;
                    case 2:
                        r = p;
                        g = v;
                        b = t;
                        break;
                    case 3:
                        r = p;
                        g = q;
                        b = v;
                        break;
                    case 4:
                        r = t;
                        g = p;
                        b = v;
                        break;
                    case 5:
                        r = v;
                        g = p;
                        b = q;
                        break;
                }
            }
            return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
        }
    }
}
