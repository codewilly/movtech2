using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movtech.API.ViewModels.InsurenceClaim;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Services;

namespace movtech.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class InsurenceClaimsController : ControllerBase
    {

        private readonly IInsurenceClaimService _insurenceClaimService;
        private readonly IInsurenceService _insurenceService;
        private readonly IDriverService _driverService;
        public InsurenceClaimsController(IInsurenceClaimService insurenceClaimService, IInsurenceService insurenceService, IDriverService driverService)
        {
            _insurenceClaimService = insurenceClaimService;
            _insurenceService = insurenceService;
            _driverService = driverService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetAllInsurenceClaims()
        {


            IEnumerable<InsurenceClaim> _insurenceClaims = _insurenceClaimService.GetAll();



            if (_insurenceClaims.Count() > 0)
            {
                return Ok(_insurenceClaims);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetInsurenceClaim(int id)
        {

            InsurenceClaim _insurenceClaim = _insurenceClaimService.Get(id);

            if (_insurenceClaim != null)
            {
                return Ok(_insurenceClaim);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateInsurenceClaim([FromBody]CreateInsurenceClaimViewModel viewModel)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    Driver _driver = _driverService.GetByCPF(viewModel.DriverCPF);
                    Insurence _insurence = _insurenceService.Get(viewModel.InsurenceId);

                    InsurenceClaim _insurenceClaim = new InsurenceClaim()
                    {

                        OccurrenceNumber = viewModel.OccurrenceNumber,
                        InsurenceClaimDate = viewModel.InsurenceClaimDate,
                        Observation = viewModel.Observation,
                        InsurenceClaimNumber = viewModel.InsurenceClaimNumber,
                        
                        InsurenceClaimType = viewModel.InsurenceClaimType,

                        CEP = viewModel.CEP,
                        Street = viewModel.Street,
                        Number = viewModel.Number,
                        Neighborhood = viewModel.Neighborhood,
                        City = viewModel.City,
                        UF = viewModel.UF,

                        Insurence = _insurence,
                        Driver = _driver


                    };
                    _insurenceClaimService.Insert(_insurenceClaim);
                    
                    if (_insurenceService.SetInsurenceClaim(_insurence) == "ok")
                    {
                        return Created("", _insurenceClaim);
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

    }
}