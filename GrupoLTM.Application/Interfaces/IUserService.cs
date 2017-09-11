using System;

namespace GrupoLTM.Application.Interfaces
{
    public interface IUserService : IDisposable
    {
        bool ValidateLogin(string login, string password);
    }
}
