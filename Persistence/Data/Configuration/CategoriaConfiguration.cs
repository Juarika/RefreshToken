using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        // Aquí puedes configurar las propiedades de la entidad Categoria
        // utilizando el objeto 'builder'.
        builder.ToTable("categoria");

        builder.Property(p => p.Id)
                .IsRequired();

        builder.Property(p => p.Nombre)
        .HasColumnName("CategoriaName")
        .HasColumnType("varchar")
        .HasMaxLength(50)
        .IsRequired();
    }
}