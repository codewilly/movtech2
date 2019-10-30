using movtech.Domain.Entities.Abstract;
using movtech.Domain.Enums;
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

        public Person(int id,string name, string cPF, DateTime birthDate, string phone, string email, string cEP, string street, int number, string neighborhood, string city, UF uF) : base(cEP,street,number,neighborhood,city,uF)
        {
            Id = id;
            Name = name;
            CPF = cPF;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
        }
        public Person()
        {
                
        }
    }
}
