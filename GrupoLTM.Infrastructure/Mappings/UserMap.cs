using FluentNHibernate.Mapping;
using GrupoLTM.Domain.Models;

namespace GrupoLTM.Infrastructure.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("USERAPP");
            Id(x => x.Id).Column("IDUSERAPP").GeneratedBy.Identity();
            Map(x => x.Login).Column("DSLOGIN");
            Map(x => x.Password).Column("DSPASSWORD");
        }
    }
}
