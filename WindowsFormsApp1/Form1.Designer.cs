
namespace WindowsFormsApp1
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
            this.richTextBoxBase = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSorted = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxCritic = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxBase
            // 
            this.richTextBoxBase.Location = new System.Drawing.Point(43, 12);
            this.richTextBoxBase.Name = "richTextBoxBase";
            this.richTextBoxBase.Size = new System.Drawing.Size(203, 187);
            this.richTextBoxBase.TabIndex = 0;
            this.richTextBoxBase.Text = "";
            // 
            // richTextBoxSorted
            // 
            this.richTextBoxSorted.Location = new System.Drawing.Point(433, 4);
            this.richTextBoxSorted.Name = "richTextBoxSorted";
            this.richTextBoxSorted.Size = new System.Drawing.Size(222, 195);
            this.richTextBoxSorted.TabIndex = 1;
            this.richTextBoxSorted.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxCritic
            // 
            this.checkBoxCritic.AutoSize = true;
            this.checkBoxCritic.Location = new System.Drawing.Point(334, 329);
            this.checkBoxCritic.Name = "checkBoxCritic";
            this.checkBoxCritic.Size = new System.Drawing.Size(80, 17);
            this.checkBoxCritic.TabIndex = 4;
            this.checkBoxCritic.Text = "checkBox1";
            this.checkBoxCritic.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBoxCritic);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxSorted);
            this.Controls.Add(this.richTextBoxBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxBase;
        private System.Windows.Forms.RichTextBox richTextBoxSorted;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxCritic;
        private System.Windows.Forms.Button button3;
    }
}

