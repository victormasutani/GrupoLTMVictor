using System;

namespace GrupoLTM.Domain.Models
{
    public class Product
    {
        public virtual long Id { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Value { get; set; }
    }
}
