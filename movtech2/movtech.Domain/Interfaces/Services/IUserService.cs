using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Interfaces.Services
{
    public interface IUserService : IBaseService<User>
    {
        User Register(User user);

        User Login(string cpf, string password);
    }
}
