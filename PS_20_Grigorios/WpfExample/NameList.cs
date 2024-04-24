using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfExample
{
    public class NamesList : INotifyPropertyChanged
    {
        private string _firstName = "";
        private string _lastName = "";
        private string _selectedName;

        public NamesList()
        {
            Names = new ObservableCollection<string>();
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public string SelectedName
        {
            get { return _selectedName; }
            set
            {
                if (_selectedName != value)
                {
                    _selectedName = value;
                    OnPropertyChanged("SelectedName");
                }
            }
        }

        public ObservableCollection<string> Names { get; private set; }

        public AddCommand AddNameCommand { get; private set; } = new AddCommand();
        public RemoveCommand RemoveNameCommand { get; private set; } = new RemoveCommand();

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
