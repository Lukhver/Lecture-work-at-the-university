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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myCircle = new System.Drawing.Drawing2D.GraphicsPath();

            myCircle.AddEllipse(0, 0, Width, Height);

            Region myRegion = new Region(myCircle);

            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lukhverchyk Serhii\n2KH-Б\nTask №5\nLecture №6");
            Environment.Exit(0);
        }
    }
}
