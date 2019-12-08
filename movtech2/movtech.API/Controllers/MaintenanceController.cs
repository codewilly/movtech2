using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movtech.API.ViewModels.Maintenance;
using movtech.Domain.Entities;
using movtech.Domain.Enums;
using movtech.Domain.Interfaces.Services;

namespace movtech.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        #region Config

        private readonly IVehicleService _vehicleService;
        private readonly IMaintenanceService _maintenanceService;

        public MaintenanceController(IVehicleService vehicleService, IMaintenanceService maintenanceService)
        {
            _vehicleService = vehicleService;
            _maintenanceService = maintenanceService;
        }

        #endregion


        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetAllMaintenances()
        {

            IEnumerable<Maintenance> _maintenances = _maintenanceService.GetAll();

            if (_maintenances.Count() > 0)
            {
                return Ok(_maintenances);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult NewMaintenance([FromQuery]MaintenanceType type, [FromBody]NewMaintenanceViewModel viewModel)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    Vehicle _vehicle = _vehicleService.GetByLicensePlate(viewModel.LicensePlate);

                    if (_vehicle is null)
                    {
                        return NotFound("Veículo não encontrado");
                    }

                    Maintenance _maintenance = new Maintenance()
                    {
                        //MaintenanceType = type,
                        MaintenanceDate = DateTime.Now,
                        VehicleId = _vehicle.Id,
                        Vehicle = _vehicle,
                        Cost = viewModel.Cost,
                        PreventivaOrCorretiva = viewModel.PreventivaOrCorretiva,
                        TiresChanged = viewModel.TiresChanged,
                        OilChanged = viewModel.OilChanged,
                        OperationDescription = viewModel.OperationDescription,
                    };
                    
                    return Created("", _maintenanceService.NewMaintenance(_maintenance));
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

        [HttpGet("Vehicles")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetVehiclesWhoNeedsMaintenance()
        {

            List<Vehicle> _vehicles = await _vehicleService.GetVehiclesWhoNeedsMaintenance();

            if (_vehicles.Count() > 0)
            {
                return Ok(_vehicles);
            }
            else
            {
                return NotFound();
            }

        }

    }
}