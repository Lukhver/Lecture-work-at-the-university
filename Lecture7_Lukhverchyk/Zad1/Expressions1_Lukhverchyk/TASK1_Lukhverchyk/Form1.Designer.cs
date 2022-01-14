
namespace TASK1_Lukhverchyk
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
            this.tbVolume7 = new System.Windows.Forms.TrackBar();
            this.pbVolume7 = new System.Windows.Forms.ProgressBar();
            this.lVolume7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume7)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVolume7
            // 
            this.tbVolume7.Location = new System.Drawing.Point(237, 222);
            this.tbVolume7.Maximum = 100;
            this.tbVolume7.Name = "tbVolume7";
            this.tbVolume7.Size = new System.Drawing.Size(257, 45);
            this.tbVolume7.TabIndex = 0;
            this.tbVolume7.TickFrequency = 10;
            this.tbVolume7.Value = 55;
            this.tbVolume7.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pbVolume7
            // 
            this.pbVolume7.Location = new System.Drawing.Point(237, 165);
            this.pbVolume7.Name = "pbVolume7";
            this.pbVolume7.Size = new System.Drawing.Size(257, 42);
            this.pbVolume7.Step = 100;
            this.pbVolume7.TabIndex = 1;
            this.pbVolume7.Value = 55;
            this.pbVolume7.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lVolume7
            // 
            this.lVolume7.AutoSize = true;
            this.lVolume7.Location = new System.Drawing.Point(351, 124);
            this.lVolume7.Name = "lVolume7";
            this.lVolume7.Size = new System.Drawing.Size(27, 13);
            this.lVolume7.TabIndex = 2;
            this.lVolume7.Text = "55%";
            this.lVolume7.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lVolume7);
            this.Controls.Add(this.pbVolume7);
            this.Controls.Add(this.tbVolume7);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbVolume7;
        private System.Windows.Forms.ProgressBar pbVolume7;
        private System.Windows.Forms.Label lVolume7;
    }
}

