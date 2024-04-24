using System;
using Welcome.Model;
using Welcome.ViewModel;
using Welcome.View;
using Welcome.Others;

namespace Welcome
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                Names = "John Doe",
                Password = "securePassword",
                Role = UserRolesEnum.UserRole.student
            };

            UserViewModel viewModel = new UserViewModel(user);
            UserView userView = new UserView(viewModel);
            userView.Display();
            Console.ReadKey();
        }
    }
}
