using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.Insurer
{
    public class UpdateInsurerRequest : AddressRequest
    {
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
