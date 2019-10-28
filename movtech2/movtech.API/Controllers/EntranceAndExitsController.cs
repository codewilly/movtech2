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


        [HttpPost("entrance")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult RegisterEntrance([FromBody] RegisterEntranceExitViewModel viewModel)
        {
            try
            {


                Vehicle _vehicle = _vehicleService.GetByLicensePlate(viewModel.LicensePlate);
                Driver _driver = _driverService.GetByCPF(viewModel.DriverCPF);

                List<AuxModelState> _modelState = _entranceAndExitService.EntranceExitValidation(_vehicle, _driver, viewModel.Quilometers, true);

                if (_modelState != null)
                {
                    _modelState.ForEach(x => ModelState.AddModelError(x.Field, x.Message));
                }

                if (ModelState.IsValid)
                {

                    var _entrance = new EntranceAndExit()
                    {
                        CreationDate = DateTime.Now,
                        Driver = _driver,
                        Vehicle = _vehicle,
                        VehicleKms = viewModel.Quilometers,
                        IsEntrance = true,                        
                    };
                    _entrance.Description = _entrance.ToString();

                    return Ok(_entranceAndExitService.Insert(_entrance));;
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
                    var _exit = new EntranceAndExit()
                    {
                        CreationDate = DateTime.Now,
                        Driver = _driver,
                        Vehicle = _vehicle,
                        VehicleKms = viewModel.Quilometers,
                        IsEntrance = false,
                    };

                    _exit.Description = _exit.ToString();

                    return Ok(_entranceAndExitService.Insert(_exit));
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
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult ViewEntranceAndExitLog([FromQuery] string placa = "", [FromQuery] string cpf = "", [FromQuery] bool asc = true)
        {

            try
            {
                return Ok(_entranceAndExitService.GetEntranceAndExitLog(placa, cpf, asc));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException);
            }
            
        }
    }
}