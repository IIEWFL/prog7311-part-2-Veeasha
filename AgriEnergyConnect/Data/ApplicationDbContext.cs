// Data/ApplicationDbContext.cs
using AgriEnergyConnect.Models;
using Microsoft.EntityFrameworkCore;


namespace AgriEnergyConnect.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Defining the relationship between Product and User
            modelBuilder.Entity<Product>()
                .HasOne(p => p.User)
                .WithMany()  // Assuming one User can have many Products, you can change this if needed
                .HasForeignKey(p => p.UserId);
        }
    }
}
//erinstellato-ms (2025). Connect and Query SQL Server Using SSMS. [online] Microsoft.com. Available at: https://learn.microsoft.com/en-us/ssms/quickstarts/ssms-connect-query-sql-server?tabs=modern.
//Ervis Trupja. (2021, June 7). 12. Adding your DbContext file | ASP.NET MVC [Video]. YouTube. https://www.youtube.com/watch?v=L7p5Mi4DBMk