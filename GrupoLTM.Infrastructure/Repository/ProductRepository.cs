using GrupoLTM.Domain.Interfaces;
using GrupoLTM.Domain.Models;

namespace GrupoLTM.Infrastructure.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
    }
}
