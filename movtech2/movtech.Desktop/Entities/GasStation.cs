﻿using movtech.Desktop.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Desktop.Entities
{
    public class GasStation : Address
    {
        public int Id { get; set; }

        public string CNPJ { get; set; }

        public string Name { get; set; }

        public List<Refuel> Refuels { get; set; }
    }
}