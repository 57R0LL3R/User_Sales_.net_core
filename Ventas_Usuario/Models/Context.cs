using Microsoft.EntityFrameworkCore;

namespace User_Sales.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Product> User_Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasKey(p=>p.IdProduct);

            modelBuilder.Entity<User_Product>()
                .HasOne(p => p.User)
                .WithMany(p=>p.User_Products)
                .HasForeignKey(p => p.IdUser)
                .HasForeignKey(p => p.IdProduct)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User_Product>()
                .HasOne(p => p.Product)
                .WithMany(p => p.User_Products)
                .HasForeignKey(p => p.IdUser)
                .HasForeignKey(p => p.IdProduct)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
