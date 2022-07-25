using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class TiersConfig : IEntityTypeConfiguration<Tiers>
    {
        public void Configure(EntityTypeBuilder<Tiers> builder)
        {
            builder.HasKey(t => t.Id);
        }
    }
}
