using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK2_Lukhverchyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PrevierColor()
        {
            lRGB1.BackColor = Color.FromArgb((int)tbRGB1.Value,
            (int)tbRGB2.Value, (int)tbRGB3.Value);
            lRGB15.Text = tbRGB1.Value + "," + tbRGB2.Value + "," + tbRGB3.Value;
            lRGB7.Text = tbRGB1.Value+"";
            lRGB9.Text = tbRGB2.Value+"";
            lRGB11.Text = tbRGB3.Value+"";
            string HEX1 = Convert.ToString(tbRGB1.Value, 16);
            string HEX2 = Convert.ToString(tbRGB2.Value, 16);
            string HEX3 = Convert.ToString(tbRGB3.Value, 16);
            lRGB8.Text = HEX1;
            lRGB10.Text = HEX2;
            lRGB12.Text = HEX3;
            lRGB16.Text = HEX1 + HEX3 + HEX2;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PrevierColor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            PrevierColor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            PrevierColor();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
