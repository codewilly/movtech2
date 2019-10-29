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
        private readonly IDriverService _driverService;
        private readonly IVehicleService _vehicleService;

        public RefuelsController(IRefuelService refuelService, IGasStationService gasStationService,
                                 IDriverService driverService, IVehicleService vehicleService)
        {
            _refuelService = refuelService;
            _gasStationService = gasStationService;
            _driverService = driverService;
            _vehicleService = vehicleService;

        }

        #endregion

        #region Refuel

        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetRefuel(int id)
        {

            Refuel _refuel = _refuelService.Get(id);

            if (_refuel != null)
            {
                return Ok(_refuel);
            }
            else
            {
                return NotFound();
            }

        }
               
        [HttpPost("")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult RegisterRefuel([FromBody]RegisterRefuelViewModel viewModel)
        {

            try
            {
                // TODO Arrumar bug do ano
                if (ModelState.IsValid)
                {

                    Vehicle _vehicle = _vehicleService.GetByLicensePlate(viewModel.VehicleLicensePlate);
                    Driver _driver = _driverService.GetByCPF(viewModel.DriverCPF);
                    GasStation _gasStation = _gasStationService.GetByCnpj(viewModel.GasStationCNPJ);

                    Refuel refuel = new Refuel()
                    {
                        TotalValue = viewModel.TotalValue,
                        LiterValue = viewModel.LiterValue,
                        Liters = viewModel.Liters,
                        FuelType = viewModel.FuelType,
                        RefuelDate = viewModel.RefuelDate,
                        Driver = _driver,
                        Vehicle = _vehicle,
                        GasStation = _gasStation
                    };

                    string _refuelFeedback = refuel.Validate();

                    if (_refuelFeedback == "ok")
                    {
                        return Created("", _refuelService.Insert(refuel));
                    }
                    else
                    {
                        return BadRequest(_refuelFeedback);
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


        [HttpGet("log")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> RefuelLog([FromQuery] string placa = "", [FromQuery] string cpf = "", [FromQuery] string cnpj = "", bool asc = true)
        {

            try
            {
                return Ok(await _refuelService.GetRefuelLog(placa, cpf, cnpj, asc));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException);
            }

        }
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