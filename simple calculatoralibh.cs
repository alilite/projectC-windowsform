using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name:Ali Bahiraei
//Date : 18/07/2023
//descripton:it's calculator class that we use class according to word document
namespace project_section1
{
    public partial class simple_calculatoralibh : Form
    {
        private Calculator calculator;
        private decimal previousResult = 0;
        private bool isNewCalculation = true;

        public simple_calculatoralibh()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //just i put it here that i underestand what is the name for input
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "X";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (input.Contains("+") || input.Contains("-") || input.Contains("X") || input.Contains("/"))
            {
                try
                {
                    // Split the input into operands and operator
                    string[] parts = input.Split(new char[] { '+', '-', 'X', '/' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length == 2)
                    {
                        decimal operand1 = decimal.Parse(parts[0]);
                        decimal operand2 = decimal.Parse(parts[1]);
                       // decimal result = 0;

                        // Determine the operator and perform the corresponding operation
                        if (input.Contains("+"))
                        {
                            calculator.Add(operand1);
                            calculator.Equals(operand2);
                        }
                        else if (input.Contains("-"))
                        {
                            calculator.Subtract(operand1);
                            calculator.Equals(operand2);
                        }
                        else if (input.Contains("X"))
                        {
                            calculator.Multiply(operand1);
                            calculator.Equals(operand2);
                        }
                        else if (input.Contains("/"))
                        {
                            calculator.Divide(operand1);
                            calculator.Equals(operand2);
                        }

                        textBox2.Text = calculator.CurrentValue.ToString();
                        textBox1.Text = input + " = " + calculator.CurrentValue.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid input. Please enter a valid arithmetic expression.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred during evaluation: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No arithmetic operation found in the input.");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close theApp.? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ClearCalculator();

        }
        private void ClearCalculator()
        {
            calculator.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void simple_calculatoralibh_Load(object sender, EventArgs e)
        {

        }
    }
}
