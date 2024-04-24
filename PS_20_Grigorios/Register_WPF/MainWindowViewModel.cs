using Prism.Commands;
using Prism.Mvvm;
using System;

namespace Register_WPF
{
    public class MainWindowViewModel : BindableBase
    {
        private string _userName;
        private string _age;
        private string _email;

        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        public string Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        public DelegateCommand RegisterButtonClicked { get; private set; }
        public DelegateCommand ResetButtonClicked { get; private set; }

        public MainWindowViewModel()
        {
            RegisterButtonClicked = new DelegateCommand(RegisterUser, CanRegister);
            ResetButtonClicked = new DelegateCommand(Reset);
        }

        private void RegisterUser()
        {
            Console.WriteLine($"User registered: {UserName}, Age: {Age}, Email: {Email}");
            // Additional registration logic here
        }

        private bool CanRegister()
        {
            bool canRegister = !string.IsNullOrWhiteSpace(UserName);
            Console.WriteLine($"Can register: {canRegister}");
            return canRegister;
        }

        private void Reset()
        {
            UserName = Age = Email = string.Empty;
        }
    }
}
