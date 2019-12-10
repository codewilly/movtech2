using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Services
{
    public class UserService : BaseService<User>, IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public User Login(string cpf, string password)
        {
            return _userRepository.Login(cpf, password);
        }

        public User Register(User user)
        {
            return _userRepository.Register(user);
        }
    }
}
