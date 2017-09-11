using GrupoLTM.Domain.Interfaces;
using GrupoLTM.Domain.Models;
using GrupoLTM.Infrastructure.NHibernate;
using NHibernate;
using NHibernate.Linq;
using System.Linq;

namespace GrupoLTM.Infrastructure.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public User GetByLoginAndPassword(string login, string password)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Query<User>().Where(u => u.Login == login.ToLowerInvariant() && u.Password == password).FirstOrDefault();
        }
    }
}
