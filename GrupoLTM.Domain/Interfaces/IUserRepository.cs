using GrupoLTM.Domain.Models;

namespace GrupoLTM.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByLoginAndPassword(string login, string password);
    }
}
