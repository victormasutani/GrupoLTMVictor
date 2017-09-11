using GrupoLTM.Application.DTOs;
using System;
using System.Collections.Generic;

namespace GrupoLTM.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        IList<ProductDTO> GetProducts();
    }
}
