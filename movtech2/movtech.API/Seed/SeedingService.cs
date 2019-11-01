using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using movtech.Infra.Context;
using movtech.Domain.Entities;
using movtech.Domain.Enums;
using movtech.Infra.Repository;


namespace movtech.API.Seed
{
    public class SeedingService
    {
        
        private readonly IDriverService _driverService;
        private readonly IVehicleService _vehicleService;
        private readonly IEntranceAndExitService _entranceAndExitService;
        private readonly IRefuelService _refuelService;
        private readonly IGasStationService _gasStationService;



        public SeedingService(IDriverService driverService,IVehicleService vehicleService,IEntranceAndExitService entranceAndExitService, IRefuelService refuelService, IGasStationService gasStationService)
        {
            _vehicleService = vehicleService;
            _driverService = driverService;
            _entranceAndExitService = entranceAndExitService;
            _refuelService = refuelService;
            _gasStationService = gasStationService;


        }


        public void Seed()
        {
            if (_vehicleService.GetAll().Any())
            /*_context.TrafficTickets.Any() ||
            _context.GasStations.Any() ||
            _context.Refuels.Any() ||
            _context.Maintenances.Any() ||
            _context.EntranceAndExits.Any() ||
            _context.Drivers.Any())*/
            {
                return; // Banco ja esta populado
            }
            else
            {
                 _vehicleService.InsertMany(SeedVehicle());
                _driverService.InsertMany(SeedDriver());
                _entranceAndExitService.InsertMany(SeedEntranceAndExits());
               _refuelService.InsertMany(SeedRefuel());
              //  _gasStationService.InsertMany(SeedGasStation());
                

            }
        }

        

        private List<Vehicle> SeedVehicle()
        {
            var list = new List<Vehicle>();

            list.Add(new Vehicle("Chevetao", "Rebaixado", "KKK-454", "45645", 2000, 1000, FuelType.Alcool, VehicleType.Carro, true, VehicleStatus.Disponivel, null, null, DateTime.Parse("10/10/2010"), 900, 900, 900));

            return list;
        }
        private List<Driver> SeedDriver()
        {
            var list = new List<Driver>();

            
            list.Add(new Driver("444555", "AB", 1,null, DriverStatus.Ativo,1, "Marco", "4833438089", DateTime.Parse("31/10/1999"), "39027173", "marco@gmail.com", "12213210", "estrada Juca de Carvalho", 3548, "caete", "sjc",UF.SP));

            return list;
        }
        private List<EntranceAndExit> SeedEntranceAndExits()
        {

            var list = new List<EntranceAndExit>();

            list.Add(new EntranceAndExit(DateTime.Parse("10/10/2010"), 1, 1, 1000, false, "Veículo Normal"));


            return list;
        }
        private List<Refuel> SeedRefuel()
        {

            var list = new List<Refuel>();

            list.Add(new Refuel(100, 10, 10, FuelType.Alcool,DateTime.Parse("10/10/2010")));


            return list;
        }
        private List<GasStation> SeedGasStation()
        {

            var list = new List<GasStation>();

            list.Add(new GasStation("1234567897","Shell",null));


            return list;
        }





    }
}
