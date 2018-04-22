namespace Queue
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
            this.queueBox1 = new System.Windows.Forms.TextBox();
            this.queueBox2 = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queueBox1
            // 
            this.queueBox1.Location = new System.Drawing.Point(28, 143);
            this.queueBox1.Name = "queueBox1";
            this.queueBox1.Size = new System.Drawing.Size(451, 22);
            this.queueBox1.TabIndex = 0;
            // 
            // queueBox2
            // 
            this.queueBox2.Location = new System.Drawing.Point(28, 252);
            this.queueBox2.Name = "queueBox2";
            this.queueBox2.Size = new System.Drawing.Size(451, 22);
            this.queueBox2.TabIndex = 1;
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(28, 345);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(451, 22);
            this.ResultBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ввелите очередь X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите очередь Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "число шагов, через которое одна из очередей станет пустой";
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(28, 22);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(451, 55);
            this.Check.TabIndex = 6;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 441);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.queueBox2);
            this.Controls.Add(this.queueBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox queueBox1;
        private System.Windows.Forms.TextBox queueBox2;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Check;
    }
}

