using Proiect.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Proiect.Data;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.ClasaRepository
{
    public class ClasaRepository : GenericRepository<Clasa>, IClasaRepository
    {
        private readonly tableContext _context;

        public ClasaRepository(tableContext tableContext) : base(tableContext)
        {
        }

        public new async Task<List<Clasa>> GetAllAsync()
        {
            return await _context.Clase.ToListAsync();
        }

        public async Task<Clasa> GetByIdAsync(Guid id)
        {
            return await _context.Clase.FindAsync(id);
        }

        public async Task CreateAsync(Clasa clasa)
        {
            await _context.Clase.AddAsync(clasa);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Clasa clasa)
        {
            _context.Clase.Update(clasa);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var clasa = await _context.Clase.FindAsync(id);
            if (clasa != null)
            {
                _context.Clase.Remove(clasa);
                await _context.SaveChangesAsync();
            }
        }
    }
}
