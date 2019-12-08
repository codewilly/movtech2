using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Interfaces.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User Login(string cpf, string password);

        User Register(User user);
    }
}
