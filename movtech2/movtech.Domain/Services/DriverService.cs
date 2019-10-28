using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Services
{
    public class DriverService : BaseService<Driver>, IDriverService
    {
        private readonly IDriverRepository _driverRepository;

        public DriverService(IDriverRepository driverRepository) : base(driverRepository)
        {
            _driverRepository = driverRepository;
        }

        public Driver GetByCPF(string cpf)
        {
            return _driverRepository.GetByCPF(cpf);
        }
    }
}
