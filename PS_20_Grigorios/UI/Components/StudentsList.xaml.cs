using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DataLayer.Database; // Import the namespace containing DatabaseContext

namespace UI.Components
{
    public partial class StudentsList : UserControl
    {
        public StudentsList()
        {
            InitializeComponent();

            // Load data from the database
            try
            {
                using (var context = new DatabaseContext())
                {
                    // Retrieve all users from the database
                    var records = context.Users.ToList();

                    // Set the DataContext of the DataGrid to the retrieved records
                    students.ItemsSource = records;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during database access
                MessageBox.Show($"Error loading users: {ex.Message}", "Database Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}