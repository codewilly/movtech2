using movtech.Desktop.Contracts;
using movtech.Desktop.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Desktop.Services
{
    class UserService
    {
        public async Task<User> Login(UserLoginRequest request)
        {
            
            try
            {
                var _client = new HttpClient();
                HttpResponseMessage _message = await _client.PostAsync("https://localhost:44310/api/v1/Users/login",
                    new StringContent(JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json"));

                return JsonConvert.DeserializeObject<User>(await _message.Content.ReadAsStringAsync());

            }
            catch (Exception ex)
            {
                throw;
            }



        }
    }
}
