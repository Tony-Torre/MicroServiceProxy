using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Book.Models
{
    public class BookDBContext : DbContext
    {
        public DbSet<BookModel> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=localhost\\SQLEXPRESS;Database=test;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
