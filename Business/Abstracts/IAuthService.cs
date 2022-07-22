using Core.CrossCuttingConcerns.Security.Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    internal interface IAuthService
    {
        User Register(UserForRegisterDto userForRegisterDto, string password);
        User Login(UserForLoginDto userForLoginDto);
    }
}
