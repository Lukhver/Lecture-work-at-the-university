
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
            this.gbZakaz1 = new System.Windows.Forms.GroupBox();
            this.Processor = new System.Windows.Forms.CheckBox();
            this.gbZakaz4 = new System.Windows.Forms.GroupBox();
            this.NVIDIA = new System.Windows.Forms.CheckBox();
            this.ATI = new System.Windows.Forms.CheckBox();
            this.gbZakaz9 = new System.Windows.Forms.GroupBox();
            this.Radeon4 = new System.Windows.Forms.RadioButton();
            this.Radeon3 = new System.Windows.Forms.RadioButton();
            this.Radeon2 = new System.Windows.Forms.RadioButton();
            this.Radeon1 = new System.Windows.Forms.RadioButton();
            this.gbZakaz8 = new System.Windows.Forms.GroupBox();
            this.GeForce4 = new System.Windows.Forms.RadioButton();
            this.GeForce3 = new System.Windows.Forms.RadioButton();
            this.GeForce2 = new System.Windows.Forms.RadioButton();
            this.GeForce1 = new System.Windows.Forms.RadioButton();
            this.gbZakaz3 = new System.Windows.Forms.GroupBox();
            this.VIA = new System.Windows.Forms.CheckBox();
            this.SiS = new System.Windows.Forms.CheckBox();
            this.gbZakaz7 = new System.Windows.Forms.GroupBox();
            this.pm2 = new System.Windows.Forms.RadioButton();
            this.pm1 = new System.Windows.Forms.RadioButton();
            this.Intel = new System.Windows.Forms.CheckBox();
            this.gbZakaz6 = new System.Windows.Forms.GroupBox();
            this.sis2 = new System.Windows.Forms.RadioButton();
            this.sis1 = new System.Windows.Forms.RadioButton();
            this.gbZakaz5 = new System.Windows.Forms.GroupBox();
            this.Express2 = new System.Windows.Forms.RadioButton();
            this.Express1 = new System.Windows.Forms.RadioButton();
            this.gbZakaz2 = new System.Windows.Forms.GroupBox();
            this.rbZakaz4 = new System.Windows.Forms.RadioButton();
            this.rbZakaz3 = new System.Windows.Forms.RadioButton();
            this.rbZakaz2 = new System.Windows.Forms.RadioButton();
            this.rbZakaz1 = new System.Windows.Forms.RadioButton();
            this.gbZakaz10 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Wywod = new System.Windows.Forms.Label();
            this.btnZakaz2 = new System.Windows.Forms.Button();
            this.btnZakaz1 = new System.Windows.Forms.Button();
            this.gbZakaz1.SuspendLayout();
            this.gbZakaz4.SuspendLayout();
            this.gbZakaz9.SuspendLayout();
            this.gbZakaz8.SuspendLayout();
            this.gbZakaz3.SuspendLayout();
            this.gbZakaz7.SuspendLayout();
            this.gbZakaz6.SuspendLayout();
            this.gbZakaz5.SuspendLayout();
            this.gbZakaz2.SuspendLayout();
            this.gbZakaz10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbZakaz1
            // 
            this.gbZakaz1.Controls.Add(this.Processor);
            this.gbZakaz1.Controls.Add(this.gbZakaz4);
            this.gbZakaz1.Controls.Add(this.gbZakaz3);
            this.gbZakaz1.Controls.Add(this.gbZakaz2);
            this.gbZakaz1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbZakaz1.Location = new System.Drawing.Point(12, 12);
            this.gbZakaz1.Name = "gbZakaz1";
            this.gbZakaz1.Size = new System.Drawing.Size(594, 377);
            this.gbZakaz1.TabIndex = 0;
            this.gbZakaz1.TabStop = false;
            this.gbZakaz1.Text = "Компоненты ПК";
            // 
            // Processor
            // 
            this.Processor.AutoSize = true;
            this.Processor.Location = new System.Drawing.Point(41, 58);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(103, 23);
            this.Processor.TabIndex = 18;
            this.Processor.Text = "Процессор";
            this.Processor.UseVisualStyleBackColor = true;
            // 
            // gbZakaz4
            // 
            this.gbZakaz4.Controls.Add(this.NVIDIA);
            this.gbZakaz4.Controls.Add(this.ATI);
            this.gbZakaz4.Controls.Add(this.gbZakaz9);
            this.gbZakaz4.Controls.Add(this.gbZakaz8);
            this.gbZakaz4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbZakaz4.Location = new System.Drawing.Point(288, 108);
            this.gbZakaz4.Name = "gbZakaz4";
            this.gbZakaz4.Size = new System.Drawing.Size(295, 263);
            this.gbZakaz4.TabIndex = 1;
            this.gbZakaz4.TabStop = false;
            this.gbZakaz4.Text = "Видеокарты";
            // 
            // NVIDIA
            // 
            this.NVIDIA.AutoSize = true;
            this.NVIDIA.Location = new System.Drawing.Point(9, 80);
            this.NVIDIA.Name = "NVIDIA";
            this.NVIDIA.Size = new System.Drawing.Size(70, 19);
            this.NVIDIA.TabIndex = 16;
            this.NVIDIA.Text = "NVIDIA";
            this.NVIDIA.UseVisualStyleBackColor = true;
            this.NVIDIA.CheckedChanged += new System.EventHandler(this.NVIDIA_CheckedChanged);
            this.NVIDIA.Click += new System.EventHandler(this.NVIDIA_Click);
            // 
            // ATI
            // 
            this.ATI.AutoSize = true;
            this.ATI.Location = new System.Drawing.Point(9, 198);
            this.ATI.Name = "ATI";
            this.ATI.Size = new System.Drawing.Size(46, 19);
            this.ATI.TabIndex = 17;
            this.ATI.Text = "ATI";
            this.ATI.UseVisualStyleBackColor = true;
            this.ATI.CheckedChanged += new System.EventHandler(this.ATI_CheckedChanged);
            this.ATI.Click += new System.EventHandler(this.ATI_Click);
            // 
            // gbZakaz9
            // 
            this.gbZakaz9.Controls.Add(this.Radeon4);
            this.gbZakaz9.Controls.Add(this.Radeon3);
            this.gbZakaz9.Controls.Add(this.Radeon2);
            this.gbZakaz9.Controls.Add(this.Radeon1);
            this.gbZakaz9.Location = new System.Drawing.Point(85, 150);
            this.gbZakaz9.Name = "gbZakaz9";
            this.gbZakaz9.Size = new System.Drawing.Size(200, 107);
            this.gbZakaz9.TabIndex = 2;
            this.gbZakaz9.TabStop = false;
            this.gbZakaz9.Text = "Тип видеокарты";
            // 
            // Radeon4
            // 
            this.Radeon4.AutoSize = true;
            this.Radeon4.Location = new System.Drawing.Point(5, 82);
            this.Radeon4.Name = "Radeon4";
            this.Radeon4.Size = new System.Drawing.Size(98, 19);
            this.Radeon4.TabIndex = 15;
            this.Radeon4.TabStop = true;
            this.Radeon4.Text = "Radeon X850";
            this.Radeon4.UseVisualStyleBackColor = true;
            this.Radeon4.CheckedChanged += new System.EventHandler(this.radioButton18_CheckedChanged);
            // 
            // Radeon3
            // 
            this.Radeon3.AutoSize = true;
            this.Radeon3.Location = new System.Drawing.Point(5, 63);
            this.Radeon3.Name = "Radeon3";
            this.Radeon3.Size = new System.Drawing.Size(98, 19);
            this.Radeon3.TabIndex = 14;
            this.Radeon3.TabStop = true;
            this.Radeon3.Text = "Radeon X800";
            this.Radeon3.UseVisualStyleBackColor = true;
            // 
            // Radeon2
            // 
            this.Radeon2.AutoSize = true;
            this.Radeon2.Location = new System.Drawing.Point(5, 42);
            this.Radeon2.Name = "Radeon2";
            this.Radeon2.Size = new System.Drawing.Size(98, 19);
            this.Radeon2.TabIndex = 13;
            this.Radeon2.TabStop = true;
            this.Radeon2.Text = "Radeon X700";
            this.Radeon2.UseVisualStyleBackColor = true;
            // 
            // Radeon1
            // 
            this.Radeon1.AutoSize = true;
            this.Radeon1.Location = new System.Drawing.Point(5, 21);
            this.Radeon1.Name = "Radeon1";
            this.Radeon1.Size = new System.Drawing.Size(98, 19);
            this.Radeon1.TabIndex = 12;
            this.Radeon1.Text = "Radeon X600";
            this.Radeon1.UseVisualStyleBackColor = true;
            // 
            // gbZakaz8
            // 
            this.gbZakaz8.Controls.Add(this.GeForce4);
            this.gbZakaz8.Controls.Add(this.GeForce3);
            this.gbZakaz8.Controls.Add(this.GeForce2);
            this.gbZakaz8.Controls.Add(this.GeForce1);
            this.gbZakaz8.Location = new System.Drawing.Point(85, 21);
            this.gbZakaz8.Name = "gbZakaz8";
            this.gbZakaz8.Size = new System.Drawing.Size(200, 123);
            this.gbZakaz8.TabIndex = 1;
            this.gbZakaz8.TabStop = false;
            this.gbZakaz8.Text = "Тип видеокарты";
            // 
            // GeForce4
            // 
            this.GeForce4.AutoSize = true;
            this.GeForce4.Location = new System.Drawing.Point(6, 94);
            this.GeForce4.Name = "GeForce4";
            this.GeForce4.Size = new System.Drawing.Size(99, 19);
            this.GeForce4.TabIndex = 11;
            this.GeForce4.TabStop = true;
            this.GeForce4.Text = "GeForce7800";
            this.GeForce4.UseVisualStyleBackColor = true;
            // 
            // GeForce3
            // 
            this.GeForce3.AutoSize = true;
            this.GeForce3.Location = new System.Drawing.Point(6, 69);
            this.GeForce3.Name = "GeForce3";
            this.GeForce3.Size = new System.Drawing.Size(99, 19);
            this.GeForce3.TabIndex = 10;
            this.GeForce3.TabStop = true;
            this.GeForce3.Text = "GeForce6800";
            this.GeForce3.UseVisualStyleBackColor = true;
            // 
            // GeForce2
            // 
            this.GeForce2.AutoSize = true;
            this.GeForce2.Location = new System.Drawing.Point(6, 44);
            this.GeForce2.Name = "GeForce2";
            this.GeForce2.Size = new System.Drawing.Size(99, 19);
            this.GeForce2.TabIndex = 9;
            this.GeForce2.TabStop = true;
            this.GeForce2.Text = "GeForce6600";
            this.GeForce2.UseVisualStyleBackColor = true;
            // 
            // GeForce1
            // 
            this.GeForce1.AutoSize = true;
            this.GeForce1.Location = new System.Drawing.Point(6, 21);
            this.GeForce1.Name = "GeForce1";
            this.GeForce1.Size = new System.Drawing.Size(131, 19);
            this.GeForce1.TabIndex = 8;
            this.GeForce1.Text = "GeForce6200/6500";
            this.GeForce1.UseVisualStyleBackColor = true;
            // 
            // gbZakaz3
            // 
            this.gbZakaz3.Controls.Add(this.VIA);
            this.gbZakaz3.Controls.Add(this.SiS);
            this.gbZakaz3.Controls.Add(this.gbZakaz7);
            this.gbZakaz3.Controls.Add(this.Intel);
            this.gbZakaz3.Controls.Add(this.gbZakaz6);
            this.gbZakaz3.Controls.Add(this.gbZakaz5);
            this.gbZakaz3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbZakaz3.Location = new System.Drawing.Point(6, 108);
            this.gbZakaz3.Name = "gbZakaz3";
            this.gbZakaz3.Size = new System.Drawing.Size(276, 263);
            this.gbZakaz3.TabIndex = 0;
            this.gbZakaz3.TabStop = false;
            this.gbZakaz3.Text = "Чипсеты";
            // 
            // VIA
            // 
            this.VIA.AutoSize = true;
            this.VIA.Location = new System.Drawing.Point(6, 213);
            this.VIA.Name = "VIA";
            this.VIA.Size = new System.Drawing.Size(48, 19);
            this.VIA.TabIndex = 20;
            this.VIA.Text = "VIA";
            this.VIA.UseVisualStyleBackColor = true;
            this.VIA.Click += new System.EventHandler(this.VIA_Click);
            // 
            // SiS
            // 
            this.SiS.AutoSize = true;
            this.SiS.Location = new System.Drawing.Point(6, 125);
            this.SiS.Name = "SiS";
            this.SiS.Size = new System.Drawing.Size(46, 19);
            this.SiS.TabIndex = 19;
            this.SiS.Text = "SiS";
            this.SiS.UseVisualStyleBackColor = true;
            this.SiS.Click += new System.EventHandler(this.SiS_Click);
            // 
            // gbZakaz7
            // 
            this.gbZakaz7.Controls.Add(this.pm2);
            this.gbZakaz7.Controls.Add(this.pm1);
            this.gbZakaz7.Location = new System.Drawing.Point(66, 183);
            this.gbZakaz7.Name = "gbZakaz7";
            this.gbZakaz7.Size = new System.Drawing.Size(200, 74);
            this.gbZakaz7.TabIndex = 3;
            this.gbZakaz7.TabStop = false;
            this.gbZakaz7.Text = "Тип чипсета";
            // 
            // pm2
            // 
            this.pm2.AutoSize = true;
            this.pm2.Location = new System.Drawing.Point(6, 46);
            this.pm2.Name = "pm2";
            this.pm2.Size = new System.Drawing.Size(73, 19);
            this.pm2.TabIndex = 7;
            this.pm2.TabStop = true;
            this.pm2.Text = "K8M800";
            this.pm2.UseVisualStyleBackColor = true;
            // 
            // pm1
            // 
            this.pm1.AutoSize = true;
            this.pm1.Location = new System.Drawing.Point(6, 21);
            this.pm1.Name = "pm1";
            this.pm1.Size = new System.Drawing.Size(72, 19);
            this.pm1.TabIndex = 6;
            this.pm1.Text = "P4M800";
            this.pm1.UseVisualStyleBackColor = true;
            // 
            // Intel
            // 
            this.Intel.AutoSize = true;
            this.Intel.Location = new System.Drawing.Point(6, 54);
            this.Intel.Name = "Intel";
            this.Intel.Size = new System.Drawing.Size(51, 19);
            this.Intel.TabIndex = 18;
            this.Intel.Text = "Intel";
            this.Intel.UseVisualStyleBackColor = true;
            this.Intel.Click += new System.EventHandler(this.Intel_Click);
            // 
            // gbZakaz6
            // 
            this.gbZakaz6.Controls.Add(this.sis2);
            this.gbZakaz6.Controls.Add(this.sis1);
            this.gbZakaz6.Location = new System.Drawing.Point(66, 94);
            this.gbZakaz6.Name = "gbZakaz6";
            this.gbZakaz6.Size = new System.Drawing.Size(200, 71);
            this.gbZakaz6.TabIndex = 3;
            this.gbZakaz6.TabStop = false;
            this.gbZakaz6.Text = "Тип чипсета";
            // 
            // sis2
            // 
            this.sis2.AutoSize = true;
            this.sis2.Location = new System.Drawing.Point(6, 46);
            this.sis2.Name = "sis2";
            this.sis2.Size = new System.Drawing.Size(66, 19);
            this.sis2.TabIndex = 6;
            this.sis2.TabStop = true;
            this.sis2.Text = "SiS760";
            this.sis2.UseVisualStyleBackColor = true;
            // 
            // sis1
            // 
            this.sis1.AutoSize = true;
            this.sis1.Location = new System.Drawing.Point(6, 21);
            this.sis1.Name = "sis1";
            this.sis1.Size = new System.Drawing.Size(66, 19);
            this.sis1.TabIndex = 5;
            this.sis1.Text = "SiS656";
            this.sis1.UseVisualStyleBackColor = true;
            // 
            // gbZakaz5
            // 
            this.gbZakaz5.Controls.Add(this.Express2);
            this.gbZakaz5.Controls.Add(this.Express1);
            this.gbZakaz5.Location = new System.Drawing.Point(66, 21);
            this.gbZakaz5.Name = "gbZakaz5";
            this.gbZakaz5.Size = new System.Drawing.Size(200, 67);
            this.gbZakaz5.TabIndex = 2;
            this.gbZakaz5.TabStop = false;
            this.gbZakaz5.Text = "Тип чипсета";
            // 
            // Express2
            // 
            this.Express2.AutoSize = true;
            this.Express2.Location = new System.Drawing.Point(6, 44);
            this.Express2.Name = "Express2";
            this.Express2.Size = new System.Drawing.Size(117, 19);
            this.Express2.TabIndex = 4;
            this.Express2.Text = "945/955 Express";
            this.Express2.UseVisualStyleBackColor = true;
            // 
            // Express1
            // 
            this.Express1.AutoSize = true;
            this.Express1.Location = new System.Drawing.Point(6, 21);
            this.Express1.Name = "Express1";
            this.Express1.Size = new System.Drawing.Size(117, 19);
            this.Express1.TabIndex = 3;
            this.Express1.Text = "915/925 Express";
            this.Express1.UseVisualStyleBackColor = true;
            // 
            // gbZakaz2
            // 
            this.gbZakaz2.Controls.Add(this.rbZakaz4);
            this.gbZakaz2.Controls.Add(this.rbZakaz3);
            this.gbZakaz2.Controls.Add(this.rbZakaz2);
            this.gbZakaz2.Controls.Add(this.rbZakaz1);
            this.gbZakaz2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbZakaz2.Location = new System.Drawing.Point(181, 25);
            this.gbZakaz2.Name = "gbZakaz2";
            this.gbZakaz2.Size = new System.Drawing.Size(220, 77);
            this.gbZakaz2.TabIndex = 1;
            this.gbZakaz2.TabStop = false;
            this.gbZakaz2.Text = "Тип процессора";
            // 
            // rbZakaz4
            // 
            this.rbZakaz4.AutoSize = true;
            this.rbZakaz4.Location = new System.Drawing.Point(109, 46);
            this.rbZakaz4.Name = "rbZakaz4";
            this.rbZakaz4.Size = new System.Drawing.Size(108, 19);
            this.rbZakaz4.TabIndex = 4;
            this.rbZakaz4.TabStop = true;
            this.rbZakaz4.Text = " AMD Sempron";
            this.rbZakaz4.UseVisualStyleBackColor = true;
            // 
            // rbZakaz3
            // 
            this.rbZakaz3.AutoSize = true;
            this.rbZakaz3.Location = new System.Drawing.Point(6, 46);
            this.rbZakaz3.Name = "rbZakaz3";
            this.rbZakaz3.Size = new System.Drawing.Size(97, 19);
            this.rbZakaz3.TabIndex = 3;
            this.rbZakaz3.TabStop = true;
            this.rbZakaz3.Text = "Intel Celeron";
            this.rbZakaz3.UseVisualStyleBackColor = true;
            // 
            // rbZakaz2
            // 
            this.rbZakaz2.AutoSize = true;
            this.rbZakaz2.Location = new System.Drawing.Point(109, 21);
            this.rbZakaz2.Name = "rbZakaz2";
            this.rbZakaz2.Size = new System.Drawing.Size(93, 19);
            this.rbZakaz2.TabIndex = 2;
            this.rbZakaz2.TabStop = true;
            this.rbZakaz2.Text = "AMD Athion";
            this.rbZakaz2.UseVisualStyleBackColor = true;
            // 
            // rbZakaz1
            // 
            this.rbZakaz1.AutoSize = true;
            this.rbZakaz1.Location = new System.Drawing.Point(6, 21);
            this.rbZakaz1.Name = "rbZakaz1";
            this.rbZakaz1.Size = new System.Drawing.Size(99, 19);
            this.rbZakaz1.TabIndex = 1;
            this.rbZakaz1.Text = "Intel Pentium";
            this.rbZakaz1.UseVisualStyleBackColor = true;
            // 
            // gbZakaz10
            // 
            this.gbZakaz10.Controls.Add(this.panel1);
            this.gbZakaz10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbZakaz10.Location = new System.Drawing.Point(265, 395);
            this.gbZakaz10.Name = "gbZakaz10";
            this.gbZakaz10.Size = new System.Drawing.Size(341, 95);
            this.gbZakaz10.TabIndex = 0;
            this.gbZakaz10.TabStop = false;
            this.gbZakaz10.Text = "Выбрана следующая коплектация ПК";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Wywod);
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 62);
            this.panel1.TabIndex = 21;
            // 
            // Wywod
            // 
            this.Wywod.AutoSize = true;
            this.Wywod.Location = new System.Drawing.Point(3, 0);
            this.Wywod.Name = "Wywod";
            this.Wywod.Size = new System.Drawing.Size(0, 15);
            this.Wywod.TabIndex = 0;
            // 
            // btnZakaz2
            // 
            this.btnZakaz2.BackColor = System.Drawing.Color.White;
            this.btnZakaz2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZakaz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZakaz2.Location = new System.Drawing.Point(235, 496);
            this.btnZakaz2.Name = "btnZakaz2";
            this.btnZakaz2.Size = new System.Drawing.Size(120, 30);
            this.btnZakaz2.TabIndex = 20;
            this.btnZakaz2.Text = "Закрыть";
            this.btnZakaz2.UseVisualStyleBackColor = false;
            this.btnZakaz2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnZakaz1
            // 
            this.btnZakaz1.BackColor = System.Drawing.Color.White;
            this.btnZakaz1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZakaz1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZakaz1.ForeColor = System.Drawing.Color.Red;
            this.btnZakaz1.Location = new System.Drawing.Point(18, 415);
            this.btnZakaz1.Name = "btnZakaz1";
            this.btnZakaz1.Size = new System.Drawing.Size(230, 50);
            this.btnZakaz1.TabIndex = 19;
            this.btnZakaz1.Text = "Сделать заказ";
            this.btnZakaz1.UseVisualStyleBackColor = false;
            this.btnZakaz1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(620, 537);
            this.Controls.Add(this.btnZakaz2);
            this.Controls.Add(this.btnZakaz1);
            this.Controls.Add(this.gbZakaz10);
            this.Controls.Add(this.gbZakaz1);
            this.Name = "Form1";
            this.Text = "Выбор комплектующих компонентов ПК";
            this.gbZakaz1.ResumeLayout(false);
            this.gbZakaz1.PerformLayout();
            this.gbZakaz4.ResumeLayout(false);
            this.gbZakaz4.PerformLayout();
            this.gbZakaz9.ResumeLayout(false);
            this.gbZakaz9.PerformLayout();
            this.gbZakaz8.ResumeLayout(false);
            this.gbZakaz8.PerformLayout();
            this.gbZakaz3.ResumeLayout(false);
            this.gbZakaz3.PerformLayout();
            this.gbZakaz7.ResumeLayout(false);
            this.gbZakaz7.PerformLayout();
            this.gbZakaz6.ResumeLayout(false);
            this.gbZakaz6.PerformLayout();
            this.gbZakaz5.ResumeLayout(false);
            this.gbZakaz5.PerformLayout();
            this.gbZakaz2.ResumeLayout(false);
            this.gbZakaz2.PerformLayout();
            this.gbZakaz10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbZakaz1;
        private System.Windows.Forms.GroupBox gbZakaz4;
        private System.Windows.Forms.GroupBox gbZakaz9;
        private System.Windows.Forms.RadioButton Radeon4;
        private System.Windows.Forms.RadioButton Radeon3;
        private System.Windows.Forms.RadioButton Radeon2;
        private System.Windows.Forms.RadioButton Radeon1;
        private System.Windows.Forms.GroupBox gbZakaz8;
        private System.Windows.Forms.RadioButton GeForce4;
        private System.Windows.Forms.RadioButton GeForce3;
        private System.Windows.Forms.RadioButton GeForce2;
        private System.Windows.Forms.RadioButton GeForce1;
        private System.Windows.Forms.GroupBox gbZakaz3;
        private System.Windows.Forms.GroupBox gbZakaz7;
        private System.Windows.Forms.RadioButton pm2;
        private System.Windows.Forms.RadioButton pm1;
        private System.Windows.Forms.GroupBox gbZakaz6;
        private System.Windows.Forms.RadioButton sis2;
        private System.Windows.Forms.RadioButton sis1;
        private System.Windows.Forms.GroupBox gbZakaz5;
        private System.Windows.Forms.RadioButton Express2;
        private System.Windows.Forms.RadioButton Express1;
        private System.Windows.Forms.GroupBox gbZakaz2;
        private System.Windows.Forms.RadioButton rbZakaz4;
        private System.Windows.Forms.RadioButton rbZakaz3;
        private System.Windows.Forms.RadioButton rbZakaz2;
        private System.Windows.Forms.RadioButton rbZakaz1;
        private System.Windows.Forms.GroupBox gbZakaz10;
        private System.Windows.Forms.CheckBox Processor;
        private System.Windows.Forms.CheckBox NVIDIA;
        private System.Windows.Forms.CheckBox ATI;
        private System.Windows.Forms.CheckBox VIA;
        private System.Windows.Forms.CheckBox SiS;
        private System.Windows.Forms.CheckBox Intel;
        private System.Windows.Forms.Button btnZakaz1;
        private System.Windows.Forms.Button btnZakaz2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Wywod;
    }
}

