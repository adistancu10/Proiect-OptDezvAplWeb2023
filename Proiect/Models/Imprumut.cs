namespace Proiect.Models
{
    public class Imprumut
    {
        public int Id { get; set; }

        public int Id_Carte { get; set; }
        public int Id_Cititor { get; set; }
        public DateTime Data_Imprumut { get; set; }
        public DateTime Data_Returnare { get; set; }

    }
}
