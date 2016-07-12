using System;
using System.Windows.Forms;
using Calculator.OneArguments;
using Calculator.TwoArguments;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            double firstvalue = Convert.ToDouble(textBox1.Text);
            double secondvalue = Convert.ToDouble(textBox2.Text);
            ITwoArgCalculator calculator = TwoArgFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstvalue, secondvalue);
            textBox3.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstvalue = Convert.ToDouble(textBox1.Text);
            IOneArgCalculator calculator = OneArgFactory.CreateCalculator(((Button) sender).Name);
            double result = calculator.Calculate(firstvalue);
            textBox3.Text = result.ToString();
        }
    }
}
