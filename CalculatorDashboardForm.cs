using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class CalculatorDashboardForm : Form
    {
        private string lastOperator;

        public CalculatorDashboardForm()
        {
            InitializeComponent();
        }

        //decimal to number
        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = calculatorLabel.Text + ".";
        }

        //Clear information on calculator
        private void clearButton_Click(object sender, EventArgs e)
        {
            operatorLabel.ResetText();
            firstNumberLabel.ResetText();
            secondNumberLabel.ResetText();
            calculatorLabel.ResetText();
            equalLabel.ResetText();
        }
        // Calculator numbers
        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = calculatorLabel.Text + "0";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = calculatorLabel.Text + "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = calculatorLabel.Text + "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = calculatorLabel.Text + "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = calculatorLabel.Text + "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = calculatorLabel.Text + "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = calculatorLabel.Text + "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = calculatorLabel.Text + "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = calculatorLabel.Text + "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = calculatorLabel.Text + "9";
        }
        // end calculator numbers

        //Operators
        private void plusButton_Click(object sender, EventArgs e)
        {
            if (calculatorLabel.Text == "")
                return;
            
            operatorLabel.ResetText();

            //float.TryParse(calculatorLabel.Text, out firstNumber);

            operatorLabel.ResetText();
            operatorLabel.Text = "+";
            firstNumberLabel.Text = calculatorLabel.Text;

            lastOperator = "+";

            calculatorLabel.ResetText();

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (calculatorLabel.Text == "")
                return;

            operatorLabel.ResetText();

            //float.TryParse(calculatorLabel.Text, out firstNumber);

            operatorLabel.ResetText();
            operatorLabel.Text = "-";
            firstNumberLabel.Text = calculatorLabel.Text;

            lastOperator = "-";

            calculatorLabel.ResetText();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (calculatorLabel.Text == "")
                return;

            //float.TryParse(calculatorLabel.Text, out firstNumber);

            operatorLabel.ResetText();
            operatorLabel.Text = "*";
            firstNumberLabel.Text = calculatorLabel.Text;

            lastOperator = "*";

            calculatorLabel.ResetText();
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
            if (calculatorLabel.Text == "")
                return;

            //float.TryParse(calculatorLabel.Text, out firstNumber);

            operatorLabel.ResetText();
            operatorLabel.Text = "/";
            firstNumberLabel.Text = calculatorLabel.Text;

            lastOperator = "/";

            calculatorLabel.ResetText();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum;
            double result;

            if (calculatorLabel.Text == "")
                return;

            double.TryParse(firstNumberLabel.Text, out firstNum);
            double.TryParse(calculatorLabel.Text, out secondNum);
            
            switch (lastOperator)
            {
                case "+":
                    result = firstNum + secondNum;
                    secondNumberLabel.Text = secondNum.ToString();
                    calculatorLabel.Text = result.ToString();
                    break;
                case "-":
                    result = firstNum - secondNum;
                    secondNumberLabel.Text = secondNum.ToString();
                    calculatorLabel.Text = result.ToString();
                    break;
                case "*":
                    result = firstNum * secondNum;
                    secondNumberLabel.Text = secondNum.ToString();
                    calculatorLabel.Text = result.ToString();
                    break;
                case "/":
                    result = firstNum / secondNum;
                    secondNumberLabel.Text = secondNum.ToString();
                    calculatorLabel.Text = result.ToString();
                    break;
            }
            equalLabel.Text = "=";
        }

        //private bool ValidateForm()
        //{
        //    bool output = true;

        //    if (firstNumber == null)
        //        output = false;          
        //    if (secondNumber == null)
        //        output = false;
        //    if (lastOperator == null)
        //        output = false;

        //    return output;
        //}
    }
}
