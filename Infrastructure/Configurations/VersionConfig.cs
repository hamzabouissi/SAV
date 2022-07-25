using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Version = Core.Entities.Version;
namespace Infrastructure.Configurations
{
    public class VersionConfig : IEntityTypeConfiguration<Version>
    {
        public void Configure(EntityTypeBuilder<Version> builder)
        {
            builder.HasKey(t => t.Id);
        }

    }
   
}
