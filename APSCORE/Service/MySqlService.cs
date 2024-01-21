using APSCORE.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace APSCORE.Service
{
    public class MySqlService
    {
        public class LibraryContext : DbContext
        {
            public DbSet<Book> Book { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySQL("server=localhost;database=library;user=root;password=123456");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Book>(entity =>
                {
                    entity.HasKey(e => e.ISBN);
                    entity.Property(e => e.Title).IsRequired();
                });
            }
        }
    }
}
