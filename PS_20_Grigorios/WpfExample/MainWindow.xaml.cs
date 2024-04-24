using System.Windows;

namespace WpfExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NamesWindow namesWindow = new NamesWindow();
            namesWindow.Show();
        }
    }
}
