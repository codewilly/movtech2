using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Services
{
    public class RefuelService : BaseService<Refuel>, IRefuelService
    {

        private readonly IRefuelRepository _refuelRepository;

        public RefuelService(IRefuelRepository refuelRepository) : base(refuelRepository)
        {
            _refuelRepository = refuelRepository;
        }

        public Task<List<Refuel>> GetRefuelLog(string placa, string cpf, string cnpj, bool asc)
        {
            return _refuelRepository.GetRefuelLog(placa, cpf, cnpj, asc);
        }
    }
}
