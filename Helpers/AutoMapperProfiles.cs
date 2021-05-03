using System.Linq;
using AutoMapper;
using DTOs;
using BackEnd.Entities;
using Extensions;

namespace Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<ApiUser, MemberDto>()
            .ForMember(dest => dest.FotografiaUrl, opt => opt.MapFrom(src => src.Fotografite.FirstOrDefault(f => f.IsMain).Url))
            .ForMember(dest => dest.Mosha, opt => opt.MapFrom(src => src.DiteLindja.LlogaritMoshen()));
            
            CreateMap<Fotografia, FotografiaDto>();
        }
    }
}