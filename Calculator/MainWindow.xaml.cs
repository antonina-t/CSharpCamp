using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        int currentNumber = 0;
        bool reset = false;
        private Op currentOp = Op.NONE;

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
                currentNumber = int.Parse(textBox.Text);
                textBox.Text = "";
                reset = false;
            }
        }

        private void PreOpClick()
        {
            if (!reset)
            {
                switch(currentOp)
                {
                    case Op.PLUS:
                        textBox.Text = (currentNumber + int.Parse(textBox.Text)).ToString();
                        break;
                    case Op.MINUS:
                        textBox.Text = (currentNumber - int.Parse(textBox.Text)).ToString();
                        break;
                    case Op.MUL:
                        textBox.Text = (currentNumber * int.Parse(textBox.Text)).ToString();
                        break;
                    case Op.DIV:
                        textBox.Text = (currentNumber / int.Parse(textBox.Text)).ToString();
                        break;
                }
            }
            reset = true;
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
            currentNumber = 0;
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
                textBox.Text = textBox.Text.StartsWith("-") ? textBox.Text.Substring(1) : "-" + textBox.Text;
            }
        }
    }
}
