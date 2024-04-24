using System.Windows;

namespace WpfExample
{
    public partial class NamesWindow : Window
    {
        public NamesWindow()
        {
            InitializeComponent();

            // Set the data context of NamesWindow to an instance of NamesList
            DataContext = new NamesList();
        }
    }
}
