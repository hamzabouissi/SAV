using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
  public class TachesConfig : IEntityTypeConfiguration<Taches>
    {
        public void Configure(EntityTypeBuilder<Taches> builder)
        {
            builder.HasKey(t => t.Id);
        }
    }
}
