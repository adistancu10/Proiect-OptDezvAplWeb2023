using Proiect.Models;
using Proiect.Models.DTOs;
using Proiect.Models.Enums;

namespace Proiect.Services.UserService
{
    public interface IUserService
    {
        Task<List<UserRegisterDTO>> GetAllUsers();
        UserRegisterDTO GetUserByNickname(string nickname);

        Task<UserLoginResponse> Login(UserLoginDTO user);
        User GetById(Guid Id);
        Task<bool> Register(UserRegisterDTO userRegisterDTO, Role userRole);

    }
}
