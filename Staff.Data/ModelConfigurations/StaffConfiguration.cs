using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Kadro = Staff.Data.Domains;

namespace Staff.Data.ModelConfigurations
{
    public class StaffConfiguration : IEntityTypeConfiguration<Kadro.Staff>
    {
        public void Configure(EntityTypeBuilder<Kadro.Staff> builder)
        {
            builder.Property(x => x.Id).IsRequired().UseIdentityColumn();
            builder.Property(x => x.CreatedBy).IsRequired(true).HasMaxLength(20);
            builder.Property(x => x.CreatedAt).IsRequired(true);
            builder.Property(x => x.FirstName).IsRequired(true).HasMaxLength(20);
            builder.Property(x => x.LastName).IsRequired(true).HasMaxLength(20);
            builder.Property(x => x.Email).IsRequired(true);
            builder.Property(x => x.Phone).IsRequired(true).HasMaxLength(11);
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.City).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.Country).IsRequired(true).HasMaxLength(250);
            builder.Property(x => x.Province).IsRequired(true).HasMaxLength(500);
            builder.Property(x => x.AddressLine1).IsRequired(true).HasMaxLength(500);

            builder.HasIndex(e => e.Email).IsUnique(true);
        }
    }
}