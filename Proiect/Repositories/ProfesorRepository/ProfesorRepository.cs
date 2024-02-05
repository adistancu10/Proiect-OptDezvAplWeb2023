using Proiect.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Proiect.Data;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.ProfesorRepository
{
    public class ProfesorRepository : GenericRepository<Profesor>, IProfesorRepository
    {
        private readonly tableContext _context;

        public ProfesorRepository(tableContext tableContext) : base(tableContext)
        {
        }

        public async Task<List<Profesor>> GetAllAsync()
        {
            return await _context.Profesori.ToListAsync();
        }

        public async Task<Profesor> GetByIdAsync(Guid id)
        {
            return await _context.Profesori.FindAsync(id);
        }

        public async Task CreateAsync(Profesor profesor)
        {
            await _context.Profesori.AddAsync(profesor);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Profesor profesor)
        {
            _context.Profesori.Update(profesor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var profesor = await _context.Profesori.FindAsync(id);
            if (profesor != null)
            {
                _context.Profesori.Remove(profesor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
