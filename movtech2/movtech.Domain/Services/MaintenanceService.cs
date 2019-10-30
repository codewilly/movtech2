using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Services
{
    public class MaintenanceService : BaseService<Maintenance>, IMaintenanceService
    {
        private readonly IMaintenanceRepository _maintenanceRepository;

        public MaintenanceService(IMaintenanceRepository maintenanceRepository) : base(maintenanceRepository)
        {
            _maintenanceRepository = maintenanceRepository;
        }

        public Maintenance NewMaintenance(Maintenance maintenance)
        {
            maintenance.DoMaintenance();

            return _maintenanceRepository.Insert(maintenance);
        }
    }
}
