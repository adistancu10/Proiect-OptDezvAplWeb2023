using Proiect.Models.Base;

namespace Proiect.Models
{
    public class Diriginte : BaseEntity
    {
        public string? Nume { get; set; }

        public string? Prenume { get; set; }

        public string? CNP { get; set; }

        public int Varsta { get; set; }

    }
}
