using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RXCrud.Domain.Entities;

namespace RXCrud.Data.Configuration
{
    public class EstadoConfig : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).IsRequired();
            builder.Property(u => u.UF).IsRequired();
        }
    }
}