using AutoMapper;
using GrupoLTM.Application.DTOs;
using GrupoLTM.Application.Interfaces;
using GrupoLTM.Domain.Interfaces;
using GrupoLTM.Domain.Models;
using System;
using System.Security.Cryptography;

namespace GrupoLTM.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool ValidateLogin(string login, string password)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(password);
            using (var hash = SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return _userRepository.GetByLoginAndPassword(login, hashedInputStringBuilder.ToString()) != null;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
