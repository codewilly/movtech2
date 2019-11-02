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
        private readonly IMaintenanceService _maintenanceService;
        private readonly ITrafficTicketService _trafficTicketService;



        public SeedingService(IDriverService driverService,IVehicleService vehicleService,IEntranceAndExitService entranceAndExitService, IRefuelService refuelService, IGasStationService gasStationService, IMaintenanceService maintenanceService, ITrafficTicketService trafficTicketService)
        {
            _vehicleService = vehicleService;
            _driverService = driverService;
            _entranceAndExitService = entranceAndExitService;
            _refuelService = refuelService;
            _gasStationService = gasStationService;
            _maintenanceService = maintenanceService;
            _trafficTicketService = trafficTicketService;


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
               /* _vehicleService.InsertMany(SeedVehicle());
               _driverService.InsertMany(SeedDriver());
               _entranceAndExitService.InsertMany(SeedEntranceAndExits());
              _refuelService.InsertMany(SeedRefuel());
             //  _gasStationService.InsertMany(SeedGasStation());*/
                SeedAll();

            }
        }

        private void SeedAll()
        {
            Vehicle v1 = new Vehicle("Chevrolet", "Onix", "KKK-4545", "1058459789",2000, 10000, FuelType.Flex, VehicleType.Carro, true, VehicleStatus.Alocado, null, null, DateTime.Parse("10/10/2010"), 9000, 9000, 9000);
            Driver d1 = new Driver("124154215", "AB", 1, v1, DriverStatus.Ativo, 1, "Marco", "48334380892", DateTime.Parse("31/10/1999"), "39027173", "marco@gmail.com", "12213210", "estrada Juca de Carvalho", 3548, "caete", "sjc", UF.SP);
            EntranceAndExit e1 = new EntranceAndExit(DateTime.Parse("10/10/2010"),1,v1,1, d1,11000, false, "Tudo certo");
            GasStation g1 = new GasStation("1234567897", "Shell","12210215","Rua das flores",154,"Vila César","SJC",UF.SP);
            Refuel r1 = new Refuel(100, 10, 10, FuelType.Alcool, DateTime.Parse("10/10/2010"),v1,d1,g1);
            Maintenance m1 = new Maintenance(DateTime.Parse("10/10/2005"), MaintenanceType.Preventiva, 1, v1, 1000, false, true,true, "Ocorreu tudo Certo");
            TrafficTicket t1 = new TrafficTicket(d1, v1, DateTime.Parse("10/10/2011"), DateTime.Parse("18/10/2011"), null, 1000, 5, TrafficTickeLevel.Gave, "Alta velocidade", false,"12456458","Rua das Rosas",157,"Vila Maria","SJC",UF.SP);


            Vehicle v2 = new Vehicle("Fiat", "Uno", "KTY-1245", "7457531254", 2004, 5000, FuelType.Gasolina, VehicleType.Carro, true, VehicleStatus.Alocado, null, null, DateTime.Parse("10/11/2008"), 4000, 4000, 4000);
            Driver d2 = new Driver("123141214", "AB", 2, v2, DriverStatus.Ativo, 2, "Victor", "42512542536", DateTime.Parse("02/10/1999"), "40028922", "victor@gmail.com", "12213451", "Rua dos Pássaros", 45, "Vila Teodoro", "Jacareí", UF.SP);
            EntranceAndExit e2 = new EntranceAndExit(DateTime.Parse("10/10/2015"), 2, v2, 2, d2, 6000, false, "Veículo Normal");
            GasStation g2 = new GasStation("484808954", "Ipiranga", "12451978", "Avenida Brasil", 158, "Cajurú", "Jacareí", UF.SP);
            Refuel r2 = new Refuel(80, 10, 8, FuelType.Gasolina, DateTime.Parse("10/10/2015"), v2, d2, g2);
            Maintenance m2 = new Maintenance(DateTime.Parse("10/12/2016"), MaintenanceType.Preventiva, 2, v2, 2000, false, true, true, "Ocorreu tudo Certo");
            TrafficTicket t2 = new TrafficTicket(d2, v2, DateTime.Parse("02/05/2015"), DateTime.Parse("05/10/2015"), null, 1000, 5, TrafficTickeLevel.Gave, "Alta velocidade", false, "45748410", "Rua Deserta", 80, "Vila Nair", "Jacareí", UF.SP);

            Vehicle v3 = new Vehicle("Fiat", "Palio", "XAE-1455", "1245174584", 2001, 15000, FuelType.Flex, VehicleType.Carro, true, VehicleStatus.Alocado, null, null, DateTime.Parse("05/05/2015"), 20000, 20000, 20000);
            Driver d3 = new Driver("123412314", "B", 3, v3, DriverStatus.Ativo, 3, "Osvaldo", "41221412532", DateTime.Parse("02/11/1995"), "948744512", "osvaldor@gmail.com", "15241218", "Rua dos Ursos", 8000, "Bosque Imperial", "Jacareí", UF.SP);
            EntranceAndExit e3 = new EntranceAndExit(DateTime.Parse("10/10/2017"), 3, v3, 3, d3, 16000, false, "Veículo Normal");
            GasStation g3 = new GasStation("454412121454", "Sete Estrelas", "12210054", "Avenida Bonsucesso", 814, "Bom Retiro", "Jacareí", UF.SP);
            Refuel r3 = new Refuel(70, 10, 7, FuelType.Gasolina, DateTime.Parse("10/10/2016"), v3, d3, g3);
            Maintenance m3 = new Maintenance(DateTime.Parse("10/12/2017"), MaintenanceType.Preventiva, 3, v3, 1500, false, true, true, "Ocorreu tudo Certo");
            TrafficTicket t3 = new TrafficTicket(d3, v3, DateTime.Parse("08/05/2016"), DateTime.Parse("15/10/2016"), null, 200, 2, TrafficTickeLevel.Leve, "Buzina", false, "45745781", "Rua Dos Lobos", 780, "Cambucá", "Jacareí", UF.SP);











            _vehicleService.InsertMany(new List<Vehicle>() { v1,v2,v3 });
            _driverService.InsertMany(new List<Driver>() { d1,d2,d3 });
            _entranceAndExitService.InsertMany(new List<EntranceAndExit>() { e1,e2,e3 });
            _gasStationService.InsertMany(new List<GasStation>() { g1,g2,g3 });
            _refuelService.InsertMany(new List<Refuel>() { r1,r2,r3 });
            _maintenanceService.InsertMany(new List<Maintenance>() { m1,m2,m3 });
            _trafficTicketService.InsertMany(new List<TrafficTicket>() { t1,t2,t3 });
                     

        }

        





    }
}
