namespace TeamBuilderSystem.Data.EntityConfigurations
{
    using TeamBuilderSystem.Models;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    class InvitationConfiguration : IEntityTypeConfiguration<Invitation>
    {
        public void Configure(EntityTypeBuilder<Invitation> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasKey(e => new
            {
                e.InvitedUserId,
                e.TeamId
            });            
        }
    }
}
