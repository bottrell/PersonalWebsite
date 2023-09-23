using Microsoft.EntityFrameworkCore;

namespace PersonalWebsite.Utilities;

public class BloggingContext : DbContext
{

    public BloggingContext(DbContextOptions<BloggingContext> opts) : base(opts)
    {
    }

    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        try
        {
            string connectionString = Environment.GetEnvironmentVariable("BlogDatabaseConnection");
            optionsBuilder.UseNpgsql(connectionString);
        }
        catch
        {
            Console.WriteLine("NO CONNECTION STRING FOUND IN ENVIRONMENT VARIABLES");
        }
    }

}