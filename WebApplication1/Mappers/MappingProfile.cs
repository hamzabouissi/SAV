using AutoMapper;
using Core.Entities;
using WebApplication1.Dtos.Taches;
using WebApplication1.Dtos.Users;

namespace WebApplication1.Mappers;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Taches, TacheDto>();
        CreateMap<CreateTacheDto, Taches>();
        CreateMap<UserRegistrationDto, User>();
        CreateMap<User, UserDto>();
    }
}