using System.Data.Entity;

public class UniversityDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        // Configure relationships, keys, etc.
    }
}
