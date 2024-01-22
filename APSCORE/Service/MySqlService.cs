using APSCORE.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace APSCORE.Service
{
    public class MySqlService
    {
        public class LibraryContext : DbContext
        {
            //Tao Bang
            public DbSet<Book> Book { get; set; }
            public DbSet<TacGia> TacGia { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySQL("server=localhost;database=library;user=root;password=adminadmin");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Book>(entity =>
                {
                    //tao khoa chinh
                    entity.HasKey(e => e.ISBN);
                    //thiet dinh not null
                    entity.Property(e => e.Title).IsRequired();
                });

                //modelBuilder.Entity<TacGia>(entity =>
                //{
                //    entity.HasKey(e => e.Name);
                //    entity.Property(e => e.Que).IsRequired();
                //});
            }
        }
    }
}
