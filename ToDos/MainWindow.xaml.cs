using System.Windows;
using System.Windows.Input;

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
