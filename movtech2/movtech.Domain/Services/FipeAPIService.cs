using movtech.Domain.Contracts.FipeAPI;
using movtech.Domain.Enums;
using movtech.Domain.Interfaces.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Services
{
    public class FipeAPIService : IFipeAPIService
    {

        #region Configuração        

        private readonly IHttpClientFactory _httpClientFactory;

        private readonly HttpClient _client;

        public FipeAPIService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

            _client = _httpClientFactory.CreateClient("FipeApi");
        }


        #endregion

        public async Task<ConsultarModelosResponse> ConsultarModelos(ConsultarModelosRequest request)
        {
            try
            {
                return await HttpJson<ConsultarModelosRequest, ConsultarModelosResponse>
                .PostAsync(_client, "api/veiculos/ConsultarModelos", request);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<ConsultarMarcasResponse> ConsultarMarcas(ConsultarMarcasRequest request)
        {

            try
            {
                return new ConsultarMarcasResponse()
                {
                    Marcas = await HttpJson<ConsultarMarcasRequest, List<MarcaItem>>
                    .PostAsync(_client, "api/veiculos/ConsultarMarcas", request)
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<ConsultarAnoModeloResponse> ConsultarAnoModelo(ConsultarAnoModeloRequest request)
        {

            try
            {
                return new ConsultarAnoModeloResponse()
                {
                    AnoModelos = await HttpJson<ConsultarAnoModeloRequest, List<AnoModelos>>
                    .PostAsync(_client, "api/veiculos/ConsultarAnoModelo", request)
                };
            }
            catch (Exception ex)
            {
                return null;
            }


        }
    }
}
