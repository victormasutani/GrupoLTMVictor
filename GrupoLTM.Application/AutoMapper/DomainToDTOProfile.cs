using AutoMapper;
using GrupoLTM.Application.DTOs;
using GrupoLTM.Domain.Models;
using System.Collections.Generic;

namespace GrupoLTM.Application.AutoMapper
{
    public class DomainToDTOProfile : Profile
    {
        public DomainToDTOProfile()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
