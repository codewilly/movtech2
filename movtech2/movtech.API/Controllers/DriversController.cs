using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movtech.API.ViewModels.Driver;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Services;

namespace movtech.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        #region Config

        private readonly IDriverService _driverService;

        public DriversController(IDriverService driverService)
        {
            _driverService = driverService;

        }

        #endregion

        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetDriver(int id)
        {

            Driver _driver = _driverService.Get(id);

            if (_driver != null)
            {
                return Ok(_driver);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("{cpf}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetDriverByCPF(string cpf)
        {

            Driver _driver = _driverService.GetByCPF(cpf);

            if (_driver != null)
            {
                return Ok(_driver);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetAllDrivers()
        {

            IEnumerable<Driver> _drivers = _driverService.GetAll();

            if (_drivers.Count() > 0)
            {
                return Ok(_drivers);
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult CreateDriver([FromBody]CreateDriverViewModel viewModel)
        {

            try
            {
                // TODO Arrumar bug do ano
                if (ModelState.IsValid)
                {

                    Driver _driver = new Driver()
                    {
                        Name = viewModel.Name,
                        CPF = viewModel.CPF,
                        BirthDate = viewModel.BirthDate,
                        Phone = viewModel.Phone,
                        Email = viewModel.Email,
                        CNH = viewModel.CNH,
                        CNHCategory = viewModel.CNHCategory,
                        CEP = viewModel.CEP,
                        Street = viewModel.Street,
                        Number = viewModel.Number,
                        Neighborhood = viewModel.Neighborhood,
                        City = viewModel.City,
                        UF = viewModel.UF

                    };

                    return Created("", _driverService.Insert(_driver));
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


        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult UpdateDriver(int id, [FromBody]UpdateDriverViewModel viewModel)
        {

            Driver _driver = _driverService.Get(id);

            if (_driver is null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Atualizar   
                _driver.Name = viewModel.Name;
                _driver.BirthDate = viewModel.BirthDate;
                _driver.Phone = viewModel.Phone;
                _driver.Email = viewModel.Email;
                _driver.CNHCategory = viewModel.CNHCategory;
                _driver.CEP = viewModel.CEP;
                _driver.Street = viewModel.Street;
                _driver.Number = viewModel.Number;
                _driver.Neighborhood = viewModel.Neighborhood;
                _driver.City = viewModel.City;
                _driver.UF = viewModel.UF;

                return Ok(_driverService.Update(_driver));
            }
            else
            {
                return BadRequest();
            }

        }


    }
}