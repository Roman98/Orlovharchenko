﻿namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.umnojenie = new System.Windows.Forms.Button();
            this.delenie = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Sinus = new System.Windows.Forms.Button();
            this.Cosinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(12, 94);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(12, 136);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button_Click);
            // 
            // umnojenie
            // 
            this.umnojenie.Location = new System.Drawing.Point(219, 94);
            this.umnojenie.Name = "umnojenie";
            this.umnojenie.Size = new System.Drawing.Size(75, 23);
            this.umnojenie.TabIndex = 4;
            this.umnojenie.Text = "*";
            this.umnojenie.UseVisualStyleBackColor = true;
            this.umnojenie.Click += new System.EventHandler(this.button_Click);
            // 
            // delenie
            // 
            this.delenie.Location = new System.Drawing.Point(219, 136);
            this.delenie.Name = "delenie";
            this.delenie.Size = new System.Drawing.Size(75, 23);
            this.delenie.TabIndex = 5;
            this.delenie.Text = "/";
            this.delenie.UseVisualStyleBackColor = true;
            this.delenie.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Ответ:";
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(115, 94);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(75, 23);
            this.Sinus.TabIndex = 8;
            this.Sinus.Text = "sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cosinus
            // 
            this.Cosinus.Location = new System.Drawing.Point(115, 136);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(75, 23);
            this.Cosinus.TabIndex = 9;
            this.Cosinus.Text = "cos";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 266);
            this.Controls.Add(this.Cosinus);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.delenie);
            this.Controls.Add(this.umnojenie);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Cosinus_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button umnojenie;
        private System.Windows.Forms.Button delenie;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Cosinus;
    }
}

