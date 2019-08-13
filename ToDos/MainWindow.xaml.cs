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

namespace ToDos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.Focus();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add(textBox.Text);
            textBox.Text = "";
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                add_Click(sender, null);
            }
        }
    }
}
