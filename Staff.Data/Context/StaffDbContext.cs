using Microsoft.EntityFrameworkCore;
using Staff.Data.ModelConfigurations;
using Kadro = Staff.Data.Domains;

namespace Staff.Data.Context
{
    public class StaffDbContext : DbContext
    {
        public StaffDbContext(DbContextOptions<StaffDbContext> options) : base(options) { }

        public DbSet<Kadro.Staff> Staff { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StaffConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}