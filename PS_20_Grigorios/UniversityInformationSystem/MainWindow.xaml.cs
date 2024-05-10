using System.Windows;
using UniversityInformationSystem.ViewModels;

namespace UniversityInformationSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
