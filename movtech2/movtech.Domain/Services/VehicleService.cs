using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Services
{
    public class VehicleService : BaseService<Vehicle>, IVehicleService
    {

        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository) : base(vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public Vehicle GetByLicensePlate(string lp)
        {
            return _vehicleRepository.GetByLicensePlate(lp);
        }

        public Task<List<Vehicle>> GetVehiclesWhoNeedsMaintenance()
        {
            return _vehicleRepository.GetVehiclesWhoNeedsMaintenance();
        }

        public bool SetInsurence(Insurence insurence,int vehicleId)
        {
            Vehicle vehicle = _vehicleRepository.Get((vehicleId));
            if (vehicle != null)
            {
                vehicle.Insurence = insurence;
                vehicle.InsurenceId = insurence.Id;
                _vehicleRepository.Update(vehicle);
                return true;
            }
            else
            {
                return false;
            }

            

            


        }
    }
}
