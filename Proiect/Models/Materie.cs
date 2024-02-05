using Proiect.Models.Base;

namespace Proiect.Models
{
    public class Materie : BaseEntity
    {
        public string? NumeMaterie { get; set; }

        //relatia Many-to-Many cu "Elev"

        public ICollection<ElevMaterie> ElevMaterie { get; set; }
    }
}
