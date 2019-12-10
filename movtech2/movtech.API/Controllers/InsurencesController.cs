using Microsoft.AspNetCore.Mvc;
using movtech.API.ViewModels.Insurence;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movtech.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class InsurencesController : ControllerBase
    {
        private readonly IInsurenceService _insurenceService;
        private readonly IVehicleService _vehicleService;
        private readonly IBrokerService _brokerService;
        private readonly IInsurerService _insurerService;


        public InsurencesController(IInsurenceService insurenceService, IVehicleService vehicleService, IBrokerService brokerService, IInsurerService insurerService)
        {
            _insurenceService = insurenceService;
            _vehicleService = vehicleService;
            _brokerService = brokerService;
            _insurerService = insurerService;


        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateDriver([FromBody]CreateInsurenceViewModel viewModel)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    Vehicle _vehicle = _vehicleService.Get(viewModel.VehicleId);

                    Broker _broker = _brokerService.Get(viewModel.BrokerId);
                    Insurer _insurer = _insurerService.Get(viewModel.InsurerId);



                    Insurence _insurence = new Insurence()
                    {
                        BeginOfVigency = viewModel.BeginOfVigency,
                        EndOfVigency = viewModel.EndOfVigency,
                        BonusClass = viewModel.BonusClass,
                        CINumber = viewModel.CINumber,
                        PolicyNumber = viewModel.PolicyNumber,

                        Vehicle = _vehicle,
                        Broker = _broker,
                        Insurer = _insurer,
      
                        



                    };
                    _insurenceService.Insert(_insurence);


                    if(_vehicleService.SetInsurence(_insurence, viewModel.VehicleId))
                    {
                        return Created("", _insurence);
                    }
                    else
                    {
                        return BadRequest();
                    }


                    
                  


                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException);
            }

        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAll()
        {

            IEnumerable<Insurence> _insurences = await _insurenceService.GetAllInsurences();


            if (_insurences.Count() > 0)
            {
                return Ok(_insurences);
            }
            else
            {
                return NotFound();
            }

        }
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetInsurence(int id)
        {

            Insurence _insurence = await _insurenceService.GetInsurence(id);

            if (_insurence != null)
            {
                return Ok(_insurence);
            }
            else
            {
                return NotFound();
            }

        }
    }
}

