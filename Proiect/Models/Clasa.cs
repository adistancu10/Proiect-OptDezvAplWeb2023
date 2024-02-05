using Proiect.Models.Base;

namespace Proiect.Models
{
    public class Clasa : BaseEntity
    {
        public string? NumeClasa { get; set; }

        //relatie One-to-Many cu "Elev"
        public ICollection<Elev> Elevi { get; set; }

        //relatie One-to-One cu "Diriginte"

        public Diriginte Diriginte { get; set; }

    }
}
