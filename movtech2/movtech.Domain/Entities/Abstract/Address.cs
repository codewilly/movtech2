using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities.Abstract
{
    public abstract class Address
    {
        public string CEP { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public string Neighborhood { get; set; }

        public string City { get; set; }

        public UF UF { get; set; }

        protected Address(string cEP, string street, int number, string neighborhood, string city, UF uF)
        {
            CEP = cEP;
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            UF = uF;
        }
        public Address()
        {
                
        }
    }

}
