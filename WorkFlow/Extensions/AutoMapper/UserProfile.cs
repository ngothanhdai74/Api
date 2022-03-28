using AutoMapper;
using WorkFlow.Models.User;

namespace WorkFlow.Extensions.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>()
                .ForMember(
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => $"{src.FirstName}-TEST")
                )
                .ForMember(
                    dest => dest.LastName,
                    opt => opt.MapFrom(src => $"{src.LastName}-TEST")
                )
                .ForMember(
                    dest => dest.Email,
                    opt => opt.MapFrom(src => $"{src.Email}-TEST")
                )
                .ForMember(
                    dest => dest.Phone,
                    opt => opt.MapFrom(src => $"{src.Phone}-TEST")
                )
                .ForMember(
                    dest => dest.Country,
                    opt => opt.MapFrom(src => $"{src.Country}-TEST")
                );
        }

    }
}
