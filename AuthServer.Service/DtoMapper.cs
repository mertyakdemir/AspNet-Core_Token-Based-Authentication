using AuthServer.Core.DTOs;
using AuthServer.Core.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServer.Service
{
    internal class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}
