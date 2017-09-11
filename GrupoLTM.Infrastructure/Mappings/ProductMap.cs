using FluentNHibernate.Mapping;
using GrupoLTM.Domain.Models;

namespace GrupoLTM.Infrastructure.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("PRODUCT");
            Id(x => x.Id).Column("IDPRODUCT").GeneratedBy.Identity();
            Map(x => x.Description).Column("DSPRODUCT");
            Map(x => x.Value).Column("VLPRODUCT");
        }
    }
}
