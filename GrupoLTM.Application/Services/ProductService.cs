using AutoMapper;
using GrupoLTM.Application.DTOs;
using GrupoLTM.Application.Interfaces;
using GrupoLTM.Domain.Interfaces;
using GrupoLTM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoLTM.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IList<ProductDTO> GetProducts()
        {
            var list = _productRepository.GetAll().ToList();
            IList<ProductDTO> listDTO = new List<ProductDTO>();
            list.ForEach(i => listDTO.Add(Mapper.Map<ProductDTO>(i)));
            return listDTO;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
