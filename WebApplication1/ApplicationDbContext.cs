using WebApplication1.Entities;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Enums;

namespace CarBookingAPI
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.Name).HasColumnType("text");
                entity.Property(e => e.Description).HasColumnType("text");
                entity.Property(e => e.Transmissions).HasColumnType("text");
                entity.Property(e => e.Comments).HasColumnType("text[]"); // Важно для массива
                entity.Property(e => e.image).HasColumnType("text");
                entity.Property(e => e.Capacity).HasColumnType("text");
                entity.Property(e => e.Fuel).HasColumnType("text");
                entity.Property(e => e.Price).HasColumnType("numeric(18,2)");
                entity.Property(e => e.Type).HasColumnType("text");  // Для enum
            });
        }

    }


}
