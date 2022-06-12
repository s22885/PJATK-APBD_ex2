using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class EventOrganiserEfConfiguration : IEntityTypeConfiguration<EventOrganiser>
    {
        public void Configure(EntityTypeBuilder<EventOrganiser> builder)
        {
            builder.HasKey(e => new { e.IdEvent, e.IdOrganiser }).HasName("EventOrganiser_pk");
            builder.Property(e => e.MainOrganiser).IsRequired();
            
            builder.HasOne(e => e.IdEventNavigation)
                .WithMany(e => e.EventOrganisers)
                .HasForeignKey(e => e.IdEvent)
                .HasConstraintName("FileEventOrganiser_Event")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.IdOrganiserNavigation)
                .WithMany(e => e.EventOrganisers)
                .HasForeignKey(e => e.IdOrganiser)
                .HasConstraintName("FileEventOrganiser_Organiser")
                .OnDelete(DeleteBehavior.Cascade);


            builder.ToTable("Event_Organiser");
        }
    }
}
