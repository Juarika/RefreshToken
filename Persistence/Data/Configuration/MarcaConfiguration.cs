using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
{
    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        // Aquí puedes configurar las propiedades de la entidad Marca
        // utilizando el objeto 'builder'.
        builder.ToTable("marca");

        builder.Property(p => p.Id)
                .IsRequired();
        
        builder.Property(p => p.Nombre)
        .HasColumnName("MarcaName")
        .HasColumnType("varchar")
        .HasMaxLength(50)
        .IsRequired();
    }
}