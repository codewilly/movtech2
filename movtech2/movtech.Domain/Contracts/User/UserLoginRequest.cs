using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.User
{
    public class UserLoginRequest
    {

        public string CPF { get; set; }

        public string Password { get; set; }
    }
}
