using Models.Configurations;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Models;

public sealed class ContextApp : DbContext {
    public ContextApp(DbContextOptions<ContextApp> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Checklist> Checklists { get; set; }
    public DbSet<UserChecklist> UserChecklists { get; set; }
    public DbSet<ChecklistElement> ChecklistElements { get; set; }

    // Это чтобы конфигурации применились
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserChecklistsConfiguration());
        modelBuilder.ApplyConfiguration(new ChecklistConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
