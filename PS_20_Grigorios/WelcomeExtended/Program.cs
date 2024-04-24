using System;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using Welcome.Model;
using Welcome.Others;
using Welcome.ViewModel;
using Welcome.View;
using WelcomeExtended.Others;

try
{
    UserData userData = new UserData();

    // Adding users to the collection
    User studentUser = new User
    {
        Names = "Student",
        Password = "123",
        Role = UserRolesEnum.UserRole.student
    };
    userData.AddUser(studentUser);

    // Add 3 more users
    userData.AddUser(new User { Names = "Student2", Password = "123", Role = UserRolesEnum.UserRole.student });
    userData.AddUser(new User { Names = "Teacher", Password = "1234", Role = UserRolesEnum.UserRole.professor });
    userData.AddUser(new User { Names = "Admin", Password = "12345", Role = UserRolesEnum.UserRole.admin });

    // Prompt user to enter name and password
    Console.Write("Enter name: ");
    string? name = Console.ReadLine();

    Console.Write("Enter password: ");
    string? password = Console.ReadLine();

    if (name is not null && password is not null)
    {
        // Validate credentials and display user information or throw an error

        if (string.IsNullOrEmpty(UserHelper.ValidateCredentials(userData, name, password)))
        {
            // Credentials are valid, continue with the logic
            // ...
        }
        else
        {
            // Display the validation error
            Console.WriteLine(UserHelper.ValidateCredentials(userData, name, password));
        }
    }
    else
    {
        // Handle the case where name or password is null
        Console.WriteLine("Invalid input. Please enter both name and password.");
    }


    // Validate credentials and display user information or throw an error
    string validationError = UserHelper.ValidateCredentials(userData, name, password);

    if (validationError == null)
    {
        User user = UserHelper.GetUser(userData, name, password);
        Console.WriteLine($"User found: {UserHelper.ToString(user)}");
    }
    else
    {
        throw new Exception(validationError);
    }
}
catch (Exception e)
{
    // Step 1: Use the ActionOnError delegate
    var log = new Delegates.ActionOnError(Delegates.Log);
    log(e.Message);
}
finally
{
    Console.WriteLine("Execute In Any Case!");
}
