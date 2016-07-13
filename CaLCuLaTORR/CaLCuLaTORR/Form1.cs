using System;
using System.Windows.Forms;
using Calculator.OneArguments;
using Calculator.TwoArguments;
using Calculator.SortMass;

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
            try
            {
                double firstvalue = Convert.ToDouble(textBox1.Text);
                double secondvalue = Convert.ToDouble(textBox2.Text);
                ITwoArgCalculator calculator = TwoArgFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstvalue, secondvalue);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка: " + exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double firstvalue = Convert.ToDouble(textBox1.Text);
                IOneArgCalculator calculator = OneArgFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstvalue);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка: " + exc.Message);
            }
        }

        private void Sort1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = Mass.Text.Split(' ');
                double[] doubleArray = new double[stringArray.Length];
                for (int i = 0; i < doubleArray.Length; i++)
                {
                    doubleArray[i] = Convert.ToDouble(stringArray[i]);
                }

                ISortMass calculator = SortMassFactory.CreateCalculator(((Button) sender).Name);
                calculator.Calculate(doubleArray);           //вызов сортировки

                string stringResult = "";
                for (int i = 0; i < doubleArray.Length; i++)
                {
                    stringResult += " " + doubleArray[i];
                }
                textBox3.Text = stringResult;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка: " + exc.Message);
            }
        }


    }
}
