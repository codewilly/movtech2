using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.Refuel
{
    public class CreateGasStationRequest
    {

        public string CNPJ { get; set; }

        public string Name { get; set; }

        public string CEP { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public string Neighborhood { get; set; }

        public string City { get; set; }

        public UF UF { get; set; }
    }
}
