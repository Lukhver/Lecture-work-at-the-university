using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKS_Lukhverchyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();

            Point[] myArray =
        {
                new Point(5,250),
                new Point (320,245),
                new Point (420, 0),
                new Point (520,250),
                new Point (830, 255),
                new Point (585, 400),
                new Point (675,645),
                new Point (420, 505),
                new Point (165,640),
                new Point (255,400)
             };

            myPath.AddPolygon(myArray);

           

            Region myRegion = new Region(myPath);

            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        static void ring()
        {

        }
    }
}
