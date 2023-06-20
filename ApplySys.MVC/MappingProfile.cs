using ApplySys.MVC.Models;
using ApplySys.MVC.Services.Base;
using AutoMapper;

namespace ApplySys.MVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplyDto, ApplyVM>().ReverseMap();
            CreateMap<CreateApplyDto, CreateApplyVM>().ReverseMap();
        }
    }
}
