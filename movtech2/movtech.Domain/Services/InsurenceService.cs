using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace movtech.Domain.Services
{
    public class InsurenceService : BaseService<Insurence>, IInsurenceService
    {
        private readonly IInsurenceRepository _insurenceRepository;

        public InsurenceService(IInsurenceRepository insurenceRepository) : base(insurenceRepository)
        {
            _insurenceRepository = insurenceRepository;
        }

        public Task<IEnumerable<Insurence>> GetAllInsurences()
        {
            return _insurenceRepository.GetAllInsurences();
        }

        public Task<Insurence> GetInsurence(int id)
        {
            return _insurenceRepository.GetInsurence(id);
        }

      

        public string SetInsurenceClaim(Insurence insurence)
        {
            insurence.HasInsurenceClaim = true;
            _insurenceRepository.Update(insurence);
            return "ok";
        }
        
    }
}
