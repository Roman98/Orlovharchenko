using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaLCuLaTORR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)                                 //PLUS
        {
            //Convert.ToDouble(textBox1.Text);
            double firstvalue = Convert.ToDouble(textBox1.Text);
            double secondvalue = Convert.ToDouble(textBox2.Text);
            double result = firstvalue + secondvalue;
            textBox3.Text = result.ToString();
        }

        private void delenie_Click(object sender, EventArgs e)                                //DELENIE
        {
            double firstvalue = Convert.ToDouble(textBox1.Text);
            double secondvalue = Convert.ToDouble(textBox2.Text);
            double result = firstvalue / secondvalue;
            textBox3.Text = result.ToString();
        }


        private void umnojenie_Click(object sender, EventArgs e)                                   //UMNOJ
        {
            double firstvalue = Convert.ToDouble(textBox1.Text);
            double secondvalue = Convert.ToDouble(textBox2.Text);
            double result = firstvalue * secondvalue;
            textBox3.Text = result.ToString();
        }

        private void minus_Click(object sender, EventArgs e)                                  //MINUS
        {
            double firstvalue = Convert.ToDouble(textBox1.Text);
            double secondvalue = Convert.ToDouble(textBox2.Text);
            double result = firstvalue - secondvalue;
            textBox3.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
