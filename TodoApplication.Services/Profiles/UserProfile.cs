using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApplication.Models;
using TodoApplication.Services.Models;

namespace TodoApplication.Services.Profiles {
    internal class UserProfile : Profile {
        public UserProfile() {
            CreateMap<ApplicationUser, UserModel>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => $"{src.AddressNo}, {src.Street}, {src.City}"));
        }
    }
}
