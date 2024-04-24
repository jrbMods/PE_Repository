using System;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine($"User: {_viewModel.Names}");
            Console.WriteLine($"Role: {_viewModel.Role}");
        }

        // Step 2: Create DisplayError() method
        public void DisplayError()
        {
            try
            {
                // Throw an exception to simulate an error
                throw new Exception("ERROR TEXT");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}