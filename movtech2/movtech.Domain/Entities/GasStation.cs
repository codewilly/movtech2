using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Entities
{
    public class GasStation
    {
        public int Id { get; set; }

        public string CNPJ { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public List<Refuel> Refuels { get; set; }
    }
}
