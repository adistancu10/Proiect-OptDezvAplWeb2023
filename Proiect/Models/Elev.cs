using Proiect.Models.Base;

namespace Proiect.Models
{
    public class Elev : BaseEntity
    {
        public string? Nume { get; set; }

        public string? Prenume { get; set; }

        public string? CNP { get; set; }

        public int Varsta { get; set; }

        //relatie One-to-Many cu "Clasa"

        public Guid ClasaId { get; set; }
        public Clasa Clasa { get; set; }

        //relatie One-to-Many cu "Profesor"

        public Guid ProfesorId { get; set; }
        public Profesor Profesor { get; set; }

        //relatia Many-to-Many cu "Materie"

        public ICollection<ElevMaterie> ElevMaterie { get; set; }

    }
}
