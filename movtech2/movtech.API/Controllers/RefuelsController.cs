using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movtech.API.ViewModels.Refuel;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Services;

namespace movtech.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RefuelsController : ControllerBase
    {

        #region Config

        private readonly IRefuelService _refuelService;
        private readonly IGasStationService _gasStationService;

        public RefuelsController(IRefuelService refuelService, IGasStationService gasStationService)
        {
            _refuelService = refuelService;
            _gasStationService = gasStationService;

        }

        #endregion

        #region Refuel

        #endregion

        #region GasStation

        [HttpGet("gasStations/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetGasStation(int id)
        {

            GasStation _gasStation = _gasStationService.Get(id);

            if (_gasStation != null)
            {
                return Ok(_gasStation);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("gasStations")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetAllGasStations()
        {

            IEnumerable<GasStation> _drivers = _gasStationService.GetAll();

            if (_drivers.Count() > 0)
            {
                return Ok(_drivers);
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost("gasStations")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateGasStation([FromBody]CreateGasStationViewModel viewModel)
        {

            try
            {
                // TODO Arrumar bug do ano
                if (ModelState.IsValid)
                {

                    GasStation _gasStation = new GasStation()
                    {
                        CNPJ = viewModel.CNPJ,
                        Name = viewModel.Name,
                        CEP = viewModel.CEP,
                        Street = viewModel.Street,
                        Number = viewModel.Number,
                        Neighborhood = viewModel.Neighborhood,
                        City = viewModel.City,
                        UF = viewModel.UF

                    };

                    return Created("", _gasStationService.Insert(_gasStation));
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

        [HttpPut("gasStations/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult UpdateGasStation(int id, [FromBody]UpdateGasStationViewModel viewModel)
        {

            GasStation _gasStation = _gasStationService.Get(id);

            if (_gasStation is null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Atualizar   
                _gasStation.Name = viewModel.Name;
                _gasStation.CEP = viewModel.CEP;
                _gasStation.Street = viewModel.Street;
                _gasStation.Number = viewModel.Number;
                _gasStation.Neighborhood = viewModel.Neighborhood;
                _gasStation.City = viewModel.City;
                _gasStation.UF = viewModel.UF;

                return Ok(_gasStationService.Update(_gasStation));
            }
            else
            {
                return BadRequest();
            }

        }


        #endregion

    }
}