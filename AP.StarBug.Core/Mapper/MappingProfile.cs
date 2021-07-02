using AP.StarBug.Core.Dao.DTOS;
using AP.StarBug.Core.Entities;
using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AP.StarBug.Core.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ProductDto, Product>();
            CreateMap<Product, ProductDto>();
        }
    }
}