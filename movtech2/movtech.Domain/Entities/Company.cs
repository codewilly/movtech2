using movtech.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class Company : Address
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
