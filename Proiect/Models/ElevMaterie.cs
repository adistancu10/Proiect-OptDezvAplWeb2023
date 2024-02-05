namespace Proiect.Models
{
    public class ElevMaterie
    {
        public Guid ElevId { get; set; }
        public Elev Elev { get; set; }

        public Guid MaterieId { get; set; }
        public Materie Materie { get; set; }
    }
}
