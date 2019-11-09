using movtech.Domain.Contracts.FipeAPI;
using movtech.Domain.Contracts.Vehicle;
using movtech.Domain.Entities;
using movtech.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.MVC.Services.Interface
{
    public interface IMovtechAPIService
    {

        #region Veiculos        

        Task<ConsultarMarcasResponse> ConsultarMarcas(VehicleType type);

        Task<ConsultarModelosResponse> ConsultarModelos(VehicleType type, int MarcaId);

        Task<ConsultarAnoModeloResponse> ConsultarAnosDoModelo(VehicleType type, int MarcaId, int ModeloId);

        Task<bool> CadastrarVeiculo(CreateVehicleRequest request);

        Task<bool> AtualizarVeiculo(int id,UpdateVehicleRequest request);

        Task<Vehicle> GetVehicle(int id);

        Task<IEnumerable<Vehicle>> GetAllVeiculos();

        #endregion

        Task<IEnumerable<Driver>> GetAllDrivers();

    }
}
