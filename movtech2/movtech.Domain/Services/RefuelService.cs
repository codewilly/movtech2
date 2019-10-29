using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Services
{
    public class RefuelService : BaseService<Refuel>, IRefuelService
    {

        private readonly IRefuelRepository _refuelRepository;

        public RefuelService(IRefuelRepository refuelRepository) : base(refuelRepository)
        {
            _refuelRepository = refuelRepository;
        }
    }
}
