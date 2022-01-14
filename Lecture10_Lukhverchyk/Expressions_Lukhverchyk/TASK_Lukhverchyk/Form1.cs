using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_Lukhverchyk
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double min = -5; double max = 5; double krok = 0.25; double Num = 12;
                int cou = (int)Math.Ceiling((max - min) / krok) + 1;
                double[] x = new double[cou];
                double[] y1 = new double[cou];
                double[] y2 = new double[cou];
                double[] y3 = new double[cou];

                for (int i = 0; i < cou; i++)
                {
                    x[i] = min + krok * i;
                    y1[i] = ((4 * Num) / Math.PI) * (Math.Cos(x[i]) - (1 / 3.0) * Math.Cos(3 * x[i]) + (1 / 5.0) * Math.Cos(5 * x[i]));
                    y3[i] = ((2 * Num) / Math.PI) * (4.0 / Math.PI) * (Math.Cos(x[i]) + (1.0 / Math.Pow(3, 2)) * Math.Cos(3 * x[i]) + (1.0 / Math.Pow(5, 2)) * Math.Cos(5 * x[i]));
                    y2[i] = ((2 * Num) / Math.PI) * (Math.Sin(x[i]) - (1 / 2.0) * Math.Cos(2 * x[i]) + (1 / 3.0) * Math.Sin(3 * x[i]) - (1 / 4.0) * Math.Sin(4 * x[i]));

                }
                cGraphics1.ChartAreas[0].AxisX.Minimum = min; cGraphics1.ChartAreas[0].AxisX.Maximum = max; cGraphics1.ChartAreas[0].AxisX.MajorGrid.Interval = krok;
                cGraphics1.Series[0].Points.DataBindXY(x, y1); cGraphics1.Series[1].Points.DataBindXY(x, y2); cGraphics1.Series[2].Points.DataBindXY(x, y3);
                lGraphics1.Text = "Дата та час: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            }
            catch
            {
            }
        }

        private void lGraphics1_Click(object sender, EventArgs e)
        {

        }
    }
}
