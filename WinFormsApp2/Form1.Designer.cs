﻿namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textSentence = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textSentence
            // 
            textSentence.Location = new Point(199, 125);
            textSentence.Name = "textSentence";
            textSentence.Size = new Size(205, 27);
            textSentence.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(86, 32);
            label1.Name = "label1";
            label1.Size = new Size(318, 66);
            label1.TabIndex = 1;
            label1.Text = "Дано предложение. Определить, сколько в нем одинаковых соседних букв. Пробелы не учитывать.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 125);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "Предложение";
            // 
            // button1
            // 
            button1.Location = new Point(249, 216);
            button1.Name = "button1";
            button1.Size = new Size(155, 29);
            button1.TabIndex = 3;
            button1.Text = "Вывести результат";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 257);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSentence);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textSentence;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
