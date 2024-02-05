using AutoMapper;
using Proiect.Models.DTOs;
using Proiect.Models;

namespace Proiect.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserRegisterDTO>();
            CreateMap<UserRegisterDTO, User>();

            CreateMap<User, UserRegisterDTO>()
                .ForMember(u => u.FirstName,
                o1 => o1.MapFrom(u1 => u1.FirstName))
                .ForMember(ud => ud.LastName,
                o2 => o2.MapFrom(u2 => u2.LastName));
        }
    }
}
