using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SAV.infrastructure;

namespace infrastructure
{
    public class ContextFactory : IDesignTimeDbContextFactory<RepoContext>
    {
        public RepoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RepoContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Database=savdb;Username=user;Password=mysecretpassword")
                .EnableDetailedErrors().EnableSensitiveDataLogging();

            return new RepoContext(optionsBuilder.Options);
        }
    }
}