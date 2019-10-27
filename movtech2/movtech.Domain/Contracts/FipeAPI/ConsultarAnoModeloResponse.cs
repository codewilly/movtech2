using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.FipeAPI
{
    public class ConsultarAnoModeloResponse
    {
        public List<AnoModelos> AnoModelos { get; set; }
    }

    public class AnoModelos
    {
        public string Label { get; set; }

        public string Value { get; set; }
    }
}
