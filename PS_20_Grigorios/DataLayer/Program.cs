using System;
using System.Linq;
using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others; // Import the namespace containing UserRolesEnum

namespace DataLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated(); // Create database if not exists

                // Add a new DatabaseUser
                context.Add(new DatabaseUser
                {
                    Names = "user",
                    Password = "password",
                    Expires = DateTime.Now,
                    Role = UserRolesEnum.UserRole.student
                });

                context.SaveChanges(); // Save changes to the database

                // Retrieve all users from the database
                var users = context.Users.ToList();

                // Output the retrieved users (for demonstration purposes)
                Console.WriteLine("Users in the database:");
                foreach (var user in users)
                {
                    Console.WriteLine($"ID: {user.Id}, Name: {user.Names}, Role: {user.Role}, Expires: {user.Expires}");
                }
            }

            Console.ReadKey(); // Wait for a key press before exiting
        }
    }
}
