using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InternTask2.Models;

namespace InternTask2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Console.WriteLine("Using DB: " + Database.GetDbConnection().ConnectionString);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Men" },
                new Category { Id = 2, Name = "Women" },
                new Category { Id = 3, Name = "Sale" }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Classic Leather Sneakers", Price = 79.99M, ImageUrl = "/images/men-shoe-1.jpg", Description = "Comfortable and stylish for everyday wear.", CategoryId = 1 },
                new Product { Id = 2, Name = "Sporty Trainers", Price = 99.99M, ImageUrl = "/images/men-shoe-2.jpg", Description = "Perfect for gym and casual outings.", CategoryId = 1 },
                new Product { Id = 3, Name = "Elegant Dress Shoes", Price = 59.99M, ImageUrl = "/images/men-shoe-3.jpg", Description = "Ideal for formal occasions and office wear.", CategoryId = 1 },
                new Product { Id = 4, Name = "Urban Street Runners", Price = 89.99M, ImageUrl = "/images/men-shoe-4.jpg", Description = "Durable and sleek, designed for city life", CategoryId = 1 },
                new Product { Id = 5, Name = "Breathable Mesh Trainers", Price = 109.99M, ImageUrl = "/images/men-shoe-5.jpg", Description = "Perfect for running and staying cool on the move.", CategoryId = 1 },
                new Product { Id = 6, Name = "High Top Basketball Shoes", Price = 49.99M, ImageUrl = "/images/men-shoe-6.jpg", Description = "Supportive grip and ankle protection on the court.", CategoryId = 1 },

                new Product { Id = 7, Name = "Floral Flats", Price = 79.99M, ImageUrl = "/images/women-shoe-1.jpg", Description = "Beautiful design for a chic everyday look.", CategoryId = 2},
                new Product { Id = 8, Name = "Stylish Heels", Price = 49.99M, ImageUrl = "/images/women-shoe-2.jpg", Description = "Perfect heels for parties and events.", CategoryId = 2 },
                new Product { Id = 9, Name = "Comfort Sandals", Price = 89.99M, ImageUrl = "/images/women-shoe-3.jpg", Description = "Great for casual wear and summer outings.", CategoryId = 2 },
                new Product { Id = 10, Name = "Pastel Everyday Sneakers", Price = 129.99M, ImageUrl = "/images/women-shoe-4.jpg", Description = "Chic and comfortable for all-day wear.", CategoryId = 2 },
                new Product { Id = 11, Name = "Elegant Slip-Ons", Price = 39.99M, ImageUrl = "/images/women-shoe-5.jpg", Description = "Effortless style meets ease and grace.", CategoryId = 2 },
                new Product { Id = 12, Name = "Bold Training Sneakers", Price = 69.99M, ImageUrl = "/images/women-shoe-6.jpg", Description = "Power and confidence in every step.", CategoryId = 2 },
                new Product { Id = 13, Name = "Red Sneakers", Price = 60.00M, ImageUrl = "/images/sale-shoe1.jpg", Description = "Hot summer sale red sneakers.", CategoryId = 3 },
                new Product { Id = 14, Name = "Black Trainers", Price = 70.00M, ImageUrl = "/images/sale-shoe2.jpg", Description = "Black trainers discounted for summer.", CategoryId = 3 },
                new Product { Id = 15, Name = "Classic White", Price = 55.00M, ImageUrl = "/images/sale-shoe3.jpg", Description = "Classic white shoes on sale.", CategoryId = 3 }
            );
        }
    }
}



