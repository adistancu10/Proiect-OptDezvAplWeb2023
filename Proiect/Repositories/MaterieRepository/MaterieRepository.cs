using Proiect.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proiect.Repositories.MaterieRepository;
using Proiect.Data;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.MaterieRepository
{
    public class MaterieRepository : GenericRepository<Materie>, IMaterieRepository
    {
        private readonly tableContext _context;

        public MaterieRepository(tableContext tableContext) : base(tableContext)
        {
        }

        public async Task<List<Materie>> GetAllAsync()
        {
            return await _context.Materii.ToListAsync();
        }

        public async Task<Materie> GetByIdAsync(Guid id)
        {
            return await _context.Materii.FindAsync(id);
        }

        public async Task CreateAsync(Materie materie)
        {
            await _context.Materii.AddAsync(materie);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Materie materie)
        {
            _context.Materii.Update(materie);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var materie = await _context.Materii.FindAsync(id);
            if (materie != null)
            {
                _context.Materii.Remove(materie);
                await _context.SaveChangesAsync();
            }
        }
    }
}
