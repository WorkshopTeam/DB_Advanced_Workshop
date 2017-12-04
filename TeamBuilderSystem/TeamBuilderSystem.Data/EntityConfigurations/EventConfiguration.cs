namespace TeamBuilderSystem.Data.EntityConfigurations
{
    using TeamBuilderSystem.Models;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(true);            
        }
    }
}
