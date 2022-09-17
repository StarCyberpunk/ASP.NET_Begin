using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SiteWithMySkills.Domain.Entities;
using System.ComponentModel.DataAnnotations;
namespace SiteWithMySkills.Domain
{
    public class AppDbContext:IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<Tovar> TovarsItems { get; set; }
        public DbSet<Models.Weather> Weathers { get; set; }
        public DbSet<Models.Message> MessageItems { get; set; }


        protected override async void OnModelCreating(ModelBuilder builder)
        {
            

            builder.Entity<Tovar>().HasData(new Tovar { Name = "milk", Price = "100.0", id = Guid.NewGuid(), IdType = 0, Img = "milk.jpg", Opisanie = "Вкусное молоко" });
            builder.Entity<Tovar>().HasData(new Tovar { Name = "book", Price ="110.0", id = Guid.NewGuid(), IdType = 2, Img = "book.jpg", Opisanie = "Крутая книга" });
            builder.Entity<Tovar>().HasData(new Tovar { Name = "Ker", Price = "120.0", id = Guid.NewGuid(), IdType = 3, Img = "ker.jpg", Opisanie = "Лук по лбу стук" });
            builder.Entity<IdentityRole>().HasData(new IdentityRole("Admin"));
            builder.Entity<IdentityRole>().HasData(new IdentityRole("Guest"));
            builder.Entity<IdentityRole>().HasData(new IdentityRole("Moderator"));

            base.OnModelCreating(builder);

        }
    }
}
