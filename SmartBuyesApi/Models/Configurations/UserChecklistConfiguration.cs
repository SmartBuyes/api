using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace Models.Configurations;

internal sealed class UserChecklistsConfiguration : IEntityTypeConfiguration<UserChecklist>
{
    public void Configure(EntityTypeBuilder<UserChecklist> builder)
    {
        // создали два первичных ключа
        builder.HasKey(x => new { x.UserId, x.ChecklistId });
    }
}