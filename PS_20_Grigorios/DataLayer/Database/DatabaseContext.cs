using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using Welcome.Others;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<DatabaseUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure DatabaseUser entity
            modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

            // Seed initial data
            modelBuilder.Entity<DatabaseUser>().HasData(
                new DatabaseUser
                {
                    Id = 1,
                    Names = "Ben Dover",
                    Password = "1234",
                    Role = UserRolesEnum.UserRole.student,
                    Expires = DateTime.Now.AddYears(10)
                },
                new DatabaseUser
                {
                    Id = 2,
                    Names = "John Smith",
                    Password = "5678",
                    Role = UserRolesEnum.UserRole.admin,
                    Expires = DateTime.Now.AddYears(5)
                },
                // Add more users with different roles and expiration dates as needed
                new DatabaseUser
                {
                    Id = 3,
                    Names = "Alice Johnson",
                    Password = "abcd",
                    Role = UserRolesEnum.UserRole.inspector,
                    Expires = DateTime.Now.AddYears(3)
                }
            );
        }
    }
}
