

namespace RafahiaBlazorApp.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }



























        public DbSet<ActivityContent>? activityContents { get; set; }

        public DbSet<ActivityRegister>? activityRegisters { get; set; }

        public DbSet<TPBooking>? tPBookings { get; set; }

        public DbSet<TPImage>? tPImages { get; set; }

        public DbSet<TypeContent>? typeContents { get; set; }

        public DbSet<TypeIctivity>? typeIctivities { get; set; }
    }
}