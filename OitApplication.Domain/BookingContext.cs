using Microsoft.EntityFrameworkCore;

namespace OitApplication.Domain
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Entities.BookingInfo> BookingInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entities.BookingInfo>()
                .HasKey(b => b.Id);
        }
    }
}
