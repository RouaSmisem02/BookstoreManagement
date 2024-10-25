using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Models
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Example of configuring properties if needed
            // modelBuilder.Entity<Book>().Property(b => b.Price).HasPrecision(18, 2);
        }
    }
}
