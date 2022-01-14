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
        private int[,] Arraymatrix;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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
                {dgvColumn1.Rows[i].Cells[j].Value = a[i, j].ToString();}
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
    }
}