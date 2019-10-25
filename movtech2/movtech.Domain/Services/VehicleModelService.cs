using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Services
{
    public class VehicleModelService : BaseService<VehicleModel>, IVehicleModelService
    {

        private readonly IVehicleModelRepository _vehicleModelRepository;

        public VehicleModelService(IVehicleModelRepository vehicleModelRepository) : base(vehicleModelRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
        }
    }
}
