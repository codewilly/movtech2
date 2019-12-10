using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CPF { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
