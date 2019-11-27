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
    public class EntranceAndExitsService
    {
        public async Task<bool> RegisterEntrance(RegisterEntranceRequest request)
        {
            try
            {
                var _client = new HttpClient();
                HttpResponseMessage _message = await _client.PostAsync("https://localhost:44310/api/v1/EntranceAndExits/entrance",
                    new StringContent(JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json"));

                return _message.IsSuccessStatusCode;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<bool> RegisterExit(RegisterExitRequest request)
        {
            try
            {
                var _client = new HttpClient();
                HttpResponseMessage _message = await _client.PostAsync("https://localhost:44310/api/v1/EntranceAndExits/exit",
                    new StringContent(JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json"));

                return _message.IsSuccessStatusCode;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<List<EntranceAndExitsFormModel>> GetAll()
        {

            string URI = "https://localhost:44310/api/v1/EntranceAndExits/log";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var EntranceAndExitsJsonString = await response.Content.ReadAsStringAsync();
                        var listaEntranceAndExit = JsonConvert.DeserializeObject<EntranceAndExit[]>(EntranceAndExitsJsonString).ToList();

                        var listaFormModel = from fields in listaEntranceAndExit
                                             select new EntranceAndExitsFormModel
                                             {
                                                 CreationDate = fields.CreationDate,
                                                 VehicleBrand = fields.Vehicle.Brand,                                                 
                                                 Description = fields.Description

                                             };

                        return listaFormModel.OrderByDescending(p => p.CreationDate).ToList();


                    }
                    else
                    {
                        return null;

                    }


                }

            }

        }

    }
}

