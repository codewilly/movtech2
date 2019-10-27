using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.FipeAPI
{
    public class ConsultarMarcasResponse
    {
        public List<MarcaItem> Marcas { get; set; }
    }

    public class MarcaItem
    {
        public string Label { get; set; }

        public string Value { get; set; }

    }
}
