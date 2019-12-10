using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movtech.API.ViewModels.Broker;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using movtech.Infra.Context;

namespace movtech.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BrokersController : ControllerBase
    {

        private readonly IBrokerService _brokerService;
        public BrokersController(IBrokerService broker)
        {
            _brokerService = broker;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateBroker([FromBody]CreateBrokerViewModel viewModel)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    Broker _broker = new Broker()
                    {

                        Name = viewModel.Name,
                        CNPJ = viewModel.CNPJ,
                        Phone = viewModel.Phone,
                        Email = viewModel.Email,
                        ResponsibleBroker = viewModel.ResponsibleBroker,
                        CEP = viewModel.CEP,
                        Street = viewModel.Street,
                        Number = viewModel.Number,
                        Neighborhood = viewModel.Neighborhood,
                        City = viewModel.City,
                        UF = viewModel.UF


                    };


                    return Created("", _brokerService.Insert(_broker));
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
        public IActionResult GetAllBrokers()
        {


            IEnumerable<Broker> _brokers = _brokerService.GetAll();



            if (_brokers.Count() > 0)
            {
                return Ok(_brokers);
            }
            else
            {
                return NotFound();
            }

        }
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetBroker(int id)
        {

            Broker _broker = _brokerService.Get(id);

            if (_broker != null)
            {
                return Ok(_broker);
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
        public IActionResult UpdateBroker(int id, [FromBody]UpdateBrokerViewModel viewModel)
        {

            Broker _broker = _brokerService.Get(id);

            if (_broker is null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Atualizar   
                _broker.Name = viewModel.Name;
                _broker.Phone = viewModel.Phone;
                _broker.Email = viewModel.Email;
                _broker.ResponsibleBroker = viewModel.ResponsibleBroker;

                //Address
                _broker.CEP = viewModel.CEP;
                _broker.Street = viewModel.Street;
                _broker.Number = viewModel.Number;
                _broker.Neighborhood = viewModel.Neighborhood;
                _broker.City = viewModel.City;
                _broker.UF = viewModel.UF;



                return Ok(_brokerService.Update(_broker));
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
