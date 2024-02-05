using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Proiect.Data;
using Proiect.Models;
using Proiect.Repositories.GenericRepository;

namespace Proiect.Repositories.ProfesorRepository
{
    public class ProfesorRepository : GenericRepository<Profesor>, IProfesorRepository
    {
        public ProfesorRepository(tableContext tableContext) : base(tableContext)
        {
        }

        public List<Profesor> OrderByNume(string nume)
        {
            var _nume = from x in _table
                        orderby x.Nume
                        select x;

            return _nume.ToList();
        }

        public List<dynamic> GetAllWithJoin()
        {
            var rez = _tableContext.Profesori.Join(_tableContext.Elevi, p => p.Id, el => el.ProfesorId, (p, el) => new { p, el }).Select(ob => ob.p);
            return null;
        }
    }
}
