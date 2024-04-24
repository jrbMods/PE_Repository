using System;
using System.Windows.Input;

namespace WpfExample
{
    public class AddCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var nameList = parameter as NamesList;
            if (nameList != null)
            {
                var newName = $"{nameList.FirstName} {nameList.LastName}";
                nameList.Names.Add(newName);
                nameList.FirstName = "";
                nameList.LastName = "";
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}
