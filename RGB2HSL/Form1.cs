using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB2HSL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int R_value = 0;
        int G_value = 0;
        int B_value = 0;
        double H_value = 0;
        double S_value = 0;
        double L_value = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            R_value = Decimal.ToInt32(R_numericUpDown1.Value);
            RgbToHls(R_value, G_value, B_value, out H_value, out L_value, out S_value);
            textBoxH.Text = H_value.ToString();
            textBoxL.Text = L_value.ToString();
            textBoxS.Text = S_value.ToString();
            DisplayColor(R_value, G_value, B_value);
        }

        private void G_numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            G_value = Decimal.ToInt32(G_numericUpDown2.Value);
            RgbToHls(R_value, G_value, B_value, out H_value, out L_value, out S_value);
            textBoxH.Text = H_value.ToString();
            textBoxL.Text = L_value.ToString();
            textBoxS.Text = S_value.ToString();
            DisplayColor(R_value, G_value, B_value);
        }

        private void B_numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            B_value = Decimal.ToInt32(B_numericUpDown3.Value);
            RgbToHls(R_value, G_value, B_value, out H_value, out L_value, out S_value);
            textBoxH.Text = H_value.ToString();
            textBoxL.Text = L_value.ToString();
            textBoxS.Text = S_value.ToString();
            DisplayColor(R_value, G_value, B_value);
        }

        private void textBoxH_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxL_TextChanged(object sender, EventArgs e)
        {

        }
        private void RgbToHls(int r, int g, int b,out double h, out double l, out double s)
        {
            // Convert RGB to a 0.0 to 1.0 range.
            double double_r = r / 255.0;
            double double_g = g / 255.0;
            double double_b = b / 255.0;

            // Get the maximum and minimum RGB components.
            double max = double_r;
            if (max < double_g) max = double_g;
            if (max < double_b) max = double_b;

            double min = double_r;
            if (min > double_g) min = double_g;
            if (min > double_b) min = double_b;

            double diff = max - min;
            l = (max + min) / 2;
            if (Math.Abs(diff) < 0.00001)
            {
                s = 0;
                h = 0;  // H is really undefined.
            }
            else
            {
                if (l <= 0.5) s = diff / (max + min);
                else s = diff / (2 - max - min);

                double r_dist = (max - double_r) / diff;
                double g_dist = (max - double_g) / diff;
                double b_dist = (max - double_b) / diff;

                if (double_r == max) h = b_dist - g_dist;
                else if (double_g == max) h = 2 + r_dist - b_dist;
                else h = 4 + g_dist - r_dist;

                h = h * 60;
                if (h < 0) h += 360;
            }
        }
        private void DisplayColor(int R,int G,int B)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Height, pictureBox1.Width);
            for (int i = 0; i <= bmp.Width - 1; i++)
            {
                for (int j = 0; j <= bmp.Height - 1; j++)
                {
                    bmp.SetPixel(i,j,Color.FromArgb(R, G, B));
                }
            }
            pictureBox1.Image = bmp;
        }
    }
}
