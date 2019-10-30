using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movtech.API.ViewModels.Vehicle;
using movtech.Domain.Contracts.FipeAPI;
using movtech.Domain.Entities;
using movtech.Domain.Enums;
using movtech.Domain.Interfaces.Services;

namespace movtech.API.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {

        #region Config
        private readonly IVehicleService _vehicleService;
        private readonly IFipeAPIService _fipeAPIService;

        public VehiclesController(IVehicleService vehicleService, IFipeAPIService fipeAPIService)
        {
            _vehicleService = vehicleService;
            _fipeAPIService = fipeAPIService;
        }

        #endregion

        #region Vehicle

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
                _vehicle.CheckMaintenance();
                return Ok(_vehicle);
            }
            else
            {
                return NotFound();
            }

        }

        /// <summary>
        /// Retorna um veículo pela placa
        /// </summary>
        /// <param name="placa"></param>
        /// <returns></returns>
        [HttpGet("LicensePlate/{placa}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetVehicleByLicensePlate(string placa)
        {

            Vehicle _vehicle = _vehicleService.GetByLicensePlate(placa);

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
        /// Cria uma novo veículo
        /// </summary>
        /// <param name="vehicleModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateVehicle([FromBody]CreateVehicleViewModel vehicleModel)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    Vehicle vehicle = new Vehicle(vehicleModel.Year)
                    {
                        Brand = vehicleModel.Brand,
                        Model = vehicleModel.Model,
                        LicensePlate = vehicleModel.LicensePlate,
                        Renavam = vehicleModel.Renavam,
                        Quilometers = vehicleModel.Quilometers,
                        FuelType = vehicleModel.FuelType,
                        VehicleType = vehicleModel.VehicleType,

                        // Default Values
                        LastMaintenanceDate = DateTime.Now,
                        LastMaintenanceKms = vehicleModel.Quilometers,
                        LastOilChangeKms = vehicleModel.Quilometers,
                        LastTireChangeKms = vehicleModel.Quilometers,                        

                    };

                    return Created("", _vehicleService.Insert(vehicle));
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

        /// <summary>
        /// Atualiza um veículo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="vehicleModel"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult UpdateVehicle(int id, [FromBody]UpdateVehicleViewModel vehicleModel)
        {

            Vehicle _vehicle = _vehicleService.Get(id);

            if (_vehicle is null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Atualizar   
                _vehicle.Brand = vehicleModel.Brand;
                _vehicle.Model = vehicleModel.Model;
                _vehicle.Year = vehicleModel.Year;
                _vehicle.Quilometers = vehicleModel.Quilometers;
                _vehicle.FuelType = vehicleModel.FuelType;
                _vehicle.VehicleType = vehicleModel.VehicleType;

                return Ok(_vehicleService.Update(_vehicle));
            }
            else
            {
                return BadRequest();
            }

        }

        /// <summary>
        /// Atualiza o status de um veículo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpPut("{id}/status")]
        [ProducesResponseType(200)]
        public IActionResult ChangeVehicleStatus(int id, [FromQuery]VehicleStatus status)
        {
            Vehicle _vehicle = _vehicleService.Get(id);

            if (_vehicle is null)
            {
                return NotFound();
            }

            _vehicle.Status = status;

            return Ok(_vehicleService.Update(_vehicle));

        }

        #endregion

        #region Marcas e Modelos

        /// <summary>
        /// Retorna todas as marcas de um tipo de veículo
        /// </summary>
        /// <param name="tipo">Carro, Moto ou Caminhão</param>
        /// <returns></returns>
        [HttpGet("marcas")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetVehicleBrands([FromQuery]VehicleType tipo)
        {

            var retorno = await _fipeAPIService.ConsultarMarcas(new ConsultarMarcasRequest()
            {
                CodigoTabelaReferencia = 231,
                CodigoTipoVeiculo = tipo

            }); ;

            if (retorno != null)
            {
                return Ok(retorno);
            }
            else
            {
                return NotFound();
            }

        }

        /// <summary>
        /// Retorna todos os modelos de uma determinada marca
        /// </summary>
        /// <param name="tipo">Carro, Moto ou Caminhão</param>
        /// <param name="marcaId">ID do Modelo</param>
        /// <returns></returns>
        [HttpGet("marcas/{marcaId}/modelos/")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetVehicleModels([FromQuery]VehicleType tipo, int marcaId)
        {

            var retorno = await _fipeAPIService.ConsultarModelos(new ConsultarModelosRequest()
            {
                CodigoTabelaReferencia = 231,
                CodigoTipoVeiculo = tipo,
                CodigoMarca = marcaId
            });

            if (retorno != null)
            {
                return Ok(retorno);
            }
            else
            {
                return NotFound();
            }

        }

        /// <summary>
        /// Retorna os anos de fabricação de um determinado modelo
        /// </summary>
        /// <param name="marcaId"></param>
        /// <param name="tipo"></param>
        /// <param name="modeloId"></param>
        /// <returns></returns>
        [HttpGet("marcas/{marcaId}/modelo/anos")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetVehicleYears(int marcaId, [FromQuery] VehicleType tipo, [FromQuery] int modeloId)
        {

            var retorno = await _fipeAPIService.ConsultarAnoModelo(new ConsultarAnoModeloRequest()
            {
                CodigoTabelaReferencia = 231,
                CodigoTipoVeiculo = tipo,
                CodigoMarca = marcaId,
                CodigoModelo = modeloId

            });

            if (retorno != null)
            {
                return Ok(retorno);
            }
            else
            {
                return NotFound();
            }

        }

        #endregion

    }
}