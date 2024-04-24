using System;
using System.Windows;
using System.Windows.Input;

namespace WpfExample
{
    public class InfoCommand : ICommand
    {
        // ICommand Execute method implementation
        public void Execute(object parameter)
        {
            MessageBox.Show("Hello, world!");

            // Open a new instance of NamesWindow
            NamesWindow namesWindow = new NamesWindow();
            namesWindow.Show();
        }

        // ICommand CanExecute method implementation
        public bool CanExecute(object parameter)
        {
            return true; // Always allow execution
        }

        // ICommand CanExecuteChanged event implementation
        // Properly implement the event to notify when CanExecute may have changed
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        // Explicitly raise the CanExecuteChanged event
        public void RaiseCanExecuteChanged()
        {
            // Notify subscribers that the CanExecute state may have changed
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
