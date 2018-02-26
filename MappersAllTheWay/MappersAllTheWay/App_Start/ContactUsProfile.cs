using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MappersAllTheWay.Models;

namespace MappersAllTheWay.App_Start
{
    public class ContactUsProfile : AutoMapper.Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ContactUsModel, ContactUsViewModel>()
                .ForMember(s => s.Name, d => d.MapFrom(g => g.FirstName + " " + g.LastName));
        }
    }
}