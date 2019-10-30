using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movtech.API.ViewModels.TrafficTicket;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Services;

namespace movtech.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TrafficTicketsController : ControllerBase
    {
        private readonly ITrafficTicketService _trafficTicketService;
        private readonly IDriverService _driverService;
        private readonly IVehicleService _vehicleService;

        public TrafficTicketsController(ITrafficTicketService trafficTicketService, IDriverService driverService, IVehicleService vehicleService)
        {
            _trafficTicketService = trafficTicketService;
            _driverService = driverService;
            _vehicleService = vehicleService;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult RegisterTrafficTicket([FromBody]RegisterTrafficTicketViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    Vehicle _vehicle = _vehicleService.GetByLicensePlate(viewModel.VehicleLicensePlate);
                    Driver _driver = _driverService.GetByCPF(viewModel.DriverCPF);

                    TrafficTicket _trafficTicket = new TrafficTicket()
                    {
                        Vehicle = _vehicle,
                        Driver = _driver,

                        TrafficTicketDate = viewModel.TrafficTicketDate,
                        BilletExpiration = viewModel.BilletExpiration,
                        Cost = viewModel.Cost,
                        Level = viewModel.Level,
                        Description = viewModel.Description,

                        CEP = viewModel.CEP,
                        Street = viewModel.Street,
                        Number = viewModel.Number,
                        Neighborhood = viewModel.Neighborhood,
                        City = viewModel.City,
                        UF = viewModel.UF

                    };

                    string _trafficTicketFeedback = _trafficTicket.Validate();

                    if (_trafficTicketFeedback == "ok")
                    {
                        return Created("", _trafficTicketService.Insert(_trafficTicket));
                    }
                    else
                    {
                        return BadRequest(_trafficTicketFeedback);
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

        [HttpPost("{trafficTicketId}/pay")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult PayTrafficTicket(int trafficTicketId)
        {
            try
            {

                TrafficTicket _trafficTicket = _trafficTicketService.Get(trafficTicketId);

                if (_trafficTicket != null)
                {
                    try
                    {
                        _trafficTicket.Pay();
                    }
                    catch (InvalidOperationException ex)
                    {

                        return BadRequest(ex.Message);
                    }

                    return Ok(_trafficTicketService.Update(_trafficTicket));
                    
                }
                else
                {
                    return BadRequest("Multa não encontrada!");
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
        public async Task<IActionResult> GetTrafficTickets([FromQuery] string cpf = "", [FromQuery] string placa = "")
        {

            IEnumerable<TrafficTicket> _tickets = await _trafficTicketService.GetTrafficTickets(cpf, placa);

            if (_tickets.Count() > 0)
            {
                return Ok(_tickets);
            }
            else
            {
                return NotFound();
            }

        }




    }
}