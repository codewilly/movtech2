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
        private readonly MovtechContext _context;


        public SeedingService(MovtechContext context)
        {
            _context = context;
            

        }
    

        public void Seed()
        {
            if (_context.Vehicles.Any())
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
               
                for(int i = 1; i < 10; ++i)
                {
                    
                    Vehicle vehicle = new Vehicle("Chevetao", "Rebaixado", "KKK-454"+i, "45645"+i, 2000, 1000, FuelType.Alcool, VehicleType.Carro, true, VehicleStatus.Disponivel, null, null, DateTime.Parse("10/10/2010"), 900, 900, 900);
                    Driver driver = new Driver("444555" + i, "AB", i, vehicle, DriverStatus.Ativo, i, "Marco", "4833438089" + i, DateTime.Parse("31/10/1999"), "39027173", "marco@gmail.com", "12213210", "estrada Juca de Carvalho", 3548, "caete", "sjc", UF.SP);
                    _context.Drivers.Add(driver);
                    _context.Vehicles.Add(vehicle);

                }

                _context.SaveChanges();

                



                
            }
        }

       
       
    }
}
