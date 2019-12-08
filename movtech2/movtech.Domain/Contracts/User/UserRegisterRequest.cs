using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.User
{
    public class UserRegisterRequest
    {

        public string Name { get; set; }

        public string CPF { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Email { get; set; }
    }
}
