using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Desktop.Contracts
{
    public class UserLoginRequest
    {

        public string CPF { get; set; }

        public string Password { get; set; }
    }
}
