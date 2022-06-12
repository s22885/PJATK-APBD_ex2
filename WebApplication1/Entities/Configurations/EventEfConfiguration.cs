using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class EventEfConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.IdEvent).HasName("Event_pk");
            builder.Property(e=>e.Name).IsRequired().HasMaxLength(60);
            builder.Property(e => e.DateFrom).IsRequired();
            builder.Property(e => e.DateTo);
        }
    }
}
