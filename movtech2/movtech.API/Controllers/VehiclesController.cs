using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Services;

namespace movtech.API.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {

        #region Config
        private readonly IVehicleService _vehicleService;

        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        #endregion

        /// <summary>
        /// Retorna um Veículo baseado no ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetVehicle(int id)
        {
            Vehicle _vehicle = _vehicleService.Get(id);

            if (_vehicle != null)
            {
                return Ok(_vehicle);
            }
            else
            {
                return NotFound();
            }

        }

        /// <summary>
        /// Retorna todos os Veiculos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetAllVehicles()
        {

            IEnumerable<Vehicle> _vehicles = _vehicleService.GetAll();

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