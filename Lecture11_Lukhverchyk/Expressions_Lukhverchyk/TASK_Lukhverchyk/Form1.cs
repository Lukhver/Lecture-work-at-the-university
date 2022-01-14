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
    public partial class lecture14 : Form
    {

        public lecture14()
        {
            InitializeComponent();
            lAbout3.Text = "Дата та час: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(); //About2
        }

        //Task7 1.1

        private void tbVolume7_Scroll(object sender, EventArgs e)
        {
            lVolume7.Text = String.Format(tbVolume7.Value + "%");
            pbVolume7.Value = tbVolume7.Value;
        }


        //Task7 1.2

        private void PrevierColor()
        {
            lRGB1.BackColor = Color.FromArgb((int)tbRGB1.Value,
            (int)tbRGB2.Value, (int)tbRGB3.Value);
            lRGB15.Text = tbRGB1.Value + "," + tbRGB2.Value + "," + tbRGB3.Value;
            lRGB7.Text = tbRGB1.Value + "";
            lRGB9.Text = tbRGB2.Value + "";
            lRGB11.Text = tbRGB3.Value + "";
            string HEX1 = Convert.ToString(tbRGB1.Value, 16);
            string HEX2 = Convert.ToString(tbRGB2.Value, 16);
            string HEX3 = Convert.ToString(tbRGB3.Value, 16);
            lRGB8.Text = HEX1;
            lRGB10.Text = HEX2;
            lRGB12.Text = HEX3;
            lRGB16.Text = HEX1 + HEX3 + HEX2; 
        }

        private void tbRGB1_Scroll(object sender, EventArgs e)
        {
            PrevierColor();
        }

        private void tbRGB2_Scroll(object sender, EventArgs e)
        {
            PrevierColor();
        }

        private void tbRGB3_Scroll(object sender, EventArgs e)
        {
            PrevierColor();
        }

        //Task8

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

        private void btnZakaz1_Click(object sender, EventArgs e)
        {
            Wywod.Text = "";
            Processors();
            ChipSet();
            GraphicsCard();
        }

        private void btnZakaz2_Click(object sender, EventArgs e)
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

        //Task9

        private int[,] Arraymatrix;

        private void lecture14_Load(object sender, EventArgs e)
        {
            dgvColumn1.RowCount = 4;
            dgvColumn1.ColumnCount = 5;
            Arraymatrix = new int[5, 4];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int element = random.Next(0, 100);
                    Arraymatrix[i, j] = element;
                    dgvColumn1.Rows[j].Cells[i].Value = Arraymatrix[i, j].ToString();
                }
            }
        }

        private void btnColumn1_Click(object sender, EventArgs e)
        {
            dgvColumn1.RowCount = 4;
            dgvColumn1.ColumnCount = 5;
            int[,] a = new int[4, 5];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                }
            }
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                { dgvColumn1.Rows[i].Cells[j].Value = a[i, j].ToString(); }
            }
            int b = int.MinValue;
            int count = 1;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (a[i, j] > b)
                    {
                        b = a[i, j];
                        lColumn1.Text = "Рядок №" + Convert.ToString(count);
                        count++;
                    }
                }
            }
        }

        //Task 10

        private void btnGraphics1_Click(object sender, EventArgs e)
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

        //About1

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Лухверчик Сергій\nФакультет: ФІПТ\nГрупа: 2КН-Б\nДоННУ\n" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), "Про програму");
        }

        //Task Condition

        private void task11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розробити додаток Volume. Додаток містить елементи TrackBar, ProgressBar, Label. При зміні положення TrackBar змінюється значення ProgressBar та значення індикатори відображається у %. Елемент TrackBar має максимальне значення 100 (дизайн додатку в лекції/презентації).", "Умова завдання №1.1");
        }

        private void task12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розробити додаток RGB.Додаток містить елементи TrackBar, Label. Додаток відображає код TrackBar(Red), TrackBar(Green), TrackBar(Blue) у десятковому та шістнадцятковому значенні, RGB код коліру у  десятковому та шістнадцятковому значенні та зафарбовує фон елемента Label кольором RGB.Елементи TrackBar мають максимальне значення 255.", "Умова завдання №1.2");
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розробити додаток «Заказ комплектуюших компонентов ПК», який дозволяє вибирати комплектучі компоненти ПК (тип процесорів, чипсетів та відеокарт) для формування заказа. У відповідності з вибраними компонентами за натисненням кнопки «Сделать заказ» виводиться повідомлення про замовлення, що зроблено.", "Умова завдання №2");
        }

        private void task3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розробити програму з використанням елементу dataGridView для реалізації індивідуального завдання.  Значення комірок dataGridView заповнити випадковими числами. Визначити номер стовпчика матриці дійсних чисел розміром 4x5 з найменшою сумою елементів.", "Умова завдання №3");
        }

        private void task4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розробити форму, в якій побудовані графіки функцій s1(x), s2(x), s3(x) при х, що змінюється від -5 до 5 з кроком 0.25, N – константа, що відповідає номеру за списком. На формі показується дата та час побудови графіків функцій.", "Умова завдання №4");
        }

        //About2
        private void tabControl1_Click(object sender, EventArgs e)
        {
            lAbout3.Text = "Дата та час: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void llAbout1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://fiat.donnu.edu.ua/");
        }

        private void llAbout2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.donnu.edu.ua/uk/");
        }

        //Save

        private void save()
        {
            rtbSave1.Text = "Автор: Лухверчик Сергій\nФакультет: ФІПТ\nГрупа: 2КН - Б\nДонецький національний університет(ДоННУ)\n\n" + lAbout3.Text + "\n\nTask #1\n" + lRGB15.Text + "\n" + lRGB16.Text + "\n\nTask #2\n" + Wywod.Text + "\n\nTask #3\n" + lColumn1.Text;

            try
            {
                rtbSave1.SaveFile("lecture11.rtf");
            }
            catch
            {
                MessageBox.Show("Помилка при збереженні!");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        //Copy

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            rtbSave1.Text = "Автор: Лухверчик Сергій\nФакультет: ФІПТ\nГрупа: 2КН - Б\nДонецький національний університет(ДоННУ)\n\n" + lAbout3.Text + "\n\nTask #1\n" + lRGB15.Text + "\n" + lRGB16.Text + "\n\nTask #2\n" + Wywod.Text + "\n\nTask #3\n" + lColumn1.Text;
            Clipboard.SetText(rtbSave1.Text);
        }

        //Exit

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
            Clipboard.SetText(rtbSave1.Text);
            Environment.Exit(0);
        }
    }
}
