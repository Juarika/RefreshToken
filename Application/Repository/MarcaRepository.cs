using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class MarcaRepository : GenericRepository<Marca>, IMarcaRepository
{
    private readonly JwtAppContext _context;

    public MarcaRepository(JwtAppContext context) : base(context)
    {
       _context = context;
    } 
}