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

        public void GraphicsCard()
        {
            if (NVIDIA.Checked == true)
            {
                Wywod.Text = Wywod.Text + "Видеокарта - " + NVIDIA.Text + " ";
                if (GeForce1.Checked == true)
                {
                    Wywod.Text = Wywod.Text + GeForce1.Text;
                }
                if (GeForce2.Checked == true)
                {
                    Wywod.Text = Wywod.Text + GeForce2.Text;
                }
                if (GeForce3.Checked == true)
                {
                    Wywod.Text = Wywod.Text + GeForce3.Text;
                }
                if (GeForce4.Checked == true)
                {
                    Wywod.Text = Wywod.Text + GeForce4.Text;
                }
                Wywod.Text = Wywod.Text + "\n";
            }

            if (ATI.Checked == true)
            {
                Wywod.Text = Wywod.Text + "Видеокарта - " + ATI.Text + " ";
                if (Radeon1.Checked == true)
                {
                    Wywod.Text = Wywod.Text + Radeon1.Text;
                }
                if (Radeon2.Checked == true)
                {
                    Wywod.Text = Wywod.Text + Radeon2.Text;
                }
                if (Radeon3.Checked == true)
                {
                    Wywod.Text = Wywod.Text + Radeon3.Text;
                }
                if (Radeon4.Checked == true)
                {
                    Wywod.Text = Wywod.Text + Radeon4.Text;
                }
                Wywod.Text = Wywod.Text + "\n";
            }
        }
        public void ChipSet()
        {
            if (Intel.Checked == true)
            {
                Wywod.Text = Wywod.Text + "Чипсет - " + Intel.Text + " ";
                if (Express1.Checked == true)
                {
                    Wywod.Text = Wywod.Text + Express1.Text;
                }
                if (Express2.Checked == true)
                {
                    Wywod.Text = Wywod.Text + Express1.Text;
                }
                Wywod.Text = Wywod.Text + "\n";
            }

            if (SiS.Checked == true)
            {
                Wywod.Text = Wywod.Text + "Чипсет - " + SiS.Text + " ";
                if (sis1.Checked == true)
                {
                    Wywod.Text = Wywod.Text + sis1.Text;
                }
                if (sis2.Checked == true)
                {
                    Wywod.Text = Wywod.Text + sis2.Text;
                }
                Wywod.Text = Wywod.Text + "\n";
            }

            if (VIA.Checked == true)
            {
                Wywod.Text = Wywod.Text + "Чипсет - " + VIA.Text + " ";
                if (pm1.Checked == true)
                {
                    Wywod.Text = Wywod.Text + pm1.Text;
                }
                if (pm2.Checked == true)
                {
                    Wywod.Text = Wywod.Text + pm2.Text;
                }
                Wywod.Text = Wywod.Text + "\n";
            }
        }
        public void Processors()
        {
            if (Processor.Checked == true)
            {
                Wywod.Text = Wywod.Text + Processor.Text + " - ";
                if (rbZakaz1.Checked == true)
                {
                    Wywod.Text = Wywod.Text + rbZakaz1.Text;
                }
                if (rbZakaz2.Checked == true)
                {
                    Wywod.Text = Wywod.Text + rbZakaz2.Text;
                }
                if (rbZakaz3.Checked == true)
                {
                    Wywod.Text = Wywod.Text + rbZakaz3.Text;
                }
                if (rbZakaz4.Checked == true)
                {
                    Wywod.Text = Wywod.Text + rbZakaz4.Text;
                }
                Wywod.Text = Wywod.Text + "\n";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wywod.Text = "";
            Processors();
            ChipSet();
            GraphicsCard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void NVIDIA_Click(object sender, EventArgs e)
        {
            if (NVIDIA.Checked == true)
            {
                ATI.Checked = false;
                Radeon1.Checked = false;
                Radeon2.Checked = false;
                Radeon3.Checked = false;
                Radeon4.Checked = false;
            }
        }

        private void ATI_Click(object sender, EventArgs e)
        {
            if (ATI.Checked == true)
            {
                NVIDIA.Checked = false;
                GeForce1.Checked = false;
                GeForce2.Checked = false;
                GeForce3.Checked = false;
                GeForce4.Checked = false;
            }
        }

        private void Intel_Click(object sender, EventArgs e)
        {
            if (Intel.Checked == true)
            {
                SiS.Checked = false;
                VIA.Checked = false;
                sis1.Checked = false;
                sis2.Checked = false;
                pm1.Checked = false;
                pm2.Checked = false;
            }
        }

        private void SiS_Click(object sender, EventArgs e)
        {
            if (SiS.Checked == true)
            {
                Intel.Checked = false;
                VIA.Checked = false;
                Express1.Checked = false;
                Express2.Checked = false;
                pm1.Checked = false;
                pm2.Checked = false;
            }
        }

        private void VIA_Click(object sender, EventArgs e)
        {
            if (VIA.Checked == true)
            {
                Intel.Checked = false;
                SiS.Checked = false;
                Express1.Checked = false;
                Express2.Checked = false;
                sis1.Checked = false;
                sis2.Checked = false;
            }
        }

        private void NVIDIA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ATI_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
