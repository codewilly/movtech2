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
        private readonly IVehicleModelService _vehicleModelService;

        public VehiclesController(IVehicleService vehicleService, IVehicleModelService vehicleModelService)
        {
            _vehicleService = vehicleService;
            _vehicleModelService = vehicleModelService;
        }

        #endregion

        #region Vehicle

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

        /// <summary>
        /// Cria uma novo veículo
        /// </summary>
        /// <param name="vehicleModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateVehicle([FromBody]Vehicle vehicleModel)
        {

            // TODO Arrumar bug do ano
            if (ModelState.IsValid)
            {

                return Created("", _vehicleService.Insert(vehicleModel));
            }
            else
            {
                return BadRequest();
            }

        }


        /// <summary>
        /// Atualiza um veículo
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult UpdateVehicle(int id, [FromBody]Vehicle vehicle)
        {

            Vehicle _vehicle = _vehicleService.Get(id);

            if (_vehicle is null)
            {
                return CreateVehicle(vehicle);
            }

            if (ModelState.IsValid)
            {
                // Atualizar       
                _vehicle.LicensePlate = vehicle.LicensePlate;
                _vehicle.Renavam = vehicle.Renavam;
                _vehicle.SetYear(vehicle.Year);
                _vehicle.Quilometers = vehicle.Quilometers;
                _vehicle.FuelType = vehicle.FuelType;
                _vehicle.InGarage = vehicle.InGarage;
                _vehicle.VehicleModelId = vehicle.VehicleModelId;

                return Ok(_vehicleService.Update(_vehicle));
            }
            else
            {
                return BadRequest();
            }

        }


        #endregion

        #region Model        

        /// <summary>
        /// Retorna uma marca baseado no ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("models/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetVehicleModel(int id)
        {
            VehicleModel _vehicle = _vehicleModelService.Get(id);

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
        /// Retorna todos os modelos de veículos
        /// </summary>
        /// <returns></returns>
        [HttpGet("models")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetAllVehiclesModels()
        {

            IEnumerable<VehicleModel> _models = _vehicleModelService.GetAll();

            if (_models.Count() > 0)
            {
                return Ok(_models);
            }
            else
            {
                return NotFound();
            }

        }

        /// <summary>
        /// Cria uma novo modelo de uma marca
        /// </summary>
        /// <param name="vehicleModel"></param>
        /// <returns></returns>
        [HttpPost("models")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult CreateModel([FromBody]VehicleModel vehicleModel)
        {

            if (ModelState.IsValid)
            {
                
                return Created("", _vehicleModelService.Insert(vehicleModel));
            }
            else
            {
                return BadRequest();
            }

        }

        /// <summary>
        /// Atualiza uma marca
        /// </summary>
        /// <param name="vehicleModel"></param>
        /// <returns></returns>
        [HttpPut("{id}/models")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult UpdateModel(int id, [FromBody]VehicleModel vehicleModel)
        {

            VehicleModel _vehicleModel = _vehicleModelService.Get(id);

            if (_vehicleModel is null)
            {
                return CreateModel(vehicleModel);
            }

            if (ModelState.IsValid)
            {
                // Atualizar
                _vehicleModel.Name = vehicleModel.Name;
                _vehicleModel.VehicleBrand = vehicleModel.VehicleBrand;
                _vehicleModel.VehicleType = vehicleModel.VehicleType;

                return Ok(_vehicleModelService.Update(_vehicleModel));
            }
            else
            {
                return BadRequest();
            }

        }


        #endregion

    }
}