using AutoMapper;
using Mach.Domain.Identity;
using Mach.DTO;

namespace Mach.Infrastructure
{
    public class MachProfile : Profile
    {
        public MachProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
        }
    }
}