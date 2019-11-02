using movtech.Domain.Entities.Abstract;
using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class GasStation : Address
    {
        public int Id { get; set; }

        public string CNPJ { get; set; }

        public string Name { get; set; }

        public List<Refuel> Refuels { get; set; }
        public GasStation()
        {

        }
        public GasStation(string cNPJ, string name, string cEP, string street, int number, string neighborhood, string city, UF uF) :base(cEP,street,number,neighborhood,city,uF)
        {
            
            CNPJ = cNPJ;
            Name = name;
          
        }
    }
}
