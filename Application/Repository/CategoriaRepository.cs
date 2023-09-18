using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class CategoriaRepository : GenericRepository<Categoria>, ICategoriaRepository
{
    private readonly JwtAppContext _context;

    public CategoriaRepository(JwtAppContext context) : base(context)
    {
       _context = context;
    }
    
}