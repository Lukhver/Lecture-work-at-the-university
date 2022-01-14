
namespace TASK_Lukhverchyk
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cGraphics1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraphics1 = new System.Windows.Forms.Button();
            this.lGraphics1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.cGraphics1)).BeginInit();
            this.SuspendLayout();
            // 
            // cGraphics1
            // 
            chartArea2.Name = "ChartArea1";
            this.cGraphics1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cGraphics1.Legends.Add(legend2);
            this.cGraphics1.Location = new System.Drawing.Point(12, 12);
            this.cGraphics1.Name = "cGraphics1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "s1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "s2";
            series6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "s3";
            this.cGraphics1.Series.Add(series4);
            this.cGraphics1.Series.Add(series5);
            this.cGraphics1.Series.Add(series6);
            this.cGraphics1.Size = new System.Drawing.Size(776, 365);
            this.cGraphics1.TabIndex = 0;
            this.cGraphics1.Text = "chart1";
            // 
            // btnGraphics1
            // 
            this.btnGraphics1.Location = new System.Drawing.Point(342, 397);
            this.btnGraphics1.Name = "btnGraphics1";
            this.btnGraphics1.Size = new System.Drawing.Size(75, 23);
            this.btnGraphics1.TabIndex = 1;
            this.btnGraphics1.Text = "Побудувати";
            this.btnGraphics1.UseVisualStyleBackColor = true;
            this.btnGraphics1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lGraphics1
            // 
            this.lGraphics1.AutoSize = true;
            this.lGraphics1.Location = new System.Drawing.Point(9, 402);
            this.lGraphics1.Name = "lGraphics1";
            this.lGraphics1.Size = new System.Drawing.Size(70, 13);
            this.lGraphics1.TabIndex = 2;
            this.lGraphics1.Text = "Дата та час:";
            this.lGraphics1.Click += new System.EventHandler(this.lGraphics1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lGraphics1);
            this.Controls.Add(this.btnGraphics1);
            this.Controls.Add(this.cGraphics1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cGraphics1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cGraphics1;
        private System.Windows.Forms.Button btnGraphics1;
        private System.Windows.Forms.Label lGraphics1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

