using Business.Abstracts;
using Core.CrossCuttingConcerns.Security.Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    internal class AuthManager : IAuthService
    {
        public User Login(UserForLoginDto userForLoginDto)
        {
            throw new NotImplementedException();
        }

        public User Register(UserForRegisterDto userForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }
    }
}
