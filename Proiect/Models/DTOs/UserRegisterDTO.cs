using System.ComponentModel.DataAnnotations;

namespace Proiect.Models.DTOs
{
    public class UserRegisterDTO
    {
        [Required]
        public string Nickname { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
