using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcu
{
    public partial class Form1 : Form
    {

        string first = "";
        string second = "";

        string firstShow = "";

        char function;
        double result = 0.0;
        string input = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text ="";
            input += "1";
            calculatorDisplay.Text += input;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text ="";
            input += "2";
            calculatorDisplay.Text += input;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text ="";
            input += "3";
            calculatorDisplay.Text += input;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text ="";
            input += "4";
            calculatorDisplay.Text += input;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text ="";
            input += "5";
            calculatorDisplay.Text += input;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text ="";
            input += "6";
            calculatorDisplay.Text += input;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text ="";
            input += "7";
            calculatorDisplay.Text += input;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text ="";
            input += "8";
            calculatorDisplay.Text += input;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text ="";
            input += "9";
            calculatorDisplay.Text += input;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text ="";
            input += "0";
            calculatorDisplay.Text += input;
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            input += ".";
            calculatorDisplay.Text += input;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            input = "";
            result = 0.0;
            
            firstShow = input;
            calculatorShow.Text = firstShow;
            calculatorDisplay.Text = "0";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = input;
            firstShow = input +" / ";
            calculatorShow.Text = firstShow;
            input = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function ='*';
            first = input;
            firstShow = input +" * ";
            calculatorShow.Text = firstShow;
            input = "";
        }

        private void substractionButton_Click(object sender, EventArgs e)
        {
            function ='-';
            first = input;
            firstShow = input +" - ";
            calculatorShow.Text = firstShow;
            input = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            function ='+';
            first = input;
            firstShow = input +" + ";
            calculatorShow.Text = firstShow;
            input = "";
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
                second = input;
                double firstNum, secondNum;
                firstShow += input +" = ";
                calculatorShow.Text = firstShow;
                firstNum = Convert.ToDouble(first);
                secondNum = Convert.ToDouble(second);
                //plus
                if (function == '+')
                {
                    result = firstNum + secondNum;
                    calculatorDisplay.Text = result.ToString();
                }
                //minus
                else if (function == '-')
                {
                    result = firstNum - secondNum;
                    calculatorDisplay.Text = result.ToString();
                }
                //divide
                else if (function == '/')
                {
                    if (secondNum == '0')
                    {
                        calculatorDisplay.Text= "cant divide to 0";
                    }
                    else
                    {
                        result = firstNum / secondNum;
                        calculatorDisplay.Text = result.ToString();
                    }

                }
                //multiply
                else if (function == '*')
                {
                    result = firstNum * secondNum;
                    calculatorDisplay.Text = result.ToString();
                }

                first = "";
                second = "";
                input = "";
                firstShow= "";
          

        }
    }
}
