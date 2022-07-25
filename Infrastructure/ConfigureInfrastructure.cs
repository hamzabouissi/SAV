using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SAV.infrastructure;

namespace Infrastructure;

public static class ConfigureInfrastructure
{
    public static void AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<RepoContext>(options =>
            options.UseNpgsql(connectionString));
        services.AddScoped<IRepositoryManager, RepositoryManager>();
    }

    public static void AddIdentity(this IServiceCollection services)
    {
        var builder = services.AddIdentityCore<User>(o =>
        {
            o.Password.RequireDigit = true;
            o.User.RequireUniqueEmail = true;
        }).AddRoles<IdentityRole>();
        builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), builder.Services);
        builder.AddEntityFrameworkStores<RepoContext>();
    }
}