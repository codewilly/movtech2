using movtech.Domain.Interfaces.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Services
{
    public static class HttpJson<TRequest, TResponse>
    {

        public static async Task<TResponse> PostAsync(HttpClient client, string uri, TRequest request)
        {
            try
            {
                HttpResponseMessage _message = await client.PostAsync(
                    uri,
                    new StringContent(JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json"));

                var content = await _message.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResponse>(content);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static async Task<TResponse> GetAsync(HttpClient client, string uri, TRequest request)
        {
            try
            {
                HttpResponseMessage _message = await client.GetAsync(uri);
                return JsonConvert.DeserializeObject<TResponse>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
