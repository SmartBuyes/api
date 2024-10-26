using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace Models.Configurations;

internal sealed class ChecklistConfiguration : IEntityTypeConfiguration<Checklist>
{
    public void Configure(EntityTypeBuilder<Checklist> builder)
    {
        builder.HasMany(x => x.UserChecklists)
            .WithOne(x => x.Checklist)
            .HasForeignKey(x => x.ChecklistId);

        builder.HasMany(x => x.ChecklistElements)
            .WithOne(x => x.Checklist)
            .HasForeignKey(x => x.ChecklistId);

        // builder.Property(p => p.DateCreate)
        //     .HasDefaultValue(DateTime.UtcNow);
    }
}