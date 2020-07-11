using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCodeCamp.Models;

namespace TheCodeCamp.Data
{
    public class CampMappingProfile : Profile
    {
        public CampMappingProfile()
        {
            CreateMap<Camp, CampModel>()
              .ForMember(c => c.Venue, opt => opt.MapFrom(m => m.Location.VenueName))
              .ReverseMap(); // in post we are doing campmodel to camp mapping so use reverse map

        CreateMap<Talk, TalkModel>()
        .ReverseMap()
        .ForMember(t => t.Speaker, opt => opt.Ignore()) // when updating a talk you can ignore its sub objects talks and camps
        .ForMember(t => t.Camp, opt => opt.Ignore());

            CreateMap<Speaker, SpeakerModel>()
                .ReverseMap();
        }
    }
}
