using Models;
using Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Extensions;

internal static class RepositoriesRegisterExtension
{
    public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(nameof(ContextApp));
        services.AddDbContext<ContextApp>(x => x.UseNpgsql(connectionString), ServiceLifetime.Transient);

        return services;
    }

    // public static IServiceCollection AddRepositories(this IServiceCollection services)
    // {
    //     services.AddScoped<IRepository<Account>, AccountRepository>();
    //     services.AddScoped<IRepository<Category>, CategoryRepository>();
    //     services.AddScoped<ICardRepository, CardRepository>();
    //     services.AddScoped<IUserRepository, UserRepository>();
    //     services.AddScoped<IRepository<Vault>, VaultRepository>();

    //     return services;
    // }
}