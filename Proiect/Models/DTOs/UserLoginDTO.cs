using System.ComponentModel.DataAnnotations;

namespace Proiect.Models.DTOs
{
    public class UserLoginDTO
    {
        [Required]
        public string Nickname { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
