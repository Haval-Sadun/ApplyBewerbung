using ApplySys.Application.DTOs.Apply;
using ApplySys.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.Profiles
{
    internal class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<Apply,ApplyDto>().ReverseMap();
        }
    }
}
