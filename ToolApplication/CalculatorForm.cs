using System;
using System.Windows.Forms;

namespace ToolApplication
{
    public partial class CalculatorForm : Form
    {
        private double _result = 0;
        private string _operator = null;
        private bool _isOperatorClicked = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (_isOperatorClicked)
            {
                numericBox.Clear();
                _isOperatorClicked = false;
            }

            if (sender is Control button)
            {
                numericBox.Text += button.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            if (!(sender is Control button) || !double.TryParse(numericBox.Text, out double currentNumber))
            {
                return;
            }

            if (!string.IsNullOrEmpty(_operator) && !_isOperatorClicked)
            {
                BtnEqual_Click(this, EventArgs.Empty);
            }

            _operator = button.Text;
            _result = currentNumber;
            _isOperatorClicked = true;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_operator) || !double.TryParse(numericBox.Text, out double currentNumber))
                return;

            double result = _result;

            switch (_operator)
            {
                case "+":
                    result += currentNumber;
                    break;
                case "-":
                    result -= currentNumber;
                    break;
                case "*":
                    result *= currentNumber;
                    break;
                case "/":
                    if (currentNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!");
                        numericBox.Clear();
                        return;
                    }
                    result /= currentNumber;
                    break;
                default:
                    return;
            }

            if (!double.IsNaN(result) && !double.IsInfinity(result))
            {
                numericBox.Text = result.ToString();
                _result = result;
            }
            else
            {
                numericBox.Text = "Error";
            }

            _operator = null;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            numericBox.Clear();
            _result = 0;
            _operator = null;
            _isOperatorClicked = false;
        }
    }
}
