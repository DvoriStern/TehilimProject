using AutoMapper;
using Common.Dtos;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<ChaptersOfTehilim, ChaptersOfTehilimDto>().ReverseMap();
            CreateMap<Group, GroupDto>().ReverseMap();
            CreateMap<NameForPrayer, NameForPrayerDto>().ReverseMap();
            CreateMap<RequestPrayer, RequestPrayerDto>().ReverseMap();
            CreateMap<Sharing, SharingDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
