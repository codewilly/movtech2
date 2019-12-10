using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Services
{
    public class InsurerService : BaseService<Insurer>, IInsurerService
    {
        private readonly IInsurerRepository _insurerRepository;

        public InsurerService(IInsurerRepository insurerRepository) : base(insurerRepository)
        {
            _insurerRepository = insurerRepository;
        }


    }
}
