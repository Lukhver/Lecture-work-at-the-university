
namespace TASK2_Lukhverchyk
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
            this.lRGB14 = new System.Windows.Forms.Label();
            this.lRGB13 = new System.Windows.Forms.Label();
            this.lRGB4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbRGB1 = new System.Windows.Forms.TrackBar();
            this.tbRGB2 = new System.Windows.Forms.TrackBar();
            this.tbRGB3 = new System.Windows.Forms.TrackBar();
            this.lRGB1 = new System.Windows.Forms.Label();
            this.lRGB5 = new System.Windows.Forms.Label();
            this.lRGB6 = new System.Windows.Forms.Label();
            this.lRGB2 = new System.Windows.Forms.Label();
            this.lRGB3 = new System.Windows.Forms.Label();
            this.lRGB7 = new System.Windows.Forms.Label();
            this.lRGB8 = new System.Windows.Forms.Label();
            this.lRGB9 = new System.Windows.Forms.Label();
            this.lRGB10 = new System.Windows.Forms.Label();
            this.lRGB11 = new System.Windows.Forms.Label();
            this.lRGB12 = new System.Windows.Forms.Label();
            this.lRGB15 = new System.Windows.Forms.Label();
            this.lRGB16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbRGB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRGB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRGB3)).BeginInit();
            this.SuspendLayout();
            // 
            // lRGB14
            // 
            this.lRGB14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lRGB14.Location = new System.Drawing.Point(20, 72);
            this.lRGB14.Name = "lRGB14";
            this.lRGB14.Size = new System.Drawing.Size(336, 211);
            this.lRGB14.TabIndex = 3;
            this.lRGB14.Click += new System.EventHandler(this.label1_Click);
            // 
            // lRGB13
            // 
            this.lRGB13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lRGB13.Location = new System.Drawing.Point(384, 72);
            this.lRGB13.Name = "lRGB13";
            this.lRGB13.Size = new System.Drawing.Size(268, 211);
            this.lRGB13.TabIndex = 4;
            // 
            // lRGB4
            // 
            this.lRGB4.AutoSize = true;
            this.lRGB4.Location = new System.Drawing.Point(28, 234);
            this.lRGB4.Name = "lRGB4";
            this.lRGB4.Size = new System.Drawing.Size(28, 13);
            this.lRGB4.TabIndex = 5;
            this.lRGB4.Text = "Blue";
            // 
            // tbRGB1
            // 
            this.tbRGB1.BackColor = System.Drawing.Color.Red;
            this.tbRGB1.Location = new System.Drawing.Point(70, 91);
            this.tbRGB1.Maximum = 255;
            this.tbRGB1.Name = "tbRGB1";
            this.tbRGB1.Size = new System.Drawing.Size(260, 45);
            this.tbRGB1.TabIndex = 7;
            this.tbRGB1.TickFrequency = 26;
            this.tbRGB1.Value = 168;
            this.tbRGB1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tbRGB2
            // 
            this.tbRGB2.BackColor = System.Drawing.Color.Green;
            this.tbRGB2.Location = new System.Drawing.Point(70, 154);
            this.tbRGB2.Maximum = 255;
            this.tbRGB2.Name = "tbRGB2";
            this.tbRGB2.Size = new System.Drawing.Size(260, 45);
            this.tbRGB2.TabIndex = 8;
            this.tbRGB2.TickFrequency = 26;
            this.tbRGB2.Value = 116;
            this.tbRGB2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // tbRGB3
            // 
            this.tbRGB3.BackColor = System.Drawing.Color.Blue;
            this.tbRGB3.Location = new System.Drawing.Point(70, 221);
            this.tbRGB3.Maximum = 255;
            this.tbRGB3.Name = "tbRGB3";
            this.tbRGB3.Size = new System.Drawing.Size(260, 45);
            this.tbRGB3.TabIndex = 9;
            this.tbRGB3.TickFrequency = 26;
            this.tbRGB3.Value = 181;
            this.tbRGB3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // lRGB1
            // 
            this.lRGB1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRGB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.lRGB1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lRGB1.Location = new System.Drawing.Point(20, 9);
            this.lRGB1.Name = "lRGB1";
            this.lRGB1.Size = new System.Drawing.Size(632, 45);
            this.lRGB1.TabIndex = 10;
            this.lRGB1.Click += new System.EventHandler(this.label5_Click);
            // 
            // lRGB5
            // 
            this.lRGB5.AutoSize = true;
            this.lRGB5.Location = new System.Drawing.Point(438, 87);
            this.lRGB5.Name = "lRGB5";
            this.lRGB5.Size = new System.Drawing.Size(29, 13);
            this.lRGB5.TabIndex = 17;
            this.lRGB5.Text = "DEX";
            // 
            // lRGB6
            // 
            this.lRGB6.AutoSize = true;
            this.lRGB6.Location = new System.Drawing.Point(569, 87);
            this.lRGB6.Name = "lRGB6";
            this.lRGB6.Size = new System.Drawing.Size(29, 13);
            this.lRGB6.TabIndex = 18;
            this.lRGB6.Text = "HEX";
            // 
            // lRGB2
            // 
            this.lRGB2.AutoSize = true;
            this.lRGB2.Location = new System.Drawing.Point(28, 106);
            this.lRGB2.Name = "lRGB2";
            this.lRGB2.Size = new System.Drawing.Size(27, 13);
            this.lRGB2.TabIndex = 21;
            this.lRGB2.Text = "Red";
            // 
            // lRGB3
            // 
            this.lRGB3.AutoSize = true;
            this.lRGB3.Location = new System.Drawing.Point(28, 169);
            this.lRGB3.Name = "lRGB3";
            this.lRGB3.Size = new System.Drawing.Size(36, 13);
            this.lRGB3.TabIndex = 22;
            this.lRGB3.Text = "Green";
            // 
            // lRGB7
            // 
            this.lRGB7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lRGB7.Location = new System.Drawing.Point(402, 103);
            this.lRGB7.Name = "lRGB7";
            this.lRGB7.Size = new System.Drawing.Size(100, 20);
            this.lRGB7.TabIndex = 23;
            this.lRGB7.Text = "168";
            this.lRGB7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lRGB7.Click += new System.EventHandler(this.label9_Click);
            // 
            // lRGB8
            // 
            this.lRGB8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lRGB8.Location = new System.Drawing.Point(534, 103);
            this.lRGB8.Name = "lRGB8";
            this.lRGB8.Size = new System.Drawing.Size(100, 20);
            this.lRGB8.TabIndex = 24;
            this.lRGB8.Text = "А8";
            this.lRGB8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lRGB8.UseCompatibleTextRendering = true;
            this.lRGB8.Click += new System.EventHandler(this.label10_Click);
            // 
            // lRGB9
            // 
            this.lRGB9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lRGB9.Location = new System.Drawing.Point(402, 166);
            this.lRGB9.Name = "lRGB9";
            this.lRGB9.Size = new System.Drawing.Size(100, 20);
            this.lRGB9.TabIndex = 25;
            this.lRGB9.Text = "116";
            this.lRGB9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lRGB9.UseCompatibleTextRendering = true;
            // 
            // lRGB10
            // 
            this.lRGB10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lRGB10.Location = new System.Drawing.Point(534, 166);
            this.lRGB10.Name = "lRGB10";
            this.lRGB10.Size = new System.Drawing.Size(100, 20);
            this.lRGB10.TabIndex = 26;
            this.lRGB10.Text = "74";
            this.lRGB10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lRGB10.UseCompatibleTextRendering = true;
            // 
            // lRGB11
            // 
            this.lRGB11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lRGB11.Location = new System.Drawing.Point(402, 231);
            this.lRGB11.Name = "lRGB11";
            this.lRGB11.Size = new System.Drawing.Size(100, 20);
            this.lRGB11.TabIndex = 27;
            this.lRGB11.Text = "181";
            this.lRGB11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lRGB11.UseCompatibleTextRendering = true;
            // 
            // lRGB12
            // 
            this.lRGB12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lRGB12.Location = new System.Drawing.Point(534, 231);
            this.lRGB12.Name = "lRGB12";
            this.lRGB12.Size = new System.Drawing.Size(100, 20);
            this.lRGB12.TabIndex = 28;
            this.lRGB12.Text = "B5";
            this.lRGB12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lRGB12.UseCompatibleTextRendering = true;
            // 
            // lRGB15
            // 
            this.lRGB15.BackColor = System.Drawing.Color.White;
            this.lRGB15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lRGB15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRGB15.Location = new System.Drawing.Point(20, 305);
            this.lRGB15.Name = "lRGB15";
            this.lRGB15.Size = new System.Drawing.Size(290, 26);
            this.lRGB15.TabIndex = 29;
            this.lRGB15.Text = "168,116,181";
            this.lRGB15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lRGB15.UseCompatibleTextRendering = true;
            // 
            // lRGB16
            // 
            this.lRGB16.BackColor = System.Drawing.Color.White;
            this.lRGB16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lRGB16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRGB16.Location = new System.Drawing.Point(362, 305);
            this.lRGB16.Name = "lRGB16";
            this.lRGB16.Size = new System.Drawing.Size(290, 26);
            this.lRGB16.TabIndex = 30;
            this.lRGB16.Text = "A8B574";
            this.lRGB16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lRGB16.UseCompatibleTextRendering = true;
            this.lRGB16.Click += new System.EventHandler(this.label16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 338);
            this.Controls.Add(this.lRGB16);
            this.Controls.Add(this.lRGB15);
            this.Controls.Add(this.lRGB12);
            this.Controls.Add(this.lRGB11);
            this.Controls.Add(this.lRGB10);
            this.Controls.Add(this.lRGB9);
            this.Controls.Add(this.lRGB8);
            this.Controls.Add(this.lRGB7);
            this.Controls.Add(this.lRGB3);
            this.Controls.Add(this.lRGB2);
            this.Controls.Add(this.lRGB6);
            this.Controls.Add(this.lRGB5);
            this.Controls.Add(this.lRGB1);
            this.Controls.Add(this.tbRGB3);
            this.Controls.Add(this.tbRGB2);
            this.Controls.Add(this.tbRGB1);
            this.Controls.Add(this.lRGB4);
            this.Controls.Add(this.lRGB13);
            this.Controls.Add(this.lRGB14);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRGB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRGB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRGB3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lRGB14;
        private System.Windows.Forms.Label lRGB13;
        private System.Windows.Forms.Label lRGB4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar tbRGB1;
        private System.Windows.Forms.TrackBar tbRGB2;
        private System.Windows.Forms.TrackBar tbRGB3;
        private System.Windows.Forms.Label lRGB1;
        private System.Windows.Forms.Label lRGB5;
        private System.Windows.Forms.Label lRGB6;
        private System.Windows.Forms.Label lRGB2;
        private System.Windows.Forms.Label lRGB3;
        private System.Windows.Forms.Label lRGB7;
        private System.Windows.Forms.Label lRGB8;
        private System.Windows.Forms.Label lRGB9;
        private System.Windows.Forms.Label lRGB10;
        private System.Windows.Forms.Label lRGB11;
        private System.Windows.Forms.Label lRGB12;
        private System.Windows.Forms.Label lRGB15;
        private System.Windows.Forms.Label lRGB16;
    }
}

