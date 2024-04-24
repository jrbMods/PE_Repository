using System;
using System.Windows.Input;

namespace WpfExample
{
    public class RemoveCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true; // Always allow execution
        }

        public void Execute(object parameter)
        {
            var namesList = parameter as NamesList;
            if (namesList != null && !string.IsNullOrEmpty(namesList.SelectedName))
            {
                string selectedName = namesList.SelectedName;
                namesList.Names.Remove(selectedName);
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }
    }
}
