namespace TeamBuilderSystem.Data.EntityConfigurations
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    using TeamBuilderSystem.Models;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .HasMaxLength(25)
                .IsRequired(true);

            builder.HasIndex(e => e.Name)
                .IsUnique(true);

            builder.Property(e => e.Description)
                .HasMaxLength(32);

            builder.Property(e => e.Acronym)
                .HasColumnType("CHAR(3)");
        }
    }
}
