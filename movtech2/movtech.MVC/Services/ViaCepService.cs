using movtech.Domain.Contracts.ViaCEP;
using movtech.MVC.Services.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace movtech.MVC.Services
{
    public class ViaCepService : IViaCepService
    {

        #region Configuration

        private readonly IHttpClientFactory _httpClientFactory;

        private readonly HttpClient _client;

        public ViaCepService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

            _client = _httpClientFactory.CreateClient("ViaCEPApi");
        }
        #endregion

        public async Task<SearchCepResponse> SearchCep(string cep)
        {
            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"ws/{cep}/json/");
                return JsonConvert.DeserializeObject<SearchCepResponse>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
