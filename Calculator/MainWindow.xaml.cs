using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum Op
        {
            PLUS,
            MINUS,
            MUL,
            DIV,
            NONE
        }

        int firstNumber = 0;
        private Op currentOp = Op.NONE;
        bool reset = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PreDigitClick()
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            if (reset)
            {
                firstNumber = int.Parse(textBox.Text);
                textBox.Text = "";
                reset = false;
            }
        }

        private void PreOpClick()
        {
            if (!reset)
            {
                int secondNumber = int.Parse(textBox.Text);
                int result = secondNumber;
                switch (currentOp)
                {
                    case Op.PLUS:
                        result = firstNumber + secondNumber;
                        break;
                    case Op.MINUS:
                        result = firstNumber - secondNumber;
                        break;
                    case Op.MUL:
                        result = firstNumber * secondNumber;
                        break;
                    case Op.DIV:
                        result = firstNumber / secondNumber;
                        break;
                }
                textBox.Text = result.ToString();
                reset = true;
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            PreDigitClick();
            textBox.Text += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            PreDigitClick();
            textBox.Text += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            PreDigitClick();
            textBox.Text += "9";
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            PreOpClick();
            currentOp = Op.PLUS;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            PreDigitClick();
            textBox.Text += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            PreDigitClick();
            textBox.Text += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            PreDigitClick();
            textBox.Text += "6";
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            PreOpClick();
            currentOp = Op.MINUS;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            PreDigitClick();
            textBox.Text += "1";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            PreDigitClick();
            textBox.Text += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            PreDigitClick();
            textBox.Text += "3";
        }

        private void buttonMul_Click(object sender, RoutedEventArgs e)
        {
            PreOpClick();
            currentOp = Op.MUL;
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            PreDigitClick();
            textBox.Text += "0";
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            PreOpClick();
            currentOp = Op.DIV;
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "0";
            currentOp = Op.NONE;
            firstNumber = 0;
            reset = false;
        }

        private void buttonEnter_Click(object sender, RoutedEventArgs e)
        {
            PreOpClick();
            currentOp = Op.NONE;
        }

        private void buttonPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "0")
            {
                int newNumber = int.Parse(textBox.Text) * (-1);
                textBox.Text = newNumber.ToString();
            }
        }
    }
}
