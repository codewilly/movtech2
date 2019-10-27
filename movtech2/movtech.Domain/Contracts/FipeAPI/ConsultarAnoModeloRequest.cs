using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Contracts.FipeAPI
{
    public class ConsultarAnoModeloRequest
    {

        public int CodigoTabelaReferencia { get; set; }

        public VehicleType CodigoTipoVeiculo { get; set; }

        public int CodigoMarca { get; set; }

        public int CodigoModelo { get; set; }

    }
}
