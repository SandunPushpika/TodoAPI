using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApplication.Models;
using TodoApplication.Services.Models;

namespace TodoApplication.Services.Profiles {
    public class TodoProfile : Profile{
        public TodoProfile() {
            CreateMap<Todo,TodoModel>();
        }
    }
}
