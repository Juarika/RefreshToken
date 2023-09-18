using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;

public class ProductoRepository : GenericRepository<Producto>, IProductoRepository
{
    private readonly JwtAppContext _context;

    public ProductoRepository(JwtAppContext context) : base(context)
    {
       _context = context;
    }

    public async Task<IEnumerable<Producto>> GetProductosMasCaros(int cantidad) =>
            await _context.Productos
                    .OrderByDescending(p => p.Precio)
                    .Take(cantidad)
                    .ToListAsync();

    public override async Task<Producto> GetByIdAsync(int id)
    {
        return await _context.Productos
                        .Include(p => p.Marca)
                        .Include(p => p.Categoria)
                        .FirstOrDefaultAsync(p => p.Id == id);
    }                    
}