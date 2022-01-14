
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
            this.dgvColumn1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnColumn1 = new System.Windows.Forms.Button();
            this.lColumn1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumn1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvColumn1
            // 
            this.dgvColumn1.AllowUserToAddRows = false;
            this.dgvColumn1.AllowUserToDeleteRows = false;
            this.dgvColumn1.AllowUserToResizeColumns = false;
            this.dgvColumn1.AllowUserToResizeRows = false;
            this.dgvColumn1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumn1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvColumn1.Location = new System.Drawing.Point(0, 0);
            this.dgvColumn1.Name = "dgvColumn1";
            this.dgvColumn1.ReadOnly = true;
            this.dgvColumn1.Size = new System.Drawing.Size(543, 111);
            this.dgvColumn1.TabIndex = 0;
            this.dgvColumn1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnColumn1
            // 
            this.btnColumn1.Location = new System.Drawing.Point(12, 126);
            this.btnColumn1.Name = "btnColumn1";
            this.btnColumn1.Size = new System.Drawing.Size(88, 23);
            this.btnColumn1.TabIndex = 1;
            this.btnColumn1.Text = "Розрахувати";
            this.btnColumn1.UseVisualStyleBackColor = true;
            this.btnColumn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lColumn1
            // 
            this.lColumn1.AutoSize = true;
            this.lColumn1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lColumn1.Location = new System.Drawing.Point(405, 127);
            this.lColumn1.Name = "lColumn1";
            this.lColumn1.Size = new System.Drawing.Size(0, 19);
            this.lColumn1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 161);
            this.Controls.Add(this.lColumn1);
            this.Controls.Add(this.btnColumn1);
            this.Controls.Add(this.dgvColumn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumn1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnColumn1;
        private System.Windows.Forms.Label lColumn1;
    }
}

