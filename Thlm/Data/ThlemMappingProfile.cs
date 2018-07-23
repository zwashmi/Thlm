using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thlem.Data.Eintities;
using thlem.Models;

namespace thlem.Data
{
    public class ThlemMappingProfile : Profile
    {
        public ThlemMappingProfile()
        {
            CreateMap<RegisterCompany, RegCompanyViewModel>().ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
                .ReverseMap();
        }

    }
}
