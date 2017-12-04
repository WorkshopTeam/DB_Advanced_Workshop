namespace TeamBuilderSystem.Data.EntityConfigurations
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    using TeamBuilderSystem.Models;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Username)
                .HasMaxLength(25)
                .IsRequired(true);

            builder.HasIndex(e => e.Username)
                .IsUnique();

            builder.Property(e => e.FirstName)
                .HasMaxLength(25);

            builder.Property(e => e.LastName)
                .HasMaxLength(25);

            builder.Property(e => e.Password)
                .HasMaxLength(30)
                .IsRequired(true);
        }
    }
}
