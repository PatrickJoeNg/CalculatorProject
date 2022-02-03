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
        public CalculatorDashboardForm()
        {
            InitializeComponent();
        }

        private void CalculatorDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = ".";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = "0";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = "0";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = "3";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calculatorLabel.Text = "9";
        }
    }
}
