using FoodOrder.Models.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace FoodOrder.Models
{
    public class Context:IdentityDbContext
    {
       
      public   DbSet<Burger> Burgers { get; set; }
      public  DbSet<Kebab> Kebabs{ get; set; }
      public  DbSet<Drink> Drinks { get; set; }
      public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Food; uid=yusuf; pwd=1234; TrustServerCertificate=true ;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Burger>().HasData(new Burger { Id = 1, price = 20, type = "burger", ımgId = 1 });
            modelBuilder.Entity<Burger>().HasData(new Burger { Id = 2, price = 22, type = "burger", ımgId = 2 });
            modelBuilder.Entity<Burger>().HasData(new Burger { Id = 3, price = 23, type = "burger", ımgId = 3 });
            modelBuilder.Entity<Burger>().HasData(new Burger { Id = 4, price = 25, type = "burger", ımgId = 4 });
            modelBuilder.Entity<Burger>().HasData(new Burger { Id = 5, price = 24, type = "burger", ımgId = 5 });

            modelBuilder.Entity<Kebab>().HasData(new Kebab { Id = 1, price = 25, type = "kebab", ımgId = 1 });
            modelBuilder.Entity<Kebab>().HasData(new Kebab { Id = 2, price = 27, type = "kebab", ımgId = 3 });
            modelBuilder.Entity<Kebab>().HasData(new Kebab { Id = 3, price = 28, type = "kebab", ımgId = 4 });
            modelBuilder.Entity<Kebab>().HasData(new Kebab { Id = 4, price = 29, type = "kebab", ımgId = 5 });
            modelBuilder.Entity<Kebab>().HasData(new Kebab { Id = 5, price = 30, type = "kebab", ımgId = 6 });

            modelBuilder.Entity<Drink>().HasData(new Kebab { Id = 1, price = 25, type = "drink", ımgId = 1 });
            modelBuilder.Entity<Drink>().HasData(new Kebab { Id = 2, price = 25, type = "drink", ımgId = 2 });
            modelBuilder.Entity<Drink>().HasData(new Kebab { Id = 3, price = 25, type = "drink", ımgId = 3 });




        }
    }
}
