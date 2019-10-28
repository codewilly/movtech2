using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
