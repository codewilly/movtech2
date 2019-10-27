using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.FipeAPI
{
    public class ConsultarModelosResponse
    {
        public List<Modelo> Modelos { get; set; }
    }

    public class Modelo
    {
        public string Label { get; set; }

        public int Value { get; set; }
    }
}
