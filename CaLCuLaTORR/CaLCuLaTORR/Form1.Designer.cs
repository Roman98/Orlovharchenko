namespace Calculator
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
            this.Radical = new System.Windows.Forms.Button();
            this.Lg = new System.Windows.Forms.Button();
            this.Inverseof = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Involution = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Tangens = new System.Windows.Forms.Button();
            this.Cotangens = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Radical3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 20);
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
            this.textBox3.Location = new System.Drawing.Point(12, 278);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 20);
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
            // Radical
            // 
            this.Radical.Location = new System.Drawing.Point(318, 94);
            this.Radical.Name = "Radical";
            this.Radical.Size = new System.Drawing.Size(75, 23);
            this.Radical.TabIndex = 10;
            this.Radical.Text = "sqrt";
            this.Radical.UseVisualStyleBackColor = true;
            this.Radical.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lg
            // 
            this.Lg.Location = new System.Drawing.Point(318, 136);
            this.Lg.Name = "Lg";
            this.Lg.Size = new System.Drawing.Size(75, 23);
            this.Lg.TabIndex = 11;
            this.Lg.Text = "lg";
            this.Lg.UseVisualStyleBackColor = true;
            this.Lg.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inverseof
            // 
            this.Inverseof.Location = new System.Drawing.Point(219, 194);
            this.Inverseof.Name = "Inverseof";
            this.Inverseof.Size = new System.Drawing.Size(75, 23);
            this.Inverseof.TabIndex = 12;
            this.Inverseof.Text = "1/x";
            this.Inverseof.UseVisualStyleBackColor = true;
            this.Inverseof.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mod
            // 
            this.Mod.Location = new System.Drawing.Point(318, 194);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(75, 23);
            this.Mod.TabIndex = 13;
            this.Mod.Text = "%2";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.button_Click);
            // 
            // Involution
            // 
            this.Involution.Location = new System.Drawing.Point(219, 243);
            this.Involution.Name = "Involution";
            this.Involution.Size = new System.Drawing.Size(75, 23);
            this.Involution.TabIndex = 14;
            this.Involution.Text = "x^n";
            this.Involution.UseVisualStyleBackColor = true;
            this.Involution.Click += new System.EventHandler(this.button_Click);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(318, 243);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(75, 23);
            this.Ln.TabIndex = 15;
            this.Ln.Text = "ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tangens
            // 
            this.Tangens.Location = new System.Drawing.Point(12, 194);
            this.Tangens.Name = "Tangens";
            this.Tangens.Size = new System.Drawing.Size(75, 23);
            this.Tangens.TabIndex = 16;
            this.Tangens.Text = "tg";
            this.Tangens.UseVisualStyleBackColor = true;
            this.Tangens.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cotangens
            // 
            this.Cotangens.Location = new System.Drawing.Point(115, 194);
            this.Cotangens.Name = "Cotangens";
            this.Cotangens.Size = new System.Drawing.Size(75, 23);
            this.Cotangens.TabIndex = 17;
            this.Cotangens.Text = "ctg";
            this.Cotangens.UseVisualStyleBackColor = true;
            this.Cotangens.Click += new System.EventHandler(this.button1_Click);
            // 
            // Factorial
            // 
            this.Factorial.Location = new System.Drawing.Point(12, 243);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(75, 23);
            this.Factorial.TabIndex = 18;
            this.Factorial.Text = "x!";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // Radical3
            // 
            this.Radical3.Location = new System.Drawing.Point(115, 243);
            this.Radical3.Name = "Radical3";
            this.Radical3.Size = new System.Drawing.Size(75, 23);
            this.Radical3.TabIndex = 19;
            this.Radical3.Text = "sqr(3)";
            this.Radical3.UseVisualStyleBackColor = true;
            this.Radical3.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 322);
            this.Controls.Add(this.Radical3);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Cotangens);
            this.Controls.Add(this.Tangens);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Involution);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.Inverseof);
            this.Controls.Add(this.Lg);
            this.Controls.Add(this.Radical);
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
        private System.Windows.Forms.Button Radical;
        private System.Windows.Forms.Button Lg;
        private System.Windows.Forms.Button Inverseof;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Involution;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button Tangens;
        private System.Windows.Forms.Button Cotangens;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button Radical3;
    }
}

