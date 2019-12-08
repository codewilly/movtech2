using movtech.Domain.Contracts.EntranceAndExit;
using movtech.Domain.Contracts.FipeAPI;
using movtech.Domain.Contracts.Maintenance;
using movtech.Domain.Contracts.Refuel;
using movtech.Domain.Contracts.TrafficTicket;
using movtech.Domain.Contracts.User;
using movtech.Domain.Contracts.Vehicle;
using movtech.Domain.Entities;
using movtech.Domain.Enums;
using movtech.Domain.Services;
using movtech.MVC.Services.Interface;
using movtech.MVC.ViewModels;
using movtech.MVC.ViewModels.Driver;
using movtech.MVC.ViewModels.TrafficTicket;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace movtech.MVC.Services
{
    public class MovtechAPIService : IMovtechAPIService
    {

        #region Configuration

        private readonly IHttpClientFactory _httpClientFactory;

        private readonly HttpClient _client;

        public MovtechAPIService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

            _client = _httpClientFactory.CreateClient("MOVTechAPI");
        }
        #endregion

        #region Veiculos


        public async Task<ConsultarMarcasResponse> ConsultarMarcas(VehicleType type)
        {
            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"api/v1/Vehicles/marcas?tipo={type}");
                return JsonConvert.DeserializeObject<ConsultarMarcasResponse>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<ConsultarModelosResponse> ConsultarModelos(VehicleType type, int MarcaId)
        {
            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"api/v1/Vehicles/marcas/{MarcaId}/modelos?tipo={type}");
                return JsonConvert.DeserializeObject<ConsultarModelosResponse>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<ConsultarAnoModeloResponse> ConsultarAnosDoModelo(VehicleType type, int MarcaId, int ModeloId)
        {
            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"api/v1/Vehicles/marcas/{MarcaId}/modelo/anos?tipo={type}&modeloId={ModeloId}");
                return JsonConvert.DeserializeObject<ConsultarAnoModeloResponse>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> CadastrarVeiculo(CreateVehicleRequest request)
        {
            try
            {
                HttpResponseMessage _message = await _client.PostAsync("api/v1/Vehicles",
                    new StringContent(JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json"));

                return _message.IsSuccessStatusCode;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<bool> AtualizarVeiculo(int id, UpdateVehicleRequest request)
        {
            try
            {
                HttpResponseMessage _message = await _client.PutAsync($"api/v1/Vehicles/{id}", new StringContent(JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json"));


                return _message.IsSuccessStatusCode;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Vehicle>> GetAllVeiculos()
        {
            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"api/v1/Vehicles");
                return JsonConvert.DeserializeObject<IEnumerable<Vehicle>>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Vehicle> GetVehicle(int id)
        {
            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"api/v1/Vehicles/{id}");
                return JsonConvert.DeserializeObject<Vehicle>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        #endregion

        public async Task<IEnumerable<Driver>> GetAllDrivers()
        {
            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"api/v1/Drivers");
                return JsonConvert.DeserializeObject<IEnumerable<Driver>>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> CadastarMotorista(CreateDriverViewModel viewModel)
        {
            try
            {
                HttpResponseMessage _message = await _client.PostAsync("api/v1/Drivers",
                    new StringContent(JsonConvert.SerializeObject(viewModel),
                    Encoding.UTF8, "application/json"));

                return _message.IsSuccessStatusCode;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Driver> GetDriver(int id)
        {
            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"api/v1/Drivers/{id}");
                return JsonConvert.DeserializeObject<Driver>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> AtualizarMotorista(int id, EditDriverViewModel request)
        {
            try
            {
                HttpResponseMessage _message = await _client.PutAsync($"api/v1/Drivers/{id}", new StringContent(JsonConvert.SerializeObject(request),
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
                HttpResponseMessage _message = await _client.PostAsync("api/v1/EntranceAndExits/exit",
                    new StringContent(JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json"));

                return _message.IsSuccessStatusCode;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> RegisterEntrance(RegisterEntranceRequest request)
        {
            try
            {
                HttpResponseMessage _message = await _client.PostAsync("api/v1/EntranceAndExits/entrance",
                    new StringContent(JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json"));

                return _message.IsSuccessStatusCode;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<EntranceAndExit>> GetAllEntranceAndExit()
        {
            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"api/v1/EntranceAndExits");
                return JsonConvert.DeserializeObject<IEnumerable<EntranceAndExit>>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesWhoNeedsMaintenance()
        {
            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"api/v1/Maintenance/Vehicles");
                return JsonConvert.DeserializeObject<IEnumerable<Vehicle>>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> RegisterMaintenance(RegisterMaintenanceRequest request)
        {
            try
            {
                HttpResponseMessage _message = await _client.PostAsync("api/v1/Maintenance",
                    new StringContent(JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json"));

                return _message.IsSuccessStatusCode;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> CadastrarMulta(CreateTrafficTicketRequest request)
        {
            try
            {
                HttpResponseMessage _message = await _client.PostAsync("api/v1/TrafficTickets",
                    new StringContent(JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json"));

                return _message.IsSuccessStatusCode;


            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<IEnumerable<TrafficTicket>> ConsultarMultas()
        {

            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"api/v1/TrafficTickets");
                return JsonConvert.DeserializeObject<IEnumerable<TrafficTicket>>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task<TrafficTicket> ConsultarMulta(int id)
        {
            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"api/v1/TrafficTickets/{id}");
                return JsonConvert.DeserializeObject<TrafficTicket>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task PagarMulta(int id)
        {
            try
            {
                HttpResponseMessage _message = await _client.PostAsync($"api/v1/TrafficTickets/{id}/pay",
                    new StringContent(JsonConvert.SerializeObject(id),
                    Encoding.UTF8, "application/json"));

                


            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> CreateGasStation(CreateGasStationRequest request)
        {
            try
            {
                HttpResponseMessage _message = await _client.PostAsync("api/v1/Refuels/gasStations",
                    new StringContent(JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json"));

                return _message.IsSuccessStatusCode;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<GasStation>> GetGasStations()
        {
            try
            {
                HttpResponseMessage _message = await _client.GetAsync($"api/v1/Refuels/gasStations");
                return JsonConvert.DeserializeObject<IEnumerable<GasStation>>(await _message.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> RegisterRefuel(RegisterRefuelRequest request)
        {
            try
            {
                HttpResponseMessage _message = await _client.PostAsync("api/v1/Refuels",
                    new StringContent(JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json"));

                return _message.IsSuccessStatusCode;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<User> Login(UserLoginRequest request)
        {
            try
            {
                HttpResponseMessage _message = await _client.PostAsync("api/v1/Users/login",
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
