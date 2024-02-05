using Proiect.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Proiect.Data;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.DiriginteRepository
{
    public class DiriginteRepository : GenericRepository<Diriginte> ,IDiriginteRepository
    {
        private readonly tableContext _context;

        public DiriginteRepository(tableContext tableContext) : base(tableContext)
        {
        }

        public async Task<List<Diriginte>> GetAllAsync()
        {
            return await _context.Diriginti.ToListAsync();
        }

        public async Task<Diriginte> GetByIdAsync(Guid id)
        {
            return await _context.Diriginti.FindAsync(id);
        }

        public async Task CreateAsync(Diriginte diriginte)
        {
            await _context.Diriginti.AddAsync(diriginte);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Diriginte diriginte)
        {
            _context.Diriginti.Update(diriginte);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var diriginte = await _context.Diriginti.FindAsync(id);
            if (diriginte != null)
            {
                _context.Diriginti.Remove(diriginte);
                await _context.SaveChangesAsync();
            }
        }
    }
}
