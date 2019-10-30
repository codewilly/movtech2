using movtech.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class Person : Address
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CPF { get; set; }

        public DateTime BirthDate { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        
    }
}
