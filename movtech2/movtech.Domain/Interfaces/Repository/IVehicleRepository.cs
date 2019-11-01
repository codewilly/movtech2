using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Interfaces.Repository
{
    public interface IVehicleRepository : IBaseRepository<Vehicle>
    {
        Vehicle GetByLicensePlate(string lp);

        Task<List<Vehicle>> GetVehiclesWhoNeedsMaintenance();


    }
}
