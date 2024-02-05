using Proiect.Models;
using Proiect.Repositories.UserRepository;

namespace Proiect.Helpers.JwtUtil
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(User user);
        object GenerateJwtToken(UserRepository user);
        public Guid? GetUserId(string? token);
    }
}
