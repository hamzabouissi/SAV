using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class FamilleTiersConfig : IEntityTypeConfiguration<FamilleTiers>
    {
        public void Configure(EntityTypeBuilder<FamilleTiers> builder)
        {
            builder.HasKey(t => t.Id);
        }
    }
}
