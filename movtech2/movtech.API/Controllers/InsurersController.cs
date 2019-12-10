using Microsoft.AspNetCore.Mvc;
using movtech.API.ViewModels.Insurer;
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
    public class InsurersController : ControllerBase
    {
        private readonly IInsurerService _insurerService;


        public InsurersController(IInsurerService insurerService)
        {
            _insurerService = insurerService;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateDriver([FromBody]CreateInsurerViewModel viewModel)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    Insurer _broker = new Insurer()
                    {

                        Name = viewModel.Name,
                        CNPJ = viewModel.CNPJ,
                        Phone = viewModel.Phone,
                        Email = viewModel.Email,                        
                        CEP = viewModel.CEP,
                        Street = viewModel.Street,
                        Number = viewModel.Number,
                        Neighborhood = viewModel.Neighborhood,
                        City = viewModel.City,
                        UF = viewModel.UF


                    };


                    return Created("", _insurerService.Insert(_broker));
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
        public IActionResult GetAllInsurers()
        {

            IEnumerable<Insurer> _insurers = _insurerService.GetAll();
            if (_insurers.Count() > 0)
            {
                return Ok(_insurers);
            }
            else
            {
                return NotFound();
            }

        }
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetInsurer(int id)
        {

            Insurer _insurer = _insurerService.Get(id);

            if (_insurer != null)
            {
                return Ok(_insurer);
            }
            else
            {
                return NotFound();
            }

        }
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult UpdateInsurer(int id, [FromBody]UpdateInsurerViewModel viewModel)
        {

            Insurer _insurer = _insurerService.Get(id);

            if (_insurer is null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Atualizar   
                _insurer.Name = viewModel.Name;
                _insurer.Phone = viewModel.Phone;
                _insurer.Email = viewModel.Email;


                //Address
                _insurer.CEP = viewModel.CEP;
                _insurer.Street = viewModel.Street;
                _insurer.Number = viewModel.Number;
                _insurer.Neighborhood = viewModel.Neighborhood;
                _insurer.City = viewModel.City;
                _insurer.UF = viewModel.UF;



                return Ok(_insurerService.Update(_insurer));
            }
            else
            {
                return BadRequest();
            }

        }
    }
   
    
}
