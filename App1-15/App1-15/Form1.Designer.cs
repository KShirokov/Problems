﻿namespace App1_15
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputEtalonLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.MaxDiff = new System.Windows.Forms.Label();
            this.DiffCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textArray
            // 
            this.textArray.Location = new System.Drawing.Point(12, 95);
            this.textArray.Name = "textArray";
            this.textArray.Size = new System.Drawing.Size(794, 20);
            this.textArray.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите замеры длин конструкций через запятую.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Длина эталонной конструкции:";
            // 
            // InputEtalonLength
            // 
            this.InputEtalonLength.Location = new System.Drawing.Point(184, 19);
            this.InputEtalonLength.Name = "InputEtalonLength";
            this.InputEtalonLength.Size = new System.Drawing.Size(100, 20);
            this.InputEtalonLength.TabIndex = 4;
            this.InputEtalonLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Наибольшее отклонение длины в наименьшую сторону:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 182);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(372, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Количество конструкций, имеющих отклонение в наименьшую сторону:";
            // 
            // MaxDiff
            // 
            this.MaxDiff.AutoSize = true;
            this.MaxDiff.Location = new System.Drawing.Point(390, 149);
            this.MaxDiff.Name = "MaxDiff";
            this.MaxDiff.Size = new System.Drawing.Size(0, 13);
            this.MaxDiff.TabIndex = 7;
            // 
            // DiffCount
            // 
            this.DiffCount.AutoSize = true;
            this.DiffCount.Location = new System.Drawing.Point(390, 182);
            this.DiffCount.Name = "DiffCount";
            this.DiffCount.Size = new System.Drawing.Size(0, 13);
            this.DiffCount.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 377);
            this.Controls.Add(this.DiffCount);
            this.Controls.Add(this.MaxDiff);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputEtalonLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textArray);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputEtalonLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label MaxDiff;
        private System.Windows.Forms.Label DiffCount;
    }
}

