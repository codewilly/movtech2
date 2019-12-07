using movtech.Domain.Contracts.EntranceAndExit;
using movtech.Domain.Contracts.FipeAPI;
using movtech.Domain.Contracts.Maintenance;
using movtech.Domain.Contracts.Refuel;
using movtech.Domain.Contracts.TrafficTicket;
using movtech.Domain.Contracts.Vehicle;
using movtech.Domain.Entities;
using movtech.Domain.Enums;
using movtech.MVC.ViewModels;
using movtech.MVC.ViewModels.Driver;
using movtech.MVC.ViewModels.TrafficTicket;
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

        #region Drivers
        Task<IEnumerable<Driver>> GetAllDrivers();

        Task<bool> CadastarMotorista(CreateDriverViewModel viewModel);

        Task<bool> AtualizarMotorista(int id, EditDriverViewModel request);

        Task<Driver> GetDriver(int id);
        #endregion

        #region Entrance and Exit

        Task<bool> RegisterExit(RegisterExitRequest request);

        Task<bool> RegisterEntrance(RegisterEntranceRequest request);

        Task<IEnumerable<EntranceAndExit>> GetAllEntranceAndExit();

        #endregion

        #region Maintenances

        Task<IEnumerable<Vehicle>> GetVehiclesWhoNeedsMaintenance();

        Task<bool> RegisterMaintenance(RegisterMaintenanceRequest request);


        #endregion


        #region TrafficTrickets
        Task<bool> CadastrarMulta(CreateTrafficTicketRequest request);
        Task<IEnumerable<TrafficTicketIndexViewModel>> ConsultarMultas();

        #endregion

        #region Refuel and GasStations

        Task<bool> CreateGasStation(CreateGasStationRequest gs);

        #endregion
    }
}
