using BakeryProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace BakeryProject.DAL.Context
{
    public class SaleContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Abdullah;initial Catalog=Tasarim;integrated Security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FiveProduct> FiveProducts { get; set; }
        public DbSet<Main> Mains { get; set; }
        public DbSet<NewProduct> NewProducts { get; set; }
        public DbSet<OnePage> OnePages { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<TwoPage> TwoPages { get; set; }
        public DbSet<Companynews> Companynews { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<HelpSupport> HelpSupports { get; set; }
        public DbSet<AboutCard> AboutCards { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Messages> Messages { get; set; }

    }
}
