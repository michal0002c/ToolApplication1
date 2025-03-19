using System;
using System.Windows.Forms;

namespace ToolApplication
{
    public partial class CalculatorForm : Form
    {
        private double _result;
        private string _operator;
        private bool _isOperatorClicked;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (_isOperatorClicked)
            {
                textBox1.Clear();
                _isOperatorClicked = false;
            }

            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!double.TryParse(textBox1.Text, out double currentNumber))
            {
                return;
            }

            if (_operator != string.Empty && !_isOperatorClicked)
            {
                btnEqual.PerformClick();
            }

            _operator = button.Text;

            _result = currentNumber;
            _isOperatorClicked = true;
            textBox1.Clear();
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if (_operator == string.Empty || !double.TryParse(textBox1.Text, out double currentNumber))
                return;

            switch (_operator)
            {
                case "+":
                    textBox1.Text = (_result + currentNumber).ToString();
                    break;
                case "-":
                    textBox1.Text = (_result - currentNumber).ToString();
                    break;
                case "*":
                    textBox1.Text = (_result * currentNumber).ToString();
                    break;
                case "/":
                    if (currentNumber != 0)
                    {
                        textBox1.Text = (_result / currentNumber).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero!");
                        textBox1.Clear();
                    }
                    break;
            }

            _result = Double.Parse(textBox1.Text);
            _operator = string.Empty;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            _result = 0;
            _operator = string.Empty;
            _isOperatorClicked = false;
        }
    }
}
