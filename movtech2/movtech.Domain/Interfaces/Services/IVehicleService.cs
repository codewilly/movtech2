using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Interfaces.Services
{
    public interface IVehicleService : IBaseService<Vehicle>
    {
        Vehicle GetByLicensePlate(string lp);

        Task<List<Vehicle>> GetVehiclesWhoNeedsMaintenance();


        bool SetInsurence(Insurence insurence,int vehicleId);
    }
}
