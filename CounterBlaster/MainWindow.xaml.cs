using System.Windows;

namespace CounterBlaster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int clicks = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clicks++;
            label.Content = "Clicks: " + clicks;
            label.FontSize++;
        }
    }
}
