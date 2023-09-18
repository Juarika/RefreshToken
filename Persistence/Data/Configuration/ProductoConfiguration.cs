using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class ProductoConfiguration  : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        // Aquí puedes configurar las propiedades de la entidad Producto
        // utilizando el objeto 'builder'.
        builder.ToTable("productos");

        builder.Property(p => p.Id)
                .IsRequired();
        
        builder.Property(p => p.Nombre)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.Precio)
        .HasColumnType("decimal(18,3)")
        .IsRequired();

        builder.Property(p => p.FechaCreacion)
        .HasColumnType("DateTime")
        .IsRequired();

        builder.HasOne(p => p.Marca)
        .WithMany(p => p.Productos)
        .HasForeignKey(p => p.MarcaId);

        builder.HasOne(p => p.Categoria)
        .WithMany(p => p.Productos)
        .HasForeignKey(p => p.CategoriaId);
    }
}