#nullable enable
using System;
using Welcome;
using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using WelcomeExtended.Loggers;
using WelcomeExtended.Others;

namespace WelcomeExtended.Helpers
{
    internal static class UserHelper
    {
        public static string ToString(this User? user)
        {
            return user?.ToString() ?? "User is null";
        }

        public static string ValidateCredentials(UserData userData, string name, string password)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "The name cannot be empty";
            }

            if (string.IsNullOrEmpty(password))
            {
                return "The password cannot be empty";
            }

            if (!userData.ValidateUser(name, password))
            {
                return "Invalid credentials";
            }

            return "";
        }

        public static User GetUser(UserData userData, string name, string password)
        {
            return userData.GetUser(name, password);
        }
    }
}