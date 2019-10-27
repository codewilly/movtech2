using movtech.Domain.Contracts.FipeAPI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Interfaces.Services
{
    public interface IFipeAPIService
    {
        Task<ConsultarModelosResponse> ConsultarModelos(ConsultarModelosRequest request);

        Task<ConsultarMarcasResponse> ConsultarMarcas(ConsultarMarcasRequest request);

        Task<ConsultarAnoModeloResponse> ConsultarAnoModelo(ConsultarAnoModeloRequest request);
    }
}
