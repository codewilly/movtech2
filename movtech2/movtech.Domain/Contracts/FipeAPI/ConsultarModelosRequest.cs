using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.FipeAPI
{
    public class ConsultarModelosRequest
    {
        public int CodigoTabelaReferencia { get; set; }

        public VehicleType CodigoTipoVeiculo { get; set; }

        public int CodigoMarca { get; set; }
    }
}
