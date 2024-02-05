using Proiect.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proiect.Data;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.ElevRepository
{
    public class ElevRepository : GenericRepository<Elev>, IElevRepository
    {
        private readonly tableContext _context;

        public ElevRepository(tableContext tableContext) : base(tableContext)
        {
        }

        public async Task<List<Elev>> GetAllAsync()
        {
            return await _context.Elevi.ToListAsync();
        }

        public async Task<Elev> GetByIdAsync(Guid id)
        {
            return await _context.Elevi.FindAsync(id);
        }

        public async Task CreateAsync(Elev elev)
        {
            await _context.Elevi.AddAsync(elev);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Elev elev)
        {
            _context.Elevi.Update(elev);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var elev = await _context.Elevi.FindAsync(id);
            if (elev != null)
            {
                _context.Elevi.Remove(elev);
                await _context.SaveChangesAsync();
            }
        }

    }
}
