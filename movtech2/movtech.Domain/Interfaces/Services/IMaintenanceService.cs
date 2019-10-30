using movtech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Interfaces.Services
{
    public interface IMaintenanceService : IBaseService<Maintenance>
    {
        Maintenance NewMaintenance(Maintenance maintenance);

    }
}
