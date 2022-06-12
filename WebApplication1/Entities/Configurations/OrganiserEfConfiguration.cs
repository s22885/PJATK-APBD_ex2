using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class OrganiserEfConfiguration : IEntityTypeConfiguration<Organiser>
    {
        public void Configure(EntityTypeBuilder<Organiser> builder)
        {
            builder.HasKey(e => e.IdOrganiser).HasName("Organiser_pk");
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
        }
    }
}
