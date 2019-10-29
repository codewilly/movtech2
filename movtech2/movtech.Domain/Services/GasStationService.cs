using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Services
{
    public class GasStationService : BaseService<GasStation>, IGasStationService
    {

        private readonly IGasStationRepository _gasStationRepository;

        public GasStationService(IGasStationRepository gasStationRepository) : base(gasStationRepository)
        {
            _gasStationRepository = gasStationRepository;
        }
    }
}
