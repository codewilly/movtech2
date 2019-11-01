using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movtech.API.ViewModels.EntranceAndExit;
using movtech.Domain.Contracts;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Services;

namespace movtech.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EntranceAndExitsController : ControllerBase
    {

        #region Config

        private readonly IEntranceAndExitService _entranceAndExitService;
        private readonly IDriverService _driverService;
        private readonly IVehicleService _vehicleService;

        public EntranceAndExitsController(IEntranceAndExitService entranceAndExitService, IDriverService driverService, IVehicleService vehicleService)
        {
            _entranceAndExitService = entranceAndExitService;
            _driverService = driverService;
            _vehicleService = vehicleService;

        }

        #endregion

        // TODO -> ADICIONAR SWAGGER SUMMARY


        [HttpPost("entrance")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult RegisterEntrance([FromBody] RegisterEntranceExitViewModel viewModel)
        {
            try
            {

                Vehicle _vehicle = _vehicleService.GetByLicensePlate(viewModel.LicensePlate);
                Driver _driver = _driverService.GetByCPF(viewModel.DriverCPF);

                List<AuxModelState> _modelStateErros = _entranceAndExitService.EntranceExitValidation(_vehicle, _driver, viewModel.Quilometers, true);

                if (_modelStateErros != null)
                {
                    _modelStateErros.ForEach(x => ModelState.AddModelError(x.Field, x.Message));
                }

                if (ModelState.IsValid)
                {

                    var _response = new EntranceExitResponseViewModel()
                    {
                        Response = _entranceAndExitService.Register(_vehicle, _driver, viewModel.Quilometers, true),
                        Messages = _vehicle.GetMaintenanceList()
                    };

                    return Ok(_response);
                }
                else
                {
                    return BadRequest(ModelState);
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.InnerException);
            }
        }

        [HttpPost("exit")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult RegisterExit([FromBody] RegisterEntranceExitViewModel viewModel)
        {
            try
            {

                Vehicle _vehicle = _vehicleService.GetByLicensePlate(viewModel.LicensePlate);
                Driver _driver = _driverService.GetByCPF(viewModel.DriverCPF);

                List<AuxModelState> _modelState = _entranceAndExitService.EntranceExitValidation(_vehicle, _driver, viewModel.Quilometers, false);

                if (_modelState != null)
                {
                    _modelState.ForEach(x => ModelState.AddModelError(x.Field, x.Message));
                }

                if (ModelState.IsValid)
                {

                    return Ok(_entranceAndExitService.Register(_vehicle, _driver, viewModel.Quilometers, false));
                }
                else
                {
                    return BadRequest(ModelState);
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
        public async Task<IActionResult> ViewEntranceAndExitLog([FromQuery] string placa = "", [FromQuery] string cpf = "", [FromQuery] bool asc = true)
        {

            try
            {
                return Ok(await _entranceAndExitService.GetEntranceAndExitLog(placa, cpf, asc));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException);
            }

        }
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetAllEntranceAndExits()
        {

            IEnumerable<EntranceAndExit> _entranceAndExits = _entranceAndExitService.GetAll();

            if (_entranceAndExits.Count() > 0)
            {
                return Ok(_entranceAndExits);
            }
            else
            {
                return NotFound();
            }

        }
    }
}