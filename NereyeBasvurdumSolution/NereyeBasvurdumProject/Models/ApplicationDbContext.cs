using Microsoft.EntityFrameworkCore;

namespace NereyeBasvurdumProject.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Basvurularim> Basvurularim { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Basvurularim>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Sirket).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Pozisyon).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Lokasyon).HasMaxLength(100);
                entity.Property(e => e.Deneyim).HasMaxLength(50);
                entity.Property(e => e.Araci).HasMaxLength(100);
                entity.Property(e => e.Durum).HasMaxLength(50);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}